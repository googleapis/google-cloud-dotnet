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
    using Google.Cloud.Speech.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAdaptationClientSnippets
    {
        /// <summary>Snippet for CreatePhraseSet</summary>
        public void CreatePhraseSetRequestObject()
        {
            // Snippet: CreatePhraseSet(CreatePhraseSetRequest, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            CreatePhraseSetRequest request = new CreatePhraseSetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PhraseSetId = "",
                PhraseSet = new PhraseSet(),
            };
            // Make the request
            PhraseSet response = adaptationClient.CreatePhraseSet(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseSetAsync</summary>
        public async Task CreatePhraseSetRequestObjectAsync()
        {
            // Snippet: CreatePhraseSetAsync(CreatePhraseSetRequest, CallSettings)
            // Additional: CreatePhraseSetAsync(CreatePhraseSetRequest, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            CreatePhraseSetRequest request = new CreatePhraseSetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PhraseSetId = "",
                PhraseSet = new PhraseSet(),
            };
            // Make the request
            PhraseSet response = await adaptationClient.CreatePhraseSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseSet</summary>
        public void CreatePhraseSet()
        {
            // Snippet: CreatePhraseSet(string, PhraseSet, string, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PhraseSet phraseSet = new PhraseSet();
            string phraseSetId = "";
            // Make the request
            PhraseSet response = adaptationClient.CreatePhraseSet(parent, phraseSet, phraseSetId);
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseSetAsync</summary>
        public async Task CreatePhraseSetAsync()
        {
            // Snippet: CreatePhraseSetAsync(string, PhraseSet, string, CallSettings)
            // Additional: CreatePhraseSetAsync(string, PhraseSet, string, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PhraseSet phraseSet = new PhraseSet();
            string phraseSetId = "";
            // Make the request
            PhraseSet response = await adaptationClient.CreatePhraseSetAsync(parent, phraseSet, phraseSetId);
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseSet</summary>
        public void CreatePhraseSetResourceNames()
        {
            // Snippet: CreatePhraseSet(LocationName, PhraseSet, string, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PhraseSet phraseSet = new PhraseSet();
            string phraseSetId = "";
            // Make the request
            PhraseSet response = adaptationClient.CreatePhraseSet(parent, phraseSet, phraseSetId);
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseSetAsync</summary>
        public async Task CreatePhraseSetResourceNamesAsync()
        {
            // Snippet: CreatePhraseSetAsync(LocationName, PhraseSet, string, CallSettings)
            // Additional: CreatePhraseSetAsync(LocationName, PhraseSet, string, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PhraseSet phraseSet = new PhraseSet();
            string phraseSetId = "";
            // Make the request
            PhraseSet response = await adaptationClient.CreatePhraseSetAsync(parent, phraseSet, phraseSetId);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseSet</summary>
        public void GetPhraseSetRequestObject()
        {
            // Snippet: GetPhraseSet(GetPhraseSetRequest, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            GetPhraseSetRequest request = new GetPhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            // Make the request
            PhraseSet response = adaptationClient.GetPhraseSet(request);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseSetAsync</summary>
        public async Task GetPhraseSetRequestObjectAsync()
        {
            // Snippet: GetPhraseSetAsync(GetPhraseSetRequest, CallSettings)
            // Additional: GetPhraseSetAsync(GetPhraseSetRequest, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            GetPhraseSetRequest request = new GetPhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            // Make the request
            PhraseSet response = await adaptationClient.GetPhraseSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseSet</summary>
        public void GetPhraseSet()
        {
            // Snippet: GetPhraseSet(string, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/phraseSets/[PHRASE_SET]";
            // Make the request
            PhraseSet response = adaptationClient.GetPhraseSet(name);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseSetAsync</summary>
        public async Task GetPhraseSetAsync()
        {
            // Snippet: GetPhraseSetAsync(string, CallSettings)
            // Additional: GetPhraseSetAsync(string, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/phraseSets/[PHRASE_SET]";
            // Make the request
            PhraseSet response = await adaptationClient.GetPhraseSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseSet</summary>
        public void GetPhraseSetResourceNames()
        {
            // Snippet: GetPhraseSet(PhraseSetName, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            PhraseSetName name = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]");
            // Make the request
            PhraseSet response = adaptationClient.GetPhraseSet(name);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseSetAsync</summary>
        public async Task GetPhraseSetResourceNamesAsync()
        {
            // Snippet: GetPhraseSetAsync(PhraseSetName, CallSettings)
            // Additional: GetPhraseSetAsync(PhraseSetName, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            PhraseSetName name = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]");
            // Make the request
            PhraseSet response = await adaptationClient.GetPhraseSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPhraseSet</summary>
        public void ListPhraseSetRequestObject()
        {
            // Snippet: ListPhraseSet(ListPhraseSetRequest, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            ListPhraseSetRequest request = new ListPhraseSetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListPhraseSetResponse, PhraseSet> response = adaptationClient.ListPhraseSet(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PhraseSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhraseSetResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListPhraseSetAsync</summary>
        public async Task ListPhraseSetRequestObjectAsync()
        {
            // Snippet: ListPhraseSetAsync(ListPhraseSetRequest, CallSettings)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            ListPhraseSetRequest request = new ListPhraseSetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPhraseSetResponse, PhraseSet> response = adaptationClient.ListPhraseSetAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PhraseSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhraseSetResponse page) =>
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

        /// <summary>Snippet for ListPhraseSet</summary>
        public void ListPhraseSet()
        {
            // Snippet: ListPhraseSet(string, string, int?, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPhraseSetResponse, PhraseSet> response = adaptationClient.ListPhraseSet(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PhraseSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhraseSetResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListPhraseSetAsync</summary>
        public async Task ListPhraseSetAsync()
        {
            // Snippet: ListPhraseSetAsync(string, string, int?, CallSettings)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPhraseSetResponse, PhraseSet> response = adaptationClient.ListPhraseSetAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PhraseSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhraseSetResponse page) =>
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

        /// <summary>Snippet for ListPhraseSet</summary>
        public void ListPhraseSetResourceNames()
        {
            // Snippet: ListPhraseSet(LocationName, string, int?, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPhraseSetResponse, PhraseSet> response = adaptationClient.ListPhraseSet(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PhraseSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhraseSetResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListPhraseSetAsync</summary>
        public async Task ListPhraseSetResourceNamesAsync()
        {
            // Snippet: ListPhraseSetAsync(LocationName, string, int?, CallSettings)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPhraseSetResponse, PhraseSet> response = adaptationClient.ListPhraseSetAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PhraseSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhraseSetResponse page) =>
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

        /// <summary>Snippet for UpdatePhraseSet</summary>
        public void UpdatePhraseSetRequestObject()
        {
            // Snippet: UpdatePhraseSet(UpdatePhraseSetRequest, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            UpdatePhraseSetRequest request = new UpdatePhraseSetRequest
            {
                PhraseSet = new PhraseSet(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PhraseSet response = adaptationClient.UpdatePhraseSet(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhraseSetAsync</summary>
        public async Task UpdatePhraseSetRequestObjectAsync()
        {
            // Snippet: UpdatePhraseSetAsync(UpdatePhraseSetRequest, CallSettings)
            // Additional: UpdatePhraseSetAsync(UpdatePhraseSetRequest, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePhraseSetRequest request = new UpdatePhraseSetRequest
            {
                PhraseSet = new PhraseSet(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PhraseSet response = await adaptationClient.UpdatePhraseSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhraseSet</summary>
        public void UpdatePhraseSet()
        {
            // Snippet: UpdatePhraseSet(PhraseSet, FieldMask, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            PhraseSet phraseSet = new PhraseSet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PhraseSet response = adaptationClient.UpdatePhraseSet(phraseSet, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhraseSetAsync</summary>
        public async Task UpdatePhraseSetAsync()
        {
            // Snippet: UpdatePhraseSetAsync(PhraseSet, FieldMask, CallSettings)
            // Additional: UpdatePhraseSetAsync(PhraseSet, FieldMask, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            PhraseSet phraseSet = new PhraseSet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PhraseSet response = await adaptationClient.UpdatePhraseSetAsync(phraseSet, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseSet</summary>
        public void DeletePhraseSetRequestObject()
        {
            // Snippet: DeletePhraseSet(DeletePhraseSetRequest, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            DeletePhraseSetRequest request = new DeletePhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            // Make the request
            adaptationClient.DeletePhraseSet(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseSetAsync</summary>
        public async Task DeletePhraseSetRequestObjectAsync()
        {
            // Snippet: DeletePhraseSetAsync(DeletePhraseSetRequest, CallSettings)
            // Additional: DeletePhraseSetAsync(DeletePhraseSetRequest, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            DeletePhraseSetRequest request = new DeletePhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            // Make the request
            await adaptationClient.DeletePhraseSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseSet</summary>
        public void DeletePhraseSet()
        {
            // Snippet: DeletePhraseSet(string, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/phraseSets/[PHRASE_SET]";
            // Make the request
            adaptationClient.DeletePhraseSet(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseSetAsync</summary>
        public async Task DeletePhraseSetAsync()
        {
            // Snippet: DeletePhraseSetAsync(string, CallSettings)
            // Additional: DeletePhraseSetAsync(string, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/phraseSets/[PHRASE_SET]";
            // Make the request
            await adaptationClient.DeletePhraseSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseSet</summary>
        public void DeletePhraseSetResourceNames()
        {
            // Snippet: DeletePhraseSet(PhraseSetName, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            PhraseSetName name = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]");
            // Make the request
            adaptationClient.DeletePhraseSet(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseSetAsync</summary>
        public async Task DeletePhraseSetResourceNamesAsync()
        {
            // Snippet: DeletePhraseSetAsync(PhraseSetName, CallSettings)
            // Additional: DeletePhraseSetAsync(PhraseSetName, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            PhraseSetName name = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]");
            // Make the request
            await adaptationClient.DeletePhraseSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomClass</summary>
        public void CreateCustomClassRequestObject()
        {
            // Snippet: CreateCustomClass(CreateCustomClassRequest, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            CreateCustomClassRequest request = new CreateCustomClassRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomClassId = "",
                CustomClass = new CustomClass(),
            };
            // Make the request
            CustomClass response = adaptationClient.CreateCustomClass(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomClassAsync</summary>
        public async Task CreateCustomClassRequestObjectAsync()
        {
            // Snippet: CreateCustomClassAsync(CreateCustomClassRequest, CallSettings)
            // Additional: CreateCustomClassAsync(CreateCustomClassRequest, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            CreateCustomClassRequest request = new CreateCustomClassRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomClassId = "",
                CustomClass = new CustomClass(),
            };
            // Make the request
            CustomClass response = await adaptationClient.CreateCustomClassAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomClass</summary>
        public void CreateCustomClass()
        {
            // Snippet: CreateCustomClass(string, CustomClass, string, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CustomClass customClass = new CustomClass();
            string customClassId = "";
            // Make the request
            CustomClass response = adaptationClient.CreateCustomClass(parent, customClass, customClassId);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomClassAsync</summary>
        public async Task CreateCustomClassAsync()
        {
            // Snippet: CreateCustomClassAsync(string, CustomClass, string, CallSettings)
            // Additional: CreateCustomClassAsync(string, CustomClass, string, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CustomClass customClass = new CustomClass();
            string customClassId = "";
            // Make the request
            CustomClass response = await adaptationClient.CreateCustomClassAsync(parent, customClass, customClassId);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomClass</summary>
        public void CreateCustomClassResourceNames()
        {
            // Snippet: CreateCustomClass(LocationName, CustomClass, string, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CustomClass customClass = new CustomClass();
            string customClassId = "";
            // Make the request
            CustomClass response = adaptationClient.CreateCustomClass(parent, customClass, customClassId);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomClassAsync</summary>
        public async Task CreateCustomClassResourceNamesAsync()
        {
            // Snippet: CreateCustomClassAsync(LocationName, CustomClass, string, CallSettings)
            // Additional: CreateCustomClassAsync(LocationName, CustomClass, string, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CustomClass customClass = new CustomClass();
            string customClassId = "";
            // Make the request
            CustomClass response = await adaptationClient.CreateCustomClassAsync(parent, customClass, customClassId);
            // End snippet
        }

        /// <summary>Snippet for GetCustomClass</summary>
        public void GetCustomClassRequestObject()
        {
            // Snippet: GetCustomClass(GetCustomClassRequest, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            GetCustomClassRequest request = new GetCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            // Make the request
            CustomClass response = adaptationClient.GetCustomClass(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomClassAsync</summary>
        public async Task GetCustomClassRequestObjectAsync()
        {
            // Snippet: GetCustomClassAsync(GetCustomClassRequest, CallSettings)
            // Additional: GetCustomClassAsync(GetCustomClassRequest, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomClassRequest request = new GetCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            // Make the request
            CustomClass response = await adaptationClient.GetCustomClassAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomClass</summary>
        public void GetCustomClass()
        {
            // Snippet: GetCustomClass(string, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customClasses/[CUSTOM_CLASS]";
            // Make the request
            CustomClass response = adaptationClient.GetCustomClass(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomClassAsync</summary>
        public async Task GetCustomClassAsync()
        {
            // Snippet: GetCustomClassAsync(string, CallSettings)
            // Additional: GetCustomClassAsync(string, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customClasses/[CUSTOM_CLASS]";
            // Make the request
            CustomClass response = await adaptationClient.GetCustomClassAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomClass</summary>
        public void GetCustomClassResourceNames()
        {
            // Snippet: GetCustomClass(CustomClassName, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            CustomClassName name = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]");
            // Make the request
            CustomClass response = adaptationClient.GetCustomClass(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomClassAsync</summary>
        public async Task GetCustomClassResourceNamesAsync()
        {
            // Snippet: GetCustomClassAsync(CustomClassName, CallSettings)
            // Additional: GetCustomClassAsync(CustomClassName, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            CustomClassName name = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]");
            // Make the request
            CustomClass response = await adaptationClient.GetCustomClassAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCustomClasses</summary>
        public void ListCustomClassesRequestObject()
        {
            // Snippet: ListCustomClasses(ListCustomClassesRequest, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            ListCustomClassesRequest request = new ListCustomClassesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListCustomClassesResponse, CustomClass> response = adaptationClient.ListCustomClasses(request);

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
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            ListCustomClassesRequest request = new ListCustomClassesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCustomClassesResponse, CustomClass> response = adaptationClient.ListCustomClassesAsync(request);

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
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCustomClassesResponse, CustomClass> response = adaptationClient.ListCustomClasses(parent);

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
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCustomClassesResponse, CustomClass> response = adaptationClient.ListCustomClassesAsync(parent);

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
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCustomClassesResponse, CustomClass> response = adaptationClient.ListCustomClasses(parent);

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
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCustomClassesResponse, CustomClass> response = adaptationClient.ListCustomClassesAsync(parent);

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

        /// <summary>Snippet for UpdateCustomClass</summary>
        public void UpdateCustomClassRequestObject()
        {
            // Snippet: UpdateCustomClass(UpdateCustomClassRequest, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            UpdateCustomClassRequest request = new UpdateCustomClassRequest
            {
                CustomClass = new CustomClass(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CustomClass response = adaptationClient.UpdateCustomClass(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomClassAsync</summary>
        public async Task UpdateCustomClassRequestObjectAsync()
        {
            // Snippet: UpdateCustomClassAsync(UpdateCustomClassRequest, CallSettings)
            // Additional: UpdateCustomClassAsync(UpdateCustomClassRequest, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCustomClassRequest request = new UpdateCustomClassRequest
            {
                CustomClass = new CustomClass(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CustomClass response = await adaptationClient.UpdateCustomClassAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomClass</summary>
        public void UpdateCustomClass()
        {
            // Snippet: UpdateCustomClass(CustomClass, FieldMask, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            CustomClass customClass = new CustomClass();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CustomClass response = adaptationClient.UpdateCustomClass(customClass, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomClassAsync</summary>
        public async Task UpdateCustomClassAsync()
        {
            // Snippet: UpdateCustomClassAsync(CustomClass, FieldMask, CallSettings)
            // Additional: UpdateCustomClassAsync(CustomClass, FieldMask, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            CustomClass customClass = new CustomClass();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CustomClass response = await adaptationClient.UpdateCustomClassAsync(customClass, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomClass</summary>
        public void DeleteCustomClassRequestObject()
        {
            // Snippet: DeleteCustomClass(DeleteCustomClassRequest, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            DeleteCustomClassRequest request = new DeleteCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            // Make the request
            adaptationClient.DeleteCustomClass(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomClassAsync</summary>
        public async Task DeleteCustomClassRequestObjectAsync()
        {
            // Snippet: DeleteCustomClassAsync(DeleteCustomClassRequest, CallSettings)
            // Additional: DeleteCustomClassAsync(DeleteCustomClassRequest, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCustomClassRequest request = new DeleteCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            // Make the request
            await adaptationClient.DeleteCustomClassAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomClass</summary>
        public void DeleteCustomClass()
        {
            // Snippet: DeleteCustomClass(string, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customClasses/[CUSTOM_CLASS]";
            // Make the request
            adaptationClient.DeleteCustomClass(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomClassAsync</summary>
        public async Task DeleteCustomClassAsync()
        {
            // Snippet: DeleteCustomClassAsync(string, CallSettings)
            // Additional: DeleteCustomClassAsync(string, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customClasses/[CUSTOM_CLASS]";
            // Make the request
            await adaptationClient.DeleteCustomClassAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomClass</summary>
        public void DeleteCustomClassResourceNames()
        {
            // Snippet: DeleteCustomClass(CustomClassName, CallSettings)
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            CustomClassName name = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]");
            // Make the request
            adaptationClient.DeleteCustomClass(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomClassAsync</summary>
        public async Task DeleteCustomClassResourceNamesAsync()
        {
            // Snippet: DeleteCustomClassAsync(CustomClassName, CallSettings)
            // Additional: DeleteCustomClassAsync(CustomClassName, CancellationToken)
            // Create client
            AdaptationClient adaptationClient = await AdaptationClient.CreateAsync();
            // Initialize request argument(s)
            CustomClassName name = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]");
            // Make the request
            await adaptationClient.DeleteCustomClassAsync(name);
            // End snippet
        }
    }
}
