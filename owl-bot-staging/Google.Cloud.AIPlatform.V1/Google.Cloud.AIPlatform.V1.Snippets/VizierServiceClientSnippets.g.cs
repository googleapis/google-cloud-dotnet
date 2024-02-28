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
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedVizierServiceClientSnippets
    {
        /// <summary>Snippet for CreateStudy</summary>
        public void CreateStudyRequestObject()
        {
            // Snippet: CreateStudy(CreateStudyRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            CreateStudyRequest request = new CreateStudyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Study = new Study(),
            };
            // Make the request
            Study response = vizierServiceClient.CreateStudy(request);
            // End snippet
        }

        /// <summary>Snippet for CreateStudyAsync</summary>
        public async Task CreateStudyRequestObjectAsync()
        {
            // Snippet: CreateStudyAsync(CreateStudyRequest, CallSettings)
            // Additional: CreateStudyAsync(CreateStudyRequest, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateStudyRequest request = new CreateStudyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Study = new Study(),
            };
            // Make the request
            Study response = await vizierServiceClient.CreateStudyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateStudy</summary>
        public void CreateStudy()
        {
            // Snippet: CreateStudy(string, Study, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Study study = new Study();
            // Make the request
            Study response = vizierServiceClient.CreateStudy(parent, study);
            // End snippet
        }

        /// <summary>Snippet for CreateStudyAsync</summary>
        public async Task CreateStudyAsync()
        {
            // Snippet: CreateStudyAsync(string, Study, CallSettings)
            // Additional: CreateStudyAsync(string, Study, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Study study = new Study();
            // Make the request
            Study response = await vizierServiceClient.CreateStudyAsync(parent, study);
            // End snippet
        }

        /// <summary>Snippet for CreateStudy</summary>
        public void CreateStudyResourceNames()
        {
            // Snippet: CreateStudy(LocationName, Study, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Study study = new Study();
            // Make the request
            Study response = vizierServiceClient.CreateStudy(parent, study);
            // End snippet
        }

        /// <summary>Snippet for CreateStudyAsync</summary>
        public async Task CreateStudyResourceNamesAsync()
        {
            // Snippet: CreateStudyAsync(LocationName, Study, CallSettings)
            // Additional: CreateStudyAsync(LocationName, Study, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Study study = new Study();
            // Make the request
            Study response = await vizierServiceClient.CreateStudyAsync(parent, study);
            // End snippet
        }

        /// <summary>Snippet for GetStudy</summary>
        public void GetStudyRequestObject()
        {
            // Snippet: GetStudy(GetStudyRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            GetStudyRequest request = new GetStudyRequest
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            // Make the request
            Study response = vizierServiceClient.GetStudy(request);
            // End snippet
        }

        /// <summary>Snippet for GetStudyAsync</summary>
        public async Task GetStudyRequestObjectAsync()
        {
            // Snippet: GetStudyAsync(GetStudyRequest, CallSettings)
            // Additional: GetStudyAsync(GetStudyRequest, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetStudyRequest request = new GetStudyRequest
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            // Make the request
            Study response = await vizierServiceClient.GetStudyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetStudy</summary>
        public void GetStudy()
        {
            // Snippet: GetStudy(string, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/studies/[STUDY]";
            // Make the request
            Study response = vizierServiceClient.GetStudy(name);
            // End snippet
        }

        /// <summary>Snippet for GetStudyAsync</summary>
        public async Task GetStudyAsync()
        {
            // Snippet: GetStudyAsync(string, CallSettings)
            // Additional: GetStudyAsync(string, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/studies/[STUDY]";
            // Make the request
            Study response = await vizierServiceClient.GetStudyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetStudy</summary>
        public void GetStudyResourceNames()
        {
            // Snippet: GetStudy(StudyName, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            StudyName name = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]");
            // Make the request
            Study response = vizierServiceClient.GetStudy(name);
            // End snippet
        }

        /// <summary>Snippet for GetStudyAsync</summary>
        public async Task GetStudyResourceNamesAsync()
        {
            // Snippet: GetStudyAsync(StudyName, CallSettings)
            // Additional: GetStudyAsync(StudyName, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            StudyName name = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]");
            // Make the request
            Study response = await vizierServiceClient.GetStudyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListStudies</summary>
        public void ListStudiesRequestObject()
        {
            // Snippet: ListStudies(ListStudiesRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            ListStudiesRequest request = new ListStudiesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListStudiesResponse, Study> response = vizierServiceClient.ListStudies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Study item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStudiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Study item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Study> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Study item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStudiesAsync</summary>
        public async Task ListStudiesRequestObjectAsync()
        {
            // Snippet: ListStudiesAsync(ListStudiesRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListStudiesRequest request = new ListStudiesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListStudiesResponse, Study> response = vizierServiceClient.ListStudiesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Study item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListStudiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Study item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Study> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Study item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStudies</summary>
        public void ListStudies()
        {
            // Snippet: ListStudies(string, string, int?, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListStudiesResponse, Study> response = vizierServiceClient.ListStudies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Study item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStudiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Study item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Study> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Study item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStudiesAsync</summary>
        public async Task ListStudiesAsync()
        {
            // Snippet: ListStudiesAsync(string, string, int?, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListStudiesResponse, Study> response = vizierServiceClient.ListStudiesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Study item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListStudiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Study item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Study> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Study item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStudies</summary>
        public void ListStudiesResourceNames()
        {
            // Snippet: ListStudies(LocationName, string, int?, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListStudiesResponse, Study> response = vizierServiceClient.ListStudies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Study item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStudiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Study item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Study> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Study item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStudiesAsync</summary>
        public async Task ListStudiesResourceNamesAsync()
        {
            // Snippet: ListStudiesAsync(LocationName, string, int?, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListStudiesResponse, Study> response = vizierServiceClient.ListStudiesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Study item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListStudiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Study item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Study> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Study item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteStudy</summary>
        public void DeleteStudyRequestObject()
        {
            // Snippet: DeleteStudy(DeleteStudyRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            DeleteStudyRequest request = new DeleteStudyRequest
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            // Make the request
            vizierServiceClient.DeleteStudy(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteStudyAsync</summary>
        public async Task DeleteStudyRequestObjectAsync()
        {
            // Snippet: DeleteStudyAsync(DeleteStudyRequest, CallSettings)
            // Additional: DeleteStudyAsync(DeleteStudyRequest, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteStudyRequest request = new DeleteStudyRequest
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            // Make the request
            await vizierServiceClient.DeleteStudyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteStudy</summary>
        public void DeleteStudy()
        {
            // Snippet: DeleteStudy(string, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/studies/[STUDY]";
            // Make the request
            vizierServiceClient.DeleteStudy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteStudyAsync</summary>
        public async Task DeleteStudyAsync()
        {
            // Snippet: DeleteStudyAsync(string, CallSettings)
            // Additional: DeleteStudyAsync(string, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/studies/[STUDY]";
            // Make the request
            await vizierServiceClient.DeleteStudyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteStudy</summary>
        public void DeleteStudyResourceNames()
        {
            // Snippet: DeleteStudy(StudyName, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            StudyName name = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]");
            // Make the request
            vizierServiceClient.DeleteStudy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteStudyAsync</summary>
        public async Task DeleteStudyResourceNamesAsync()
        {
            // Snippet: DeleteStudyAsync(StudyName, CallSettings)
            // Additional: DeleteStudyAsync(StudyName, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            StudyName name = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]");
            // Make the request
            await vizierServiceClient.DeleteStudyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for LookupStudy</summary>
        public void LookupStudyRequestObject()
        {
            // Snippet: LookupStudy(LookupStudyRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            LookupStudyRequest request = new LookupStudyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DisplayName = "",
            };
            // Make the request
            Study response = vizierServiceClient.LookupStudy(request);
            // End snippet
        }

        /// <summary>Snippet for LookupStudyAsync</summary>
        public async Task LookupStudyRequestObjectAsync()
        {
            // Snippet: LookupStudyAsync(LookupStudyRequest, CallSettings)
            // Additional: LookupStudyAsync(LookupStudyRequest, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            LookupStudyRequest request = new LookupStudyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DisplayName = "",
            };
            // Make the request
            Study response = await vizierServiceClient.LookupStudyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LookupStudy</summary>
        public void LookupStudy()
        {
            // Snippet: LookupStudy(string, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            Study response = vizierServiceClient.LookupStudy(parent);
            // End snippet
        }

        /// <summary>Snippet for LookupStudyAsync</summary>
        public async Task LookupStudyAsync()
        {
            // Snippet: LookupStudyAsync(string, CallSettings)
            // Additional: LookupStudyAsync(string, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            Study response = await vizierServiceClient.LookupStudyAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for LookupStudy</summary>
        public void LookupStudyResourceNames()
        {
            // Snippet: LookupStudy(LocationName, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Study response = vizierServiceClient.LookupStudy(parent);
            // End snippet
        }

        /// <summary>Snippet for LookupStudyAsync</summary>
        public async Task LookupStudyResourceNamesAsync()
        {
            // Snippet: LookupStudyAsync(LocationName, CallSettings)
            // Additional: LookupStudyAsync(LocationName, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Study response = await vizierServiceClient.LookupStudyAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for SuggestTrials</summary>
        public void SuggestTrialsRequestObject()
        {
            // Snippet: SuggestTrials(SuggestTrialsRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            SuggestTrialsRequest request = new SuggestTrialsRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                SuggestionCount = 0,
                ClientId = "",
                Contexts = { new TrialContext(), },
            };
            // Make the request
            Operation<SuggestTrialsResponse, SuggestTrialsMetadata> response = vizierServiceClient.SuggestTrials(request);

            // Poll until the returned long-running operation is complete
            Operation<SuggestTrialsResponse, SuggestTrialsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SuggestTrialsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SuggestTrialsResponse, SuggestTrialsMetadata> retrievedResponse = vizierServiceClient.PollOnceSuggestTrials(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SuggestTrialsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuggestTrialsAsync</summary>
        public async Task SuggestTrialsRequestObjectAsync()
        {
            // Snippet: SuggestTrialsAsync(SuggestTrialsRequest, CallSettings)
            // Additional: SuggestTrialsAsync(SuggestTrialsRequest, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            SuggestTrialsRequest request = new SuggestTrialsRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                SuggestionCount = 0,
                ClientId = "",
                Contexts = { new TrialContext(), },
            };
            // Make the request
            Operation<SuggestTrialsResponse, SuggestTrialsMetadata> response = await vizierServiceClient.SuggestTrialsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SuggestTrialsResponse, SuggestTrialsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SuggestTrialsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SuggestTrialsResponse, SuggestTrialsMetadata> retrievedResponse = await vizierServiceClient.PollOnceSuggestTrialsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SuggestTrialsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTrial</summary>
        public void CreateTrialRequestObject()
        {
            // Snippet: CreateTrial(CreateTrialRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            CreateTrialRequest request = new CreateTrialRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                Trial = new Trial(),
            };
            // Make the request
            Trial response = vizierServiceClient.CreateTrial(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTrialAsync</summary>
        public async Task CreateTrialRequestObjectAsync()
        {
            // Snippet: CreateTrialAsync(CreateTrialRequest, CallSettings)
            // Additional: CreateTrialAsync(CreateTrialRequest, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTrialRequest request = new CreateTrialRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                Trial = new Trial(),
            };
            // Make the request
            Trial response = await vizierServiceClient.CreateTrialAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTrial</summary>
        public void CreateTrial()
        {
            // Snippet: CreateTrial(string, Trial, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/studies/[STUDY]";
            Trial trial = new Trial();
            // Make the request
            Trial response = vizierServiceClient.CreateTrial(parent, trial);
            // End snippet
        }

        /// <summary>Snippet for CreateTrialAsync</summary>
        public async Task CreateTrialAsync()
        {
            // Snippet: CreateTrialAsync(string, Trial, CallSettings)
            // Additional: CreateTrialAsync(string, Trial, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/studies/[STUDY]";
            Trial trial = new Trial();
            // Make the request
            Trial response = await vizierServiceClient.CreateTrialAsync(parent, trial);
            // End snippet
        }

        /// <summary>Snippet for CreateTrial</summary>
        public void CreateTrialResourceNames()
        {
            // Snippet: CreateTrial(StudyName, Trial, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            StudyName parent = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]");
            Trial trial = new Trial();
            // Make the request
            Trial response = vizierServiceClient.CreateTrial(parent, trial);
            // End snippet
        }

        /// <summary>Snippet for CreateTrialAsync</summary>
        public async Task CreateTrialResourceNamesAsync()
        {
            // Snippet: CreateTrialAsync(StudyName, Trial, CallSettings)
            // Additional: CreateTrialAsync(StudyName, Trial, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            StudyName parent = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]");
            Trial trial = new Trial();
            // Make the request
            Trial response = await vizierServiceClient.CreateTrialAsync(parent, trial);
            // End snippet
        }

        /// <summary>Snippet for GetTrial</summary>
        public void GetTrialRequestObject()
        {
            // Snippet: GetTrial(GetTrialRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            GetTrialRequest request = new GetTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            // Make the request
            Trial response = vizierServiceClient.GetTrial(request);
            // End snippet
        }

        /// <summary>Snippet for GetTrialAsync</summary>
        public async Task GetTrialRequestObjectAsync()
        {
            // Snippet: GetTrialAsync(GetTrialRequest, CallSettings)
            // Additional: GetTrialAsync(GetTrialRequest, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTrialRequest request = new GetTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            // Make the request
            Trial response = await vizierServiceClient.GetTrialAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTrial</summary>
        public void GetTrial()
        {
            // Snippet: GetTrial(string, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/studies/[STUDY]/trials/[TRIAL]";
            // Make the request
            Trial response = vizierServiceClient.GetTrial(name);
            // End snippet
        }

        /// <summary>Snippet for GetTrialAsync</summary>
        public async Task GetTrialAsync()
        {
            // Snippet: GetTrialAsync(string, CallSettings)
            // Additional: GetTrialAsync(string, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/studies/[STUDY]/trials/[TRIAL]";
            // Make the request
            Trial response = await vizierServiceClient.GetTrialAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTrial</summary>
        public void GetTrialResourceNames()
        {
            // Snippet: GetTrial(TrialName, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            TrialName name = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]");
            // Make the request
            Trial response = vizierServiceClient.GetTrial(name);
            // End snippet
        }

        /// <summary>Snippet for GetTrialAsync</summary>
        public async Task GetTrialResourceNamesAsync()
        {
            // Snippet: GetTrialAsync(TrialName, CallSettings)
            // Additional: GetTrialAsync(TrialName, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            TrialName name = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]");
            // Make the request
            Trial response = await vizierServiceClient.GetTrialAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTrials</summary>
        public void ListTrialsRequestObject()
        {
            // Snippet: ListTrials(ListTrialsRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            ListTrialsRequest request = new ListTrialsRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            // Make the request
            PagedEnumerable<ListTrialsResponse, Trial> response = vizierServiceClient.ListTrials(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Trial item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTrialsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trial item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trial> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trial item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTrialsAsync</summary>
        public async Task ListTrialsRequestObjectAsync()
        {
            // Snippet: ListTrialsAsync(ListTrialsRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTrialsRequest request = new ListTrialsRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTrialsResponse, Trial> response = vizierServiceClient.ListTrialsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Trial item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTrialsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trial item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trial> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trial item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTrials</summary>
        public void ListTrials()
        {
            // Snippet: ListTrials(string, string, int?, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/studies/[STUDY]";
            // Make the request
            PagedEnumerable<ListTrialsResponse, Trial> response = vizierServiceClient.ListTrials(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Trial item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTrialsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trial item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trial> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trial item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTrialsAsync</summary>
        public async Task ListTrialsAsync()
        {
            // Snippet: ListTrialsAsync(string, string, int?, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/studies/[STUDY]";
            // Make the request
            PagedAsyncEnumerable<ListTrialsResponse, Trial> response = vizierServiceClient.ListTrialsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Trial item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTrialsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trial item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trial> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trial item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTrials</summary>
        public void ListTrialsResourceNames()
        {
            // Snippet: ListTrials(StudyName, string, int?, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            StudyName parent = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]");
            // Make the request
            PagedEnumerable<ListTrialsResponse, Trial> response = vizierServiceClient.ListTrials(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Trial item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTrialsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trial item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trial> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trial item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTrialsAsync</summary>
        public async Task ListTrialsResourceNamesAsync()
        {
            // Snippet: ListTrialsAsync(StudyName, string, int?, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            StudyName parent = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]");
            // Make the request
            PagedAsyncEnumerable<ListTrialsResponse, Trial> response = vizierServiceClient.ListTrialsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Trial item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTrialsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trial item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trial> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trial item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AddTrialMeasurement</summary>
        public void AddTrialMeasurementRequestObject()
        {
            // Snippet: AddTrialMeasurement(AddTrialMeasurementRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            AddTrialMeasurementRequest request = new AddTrialMeasurementRequest
            {
                TrialNameAsTrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Measurement = new Measurement(),
            };
            // Make the request
            Trial response = vizierServiceClient.AddTrialMeasurement(request);
            // End snippet
        }

        /// <summary>Snippet for AddTrialMeasurementAsync</summary>
        public async Task AddTrialMeasurementRequestObjectAsync()
        {
            // Snippet: AddTrialMeasurementAsync(AddTrialMeasurementRequest, CallSettings)
            // Additional: AddTrialMeasurementAsync(AddTrialMeasurementRequest, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddTrialMeasurementRequest request = new AddTrialMeasurementRequest
            {
                TrialNameAsTrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Measurement = new Measurement(),
            };
            // Make the request
            Trial response = await vizierServiceClient.AddTrialMeasurementAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CompleteTrial</summary>
        public void CompleteTrialRequestObject()
        {
            // Snippet: CompleteTrial(CompleteTrialRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            CompleteTrialRequest request = new CompleteTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                FinalMeasurement = new Measurement(),
                TrialInfeasible = false,
                InfeasibleReason = "",
            };
            // Make the request
            Trial response = vizierServiceClient.CompleteTrial(request);
            // End snippet
        }

        /// <summary>Snippet for CompleteTrialAsync</summary>
        public async Task CompleteTrialRequestObjectAsync()
        {
            // Snippet: CompleteTrialAsync(CompleteTrialRequest, CallSettings)
            // Additional: CompleteTrialAsync(CompleteTrialRequest, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            CompleteTrialRequest request = new CompleteTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                FinalMeasurement = new Measurement(),
                TrialInfeasible = false,
                InfeasibleReason = "",
            };
            // Make the request
            Trial response = await vizierServiceClient.CompleteTrialAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTrial</summary>
        public void DeleteTrialRequestObject()
        {
            // Snippet: DeleteTrial(DeleteTrialRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            DeleteTrialRequest request = new DeleteTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            // Make the request
            vizierServiceClient.DeleteTrial(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTrialAsync</summary>
        public async Task DeleteTrialRequestObjectAsync()
        {
            // Snippet: DeleteTrialAsync(DeleteTrialRequest, CallSettings)
            // Additional: DeleteTrialAsync(DeleteTrialRequest, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTrialRequest request = new DeleteTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            // Make the request
            await vizierServiceClient.DeleteTrialAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTrial</summary>
        public void DeleteTrial()
        {
            // Snippet: DeleteTrial(string, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/studies/[STUDY]/trials/[TRIAL]";
            // Make the request
            vizierServiceClient.DeleteTrial(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTrialAsync</summary>
        public async Task DeleteTrialAsync()
        {
            // Snippet: DeleteTrialAsync(string, CallSettings)
            // Additional: DeleteTrialAsync(string, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/studies/[STUDY]/trials/[TRIAL]";
            // Make the request
            await vizierServiceClient.DeleteTrialAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTrial</summary>
        public void DeleteTrialResourceNames()
        {
            // Snippet: DeleteTrial(TrialName, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            TrialName name = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]");
            // Make the request
            vizierServiceClient.DeleteTrial(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTrialAsync</summary>
        public async Task DeleteTrialResourceNamesAsync()
        {
            // Snippet: DeleteTrialAsync(TrialName, CallSettings)
            // Additional: DeleteTrialAsync(TrialName, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            TrialName name = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]");
            // Make the request
            await vizierServiceClient.DeleteTrialAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CheckTrialEarlyStoppingState</summary>
        public void CheckTrialEarlyStoppingStateRequestObject()
        {
            // Snippet: CheckTrialEarlyStoppingState(CheckTrialEarlyStoppingStateRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            CheckTrialEarlyStoppingStateRequest request = new CheckTrialEarlyStoppingStateRequest
            {
                TrialNameAsTrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            // Make the request
            Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata> response = vizierServiceClient.CheckTrialEarlyStoppingState(request);

            // Poll until the returned long-running operation is complete
            Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CheckTrialEarlyStoppingStateResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata> retrievedResponse = vizierServiceClient.PollOnceCheckTrialEarlyStoppingState(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CheckTrialEarlyStoppingStateResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CheckTrialEarlyStoppingStateAsync</summary>
        public async Task CheckTrialEarlyStoppingStateRequestObjectAsync()
        {
            // Snippet: CheckTrialEarlyStoppingStateAsync(CheckTrialEarlyStoppingStateRequest, CallSettings)
            // Additional: CheckTrialEarlyStoppingStateAsync(CheckTrialEarlyStoppingStateRequest, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            CheckTrialEarlyStoppingStateRequest request = new CheckTrialEarlyStoppingStateRequest
            {
                TrialNameAsTrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            // Make the request
            Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata> response = await vizierServiceClient.CheckTrialEarlyStoppingStateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CheckTrialEarlyStoppingStateResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata> retrievedResponse = await vizierServiceClient.PollOnceCheckTrialEarlyStoppingStateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CheckTrialEarlyStoppingStateResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopTrial</summary>
        public void StopTrialRequestObject()
        {
            // Snippet: StopTrial(StopTrialRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            StopTrialRequest request = new StopTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            // Make the request
            Trial response = vizierServiceClient.StopTrial(request);
            // End snippet
        }

        /// <summary>Snippet for StopTrialAsync</summary>
        public async Task StopTrialRequestObjectAsync()
        {
            // Snippet: StopTrialAsync(StopTrialRequest, CallSettings)
            // Additional: StopTrialAsync(StopTrialRequest, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            StopTrialRequest request = new StopTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            // Make the request
            Trial response = await vizierServiceClient.StopTrialAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListOptimalTrials</summary>
        public void ListOptimalTrialsRequestObject()
        {
            // Snippet: ListOptimalTrials(ListOptimalTrialsRequest, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            ListOptimalTrialsRequest request = new ListOptimalTrialsRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            // Make the request
            ListOptimalTrialsResponse response = vizierServiceClient.ListOptimalTrials(request);
            // End snippet
        }

        /// <summary>Snippet for ListOptimalTrialsAsync</summary>
        public async Task ListOptimalTrialsRequestObjectAsync()
        {
            // Snippet: ListOptimalTrialsAsync(ListOptimalTrialsRequest, CallSettings)
            // Additional: ListOptimalTrialsAsync(ListOptimalTrialsRequest, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListOptimalTrialsRequest request = new ListOptimalTrialsRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            // Make the request
            ListOptimalTrialsResponse response = await vizierServiceClient.ListOptimalTrialsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListOptimalTrials</summary>
        public void ListOptimalTrials()
        {
            // Snippet: ListOptimalTrials(string, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/studies/[STUDY]";
            // Make the request
            ListOptimalTrialsResponse response = vizierServiceClient.ListOptimalTrials(parent);
            // End snippet
        }

        /// <summary>Snippet for ListOptimalTrialsAsync</summary>
        public async Task ListOptimalTrialsAsync()
        {
            // Snippet: ListOptimalTrialsAsync(string, CallSettings)
            // Additional: ListOptimalTrialsAsync(string, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/studies/[STUDY]";
            // Make the request
            ListOptimalTrialsResponse response = await vizierServiceClient.ListOptimalTrialsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListOptimalTrials</summary>
        public void ListOptimalTrialsResourceNames()
        {
            // Snippet: ListOptimalTrials(StudyName, CallSettings)
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            StudyName parent = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]");
            // Make the request
            ListOptimalTrialsResponse response = vizierServiceClient.ListOptimalTrials(parent);
            // End snippet
        }

        /// <summary>Snippet for ListOptimalTrialsAsync</summary>
        public async Task ListOptimalTrialsResourceNamesAsync()
        {
            // Snippet: ListOptimalTrialsAsync(StudyName, CallSettings)
            // Additional: ListOptimalTrialsAsync(StudyName, CancellationToken)
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            StudyName parent = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]");
            // Make the request
            ListOptimalTrialsResponse response = await vizierServiceClient.ListOptimalTrialsAsync(parent);
            // End snippet
        }
    }
}
