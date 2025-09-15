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
    using Google.Cloud.GkeRecommender.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGkeInferenceQuickstartClientSnippets
    {
        /// <summary>Snippet for FetchModels</summary>
        public void FetchModelsRequestObject()
        {
            // Snippet: FetchModels(FetchModelsRequest, CallSettings)
            // Create client
            GkeInferenceQuickstartClient gkeInferenceQuickstartClient = GkeInferenceQuickstartClient.Create();
            // Initialize request argument(s)
            FetchModelsRequest request = new FetchModelsRequest { };
            // Make the request
            PagedEnumerable<FetchModelsResponse, string> response = gkeInferenceQuickstartClient.FetchModels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchModelsAsync</summary>
        public async Task FetchModelsRequestObjectAsync()
        {
            // Snippet: FetchModelsAsync(FetchModelsRequest, CallSettings)
            // Create client
            GkeInferenceQuickstartClient gkeInferenceQuickstartClient = await GkeInferenceQuickstartClient.CreateAsync();
            // Initialize request argument(s)
            FetchModelsRequest request = new FetchModelsRequest { };
            // Make the request
            PagedAsyncEnumerable<FetchModelsResponse, string> response = gkeInferenceQuickstartClient.FetchModelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchModelServers</summary>
        public void FetchModelServersRequestObject()
        {
            // Snippet: FetchModelServers(FetchModelServersRequest, CallSettings)
            // Create client
            GkeInferenceQuickstartClient gkeInferenceQuickstartClient = GkeInferenceQuickstartClient.Create();
            // Initialize request argument(s)
            FetchModelServersRequest request = new FetchModelServersRequest { Model = "", };
            // Make the request
            PagedEnumerable<FetchModelServersResponse, string> response = gkeInferenceQuickstartClient.FetchModelServers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchModelServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchModelServersAsync</summary>
        public async Task FetchModelServersRequestObjectAsync()
        {
            // Snippet: FetchModelServersAsync(FetchModelServersRequest, CallSettings)
            // Create client
            GkeInferenceQuickstartClient gkeInferenceQuickstartClient = await GkeInferenceQuickstartClient.CreateAsync();
            // Initialize request argument(s)
            FetchModelServersRequest request = new FetchModelServersRequest { Model = "", };
            // Make the request
            PagedAsyncEnumerable<FetchModelServersResponse, string> response = gkeInferenceQuickstartClient.FetchModelServersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchModelServersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchModelServerVersions</summary>
        public void FetchModelServerVersionsRequestObject()
        {
            // Snippet: FetchModelServerVersions(FetchModelServerVersionsRequest, CallSettings)
            // Create client
            GkeInferenceQuickstartClient gkeInferenceQuickstartClient = GkeInferenceQuickstartClient.Create();
            // Initialize request argument(s)
            FetchModelServerVersionsRequest request = new FetchModelServerVersionsRequest
            {
                Model = "",
                ModelServer = "",
            };
            // Make the request
            PagedEnumerable<FetchModelServerVersionsResponse, string> response = gkeInferenceQuickstartClient.FetchModelServerVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchModelServerVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchModelServerVersionsAsync</summary>
        public async Task FetchModelServerVersionsRequestObjectAsync()
        {
            // Snippet: FetchModelServerVersionsAsync(FetchModelServerVersionsRequest, CallSettings)
            // Create client
            GkeInferenceQuickstartClient gkeInferenceQuickstartClient = await GkeInferenceQuickstartClient.CreateAsync();
            // Initialize request argument(s)
            FetchModelServerVersionsRequest request = new FetchModelServerVersionsRequest
            {
                Model = "",
                ModelServer = "",
            };
            // Make the request
            PagedAsyncEnumerable<FetchModelServerVersionsResponse, string> response = gkeInferenceQuickstartClient.FetchModelServerVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchModelServerVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchProfiles</summary>
        public void FetchProfilesRequestObject()
        {
            // Snippet: FetchProfiles(FetchProfilesRequest, CallSettings)
            // Create client
            GkeInferenceQuickstartClient gkeInferenceQuickstartClient = GkeInferenceQuickstartClient.Create();
            // Initialize request argument(s)
            FetchProfilesRequest request = new FetchProfilesRequest
            {
                Model = "",
                ModelServer = "",
                ModelServerVersion = "",
                PerformanceRequirements = new PerformanceRequirements(),
            };
            // Make the request
            PagedEnumerable<FetchProfilesResponse, Profile> response = gkeInferenceQuickstartClient.FetchProfiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Profile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Profile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Profile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Profile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchProfilesAsync</summary>
        public async Task FetchProfilesRequestObjectAsync()
        {
            // Snippet: FetchProfilesAsync(FetchProfilesRequest, CallSettings)
            // Create client
            GkeInferenceQuickstartClient gkeInferenceQuickstartClient = await GkeInferenceQuickstartClient.CreateAsync();
            // Initialize request argument(s)
            FetchProfilesRequest request = new FetchProfilesRequest
            {
                Model = "",
                ModelServer = "",
                ModelServerVersion = "",
                PerformanceRequirements = new PerformanceRequirements(),
            };
            // Make the request
            PagedAsyncEnumerable<FetchProfilesResponse, Profile> response = gkeInferenceQuickstartClient.FetchProfilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Profile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Profile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Profile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Profile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GenerateOptimizedManifest</summary>
        public void GenerateOptimizedManifestRequestObject()
        {
            // Snippet: GenerateOptimizedManifest(GenerateOptimizedManifestRequest, CallSettings)
            // Create client
            GkeInferenceQuickstartClient gkeInferenceQuickstartClient = GkeInferenceQuickstartClient.Create();
            // Initialize request argument(s)
            GenerateOptimizedManifestRequest request = new GenerateOptimizedManifestRequest
            {
                ModelServerInfo = new ModelServerInfo(),
                AcceleratorType = "",
                KubernetesNamespace = "",
                PerformanceRequirements = new PerformanceRequirements(),
                StorageConfig = new StorageConfig(),
            };
            // Make the request
            GenerateOptimizedManifestResponse response = gkeInferenceQuickstartClient.GenerateOptimizedManifest(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateOptimizedManifestAsync</summary>
        public async Task GenerateOptimizedManifestRequestObjectAsync()
        {
            // Snippet: GenerateOptimizedManifestAsync(GenerateOptimizedManifestRequest, CallSettings)
            // Additional: GenerateOptimizedManifestAsync(GenerateOptimizedManifestRequest, CancellationToken)
            // Create client
            GkeInferenceQuickstartClient gkeInferenceQuickstartClient = await GkeInferenceQuickstartClient.CreateAsync();
            // Initialize request argument(s)
            GenerateOptimizedManifestRequest request = new GenerateOptimizedManifestRequest
            {
                ModelServerInfo = new ModelServerInfo(),
                AcceleratorType = "",
                KubernetesNamespace = "",
                PerformanceRequirements = new PerformanceRequirements(),
                StorageConfig = new StorageConfig(),
            };
            // Make the request
            GenerateOptimizedManifestResponse response = await gkeInferenceQuickstartClient.GenerateOptimizedManifestAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchBenchmarkingData</summary>
        public void FetchBenchmarkingDataRequestObject()
        {
            // Snippet: FetchBenchmarkingData(FetchBenchmarkingDataRequest, CallSettings)
            // Create client
            GkeInferenceQuickstartClient gkeInferenceQuickstartClient = GkeInferenceQuickstartClient.Create();
            // Initialize request argument(s)
            FetchBenchmarkingDataRequest request = new FetchBenchmarkingDataRequest
            {
                ModelServerInfo = new ModelServerInfo(),
                InstanceType = "",
                PricingModel = "",
            };
            // Make the request
            FetchBenchmarkingDataResponse response = gkeInferenceQuickstartClient.FetchBenchmarkingData(request);
            // End snippet
        }

        /// <summary>Snippet for FetchBenchmarkingDataAsync</summary>
        public async Task FetchBenchmarkingDataRequestObjectAsync()
        {
            // Snippet: FetchBenchmarkingDataAsync(FetchBenchmarkingDataRequest, CallSettings)
            // Additional: FetchBenchmarkingDataAsync(FetchBenchmarkingDataRequest, CancellationToken)
            // Create client
            GkeInferenceQuickstartClient gkeInferenceQuickstartClient = await GkeInferenceQuickstartClient.CreateAsync();
            // Initialize request argument(s)
            FetchBenchmarkingDataRequest request = new FetchBenchmarkingDataRequest
            {
                ModelServerInfo = new ModelServerInfo(),
                InstanceType = "",
                PricingModel = "",
            };
            // Make the request
            FetchBenchmarkingDataResponse response = await gkeInferenceQuickstartClient.FetchBenchmarkingDataAsync(request);
            // End snippet
        }
    }
}
