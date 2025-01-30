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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.RapidMigrationAssessment.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRapidMigrationAssessmentClientSnippets
    {
        /// <summary>Snippet for CreateCollector</summary>
        public void CreateCollectorRequestObject()
        {
            // Snippet: CreateCollector(CreateCollectorRequest, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            CreateCollectorRequest request = new CreateCollectorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CollectorId = "",
                Collector = new Collector(),
                RequestId = "",
            };
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.CreateCollector(request);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceCreateCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCollectorAsync</summary>
        public async Task CreateCollectorRequestObjectAsync()
        {
            // Snippet: CreateCollectorAsync(CreateCollectorRequest, CallSettings)
            // Additional: CreateCollectorAsync(CreateCollectorRequest, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            CreateCollectorRequest request = new CreateCollectorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CollectorId = "",
                Collector = new Collector(),
                RequestId = "",
            };
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.CreateCollectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceCreateCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCollector</summary>
        public void CreateCollector()
        {
            // Snippet: CreateCollector(string, Collector, string, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Collector collector = new Collector();
            string collectorId = "";
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.CreateCollector(parent, collector, collectorId);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceCreateCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCollectorAsync</summary>
        public async Task CreateCollectorAsync()
        {
            // Snippet: CreateCollectorAsync(string, Collector, string, CallSettings)
            // Additional: CreateCollectorAsync(string, Collector, string, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Collector collector = new Collector();
            string collectorId = "";
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.CreateCollectorAsync(parent, collector, collectorId);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceCreateCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCollector</summary>
        public void CreateCollectorResourceNames()
        {
            // Snippet: CreateCollector(LocationName, Collector, string, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Collector collector = new Collector();
            string collectorId = "";
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.CreateCollector(parent, collector, collectorId);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceCreateCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCollectorAsync</summary>
        public async Task CreateCollectorResourceNamesAsync()
        {
            // Snippet: CreateCollectorAsync(LocationName, Collector, string, CallSettings)
            // Additional: CreateCollectorAsync(LocationName, Collector, string, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Collector collector = new Collector();
            string collectorId = "";
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.CreateCollectorAsync(parent, collector, collectorId);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceCreateCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotation</summary>
        public void CreateAnnotationRequestObject()
        {
            // Snippet: CreateAnnotation(CreateAnnotationRequest, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            CreateAnnotationRequest request = new CreateAnnotationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Annotation = new Annotation(),
                RequestId = "",
            };
            // Make the request
            Operation<Annotation, OperationMetadata> response = rapidMigrationAssessmentClient.CreateAnnotation(request);

            // Poll until the returned long-running operation is complete
            Operation<Annotation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Annotation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Annotation, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceCreateAnnotation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Annotation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotationAsync</summary>
        public async Task CreateAnnotationRequestObjectAsync()
        {
            // Snippet: CreateAnnotationAsync(CreateAnnotationRequest, CallSettings)
            // Additional: CreateAnnotationAsync(CreateAnnotationRequest, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            CreateAnnotationRequest request = new CreateAnnotationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Annotation = new Annotation(),
                RequestId = "",
            };
            // Make the request
            Operation<Annotation, OperationMetadata> response = await rapidMigrationAssessmentClient.CreateAnnotationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Annotation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Annotation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Annotation, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceCreateAnnotationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Annotation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotation</summary>
        public void CreateAnnotation()
        {
            // Snippet: CreateAnnotation(string, Annotation, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Annotation annotation = new Annotation();
            // Make the request
            Operation<Annotation, OperationMetadata> response = rapidMigrationAssessmentClient.CreateAnnotation(parent, annotation);

            // Poll until the returned long-running operation is complete
            Operation<Annotation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Annotation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Annotation, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceCreateAnnotation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Annotation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotationAsync</summary>
        public async Task CreateAnnotationAsync()
        {
            // Snippet: CreateAnnotationAsync(string, Annotation, CallSettings)
            // Additional: CreateAnnotationAsync(string, Annotation, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Annotation annotation = new Annotation();
            // Make the request
            Operation<Annotation, OperationMetadata> response = await rapidMigrationAssessmentClient.CreateAnnotationAsync(parent, annotation);

            // Poll until the returned long-running operation is complete
            Operation<Annotation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Annotation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Annotation, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceCreateAnnotationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Annotation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotation</summary>
        public void CreateAnnotationResourceNames()
        {
            // Snippet: CreateAnnotation(LocationName, Annotation, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Annotation annotation = new Annotation();
            // Make the request
            Operation<Annotation, OperationMetadata> response = rapidMigrationAssessmentClient.CreateAnnotation(parent, annotation);

            // Poll until the returned long-running operation is complete
            Operation<Annotation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Annotation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Annotation, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceCreateAnnotation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Annotation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotationAsync</summary>
        public async Task CreateAnnotationResourceNamesAsync()
        {
            // Snippet: CreateAnnotationAsync(LocationName, Annotation, CallSettings)
            // Additional: CreateAnnotationAsync(LocationName, Annotation, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Annotation annotation = new Annotation();
            // Make the request
            Operation<Annotation, OperationMetadata> response = await rapidMigrationAssessmentClient.CreateAnnotationAsync(parent, annotation);

            // Poll until the returned long-running operation is complete
            Operation<Annotation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Annotation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Annotation, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceCreateAnnotationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Annotation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetAnnotation</summary>
        public void GetAnnotationRequestObject()
        {
            // Snippet: GetAnnotation(GetAnnotationRequest, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            GetAnnotationRequest request = new GetAnnotationRequest
            {
                AnnotationName = AnnotationName.FromProjectLocationAnnotation("[PROJECT]", "[LOCATION]", "[ANNOTATION]"),
            };
            // Make the request
            Annotation response = rapidMigrationAssessmentClient.GetAnnotation(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationAsync</summary>
        public async Task GetAnnotationRequestObjectAsync()
        {
            // Snippet: GetAnnotationAsync(GetAnnotationRequest, CallSettings)
            // Additional: GetAnnotationAsync(GetAnnotationRequest, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            GetAnnotationRequest request = new GetAnnotationRequest
            {
                AnnotationName = AnnotationName.FromProjectLocationAnnotation("[PROJECT]", "[LOCATION]", "[ANNOTATION]"),
            };
            // Make the request
            Annotation response = await rapidMigrationAssessmentClient.GetAnnotationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotation</summary>
        public void GetAnnotation()
        {
            // Snippet: GetAnnotation(string, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/annotations/[ANNOTATION]";
            // Make the request
            Annotation response = rapidMigrationAssessmentClient.GetAnnotation(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationAsync</summary>
        public async Task GetAnnotationAsync()
        {
            // Snippet: GetAnnotationAsync(string, CallSettings)
            // Additional: GetAnnotationAsync(string, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/annotations/[ANNOTATION]";
            // Make the request
            Annotation response = await rapidMigrationAssessmentClient.GetAnnotationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotation</summary>
        public void GetAnnotationResourceNames()
        {
            // Snippet: GetAnnotation(AnnotationName, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            AnnotationName name = AnnotationName.FromProjectLocationAnnotation("[PROJECT]", "[LOCATION]", "[ANNOTATION]");
            // Make the request
            Annotation response = rapidMigrationAssessmentClient.GetAnnotation(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationAsync</summary>
        public async Task GetAnnotationResourceNamesAsync()
        {
            // Snippet: GetAnnotationAsync(AnnotationName, CallSettings)
            // Additional: GetAnnotationAsync(AnnotationName, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            AnnotationName name = AnnotationName.FromProjectLocationAnnotation("[PROJECT]", "[LOCATION]", "[ANNOTATION]");
            // Make the request
            Annotation response = await rapidMigrationAssessmentClient.GetAnnotationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCollectors</summary>
        public void ListCollectorsRequestObject()
        {
            // Snippet: ListCollectors(ListCollectorsRequest, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            ListCollectorsRequest request = new ListCollectorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCollectorsResponse, Collector> response = rapidMigrationAssessmentClient.ListCollectors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Collector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCollectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Collector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Collector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Collector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectorsAsync</summary>
        public async Task ListCollectorsRequestObjectAsync()
        {
            // Snippet: ListCollectorsAsync(ListCollectorsRequest, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            ListCollectorsRequest request = new ListCollectorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCollectorsResponse, Collector> response = rapidMigrationAssessmentClient.ListCollectorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Collector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCollectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Collector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Collector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Collector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectors</summary>
        public void ListCollectors()
        {
            // Snippet: ListCollectors(string, string, int?, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCollectorsResponse, Collector> response = rapidMigrationAssessmentClient.ListCollectors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Collector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCollectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Collector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Collector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Collector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectorsAsync</summary>
        public async Task ListCollectorsAsync()
        {
            // Snippet: ListCollectorsAsync(string, string, int?, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCollectorsResponse, Collector> response = rapidMigrationAssessmentClient.ListCollectorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Collector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCollectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Collector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Collector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Collector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectors</summary>
        public void ListCollectorsResourceNames()
        {
            // Snippet: ListCollectors(LocationName, string, int?, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCollectorsResponse, Collector> response = rapidMigrationAssessmentClient.ListCollectors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Collector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCollectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Collector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Collector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Collector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectorsAsync</summary>
        public async Task ListCollectorsResourceNamesAsync()
        {
            // Snippet: ListCollectorsAsync(LocationName, string, int?, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCollectorsResponse, Collector> response = rapidMigrationAssessmentClient.ListCollectorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Collector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCollectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Collector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Collector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Collector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCollector</summary>
        public void GetCollectorRequestObject()
        {
            // Snippet: GetCollector(GetCollectorRequest, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            GetCollectorRequest request = new GetCollectorRequest
            {
                CollectorName = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]"),
            };
            // Make the request
            Collector response = rapidMigrationAssessmentClient.GetCollector(request);
            // End snippet
        }

        /// <summary>Snippet for GetCollectorAsync</summary>
        public async Task GetCollectorRequestObjectAsync()
        {
            // Snippet: GetCollectorAsync(GetCollectorRequest, CallSettings)
            // Additional: GetCollectorAsync(GetCollectorRequest, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            GetCollectorRequest request = new GetCollectorRequest
            {
                CollectorName = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]"),
            };
            // Make the request
            Collector response = await rapidMigrationAssessmentClient.GetCollectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCollector</summary>
        public void GetCollector()
        {
            // Snippet: GetCollector(string, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collectors/[COLLECTOR]";
            // Make the request
            Collector response = rapidMigrationAssessmentClient.GetCollector(name);
            // End snippet
        }

        /// <summary>Snippet for GetCollectorAsync</summary>
        public async Task GetCollectorAsync()
        {
            // Snippet: GetCollectorAsync(string, CallSettings)
            // Additional: GetCollectorAsync(string, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collectors/[COLLECTOR]";
            // Make the request
            Collector response = await rapidMigrationAssessmentClient.GetCollectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCollector</summary>
        public void GetCollectorResourceNames()
        {
            // Snippet: GetCollector(CollectorName, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            CollectorName name = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]");
            // Make the request
            Collector response = rapidMigrationAssessmentClient.GetCollector(name);
            // End snippet
        }

        /// <summary>Snippet for GetCollectorAsync</summary>
        public async Task GetCollectorResourceNamesAsync()
        {
            // Snippet: GetCollectorAsync(CollectorName, CallSettings)
            // Additional: GetCollectorAsync(CollectorName, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            CollectorName name = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]");
            // Make the request
            Collector response = await rapidMigrationAssessmentClient.GetCollectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateCollector</summary>
        public void UpdateCollectorRequestObject()
        {
            // Snippet: UpdateCollector(UpdateCollectorRequest, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            UpdateCollectorRequest request = new UpdateCollectorRequest
            {
                UpdateMask = new FieldMask(),
                Collector = new Collector(),
                RequestId = "",
            };
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.UpdateCollector(request);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceUpdateCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCollectorAsync</summary>
        public async Task UpdateCollectorRequestObjectAsync()
        {
            // Snippet: UpdateCollectorAsync(UpdateCollectorRequest, CallSettings)
            // Additional: UpdateCollectorAsync(UpdateCollectorRequest, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCollectorRequest request = new UpdateCollectorRequest
            {
                UpdateMask = new FieldMask(),
                Collector = new Collector(),
                RequestId = "",
            };
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.UpdateCollectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceUpdateCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCollector</summary>
        public void UpdateCollector()
        {
            // Snippet: UpdateCollector(Collector, FieldMask, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            Collector collector = new Collector();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.UpdateCollector(collector, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceUpdateCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCollectorAsync</summary>
        public async Task UpdateCollectorAsync()
        {
            // Snippet: UpdateCollectorAsync(Collector, FieldMask, CallSettings)
            // Additional: UpdateCollectorAsync(Collector, FieldMask, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            Collector collector = new Collector();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.UpdateCollectorAsync(collector, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceUpdateCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollector</summary>
        public void DeleteCollectorRequestObject()
        {
            // Snippet: DeleteCollector(DeleteCollectorRequest, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            DeleteCollectorRequest request = new DeleteCollectorRequest
            {
                CollectorName = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]"),
                RequestId = "",
            };
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.DeleteCollector(request);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceDeleteCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollectorAsync</summary>
        public async Task DeleteCollectorRequestObjectAsync()
        {
            // Snippet: DeleteCollectorAsync(DeleteCollectorRequest, CallSettings)
            // Additional: DeleteCollectorAsync(DeleteCollectorRequest, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCollectorRequest request = new DeleteCollectorRequest
            {
                CollectorName = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]"),
                RequestId = "",
            };
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.DeleteCollectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceDeleteCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollector</summary>
        public void DeleteCollector()
        {
            // Snippet: DeleteCollector(string, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collectors/[COLLECTOR]";
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.DeleteCollector(name);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceDeleteCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollectorAsync</summary>
        public async Task DeleteCollectorAsync()
        {
            // Snippet: DeleteCollectorAsync(string, CallSettings)
            // Additional: DeleteCollectorAsync(string, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collectors/[COLLECTOR]";
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.DeleteCollectorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceDeleteCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollector</summary>
        public void DeleteCollectorResourceNames()
        {
            // Snippet: DeleteCollector(CollectorName, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            CollectorName name = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]");
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.DeleteCollector(name);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceDeleteCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollectorAsync</summary>
        public async Task DeleteCollectorResourceNamesAsync()
        {
            // Snippet: DeleteCollectorAsync(CollectorName, CallSettings)
            // Additional: DeleteCollectorAsync(CollectorName, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            CollectorName name = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]");
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.DeleteCollectorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceDeleteCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeCollector</summary>
        public void ResumeCollectorRequestObject()
        {
            // Snippet: ResumeCollector(ResumeCollectorRequest, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            ResumeCollectorRequest request = new ResumeCollectorRequest
            {
                CollectorName = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]"),
                RequestId = "",
            };
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.ResumeCollector(request);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceResumeCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeCollectorAsync</summary>
        public async Task ResumeCollectorRequestObjectAsync()
        {
            // Snippet: ResumeCollectorAsync(ResumeCollectorRequest, CallSettings)
            // Additional: ResumeCollectorAsync(ResumeCollectorRequest, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            ResumeCollectorRequest request = new ResumeCollectorRequest
            {
                CollectorName = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]"),
                RequestId = "",
            };
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.ResumeCollectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceResumeCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeCollector</summary>
        public void ResumeCollector()
        {
            // Snippet: ResumeCollector(string, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collectors/[COLLECTOR]";
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.ResumeCollector(name);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceResumeCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeCollectorAsync</summary>
        public async Task ResumeCollectorAsync()
        {
            // Snippet: ResumeCollectorAsync(string, CallSettings)
            // Additional: ResumeCollectorAsync(string, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collectors/[COLLECTOR]";
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.ResumeCollectorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceResumeCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeCollector</summary>
        public void ResumeCollectorResourceNames()
        {
            // Snippet: ResumeCollector(CollectorName, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            CollectorName name = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]");
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.ResumeCollector(name);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceResumeCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeCollectorAsync</summary>
        public async Task ResumeCollectorResourceNamesAsync()
        {
            // Snippet: ResumeCollectorAsync(CollectorName, CallSettings)
            // Additional: ResumeCollectorAsync(CollectorName, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            CollectorName name = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]");
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.ResumeCollectorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceResumeCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterCollector</summary>
        public void RegisterCollectorRequestObject()
        {
            // Snippet: RegisterCollector(RegisterCollectorRequest, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            RegisterCollectorRequest request = new RegisterCollectorRequest
            {
                CollectorName = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]"),
                RequestId = "",
            };
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.RegisterCollector(request);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceRegisterCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterCollectorAsync</summary>
        public async Task RegisterCollectorRequestObjectAsync()
        {
            // Snippet: RegisterCollectorAsync(RegisterCollectorRequest, CallSettings)
            // Additional: RegisterCollectorAsync(RegisterCollectorRequest, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            RegisterCollectorRequest request = new RegisterCollectorRequest
            {
                CollectorName = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]"),
                RequestId = "",
            };
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.RegisterCollectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceRegisterCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterCollector</summary>
        public void RegisterCollector()
        {
            // Snippet: RegisterCollector(string, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collectors/[COLLECTOR]";
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.RegisterCollector(name);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceRegisterCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterCollectorAsync</summary>
        public async Task RegisterCollectorAsync()
        {
            // Snippet: RegisterCollectorAsync(string, CallSettings)
            // Additional: RegisterCollectorAsync(string, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collectors/[COLLECTOR]";
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.RegisterCollectorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceRegisterCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterCollector</summary>
        public void RegisterCollectorResourceNames()
        {
            // Snippet: RegisterCollector(CollectorName, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            CollectorName name = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]");
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.RegisterCollector(name);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOnceRegisterCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterCollectorAsync</summary>
        public async Task RegisterCollectorResourceNamesAsync()
        {
            // Snippet: RegisterCollectorAsync(CollectorName, CallSettings)
            // Additional: RegisterCollectorAsync(CollectorName, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            CollectorName name = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]");
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.RegisterCollectorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOnceRegisterCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PauseCollector</summary>
        public void PauseCollectorRequestObject()
        {
            // Snippet: PauseCollector(PauseCollectorRequest, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            PauseCollectorRequest request = new PauseCollectorRequest
            {
                CollectorName = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]"),
                RequestId = "",
            };
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.PauseCollector(request);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOncePauseCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PauseCollectorAsync</summary>
        public async Task PauseCollectorRequestObjectAsync()
        {
            // Snippet: PauseCollectorAsync(PauseCollectorRequest, CallSettings)
            // Additional: PauseCollectorAsync(PauseCollectorRequest, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            PauseCollectorRequest request = new PauseCollectorRequest
            {
                CollectorName = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]"),
                RequestId = "",
            };
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.PauseCollectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOncePauseCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PauseCollector</summary>
        public void PauseCollector()
        {
            // Snippet: PauseCollector(string, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collectors/[COLLECTOR]";
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.PauseCollector(name);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOncePauseCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PauseCollectorAsync</summary>
        public async Task PauseCollectorAsync()
        {
            // Snippet: PauseCollectorAsync(string, CallSettings)
            // Additional: PauseCollectorAsync(string, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collectors/[COLLECTOR]";
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.PauseCollectorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOncePauseCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PauseCollector</summary>
        public void PauseCollectorResourceNames()
        {
            // Snippet: PauseCollector(CollectorName, CallSettings)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = RapidMigrationAssessmentClient.Create();
            // Initialize request argument(s)
            CollectorName name = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]");
            // Make the request
            Operation<Collector, OperationMetadata> response = rapidMigrationAssessmentClient.PauseCollector(name);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = rapidMigrationAssessmentClient.PollOncePauseCollector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PauseCollectorAsync</summary>
        public async Task PauseCollectorResourceNamesAsync()
        {
            // Snippet: PauseCollectorAsync(CollectorName, CallSettings)
            // Additional: PauseCollectorAsync(CollectorName, CancellationToken)
            // Create client
            RapidMigrationAssessmentClient rapidMigrationAssessmentClient = await RapidMigrationAssessmentClient.CreateAsync();
            // Initialize request argument(s)
            CollectorName name = CollectorName.FromProjectLocationCollector("[PROJECT]", "[LOCATION]", "[COLLECTOR]");
            // Make the request
            Operation<Collector, OperationMetadata> response = await rapidMigrationAssessmentClient.PauseCollectorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Collector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Collector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Collector, OperationMetadata> retrievedResponse = await rapidMigrationAssessmentClient.PollOncePauseCollectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Collector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
