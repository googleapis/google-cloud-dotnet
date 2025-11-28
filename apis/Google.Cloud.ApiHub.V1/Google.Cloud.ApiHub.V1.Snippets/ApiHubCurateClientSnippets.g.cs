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
    using Google.Cloud.ApiHub.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedApiHubCurateClientSnippets
    {
        /// <summary>Snippet for CreateCuration</summary>
        public void CreateCurationRequestObject()
        {
            // Snippet: CreateCuration(CreateCurationRequest, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = ApiHubCurateClient.Create();
            // Initialize request argument(s)
            CreateCurationRequest request = new CreateCurationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CurationId = "",
                Curation = new Curation(),
            };
            // Make the request
            Curation response = apiHubCurateClient.CreateCuration(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCurationAsync</summary>
        public async Task CreateCurationRequestObjectAsync()
        {
            // Snippet: CreateCurationAsync(CreateCurationRequest, CallSettings)
            // Additional: CreateCurationAsync(CreateCurationRequest, CancellationToken)
            // Create client
            ApiHubCurateClient apiHubCurateClient = await ApiHubCurateClient.CreateAsync();
            // Initialize request argument(s)
            CreateCurationRequest request = new CreateCurationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CurationId = "",
                Curation = new Curation(),
            };
            // Make the request
            Curation response = await apiHubCurateClient.CreateCurationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCuration</summary>
        public void CreateCuration()
        {
            // Snippet: CreateCuration(string, Curation, string, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = ApiHubCurateClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Curation curation = new Curation();
            string curationId = "";
            // Make the request
            Curation response = apiHubCurateClient.CreateCuration(parent, curation, curationId);
            // End snippet
        }

        /// <summary>Snippet for CreateCurationAsync</summary>
        public async Task CreateCurationAsync()
        {
            // Snippet: CreateCurationAsync(string, Curation, string, CallSettings)
            // Additional: CreateCurationAsync(string, Curation, string, CancellationToken)
            // Create client
            ApiHubCurateClient apiHubCurateClient = await ApiHubCurateClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Curation curation = new Curation();
            string curationId = "";
            // Make the request
            Curation response = await apiHubCurateClient.CreateCurationAsync(parent, curation, curationId);
            // End snippet
        }

        /// <summary>Snippet for CreateCuration</summary>
        public void CreateCurationResourceNames()
        {
            // Snippet: CreateCuration(LocationName, Curation, string, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = ApiHubCurateClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Curation curation = new Curation();
            string curationId = "";
            // Make the request
            Curation response = apiHubCurateClient.CreateCuration(parent, curation, curationId);
            // End snippet
        }

        /// <summary>Snippet for CreateCurationAsync</summary>
        public async Task CreateCurationResourceNamesAsync()
        {
            // Snippet: CreateCurationAsync(LocationName, Curation, string, CallSettings)
            // Additional: CreateCurationAsync(LocationName, Curation, string, CancellationToken)
            // Create client
            ApiHubCurateClient apiHubCurateClient = await ApiHubCurateClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Curation curation = new Curation();
            string curationId = "";
            // Make the request
            Curation response = await apiHubCurateClient.CreateCurationAsync(parent, curation, curationId);
            // End snippet
        }

        /// <summary>Snippet for GetCuration</summary>
        public void GetCurationRequestObject()
        {
            // Snippet: GetCuration(GetCurationRequest, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = ApiHubCurateClient.Create();
            // Initialize request argument(s)
            GetCurationRequest request = new GetCurationRequest
            {
                CurationName = CurationName.FromProjectLocationCuration("[PROJECT]", "[LOCATION]", "[CURATION]"),
            };
            // Make the request
            Curation response = apiHubCurateClient.GetCuration(request);
            // End snippet
        }

        /// <summary>Snippet for GetCurationAsync</summary>
        public async Task GetCurationRequestObjectAsync()
        {
            // Snippet: GetCurationAsync(GetCurationRequest, CallSettings)
            // Additional: GetCurationAsync(GetCurationRequest, CancellationToken)
            // Create client
            ApiHubCurateClient apiHubCurateClient = await ApiHubCurateClient.CreateAsync();
            // Initialize request argument(s)
            GetCurationRequest request = new GetCurationRequest
            {
                CurationName = CurationName.FromProjectLocationCuration("[PROJECT]", "[LOCATION]", "[CURATION]"),
            };
            // Make the request
            Curation response = await apiHubCurateClient.GetCurationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCuration</summary>
        public void GetCuration()
        {
            // Snippet: GetCuration(string, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = ApiHubCurateClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/curations/[CURATION]";
            // Make the request
            Curation response = apiHubCurateClient.GetCuration(name);
            // End snippet
        }

        /// <summary>Snippet for GetCurationAsync</summary>
        public async Task GetCurationAsync()
        {
            // Snippet: GetCurationAsync(string, CallSettings)
            // Additional: GetCurationAsync(string, CancellationToken)
            // Create client
            ApiHubCurateClient apiHubCurateClient = await ApiHubCurateClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/curations/[CURATION]";
            // Make the request
            Curation response = await apiHubCurateClient.GetCurationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCuration</summary>
        public void GetCurationResourceNames()
        {
            // Snippet: GetCuration(CurationName, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = ApiHubCurateClient.Create();
            // Initialize request argument(s)
            CurationName name = CurationName.FromProjectLocationCuration("[PROJECT]", "[LOCATION]", "[CURATION]");
            // Make the request
            Curation response = apiHubCurateClient.GetCuration(name);
            // End snippet
        }

        /// <summary>Snippet for GetCurationAsync</summary>
        public async Task GetCurationResourceNamesAsync()
        {
            // Snippet: GetCurationAsync(CurationName, CallSettings)
            // Additional: GetCurationAsync(CurationName, CancellationToken)
            // Create client
            ApiHubCurateClient apiHubCurateClient = await ApiHubCurateClient.CreateAsync();
            // Initialize request argument(s)
            CurationName name = CurationName.FromProjectLocationCuration("[PROJECT]", "[LOCATION]", "[CURATION]");
            // Make the request
            Curation response = await apiHubCurateClient.GetCurationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCurations</summary>
        public void ListCurationsRequestObject()
        {
            // Snippet: ListCurations(ListCurationsRequest, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = ApiHubCurateClient.Create();
            // Initialize request argument(s)
            ListCurationsRequest request = new ListCurationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListCurationsResponse, Curation> response = apiHubCurateClient.ListCurations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Curation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCurationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Curation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Curation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Curation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCurationsAsync</summary>
        public async Task ListCurationsRequestObjectAsync()
        {
            // Snippet: ListCurationsAsync(ListCurationsRequest, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = await ApiHubCurateClient.CreateAsync();
            // Initialize request argument(s)
            ListCurationsRequest request = new ListCurationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCurationsResponse, Curation> response = apiHubCurateClient.ListCurationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Curation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCurationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Curation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Curation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Curation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCurations</summary>
        public void ListCurations()
        {
            // Snippet: ListCurations(string, string, int?, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = ApiHubCurateClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCurationsResponse, Curation> response = apiHubCurateClient.ListCurations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Curation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCurationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Curation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Curation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Curation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCurationsAsync</summary>
        public async Task ListCurationsAsync()
        {
            // Snippet: ListCurationsAsync(string, string, int?, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = await ApiHubCurateClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCurationsResponse, Curation> response = apiHubCurateClient.ListCurationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Curation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCurationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Curation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Curation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Curation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCurations</summary>
        public void ListCurationsResourceNames()
        {
            // Snippet: ListCurations(LocationName, string, int?, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = ApiHubCurateClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCurationsResponse, Curation> response = apiHubCurateClient.ListCurations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Curation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCurationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Curation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Curation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Curation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCurationsAsync</summary>
        public async Task ListCurationsResourceNamesAsync()
        {
            // Snippet: ListCurationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = await ApiHubCurateClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCurationsResponse, Curation> response = apiHubCurateClient.ListCurationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Curation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCurationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Curation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Curation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Curation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateCuration</summary>
        public void UpdateCurationRequestObject()
        {
            // Snippet: UpdateCuration(UpdateCurationRequest, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = ApiHubCurateClient.Create();
            // Initialize request argument(s)
            UpdateCurationRequest request = new UpdateCurationRequest
            {
                Curation = new Curation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Curation response = apiHubCurateClient.UpdateCuration(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCurationAsync</summary>
        public async Task UpdateCurationRequestObjectAsync()
        {
            // Snippet: UpdateCurationAsync(UpdateCurationRequest, CallSettings)
            // Additional: UpdateCurationAsync(UpdateCurationRequest, CancellationToken)
            // Create client
            ApiHubCurateClient apiHubCurateClient = await ApiHubCurateClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCurationRequest request = new UpdateCurationRequest
            {
                Curation = new Curation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Curation response = await apiHubCurateClient.UpdateCurationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCuration</summary>
        public void UpdateCuration()
        {
            // Snippet: UpdateCuration(Curation, FieldMask, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = ApiHubCurateClient.Create();
            // Initialize request argument(s)
            Curation curation = new Curation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Curation response = apiHubCurateClient.UpdateCuration(curation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCurationAsync</summary>
        public async Task UpdateCurationAsync()
        {
            // Snippet: UpdateCurationAsync(Curation, FieldMask, CallSettings)
            // Additional: UpdateCurationAsync(Curation, FieldMask, CancellationToken)
            // Create client
            ApiHubCurateClient apiHubCurateClient = await ApiHubCurateClient.CreateAsync();
            // Initialize request argument(s)
            Curation curation = new Curation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Curation response = await apiHubCurateClient.UpdateCurationAsync(curation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteCuration</summary>
        public void DeleteCurationRequestObject()
        {
            // Snippet: DeleteCuration(DeleteCurationRequest, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = ApiHubCurateClient.Create();
            // Initialize request argument(s)
            DeleteCurationRequest request = new DeleteCurationRequest
            {
                CurationName = CurationName.FromProjectLocationCuration("[PROJECT]", "[LOCATION]", "[CURATION]"),
            };
            // Make the request
            apiHubCurateClient.DeleteCuration(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCurationAsync</summary>
        public async Task DeleteCurationRequestObjectAsync()
        {
            // Snippet: DeleteCurationAsync(DeleteCurationRequest, CallSettings)
            // Additional: DeleteCurationAsync(DeleteCurationRequest, CancellationToken)
            // Create client
            ApiHubCurateClient apiHubCurateClient = await ApiHubCurateClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCurationRequest request = new DeleteCurationRequest
            {
                CurationName = CurationName.FromProjectLocationCuration("[PROJECT]", "[LOCATION]", "[CURATION]"),
            };
            // Make the request
            await apiHubCurateClient.DeleteCurationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCuration</summary>
        public void DeleteCuration()
        {
            // Snippet: DeleteCuration(string, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = ApiHubCurateClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/curations/[CURATION]";
            // Make the request
            apiHubCurateClient.DeleteCuration(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCurationAsync</summary>
        public async Task DeleteCurationAsync()
        {
            // Snippet: DeleteCurationAsync(string, CallSettings)
            // Additional: DeleteCurationAsync(string, CancellationToken)
            // Create client
            ApiHubCurateClient apiHubCurateClient = await ApiHubCurateClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/curations/[CURATION]";
            // Make the request
            await apiHubCurateClient.DeleteCurationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCuration</summary>
        public void DeleteCurationResourceNames()
        {
            // Snippet: DeleteCuration(CurationName, CallSettings)
            // Create client
            ApiHubCurateClient apiHubCurateClient = ApiHubCurateClient.Create();
            // Initialize request argument(s)
            CurationName name = CurationName.FromProjectLocationCuration("[PROJECT]", "[LOCATION]", "[CURATION]");
            // Make the request
            apiHubCurateClient.DeleteCuration(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCurationAsync</summary>
        public async Task DeleteCurationResourceNamesAsync()
        {
            // Snippet: DeleteCurationAsync(CurationName, CallSettings)
            // Additional: DeleteCurationAsync(CurationName, CancellationToken)
            // Create client
            ApiHubCurateClient apiHubCurateClient = await ApiHubCurateClient.CreateAsync();
            // Initialize request argument(s)
            CurationName name = CurationName.FromProjectLocationCuration("[PROJECT]", "[LOCATION]", "[CURATION]");
            // Make the request
            await apiHubCurateClient.DeleteCurationAsync(name);
            // End snippet
        }
    }
}
