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
    using Google.Cloud.NetworkSecurity.V1Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDnsThreatDetectorServiceClientSnippets
    {
        /// <summary>Snippet for ListDnsThreatDetectors</summary>
        public void ListDnsThreatDetectorsRequestObject()
        {
            // Snippet: ListDnsThreatDetectors(ListDnsThreatDetectorsRequest, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = DnsThreatDetectorServiceClient.Create();
            // Initialize request argument(s)
            ListDnsThreatDetectorsRequest request = new ListDnsThreatDetectorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListDnsThreatDetectorsResponse, DnsThreatDetector> response = dnsThreatDetectorServiceClient.ListDnsThreatDetectors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DnsThreatDetector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDnsThreatDetectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DnsThreatDetector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DnsThreatDetector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DnsThreatDetector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDnsThreatDetectorsAsync</summary>
        public async Task ListDnsThreatDetectorsRequestObjectAsync()
        {
            // Snippet: ListDnsThreatDetectorsAsync(ListDnsThreatDetectorsRequest, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = await DnsThreatDetectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDnsThreatDetectorsRequest request = new ListDnsThreatDetectorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDnsThreatDetectorsResponse, DnsThreatDetector> response = dnsThreatDetectorServiceClient.ListDnsThreatDetectorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DnsThreatDetector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDnsThreatDetectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DnsThreatDetector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DnsThreatDetector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DnsThreatDetector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDnsThreatDetectors</summary>
        public void ListDnsThreatDetectors()
        {
            // Snippet: ListDnsThreatDetectors(string, string, int?, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = DnsThreatDetectorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDnsThreatDetectorsResponse, DnsThreatDetector> response = dnsThreatDetectorServiceClient.ListDnsThreatDetectors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DnsThreatDetector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDnsThreatDetectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DnsThreatDetector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DnsThreatDetector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DnsThreatDetector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDnsThreatDetectorsAsync</summary>
        public async Task ListDnsThreatDetectorsAsync()
        {
            // Snippet: ListDnsThreatDetectorsAsync(string, string, int?, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = await DnsThreatDetectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDnsThreatDetectorsResponse, DnsThreatDetector> response = dnsThreatDetectorServiceClient.ListDnsThreatDetectorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DnsThreatDetector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDnsThreatDetectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DnsThreatDetector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DnsThreatDetector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DnsThreatDetector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDnsThreatDetectors</summary>
        public void ListDnsThreatDetectorsResourceNames()
        {
            // Snippet: ListDnsThreatDetectors(LocationName, string, int?, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = DnsThreatDetectorServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDnsThreatDetectorsResponse, DnsThreatDetector> response = dnsThreatDetectorServiceClient.ListDnsThreatDetectors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DnsThreatDetector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDnsThreatDetectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DnsThreatDetector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DnsThreatDetector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DnsThreatDetector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDnsThreatDetectorsAsync</summary>
        public async Task ListDnsThreatDetectorsResourceNamesAsync()
        {
            // Snippet: ListDnsThreatDetectorsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = await DnsThreatDetectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDnsThreatDetectorsResponse, DnsThreatDetector> response = dnsThreatDetectorServiceClient.ListDnsThreatDetectorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DnsThreatDetector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDnsThreatDetectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DnsThreatDetector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DnsThreatDetector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DnsThreatDetector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDnsThreatDetector</summary>
        public void GetDnsThreatDetectorRequestObject()
        {
            // Snippet: GetDnsThreatDetector(GetDnsThreatDetectorRequest, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = DnsThreatDetectorServiceClient.Create();
            // Initialize request argument(s)
            GetDnsThreatDetectorRequest request = new GetDnsThreatDetectorRequest
            {
                DnsThreatDetectorName = DnsThreatDetectorName.FromProjectLocationDnsThreatDetector("[PROJECT]", "[LOCATION]", "[DNS_THREAT_DETECTOR]"),
            };
            // Make the request
            DnsThreatDetector response = dnsThreatDetectorServiceClient.GetDnsThreatDetector(request);
            // End snippet
        }

        /// <summary>Snippet for GetDnsThreatDetectorAsync</summary>
        public async Task GetDnsThreatDetectorRequestObjectAsync()
        {
            // Snippet: GetDnsThreatDetectorAsync(GetDnsThreatDetectorRequest, CallSettings)
            // Additional: GetDnsThreatDetectorAsync(GetDnsThreatDetectorRequest, CancellationToken)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = await DnsThreatDetectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDnsThreatDetectorRequest request = new GetDnsThreatDetectorRequest
            {
                DnsThreatDetectorName = DnsThreatDetectorName.FromProjectLocationDnsThreatDetector("[PROJECT]", "[LOCATION]", "[DNS_THREAT_DETECTOR]"),
            };
            // Make the request
            DnsThreatDetector response = await dnsThreatDetectorServiceClient.GetDnsThreatDetectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDnsThreatDetector</summary>
        public void GetDnsThreatDetector()
        {
            // Snippet: GetDnsThreatDetector(string, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = DnsThreatDetectorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dnsThreatDetectors/[DNS_THREAT_DETECTOR]";
            // Make the request
            DnsThreatDetector response = dnsThreatDetectorServiceClient.GetDnsThreatDetector(name);
            // End snippet
        }

        /// <summary>Snippet for GetDnsThreatDetectorAsync</summary>
        public async Task GetDnsThreatDetectorAsync()
        {
            // Snippet: GetDnsThreatDetectorAsync(string, CallSettings)
            // Additional: GetDnsThreatDetectorAsync(string, CancellationToken)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = await DnsThreatDetectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dnsThreatDetectors/[DNS_THREAT_DETECTOR]";
            // Make the request
            DnsThreatDetector response = await dnsThreatDetectorServiceClient.GetDnsThreatDetectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDnsThreatDetector</summary>
        public void GetDnsThreatDetectorResourceNames()
        {
            // Snippet: GetDnsThreatDetector(DnsThreatDetectorName, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = DnsThreatDetectorServiceClient.Create();
            // Initialize request argument(s)
            DnsThreatDetectorName name = DnsThreatDetectorName.FromProjectLocationDnsThreatDetector("[PROJECT]", "[LOCATION]", "[DNS_THREAT_DETECTOR]");
            // Make the request
            DnsThreatDetector response = dnsThreatDetectorServiceClient.GetDnsThreatDetector(name);
            // End snippet
        }

        /// <summary>Snippet for GetDnsThreatDetectorAsync</summary>
        public async Task GetDnsThreatDetectorResourceNamesAsync()
        {
            // Snippet: GetDnsThreatDetectorAsync(DnsThreatDetectorName, CallSettings)
            // Additional: GetDnsThreatDetectorAsync(DnsThreatDetectorName, CancellationToken)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = await DnsThreatDetectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            DnsThreatDetectorName name = DnsThreatDetectorName.FromProjectLocationDnsThreatDetector("[PROJECT]", "[LOCATION]", "[DNS_THREAT_DETECTOR]");
            // Make the request
            DnsThreatDetector response = await dnsThreatDetectorServiceClient.GetDnsThreatDetectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDnsThreatDetector</summary>
        public void CreateDnsThreatDetectorRequestObject()
        {
            // Snippet: CreateDnsThreatDetector(CreateDnsThreatDetectorRequest, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = DnsThreatDetectorServiceClient.Create();
            // Initialize request argument(s)
            CreateDnsThreatDetectorRequest request = new CreateDnsThreatDetectorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DnsThreatDetectorId = "",
                DnsThreatDetector = new DnsThreatDetector(),
            };
            // Make the request
            DnsThreatDetector response = dnsThreatDetectorServiceClient.CreateDnsThreatDetector(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDnsThreatDetectorAsync</summary>
        public async Task CreateDnsThreatDetectorRequestObjectAsync()
        {
            // Snippet: CreateDnsThreatDetectorAsync(CreateDnsThreatDetectorRequest, CallSettings)
            // Additional: CreateDnsThreatDetectorAsync(CreateDnsThreatDetectorRequest, CancellationToken)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = await DnsThreatDetectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDnsThreatDetectorRequest request = new CreateDnsThreatDetectorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DnsThreatDetectorId = "",
                DnsThreatDetector = new DnsThreatDetector(),
            };
            // Make the request
            DnsThreatDetector response = await dnsThreatDetectorServiceClient.CreateDnsThreatDetectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDnsThreatDetector</summary>
        public void CreateDnsThreatDetector()
        {
            // Snippet: CreateDnsThreatDetector(string, DnsThreatDetector, string, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = DnsThreatDetectorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DnsThreatDetector dnsThreatDetector = new DnsThreatDetector();
            string dnsThreatDetectorId = "";
            // Make the request
            DnsThreatDetector response = dnsThreatDetectorServiceClient.CreateDnsThreatDetector(parent, dnsThreatDetector, dnsThreatDetectorId);
            // End snippet
        }

        /// <summary>Snippet for CreateDnsThreatDetectorAsync</summary>
        public async Task CreateDnsThreatDetectorAsync()
        {
            // Snippet: CreateDnsThreatDetectorAsync(string, DnsThreatDetector, string, CallSettings)
            // Additional: CreateDnsThreatDetectorAsync(string, DnsThreatDetector, string, CancellationToken)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = await DnsThreatDetectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DnsThreatDetector dnsThreatDetector = new DnsThreatDetector();
            string dnsThreatDetectorId = "";
            // Make the request
            DnsThreatDetector response = await dnsThreatDetectorServiceClient.CreateDnsThreatDetectorAsync(parent, dnsThreatDetector, dnsThreatDetectorId);
            // End snippet
        }

        /// <summary>Snippet for CreateDnsThreatDetector</summary>
        public void CreateDnsThreatDetectorResourceNames()
        {
            // Snippet: CreateDnsThreatDetector(LocationName, DnsThreatDetector, string, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = DnsThreatDetectorServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DnsThreatDetector dnsThreatDetector = new DnsThreatDetector();
            string dnsThreatDetectorId = "";
            // Make the request
            DnsThreatDetector response = dnsThreatDetectorServiceClient.CreateDnsThreatDetector(parent, dnsThreatDetector, dnsThreatDetectorId);
            // End snippet
        }

        /// <summary>Snippet for CreateDnsThreatDetectorAsync</summary>
        public async Task CreateDnsThreatDetectorResourceNamesAsync()
        {
            // Snippet: CreateDnsThreatDetectorAsync(LocationName, DnsThreatDetector, string, CallSettings)
            // Additional: CreateDnsThreatDetectorAsync(LocationName, DnsThreatDetector, string, CancellationToken)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = await DnsThreatDetectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DnsThreatDetector dnsThreatDetector = new DnsThreatDetector();
            string dnsThreatDetectorId = "";
            // Make the request
            DnsThreatDetector response = await dnsThreatDetectorServiceClient.CreateDnsThreatDetectorAsync(parent, dnsThreatDetector, dnsThreatDetectorId);
            // End snippet
        }

        /// <summary>Snippet for UpdateDnsThreatDetector</summary>
        public void UpdateDnsThreatDetectorRequestObject()
        {
            // Snippet: UpdateDnsThreatDetector(UpdateDnsThreatDetectorRequest, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = DnsThreatDetectorServiceClient.Create();
            // Initialize request argument(s)
            UpdateDnsThreatDetectorRequest request = new UpdateDnsThreatDetectorRequest
            {
                UpdateMask = new FieldMask(),
                DnsThreatDetector = new DnsThreatDetector(),
            };
            // Make the request
            DnsThreatDetector response = dnsThreatDetectorServiceClient.UpdateDnsThreatDetector(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDnsThreatDetectorAsync</summary>
        public async Task UpdateDnsThreatDetectorRequestObjectAsync()
        {
            // Snippet: UpdateDnsThreatDetectorAsync(UpdateDnsThreatDetectorRequest, CallSettings)
            // Additional: UpdateDnsThreatDetectorAsync(UpdateDnsThreatDetectorRequest, CancellationToken)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = await DnsThreatDetectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDnsThreatDetectorRequest request = new UpdateDnsThreatDetectorRequest
            {
                UpdateMask = new FieldMask(),
                DnsThreatDetector = new DnsThreatDetector(),
            };
            // Make the request
            DnsThreatDetector response = await dnsThreatDetectorServiceClient.UpdateDnsThreatDetectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDnsThreatDetector</summary>
        public void UpdateDnsThreatDetector()
        {
            // Snippet: UpdateDnsThreatDetector(DnsThreatDetector, FieldMask, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = DnsThreatDetectorServiceClient.Create();
            // Initialize request argument(s)
            DnsThreatDetector dnsThreatDetector = new DnsThreatDetector();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DnsThreatDetector response = dnsThreatDetectorServiceClient.UpdateDnsThreatDetector(dnsThreatDetector, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDnsThreatDetectorAsync</summary>
        public async Task UpdateDnsThreatDetectorAsync()
        {
            // Snippet: UpdateDnsThreatDetectorAsync(DnsThreatDetector, FieldMask, CallSettings)
            // Additional: UpdateDnsThreatDetectorAsync(DnsThreatDetector, FieldMask, CancellationToken)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = await DnsThreatDetectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            DnsThreatDetector dnsThreatDetector = new DnsThreatDetector();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DnsThreatDetector response = await dnsThreatDetectorServiceClient.UpdateDnsThreatDetectorAsync(dnsThreatDetector, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteDnsThreatDetector</summary>
        public void DeleteDnsThreatDetectorRequestObject()
        {
            // Snippet: DeleteDnsThreatDetector(DeleteDnsThreatDetectorRequest, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = DnsThreatDetectorServiceClient.Create();
            // Initialize request argument(s)
            DeleteDnsThreatDetectorRequest request = new DeleteDnsThreatDetectorRequest
            {
                DnsThreatDetectorName = DnsThreatDetectorName.FromProjectLocationDnsThreatDetector("[PROJECT]", "[LOCATION]", "[DNS_THREAT_DETECTOR]"),
            };
            // Make the request
            dnsThreatDetectorServiceClient.DeleteDnsThreatDetector(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDnsThreatDetectorAsync</summary>
        public async Task DeleteDnsThreatDetectorRequestObjectAsync()
        {
            // Snippet: DeleteDnsThreatDetectorAsync(DeleteDnsThreatDetectorRequest, CallSettings)
            // Additional: DeleteDnsThreatDetectorAsync(DeleteDnsThreatDetectorRequest, CancellationToken)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = await DnsThreatDetectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDnsThreatDetectorRequest request = new DeleteDnsThreatDetectorRequest
            {
                DnsThreatDetectorName = DnsThreatDetectorName.FromProjectLocationDnsThreatDetector("[PROJECT]", "[LOCATION]", "[DNS_THREAT_DETECTOR]"),
            };
            // Make the request
            await dnsThreatDetectorServiceClient.DeleteDnsThreatDetectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDnsThreatDetector</summary>
        public void DeleteDnsThreatDetector()
        {
            // Snippet: DeleteDnsThreatDetector(string, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = DnsThreatDetectorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dnsThreatDetectors/[DNS_THREAT_DETECTOR]";
            // Make the request
            dnsThreatDetectorServiceClient.DeleteDnsThreatDetector(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDnsThreatDetectorAsync</summary>
        public async Task DeleteDnsThreatDetectorAsync()
        {
            // Snippet: DeleteDnsThreatDetectorAsync(string, CallSettings)
            // Additional: DeleteDnsThreatDetectorAsync(string, CancellationToken)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = await DnsThreatDetectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dnsThreatDetectors/[DNS_THREAT_DETECTOR]";
            // Make the request
            await dnsThreatDetectorServiceClient.DeleteDnsThreatDetectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDnsThreatDetector</summary>
        public void DeleteDnsThreatDetectorResourceNames()
        {
            // Snippet: DeleteDnsThreatDetector(DnsThreatDetectorName, CallSettings)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = DnsThreatDetectorServiceClient.Create();
            // Initialize request argument(s)
            DnsThreatDetectorName name = DnsThreatDetectorName.FromProjectLocationDnsThreatDetector("[PROJECT]", "[LOCATION]", "[DNS_THREAT_DETECTOR]");
            // Make the request
            dnsThreatDetectorServiceClient.DeleteDnsThreatDetector(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDnsThreatDetectorAsync</summary>
        public async Task DeleteDnsThreatDetectorResourceNamesAsync()
        {
            // Snippet: DeleteDnsThreatDetectorAsync(DnsThreatDetectorName, CallSettings)
            // Additional: DeleteDnsThreatDetectorAsync(DnsThreatDetectorName, CancellationToken)
            // Create client
            DnsThreatDetectorServiceClient dnsThreatDetectorServiceClient = await DnsThreatDetectorServiceClient.CreateAsync();
            // Initialize request argument(s)
            DnsThreatDetectorName name = DnsThreatDetectorName.FromProjectLocationDnsThreatDetector("[PROJECT]", "[LOCATION]", "[DNS_THREAT_DETECTOR]");
            // Make the request
            await dnsThreatDetectorServiceClient.DeleteDnsThreatDetectorAsync(name);
            // End snippet
        }
    }
}
