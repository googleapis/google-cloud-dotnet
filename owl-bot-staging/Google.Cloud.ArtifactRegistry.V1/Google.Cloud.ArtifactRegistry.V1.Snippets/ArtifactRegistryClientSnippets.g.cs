// Copyright 2023 Google LLC
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

#pragma warning disable CS8981

namespace Google.Cloud.ArtifactRegistry.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcav = Google.Cloud.ArtifactRegistry.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedArtifactRegistryClientSnippets
    {
        /// <summary>Snippet for ListDockerImages</summary>
        public void ListDockerImagesRequestObject()
        {
            // Snippet: ListDockerImages(ListDockerImagesRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            ListDockerImagesRequest request = new ListDockerImagesRequest
            {
                Parent = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDockerImagesResponse, DockerImage> response = artifactRegistryClient.ListDockerImages(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DockerImage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDockerImagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DockerImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DockerImage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DockerImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDockerImagesAsync</summary>
        public async Task ListDockerImagesRequestObjectAsync()
        {
            // Snippet: ListDockerImagesAsync(ListDockerImagesRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListDockerImagesRequest request = new ListDockerImagesRequest
            {
                Parent = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDockerImagesResponse, DockerImage> response = artifactRegistryClient.ListDockerImagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DockerImage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDockerImagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DockerImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DockerImage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DockerImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDockerImages</summary>
        public void ListDockerImages()
        {
            // Snippet: ListDockerImages(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListDockerImagesResponse, DockerImage> response = artifactRegistryClient.ListDockerImages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DockerImage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDockerImagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DockerImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DockerImage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DockerImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDockerImagesAsync</summary>
        public async Task ListDockerImagesAsync()
        {
            // Snippet: ListDockerImagesAsync(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListDockerImagesResponse, DockerImage> response = artifactRegistryClient.ListDockerImagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DockerImage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDockerImagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DockerImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DockerImage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DockerImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDockerImage</summary>
        public void GetDockerImageRequestObject()
        {
            // Snippet: GetDockerImage(GetDockerImageRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            GetDockerImageRequest request = new GetDockerImageRequest
            {
                DockerImageName = DockerImageName.FromProjectLocationRepositoryDockerImage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[DOCKER_IMAGE]"),
            };
            // Make the request
            DockerImage response = artifactRegistryClient.GetDockerImage(request);
            // End snippet
        }

        /// <summary>Snippet for GetDockerImageAsync</summary>
        public async Task GetDockerImageRequestObjectAsync()
        {
            // Snippet: GetDockerImageAsync(GetDockerImageRequest, CallSettings)
            // Additional: GetDockerImageAsync(GetDockerImageRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetDockerImageRequest request = new GetDockerImageRequest
            {
                DockerImageName = DockerImageName.FromProjectLocationRepositoryDockerImage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[DOCKER_IMAGE]"),
            };
            // Make the request
            DockerImage response = await artifactRegistryClient.GetDockerImageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDockerImage</summary>
        public void GetDockerImage()
        {
            // Snippet: GetDockerImage(string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/dockerImages/[DOCKER_IMAGE]";
            // Make the request
            DockerImage response = artifactRegistryClient.GetDockerImage(name);
            // End snippet
        }

        /// <summary>Snippet for GetDockerImageAsync</summary>
        public async Task GetDockerImageAsync()
        {
            // Snippet: GetDockerImageAsync(string, CallSettings)
            // Additional: GetDockerImageAsync(string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/dockerImages/[DOCKER_IMAGE]";
            // Make the request
            DockerImage response = await artifactRegistryClient.GetDockerImageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDockerImage</summary>
        public void GetDockerImageResourceNames()
        {
            // Snippet: GetDockerImage(DockerImageName, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            DockerImageName name = DockerImageName.FromProjectLocationRepositoryDockerImage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[DOCKER_IMAGE]");
            // Make the request
            DockerImage response = artifactRegistryClient.GetDockerImage(name);
            // End snippet
        }

        /// <summary>Snippet for GetDockerImageAsync</summary>
        public async Task GetDockerImageResourceNamesAsync()
        {
            // Snippet: GetDockerImageAsync(DockerImageName, CallSettings)
            // Additional: GetDockerImageAsync(DockerImageName, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            DockerImageName name = DockerImageName.FromProjectLocationRepositoryDockerImage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[DOCKER_IMAGE]");
            // Make the request
            DockerImage response = await artifactRegistryClient.GetDockerImageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMavenArtifacts</summary>
        public void ListMavenArtifactsRequestObject()
        {
            // Snippet: ListMavenArtifacts(ListMavenArtifactsRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            ListMavenArtifactsRequest request = new ListMavenArtifactsRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedEnumerable<ListMavenArtifactsResponse, MavenArtifact> response = artifactRegistryClient.ListMavenArtifacts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MavenArtifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMavenArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MavenArtifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MavenArtifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MavenArtifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMavenArtifactsAsync</summary>
        public async Task ListMavenArtifactsRequestObjectAsync()
        {
            // Snippet: ListMavenArtifactsAsync(ListMavenArtifactsRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListMavenArtifactsRequest request = new ListMavenArtifactsRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListMavenArtifactsResponse, MavenArtifact> response = artifactRegistryClient.ListMavenArtifactsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MavenArtifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMavenArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MavenArtifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MavenArtifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MavenArtifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMavenArtifacts</summary>
        public void ListMavenArtifacts()
        {
            // Snippet: ListMavenArtifacts(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<ListMavenArtifactsResponse, MavenArtifact> response = artifactRegistryClient.ListMavenArtifacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MavenArtifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMavenArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MavenArtifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MavenArtifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MavenArtifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMavenArtifactsAsync</summary>
        public async Task ListMavenArtifactsAsync()
        {
            // Snippet: ListMavenArtifactsAsync(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<ListMavenArtifactsResponse, MavenArtifact> response = artifactRegistryClient.ListMavenArtifactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MavenArtifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMavenArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MavenArtifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MavenArtifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MavenArtifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMavenArtifacts</summary>
        public void ListMavenArtifactsResourceNames()
        {
            // Snippet: ListMavenArtifacts(RepositoryName, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<ListMavenArtifactsResponse, MavenArtifact> response = artifactRegistryClient.ListMavenArtifacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MavenArtifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMavenArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MavenArtifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MavenArtifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MavenArtifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMavenArtifactsAsync</summary>
        public async Task ListMavenArtifactsResourceNamesAsync()
        {
            // Snippet: ListMavenArtifactsAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<ListMavenArtifactsResponse, MavenArtifact> response = artifactRegistryClient.ListMavenArtifactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MavenArtifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMavenArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MavenArtifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MavenArtifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MavenArtifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMavenArtifact</summary>
        public void GetMavenArtifactRequestObject()
        {
            // Snippet: GetMavenArtifact(GetMavenArtifactRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            GetMavenArtifactRequest request = new GetMavenArtifactRequest
            {
                MavenArtifactName = MavenArtifactName.FromProjectLocationRepositoryMavenArtifact("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[MAVEN_ARTIFACT]"),
            };
            // Make the request
            MavenArtifact response = artifactRegistryClient.GetMavenArtifact(request);
            // End snippet
        }

        /// <summary>Snippet for GetMavenArtifactAsync</summary>
        public async Task GetMavenArtifactRequestObjectAsync()
        {
            // Snippet: GetMavenArtifactAsync(GetMavenArtifactRequest, CallSettings)
            // Additional: GetMavenArtifactAsync(GetMavenArtifactRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetMavenArtifactRequest request = new GetMavenArtifactRequest
            {
                MavenArtifactName = MavenArtifactName.FromProjectLocationRepositoryMavenArtifact("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[MAVEN_ARTIFACT]"),
            };
            // Make the request
            MavenArtifact response = await artifactRegistryClient.GetMavenArtifactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMavenArtifact</summary>
        public void GetMavenArtifact()
        {
            // Snippet: GetMavenArtifact(string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/mavenArtifacts/[MAVEN_ARTIFACT]";
            // Make the request
            MavenArtifact response = artifactRegistryClient.GetMavenArtifact(name);
            // End snippet
        }

        /// <summary>Snippet for GetMavenArtifactAsync</summary>
        public async Task GetMavenArtifactAsync()
        {
            // Snippet: GetMavenArtifactAsync(string, CallSettings)
            // Additional: GetMavenArtifactAsync(string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/mavenArtifacts/[MAVEN_ARTIFACT]";
            // Make the request
            MavenArtifact response = await artifactRegistryClient.GetMavenArtifactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMavenArtifact</summary>
        public void GetMavenArtifactResourceNames()
        {
            // Snippet: GetMavenArtifact(MavenArtifactName, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            MavenArtifactName name = MavenArtifactName.FromProjectLocationRepositoryMavenArtifact("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[MAVEN_ARTIFACT]");
            // Make the request
            MavenArtifact response = artifactRegistryClient.GetMavenArtifact(name);
            // End snippet
        }

        /// <summary>Snippet for GetMavenArtifactAsync</summary>
        public async Task GetMavenArtifactResourceNamesAsync()
        {
            // Snippet: GetMavenArtifactAsync(MavenArtifactName, CallSettings)
            // Additional: GetMavenArtifactAsync(MavenArtifactName, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            MavenArtifactName name = MavenArtifactName.FromProjectLocationRepositoryMavenArtifact("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[MAVEN_ARTIFACT]");
            // Make the request
            MavenArtifact response = await artifactRegistryClient.GetMavenArtifactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListNpmPackages</summary>
        public void ListNpmPackagesRequestObject()
        {
            // Snippet: ListNpmPackages(ListNpmPackagesRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            ListNpmPackagesRequest request = new ListNpmPackagesRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedEnumerable<ListNpmPackagesResponse, NpmPackage> response = artifactRegistryClient.ListNpmPackages(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NpmPackage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNpmPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NpmPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NpmPackage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NpmPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNpmPackagesAsync</summary>
        public async Task ListNpmPackagesRequestObjectAsync()
        {
            // Snippet: ListNpmPackagesAsync(ListNpmPackagesRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListNpmPackagesRequest request = new ListNpmPackagesRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListNpmPackagesResponse, NpmPackage> response = artifactRegistryClient.ListNpmPackagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NpmPackage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNpmPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NpmPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NpmPackage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NpmPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNpmPackages</summary>
        public void ListNpmPackages()
        {
            // Snippet: ListNpmPackages(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<ListNpmPackagesResponse, NpmPackage> response = artifactRegistryClient.ListNpmPackages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NpmPackage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNpmPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NpmPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NpmPackage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NpmPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNpmPackagesAsync</summary>
        public async Task ListNpmPackagesAsync()
        {
            // Snippet: ListNpmPackagesAsync(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<ListNpmPackagesResponse, NpmPackage> response = artifactRegistryClient.ListNpmPackagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NpmPackage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNpmPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NpmPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NpmPackage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NpmPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNpmPackages</summary>
        public void ListNpmPackagesResourceNames()
        {
            // Snippet: ListNpmPackages(RepositoryName, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<ListNpmPackagesResponse, NpmPackage> response = artifactRegistryClient.ListNpmPackages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NpmPackage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNpmPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NpmPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NpmPackage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NpmPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNpmPackagesAsync</summary>
        public async Task ListNpmPackagesResourceNamesAsync()
        {
            // Snippet: ListNpmPackagesAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<ListNpmPackagesResponse, NpmPackage> response = artifactRegistryClient.ListNpmPackagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NpmPackage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNpmPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NpmPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NpmPackage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NpmPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetNpmPackage</summary>
        public void GetNpmPackageRequestObject()
        {
            // Snippet: GetNpmPackage(GetNpmPackageRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            GetNpmPackageRequest request = new GetNpmPackageRequest
            {
                NpmPackageName = NpmPackageName.FromProjectLocationRepositoryNpmPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[NPM_PACKAGE]"),
            };
            // Make the request
            NpmPackage response = artifactRegistryClient.GetNpmPackage(request);
            // End snippet
        }

        /// <summary>Snippet for GetNpmPackageAsync</summary>
        public async Task GetNpmPackageRequestObjectAsync()
        {
            // Snippet: GetNpmPackageAsync(GetNpmPackageRequest, CallSettings)
            // Additional: GetNpmPackageAsync(GetNpmPackageRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetNpmPackageRequest request = new GetNpmPackageRequest
            {
                NpmPackageName = NpmPackageName.FromProjectLocationRepositoryNpmPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[NPM_PACKAGE]"),
            };
            // Make the request
            NpmPackage response = await artifactRegistryClient.GetNpmPackageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNpmPackage</summary>
        public void GetNpmPackage()
        {
            // Snippet: GetNpmPackage(string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/npmPackages/[NPM_PACKAGE]";
            // Make the request
            NpmPackage response = artifactRegistryClient.GetNpmPackage(name);
            // End snippet
        }

        /// <summary>Snippet for GetNpmPackageAsync</summary>
        public async Task GetNpmPackageAsync()
        {
            // Snippet: GetNpmPackageAsync(string, CallSettings)
            // Additional: GetNpmPackageAsync(string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/npmPackages/[NPM_PACKAGE]";
            // Make the request
            NpmPackage response = await artifactRegistryClient.GetNpmPackageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNpmPackage</summary>
        public void GetNpmPackageResourceNames()
        {
            // Snippet: GetNpmPackage(NpmPackageName, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            NpmPackageName name = NpmPackageName.FromProjectLocationRepositoryNpmPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[NPM_PACKAGE]");
            // Make the request
            NpmPackage response = artifactRegistryClient.GetNpmPackage(name);
            // End snippet
        }

        /// <summary>Snippet for GetNpmPackageAsync</summary>
        public async Task GetNpmPackageResourceNamesAsync()
        {
            // Snippet: GetNpmPackageAsync(NpmPackageName, CallSettings)
            // Additional: GetNpmPackageAsync(NpmPackageName, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            NpmPackageName name = NpmPackageName.FromProjectLocationRepositoryNpmPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[NPM_PACKAGE]");
            // Make the request
            NpmPackage response = await artifactRegistryClient.GetNpmPackageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPythonPackages</summary>
        public void ListPythonPackagesRequestObject()
        {
            // Snippet: ListPythonPackages(ListPythonPackagesRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            ListPythonPackagesRequest request = new ListPythonPackagesRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedEnumerable<ListPythonPackagesResponse, PythonPackage> response = artifactRegistryClient.ListPythonPackages(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PythonPackage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPythonPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PythonPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PythonPackage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PythonPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPythonPackagesAsync</summary>
        public async Task ListPythonPackagesRequestObjectAsync()
        {
            // Snippet: ListPythonPackagesAsync(ListPythonPackagesRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListPythonPackagesRequest request = new ListPythonPackagesRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPythonPackagesResponse, PythonPackage> response = artifactRegistryClient.ListPythonPackagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PythonPackage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPythonPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PythonPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PythonPackage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PythonPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPythonPackages</summary>
        public void ListPythonPackages()
        {
            // Snippet: ListPythonPackages(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<ListPythonPackagesResponse, PythonPackage> response = artifactRegistryClient.ListPythonPackages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PythonPackage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPythonPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PythonPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PythonPackage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PythonPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPythonPackagesAsync</summary>
        public async Task ListPythonPackagesAsync()
        {
            // Snippet: ListPythonPackagesAsync(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<ListPythonPackagesResponse, PythonPackage> response = artifactRegistryClient.ListPythonPackagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PythonPackage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPythonPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PythonPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PythonPackage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PythonPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPythonPackages</summary>
        public void ListPythonPackagesResourceNames()
        {
            // Snippet: ListPythonPackages(RepositoryName, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<ListPythonPackagesResponse, PythonPackage> response = artifactRegistryClient.ListPythonPackages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PythonPackage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPythonPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PythonPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PythonPackage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PythonPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPythonPackagesAsync</summary>
        public async Task ListPythonPackagesResourceNamesAsync()
        {
            // Snippet: ListPythonPackagesAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<ListPythonPackagesResponse, PythonPackage> response = artifactRegistryClient.ListPythonPackagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PythonPackage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPythonPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PythonPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PythonPackage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PythonPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPythonPackage</summary>
        public void GetPythonPackageRequestObject()
        {
            // Snippet: GetPythonPackage(GetPythonPackageRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            GetPythonPackageRequest request = new GetPythonPackageRequest
            {
                PythonPackageName = PythonPackageName.FromProjectLocationRepositoryPythonPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PYTHON_PACKAGE]"),
            };
            // Make the request
            PythonPackage response = artifactRegistryClient.GetPythonPackage(request);
            // End snippet
        }

        /// <summary>Snippet for GetPythonPackageAsync</summary>
        public async Task GetPythonPackageRequestObjectAsync()
        {
            // Snippet: GetPythonPackageAsync(GetPythonPackageRequest, CallSettings)
            // Additional: GetPythonPackageAsync(GetPythonPackageRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetPythonPackageRequest request = new GetPythonPackageRequest
            {
                PythonPackageName = PythonPackageName.FromProjectLocationRepositoryPythonPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PYTHON_PACKAGE]"),
            };
            // Make the request
            PythonPackage response = await artifactRegistryClient.GetPythonPackageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPythonPackage</summary>
        public void GetPythonPackage()
        {
            // Snippet: GetPythonPackage(string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pythonPackages/[PYTHON_PACKAGE]";
            // Make the request
            PythonPackage response = artifactRegistryClient.GetPythonPackage(name);
            // End snippet
        }

        /// <summary>Snippet for GetPythonPackageAsync</summary>
        public async Task GetPythonPackageAsync()
        {
            // Snippet: GetPythonPackageAsync(string, CallSettings)
            // Additional: GetPythonPackageAsync(string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pythonPackages/[PYTHON_PACKAGE]";
            // Make the request
            PythonPackage response = await artifactRegistryClient.GetPythonPackageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPythonPackage</summary>
        public void GetPythonPackageResourceNames()
        {
            // Snippet: GetPythonPackage(PythonPackageName, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            PythonPackageName name = PythonPackageName.FromProjectLocationRepositoryPythonPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PYTHON_PACKAGE]");
            // Make the request
            PythonPackage response = artifactRegistryClient.GetPythonPackage(name);
            // End snippet
        }

        /// <summary>Snippet for GetPythonPackageAsync</summary>
        public async Task GetPythonPackageResourceNamesAsync()
        {
            // Snippet: GetPythonPackageAsync(PythonPackageName, CallSettings)
            // Additional: GetPythonPackageAsync(PythonPackageName, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            PythonPackageName name = PythonPackageName.FromProjectLocationRepositoryPythonPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PYTHON_PACKAGE]");
            // Make the request
            PythonPackage response = await artifactRegistryClient.GetPythonPackageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ImportAptArtifacts</summary>
        public void ImportAptArtifactsRequestObject()
        {
            // Snippet: ImportAptArtifacts(ImportAptArtifactsRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            ImportAptArtifactsRequest request = new ImportAptArtifactsRequest
            {
                Parent = "",
                GcsSource = new ImportAptArtifactsGcsSource(),
            };
            // Make the request
            Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata> response = artifactRegistryClient.ImportAptArtifacts(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportAptArtifactsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata> retrievedResponse = artifactRegistryClient.PollOnceImportAptArtifacts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportAptArtifactsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportAptArtifactsAsync</summary>
        public async Task ImportAptArtifactsRequestObjectAsync()
        {
            // Snippet: ImportAptArtifactsAsync(ImportAptArtifactsRequest, CallSettings)
            // Additional: ImportAptArtifactsAsync(ImportAptArtifactsRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ImportAptArtifactsRequest request = new ImportAptArtifactsRequest
            {
                Parent = "",
                GcsSource = new ImportAptArtifactsGcsSource(),
            };
            // Make the request
            Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata> response = await artifactRegistryClient.ImportAptArtifactsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportAptArtifactsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata> retrievedResponse = await artifactRegistryClient.PollOnceImportAptArtifactsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportAptArtifactsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportYumArtifacts</summary>
        public void ImportYumArtifactsRequestObject()
        {
            // Snippet: ImportYumArtifacts(ImportYumArtifactsRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            ImportYumArtifactsRequest request = new ImportYumArtifactsRequest
            {
                Parent = "",
                GcsSource = new ImportYumArtifactsGcsSource(),
            };
            // Make the request
            Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata> response = artifactRegistryClient.ImportYumArtifacts(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportYumArtifactsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata> retrievedResponse = artifactRegistryClient.PollOnceImportYumArtifacts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportYumArtifactsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportYumArtifactsAsync</summary>
        public async Task ImportYumArtifactsRequestObjectAsync()
        {
            // Snippet: ImportYumArtifactsAsync(ImportYumArtifactsRequest, CallSettings)
            // Additional: ImportYumArtifactsAsync(ImportYumArtifactsRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ImportYumArtifactsRequest request = new ImportYumArtifactsRequest
            {
                Parent = "",
                GcsSource = new ImportYumArtifactsGcsSource(),
            };
            // Make the request
            Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata> response = await artifactRegistryClient.ImportYumArtifactsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportYumArtifactsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata> retrievedResponse = await artifactRegistryClient.PollOnceImportYumArtifactsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportYumArtifactsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositoriesRequestObject()
        {
            // Snippet: ListRepositories(ListRepositoriesRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            ListRepositoriesRequest request = new ListRepositoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListRepositoriesResponse, Repository> response = artifactRegistryClient.ListRepositories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesRequestObjectAsync()
        {
            // Snippet: ListRepositoriesAsync(ListRepositoriesRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListRepositoriesRequest request = new ListRepositoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListRepositoriesResponse, Repository> response = artifactRegistryClient.ListRepositoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Repository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositories()
        {
            // Snippet: ListRepositories(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListRepositoriesResponse, Repository> response = artifactRegistryClient.ListRepositories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesAsync()
        {
            // Snippet: ListRepositoriesAsync(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListRepositoriesResponse, Repository> response = artifactRegistryClient.ListRepositoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Repository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositoriesResourceNames()
        {
            // Snippet: ListRepositories(LocationName, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListRepositoriesResponse, Repository> response = artifactRegistryClient.ListRepositories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesResourceNamesAsync()
        {
            // Snippet: ListRepositoriesAsync(LocationName, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListRepositoriesResponse, Repository> response = artifactRegistryClient.ListRepositoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Repository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepositoryRequestObject()
        {
            // Snippet: GetRepository(GetRepositoryRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            Repository response = artifactRegistryClient.GetRepository(request);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryRequestObjectAsync()
        {
            // Snippet: GetRepositoryAsync(GetRepositoryRequest, CallSettings)
            // Additional: GetRepositoryAsync(GetRepositoryRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            Repository response = await artifactRegistryClient.GetRepositoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepository()
        {
            // Snippet: GetRepository(string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            Repository response = artifactRegistryClient.GetRepository(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryAsync()
        {
            // Snippet: GetRepositoryAsync(string, CallSettings)
            // Additional: GetRepositoryAsync(string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            Repository response = await artifactRegistryClient.GetRepositoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepositoryResourceNames()
        {
            // Snippet: GetRepository(RepositoryName, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            RepositoryName name = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            Repository response = artifactRegistryClient.GetRepository(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryResourceNamesAsync()
        {
            // Snippet: GetRepositoryAsync(RepositoryName, CallSettings)
            // Additional: GetRepositoryAsync(RepositoryName, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName name = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            Repository response = await artifactRegistryClient.GetRepositoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepositoryRequestObject()
        {
            // Snippet: CreateRepository(CreateRepositoryRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            CreateRepositoryRequest request = new CreateRepositoryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                RepositoryId = "",
                Repository = new Repository(),
            };
            // Make the request
            Operation<Repository, OperationMetadata> response = artifactRegistryClient.CreateRepository(request);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceCreateRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryRequestObjectAsync()
        {
            // Snippet: CreateRepositoryAsync(CreateRepositoryRequest, CallSettings)
            // Additional: CreateRepositoryAsync(CreateRepositoryRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            CreateRepositoryRequest request = new CreateRepositoryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                RepositoryId = "",
                Repository = new Repository(),
            };
            // Make the request
            Operation<Repository, OperationMetadata> response = await artifactRegistryClient.CreateRepositoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceCreateRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepository()
        {
            // Snippet: CreateRepository(string, Repository, string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Repository repository = new Repository();
            string repositoryId = "";
            // Make the request
            Operation<Repository, OperationMetadata> response = artifactRegistryClient.CreateRepository(parent, repository, repositoryId);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceCreateRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryAsync()
        {
            // Snippet: CreateRepositoryAsync(string, Repository, string, CallSettings)
            // Additional: CreateRepositoryAsync(string, Repository, string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Repository repository = new Repository();
            string repositoryId = "";
            // Make the request
            Operation<Repository, OperationMetadata> response = await artifactRegistryClient.CreateRepositoryAsync(parent, repository, repositoryId);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceCreateRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepositoryResourceNames()
        {
            // Snippet: CreateRepository(LocationName, Repository, string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Repository repository = new Repository();
            string repositoryId = "";
            // Make the request
            Operation<Repository, OperationMetadata> response = artifactRegistryClient.CreateRepository(parent, repository, repositoryId);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceCreateRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryResourceNamesAsync()
        {
            // Snippet: CreateRepositoryAsync(LocationName, Repository, string, CallSettings)
            // Additional: CreateRepositoryAsync(LocationName, Repository, string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Repository repository = new Repository();
            string repositoryId = "";
            // Make the request
            Operation<Repository, OperationMetadata> response = await artifactRegistryClient.CreateRepositoryAsync(parent, repository, repositoryId);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceCreateRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRepository</summary>
        public void UpdateRepositoryRequestObject()
        {
            // Snippet: UpdateRepository(UpdateRepositoryRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            UpdateRepositoryRequest request = new UpdateRepositoryRequest
            {
                Repository = new Repository(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Repository response = artifactRegistryClient.UpdateRepository(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRepositoryAsync</summary>
        public async Task UpdateRepositoryRequestObjectAsync()
        {
            // Snippet: UpdateRepositoryAsync(UpdateRepositoryRequest, CallSettings)
            // Additional: UpdateRepositoryAsync(UpdateRepositoryRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRepositoryRequest request = new UpdateRepositoryRequest
            {
                Repository = new Repository(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Repository response = await artifactRegistryClient.UpdateRepositoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRepository</summary>
        public void UpdateRepository()
        {
            // Snippet: UpdateRepository(Repository, FieldMask, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            Repository repository = new Repository();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Repository response = artifactRegistryClient.UpdateRepository(repository, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateRepositoryAsync</summary>
        public async Task UpdateRepositoryAsync()
        {
            // Snippet: UpdateRepositoryAsync(Repository, FieldMask, CallSettings)
            // Additional: UpdateRepositoryAsync(Repository, FieldMask, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            Repository repository = new Repository();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Repository response = await artifactRegistryClient.UpdateRepositoryAsync(repository, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepositoryRequestObject()
        {
            // Snippet: DeleteRepository(DeleteRepositoryRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            DeleteRepositoryRequest request = new DeleteRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = artifactRegistryClient.DeleteRepository(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceDeleteRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryRequestObjectAsync()
        {
            // Snippet: DeleteRepositoryAsync(DeleteRepositoryRequest, CallSettings)
            // Additional: DeleteRepositoryAsync(DeleteRepositoryRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRepositoryRequest request = new DeleteRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await artifactRegistryClient.DeleteRepositoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceDeleteRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepository()
        {
            // Snippet: DeleteRepository(string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = artifactRegistryClient.DeleteRepository(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceDeleteRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryAsync()
        {
            // Snippet: DeleteRepositoryAsync(string, CallSettings)
            // Additional: DeleteRepositoryAsync(string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await artifactRegistryClient.DeleteRepositoryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceDeleteRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepositoryResourceNames()
        {
            // Snippet: DeleteRepository(RepositoryName, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            RepositoryName name = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = artifactRegistryClient.DeleteRepository(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceDeleteRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryResourceNamesAsync()
        {
            // Snippet: DeleteRepositoryAsync(RepositoryName, CallSettings)
            // Additional: DeleteRepositoryAsync(RepositoryName, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName name = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await artifactRegistryClient.DeleteRepositoryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceDeleteRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListPackages</summary>
        public void ListPackagesRequestObject()
        {
            // Snippet: ListPackages(ListPackagesRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            ListPackagesRequest request = new ListPackagesRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedEnumerable<ListPackagesResponse, Package> response = artifactRegistryClient.ListPackages(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Package item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Package item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Package> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Package item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPackagesAsync</summary>
        public async Task ListPackagesRequestObjectAsync()
        {
            // Snippet: ListPackagesAsync(ListPackagesRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListPackagesRequest request = new ListPackagesRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPackagesResponse, Package> response = artifactRegistryClient.ListPackagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Package item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Package item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Package> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Package item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPackages</summary>
        public void ListPackages()
        {
            // Snippet: ListPackages(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<ListPackagesResponse, Package> response = artifactRegistryClient.ListPackages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Package item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Package item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Package> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Package item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPackagesAsync</summary>
        public async Task ListPackagesAsync()
        {
            // Snippet: ListPackagesAsync(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<ListPackagesResponse, Package> response = artifactRegistryClient.ListPackagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Package item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Package item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Package> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Package item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPackages</summary>
        public void ListPackagesResourceNames()
        {
            // Snippet: ListPackages(RepositoryName, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<ListPackagesResponse, Package> response = artifactRegistryClient.ListPackages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Package item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Package item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Package> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Package item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPackagesAsync</summary>
        public async Task ListPackagesResourceNamesAsync()
        {
            // Snippet: ListPackagesAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<ListPackagesResponse, Package> response = artifactRegistryClient.ListPackagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Package item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Package item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Package> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Package item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPackage</summary>
        public void GetPackageRequestObject()
        {
            // Snippet: GetPackage(GetPackageRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            GetPackageRequest request = new GetPackageRequest
            {
                PackageName = PackageName.FromProjectLocationRepositoryPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PACKAGE]"),
            };
            // Make the request
            Package response = artifactRegistryClient.GetPackage(request);
            // End snippet
        }

        /// <summary>Snippet for GetPackageAsync</summary>
        public async Task GetPackageRequestObjectAsync()
        {
            // Snippet: GetPackageAsync(GetPackageRequest, CallSettings)
            // Additional: GetPackageAsync(GetPackageRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetPackageRequest request = new GetPackageRequest
            {
                PackageName = PackageName.FromProjectLocationRepositoryPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PACKAGE]"),
            };
            // Make the request
            Package response = await artifactRegistryClient.GetPackageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPackage</summary>
        public void GetPackage()
        {
            // Snippet: GetPackage(string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/packages/[PACKAGE]";
            // Make the request
            Package response = artifactRegistryClient.GetPackage(name);
            // End snippet
        }

        /// <summary>Snippet for GetPackageAsync</summary>
        public async Task GetPackageAsync()
        {
            // Snippet: GetPackageAsync(string, CallSettings)
            // Additional: GetPackageAsync(string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/packages/[PACKAGE]";
            // Make the request
            Package response = await artifactRegistryClient.GetPackageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPackage</summary>
        public void GetPackageResourceNames()
        {
            // Snippet: GetPackage(PackageName, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            PackageName name = PackageName.FromProjectLocationRepositoryPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PACKAGE]");
            // Make the request
            Package response = artifactRegistryClient.GetPackage(name);
            // End snippet
        }

        /// <summary>Snippet for GetPackageAsync</summary>
        public async Task GetPackageResourceNamesAsync()
        {
            // Snippet: GetPackageAsync(PackageName, CallSettings)
            // Additional: GetPackageAsync(PackageName, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            PackageName name = PackageName.FromProjectLocationRepositoryPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PACKAGE]");
            // Make the request
            Package response = await artifactRegistryClient.GetPackageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePackage</summary>
        public void DeletePackageRequestObject()
        {
            // Snippet: DeletePackage(DeletePackageRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            DeletePackageRequest request = new DeletePackageRequest
            {
                PackageName = PackageName.FromProjectLocationRepositoryPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PACKAGE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = artifactRegistryClient.DeletePackage(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceDeletePackage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePackageAsync</summary>
        public async Task DeletePackageRequestObjectAsync()
        {
            // Snippet: DeletePackageAsync(DeletePackageRequest, CallSettings)
            // Additional: DeletePackageAsync(DeletePackageRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeletePackageRequest request = new DeletePackageRequest
            {
                PackageName = PackageName.FromProjectLocationRepositoryPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PACKAGE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await artifactRegistryClient.DeletePackageAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceDeletePackageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePackage</summary>
        public void DeletePackage()
        {
            // Snippet: DeletePackage(string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/packages/[PACKAGE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = artifactRegistryClient.DeletePackage(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceDeletePackage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePackageAsync</summary>
        public async Task DeletePackageAsync()
        {
            // Snippet: DeletePackageAsync(string, CallSettings)
            // Additional: DeletePackageAsync(string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/packages/[PACKAGE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await artifactRegistryClient.DeletePackageAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceDeletePackageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePackage</summary>
        public void DeletePackageResourceNames()
        {
            // Snippet: DeletePackage(PackageName, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            PackageName name = PackageName.FromProjectLocationRepositoryPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PACKAGE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = artifactRegistryClient.DeletePackage(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceDeletePackage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePackageAsync</summary>
        public async Task DeletePackageResourceNamesAsync()
        {
            // Snippet: DeletePackageAsync(PackageName, CallSettings)
            // Additional: DeletePackageAsync(PackageName, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            PackageName name = PackageName.FromProjectLocationRepositoryPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PACKAGE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await artifactRegistryClient.DeletePackageAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceDeletePackageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListVersions</summary>
        public void ListVersionsRequestObject()
        {
            // Snippet: ListVersions(ListVersionsRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            ListVersionsRequest request = new ListVersionsRequest
            {
                Parent = "",
                View = VersionView.Unspecified,
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListVersionsResponse, gcav::Version> response = artifactRegistryClient.ListVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Version item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Version> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Version item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVersionsAsync</summary>
        public async Task ListVersionsRequestObjectAsync()
        {
            // Snippet: ListVersionsAsync(ListVersionsRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListVersionsRequest request = new ListVersionsRequest
            {
                Parent = "",
                View = VersionView.Unspecified,
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListVersionsResponse, gcav::Version> response = artifactRegistryClient.ListVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Version item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Version> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Version item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVersions</summary>
        public void ListVersions()
        {
            // Snippet: ListVersions(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListVersionsResponse, gcav::Version> response = artifactRegistryClient.ListVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Version item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Version> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Version item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVersionsAsync</summary>
        public async Task ListVersionsAsync()
        {
            // Snippet: ListVersionsAsync(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListVersionsResponse, gcav::Version> response = artifactRegistryClient.ListVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Version item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Version> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Version item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetVersion</summary>
        public void GetVersionRequestObject()
        {
            // Snippet: GetVersion(GetVersionRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            GetVersionRequest request = new GetVersionRequest
            {
                Name = "",
                View = VersionView.Unspecified,
            };
            // Make the request
            gcav::Version response = artifactRegistryClient.GetVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetVersionAsync</summary>
        public async Task GetVersionRequestObjectAsync()
        {
            // Snippet: GetVersionAsync(GetVersionRequest, CallSettings)
            // Additional: GetVersionAsync(GetVersionRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetVersionRequest request = new GetVersionRequest
            {
                Name = "",
                View = VersionView.Unspecified,
            };
            // Make the request
            gcav::Version response = await artifactRegistryClient.GetVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVersion</summary>
        public void GetVersion()
        {
            // Snippet: GetVersion(string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            gcav::Version response = artifactRegistryClient.GetVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetVersionAsync</summary>
        public async Task GetVersionAsync()
        {
            // Snippet: GetVersionAsync(string, CallSettings)
            // Additional: GetVersionAsync(string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            gcav::Version response = await artifactRegistryClient.GetVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteVersion</summary>
        public void DeleteVersionRequestObject()
        {
            // Snippet: DeleteVersion(DeleteVersionRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            DeleteVersionRequest request = new DeleteVersionRequest
            {
                Name = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = artifactRegistryClient.DeleteVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceDeleteVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVersionAsync</summary>
        public async Task DeleteVersionRequestObjectAsync()
        {
            // Snippet: DeleteVersionAsync(DeleteVersionRequest, CallSettings)
            // Additional: DeleteVersionAsync(DeleteVersionRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteVersionRequest request = new DeleteVersionRequest
            {
                Name = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await artifactRegistryClient.DeleteVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceDeleteVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVersion</summary>
        public void DeleteVersion()
        {
            // Snippet: DeleteVersion(string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, OperationMetadata> response = artifactRegistryClient.DeleteVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceDeleteVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVersionAsync</summary>
        public async Task DeleteVersionAsync()
        {
            // Snippet: DeleteVersionAsync(string, CallSettings)
            // Additional: DeleteVersionAsync(string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, OperationMetadata> response = await artifactRegistryClient.DeleteVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceDeleteVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListFiles</summary>
        public void ListFilesRequestObject()
        {
            // Snippet: ListFiles(ListFilesRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            ListFilesRequest request = new ListFilesRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListFilesResponse, File> response = artifactRegistryClient.ListFiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (File item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (File item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<File> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (File item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFilesAsync</summary>
        public async Task ListFilesRequestObjectAsync()
        {
            // Snippet: ListFilesAsync(ListFilesRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListFilesRequest request = new ListFilesRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFilesResponse, File> response = artifactRegistryClient.ListFilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((File item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (File item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<File> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (File item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFiles</summary>
        public void ListFiles()
        {
            // Snippet: ListFiles(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<ListFilesResponse, File> response = artifactRegistryClient.ListFiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (File item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (File item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<File> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (File item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFilesAsync</summary>
        public async Task ListFilesAsync()
        {
            // Snippet: ListFilesAsync(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<ListFilesResponse, File> response = artifactRegistryClient.ListFilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((File item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (File item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<File> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (File item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFiles</summary>
        public void ListFilesResourceNames()
        {
            // Snippet: ListFiles(RepositoryName, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<ListFilesResponse, File> response = artifactRegistryClient.ListFiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (File item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (File item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<File> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (File item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFilesAsync</summary>
        public async Task ListFilesResourceNamesAsync()
        {
            // Snippet: ListFilesAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<ListFilesResponse, File> response = artifactRegistryClient.ListFilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((File item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (File item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<File> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (File item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFile</summary>
        public void GetFileRequestObject()
        {
            // Snippet: GetFile(GetFileRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            GetFileRequest request = new GetFileRequest
            {
                FileName = FileName.FromProjectLocationRepositoryFile("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[FILE]"),
            };
            // Make the request
            File response = artifactRegistryClient.GetFile(request);
            // End snippet
        }

        /// <summary>Snippet for GetFileAsync</summary>
        public async Task GetFileRequestObjectAsync()
        {
            // Snippet: GetFileAsync(GetFileRequest, CallSettings)
            // Additional: GetFileAsync(GetFileRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetFileRequest request = new GetFileRequest
            {
                FileName = FileName.FromProjectLocationRepositoryFile("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[FILE]"),
            };
            // Make the request
            File response = await artifactRegistryClient.GetFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFile</summary>
        public void GetFile()
        {
            // Snippet: GetFile(string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/files/[FILE]";
            // Make the request
            File response = artifactRegistryClient.GetFile(name);
            // End snippet
        }

        /// <summary>Snippet for GetFileAsync</summary>
        public async Task GetFileAsync()
        {
            // Snippet: GetFileAsync(string, CallSettings)
            // Additional: GetFileAsync(string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/files/[FILE]";
            // Make the request
            File response = await artifactRegistryClient.GetFileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFile</summary>
        public void GetFileResourceNames()
        {
            // Snippet: GetFile(FileName, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            FileName name = FileName.FromProjectLocationRepositoryFile("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[FILE]");
            // Make the request
            File response = artifactRegistryClient.GetFile(name);
            // End snippet
        }

        /// <summary>Snippet for GetFileAsync</summary>
        public async Task GetFileResourceNamesAsync()
        {
            // Snippet: GetFileAsync(FileName, CallSettings)
            // Additional: GetFileAsync(FileName, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            FileName name = FileName.FromProjectLocationRepositoryFile("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[FILE]");
            // Make the request
            File response = await artifactRegistryClient.GetFileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTags</summary>
        public void ListTagsRequestObject()
        {
            // Snippet: ListTags(ListTagsRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            ListTagsRequest request = new ListTagsRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListTagsResponse, Tag> response = artifactRegistryClient.ListTags(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagsAsync</summary>
        public async Task ListTagsRequestObjectAsync()
        {
            // Snippet: ListTagsAsync(ListTagsRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListTagsRequest request = new ListTagsRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTagsResponse, Tag> response = artifactRegistryClient.ListTagsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Tag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTags</summary>
        public void ListTags()
        {
            // Snippet: ListTags(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListTagsResponse, Tag> response = artifactRegistryClient.ListTags(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagsAsync</summary>
        public async Task ListTagsAsync()
        {
            // Snippet: ListTagsAsync(string, string, int?, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListTagsResponse, Tag> response = artifactRegistryClient.ListTagsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Tag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTag</summary>
        public void GetTagRequestObject()
        {
            // Snippet: GetTag(GetTagRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            GetTagRequest request = new GetTagRequest { Name = "", };
            // Make the request
            Tag response = artifactRegistryClient.GetTag(request);
            // End snippet
        }

        /// <summary>Snippet for GetTagAsync</summary>
        public async Task GetTagRequestObjectAsync()
        {
            // Snippet: GetTagAsync(GetTagRequest, CallSettings)
            // Additional: GetTagAsync(GetTagRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetTagRequest request = new GetTagRequest { Name = "", };
            // Make the request
            Tag response = await artifactRegistryClient.GetTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTag</summary>
        public void GetTag()
        {
            // Snippet: GetTag(string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Tag response = artifactRegistryClient.GetTag(name);
            // End snippet
        }

        /// <summary>Snippet for GetTagAsync</summary>
        public async Task GetTagAsync()
        {
            // Snippet: GetTagAsync(string, CallSettings)
            // Additional: GetTagAsync(string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Tag response = await artifactRegistryClient.GetTagAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTag</summary>
        public void CreateTagRequestObject()
        {
            // Snippet: CreateTag(CreateTagRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            CreateTagRequest request = new CreateTagRequest
            {
                Parent = "",
                TagId = "",
                Tag = new Tag(),
            };
            // Make the request
            Tag response = artifactRegistryClient.CreateTag(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTagAsync</summary>
        public async Task CreateTagRequestObjectAsync()
        {
            // Snippet: CreateTagAsync(CreateTagRequest, CallSettings)
            // Additional: CreateTagAsync(CreateTagRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            CreateTagRequest request = new CreateTagRequest
            {
                Parent = "",
                TagId = "",
                Tag = new Tag(),
            };
            // Make the request
            Tag response = await artifactRegistryClient.CreateTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTag</summary>
        public void CreateTag()
        {
            // Snippet: CreateTag(string, Tag, string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "";
            Tag tag = new Tag();
            string tagId = "";
            // Make the request
            Tag response = artifactRegistryClient.CreateTag(parent, tag, tagId);
            // End snippet
        }

        /// <summary>Snippet for CreateTagAsync</summary>
        public async Task CreateTagAsync()
        {
            // Snippet: CreateTagAsync(string, Tag, string, CallSettings)
            // Additional: CreateTagAsync(string, Tag, string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            Tag tag = new Tag();
            string tagId = "";
            // Make the request
            Tag response = await artifactRegistryClient.CreateTagAsync(parent, tag, tagId);
            // End snippet
        }

        /// <summary>Snippet for UpdateTag</summary>
        public void UpdateTagRequestObject()
        {
            // Snippet: UpdateTag(UpdateTagRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            UpdateTagRequest request = new UpdateTagRequest
            {
                Tag = new Tag(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Tag response = artifactRegistryClient.UpdateTag(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagAsync</summary>
        public async Task UpdateTagRequestObjectAsync()
        {
            // Snippet: UpdateTagAsync(UpdateTagRequest, CallSettings)
            // Additional: UpdateTagAsync(UpdateTagRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTagRequest request = new UpdateTagRequest
            {
                Tag = new Tag(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Tag response = await artifactRegistryClient.UpdateTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTag</summary>
        public void UpdateTag()
        {
            // Snippet: UpdateTag(Tag, FieldMask, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            Tag tag = new Tag();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Tag response = artifactRegistryClient.UpdateTag(tag, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagAsync</summary>
        public async Task UpdateTagAsync()
        {
            // Snippet: UpdateTagAsync(Tag, FieldMask, CallSettings)
            // Additional: UpdateTagAsync(Tag, FieldMask, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            Tag tag = new Tag();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Tag response = await artifactRegistryClient.UpdateTagAsync(tag, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteTag</summary>
        public void DeleteTagRequestObject()
        {
            // Snippet: DeleteTag(DeleteTagRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            DeleteTagRequest request = new DeleteTagRequest { Name = "", };
            // Make the request
            artifactRegistryClient.DeleteTag(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagAsync</summary>
        public async Task DeleteTagRequestObjectAsync()
        {
            // Snippet: DeleteTagAsync(DeleteTagRequest, CallSettings)
            // Additional: DeleteTagAsync(DeleteTagRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTagRequest request = new DeleteTagRequest { Name = "", };
            // Make the request
            await artifactRegistryClient.DeleteTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTag</summary>
        public void DeleteTag()
        {
            // Snippet: DeleteTag(string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            artifactRegistryClient.DeleteTag(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagAsync</summary>
        public async Task DeleteTagAsync()
        {
            // Snippet: DeleteTagAsync(string, CallSettings)
            // Additional: DeleteTagAsync(string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            await artifactRegistryClient.DeleteTagAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = artifactRegistryClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await artifactRegistryClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = artifactRegistryClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await artifactRegistryClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = artifactRegistryClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await artifactRegistryClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProjectSettings</summary>
        public void GetProjectSettingsRequestObject()
        {
            // Snippet: GetProjectSettings(GetProjectSettingsRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            GetProjectSettingsRequest request = new GetProjectSettingsRequest
            {
                ProjectSettingsName = ProjectSettingsName.FromProject("[PROJECT]"),
            };
            // Make the request
            ProjectSettings response = artifactRegistryClient.GetProjectSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetProjectSettingsAsync</summary>
        public async Task GetProjectSettingsRequestObjectAsync()
        {
            // Snippet: GetProjectSettingsAsync(GetProjectSettingsRequest, CallSettings)
            // Additional: GetProjectSettingsAsync(GetProjectSettingsRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetProjectSettingsRequest request = new GetProjectSettingsRequest
            {
                ProjectSettingsName = ProjectSettingsName.FromProject("[PROJECT]"),
            };
            // Make the request
            ProjectSettings response = await artifactRegistryClient.GetProjectSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProjectSettings</summary>
        public void GetProjectSettings()
        {
            // Snippet: GetProjectSettings(string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/projectSettings";
            // Make the request
            ProjectSettings response = artifactRegistryClient.GetProjectSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectSettingsAsync</summary>
        public async Task GetProjectSettingsAsync()
        {
            // Snippet: GetProjectSettingsAsync(string, CallSettings)
            // Additional: GetProjectSettingsAsync(string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/projectSettings";
            // Make the request
            ProjectSettings response = await artifactRegistryClient.GetProjectSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectSettings</summary>
        public void GetProjectSettingsResourceNames()
        {
            // Snippet: GetProjectSettings(ProjectSettingsName, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            ProjectSettingsName name = ProjectSettingsName.FromProject("[PROJECT]");
            // Make the request
            ProjectSettings response = artifactRegistryClient.GetProjectSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectSettingsAsync</summary>
        public async Task GetProjectSettingsResourceNamesAsync()
        {
            // Snippet: GetProjectSettingsAsync(ProjectSettingsName, CallSettings)
            // Additional: GetProjectSettingsAsync(ProjectSettingsName, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ProjectSettingsName name = ProjectSettingsName.FromProject("[PROJECT]");
            // Make the request
            ProjectSettings response = await artifactRegistryClient.GetProjectSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectSettings</summary>
        public void UpdateProjectSettingsRequestObject()
        {
            // Snippet: UpdateProjectSettings(UpdateProjectSettingsRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            UpdateProjectSettingsRequest request = new UpdateProjectSettingsRequest
            {
                ProjectSettings = new ProjectSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ProjectSettings response = artifactRegistryClient.UpdateProjectSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectSettingsAsync</summary>
        public async Task UpdateProjectSettingsRequestObjectAsync()
        {
            // Snippet: UpdateProjectSettingsAsync(UpdateProjectSettingsRequest, CallSettings)
            // Additional: UpdateProjectSettingsAsync(UpdateProjectSettingsRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProjectSettingsRequest request = new UpdateProjectSettingsRequest
            {
                ProjectSettings = new ProjectSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ProjectSettings response = await artifactRegistryClient.UpdateProjectSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectSettings</summary>
        public void UpdateProjectSettings()
        {
            // Snippet: UpdateProjectSettings(ProjectSettings, FieldMask, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            ProjectSettings projectSettings = new ProjectSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ProjectSettings response = artifactRegistryClient.UpdateProjectSettings(projectSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectSettingsAsync</summary>
        public async Task UpdateProjectSettingsAsync()
        {
            // Snippet: UpdateProjectSettingsAsync(ProjectSettings, FieldMask, CallSettings)
            // Additional: UpdateProjectSettingsAsync(ProjectSettings, FieldMask, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ProjectSettings projectSettings = new ProjectSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ProjectSettings response = await artifactRegistryClient.UpdateProjectSettingsAsync(projectSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetVPCSCConfig</summary>
        public void GetVPCSCConfigRequestObject()
        {
            // Snippet: GetVPCSCConfig(GetVPCSCConfigRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            GetVPCSCConfigRequest request = new GetVPCSCConfigRequest
            {
                VpcscConfigName = VpcscConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            VPCSCConfig response = artifactRegistryClient.GetVPCSCConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetVPCSCConfigAsync</summary>
        public async Task GetVPCSCConfigRequestObjectAsync()
        {
            // Snippet: GetVPCSCConfigAsync(GetVPCSCConfigRequest, CallSettings)
            // Additional: GetVPCSCConfigAsync(GetVPCSCConfigRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetVPCSCConfigRequest request = new GetVPCSCConfigRequest
            {
                VpcscConfigName = VpcscConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            VPCSCConfig response = await artifactRegistryClient.GetVPCSCConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVPCSCConfig</summary>
        public void GetVPCSCConfig()
        {
            // Snippet: GetVPCSCConfig(string, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vpcscConfig";
            // Make the request
            VPCSCConfig response = artifactRegistryClient.GetVPCSCConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetVPCSCConfigAsync</summary>
        public async Task GetVPCSCConfigAsync()
        {
            // Snippet: GetVPCSCConfigAsync(string, CallSettings)
            // Additional: GetVPCSCConfigAsync(string, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vpcscConfig";
            // Make the request
            VPCSCConfig response = await artifactRegistryClient.GetVPCSCConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVPCSCConfig</summary>
        public void GetVPCSCConfigResourceNames()
        {
            // Snippet: GetVPCSCConfig(VpcscConfigName, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            VpcscConfigName name = VpcscConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            VPCSCConfig response = artifactRegistryClient.GetVPCSCConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetVPCSCConfigAsync</summary>
        public async Task GetVPCSCConfigResourceNamesAsync()
        {
            // Snippet: GetVPCSCConfigAsync(VpcscConfigName, CallSettings)
            // Additional: GetVPCSCConfigAsync(VpcscConfigName, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            VpcscConfigName name = VpcscConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            VPCSCConfig response = await artifactRegistryClient.GetVPCSCConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateVPCSCConfig</summary>
        public void UpdateVPCSCConfigRequestObject()
        {
            // Snippet: UpdateVPCSCConfig(UpdateVPCSCConfigRequest, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            UpdateVPCSCConfigRequest request = new UpdateVPCSCConfigRequest
            {
                VpcscConfig = new VPCSCConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            VPCSCConfig response = artifactRegistryClient.UpdateVPCSCConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateVPCSCConfigAsync</summary>
        public async Task UpdateVPCSCConfigRequestObjectAsync()
        {
            // Snippet: UpdateVPCSCConfigAsync(UpdateVPCSCConfigRequest, CallSettings)
            // Additional: UpdateVPCSCConfigAsync(UpdateVPCSCConfigRequest, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            UpdateVPCSCConfigRequest request = new UpdateVPCSCConfigRequest
            {
                VpcscConfig = new VPCSCConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            VPCSCConfig response = await artifactRegistryClient.UpdateVPCSCConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateVPCSCConfig</summary>
        public void UpdateVPCSCConfig()
        {
            // Snippet: UpdateVPCSCConfig(VPCSCConfig, FieldMask, CallSettings)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            VPCSCConfig vpcscConfig = new VPCSCConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            VPCSCConfig response = artifactRegistryClient.UpdateVPCSCConfig(vpcscConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateVPCSCConfigAsync</summary>
        public async Task UpdateVPCSCConfigAsync()
        {
            // Snippet: UpdateVPCSCConfigAsync(VPCSCConfig, FieldMask, CallSettings)
            // Additional: UpdateVPCSCConfigAsync(VPCSCConfig, FieldMask, CancellationToken)
            // Create client
            ArtifactRegistryClient artifactRegistryClient = await ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            VPCSCConfig vpcscConfig = new VPCSCConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            VPCSCConfig response = await artifactRegistryClient.UpdateVPCSCConfigAsync(vpcscConfig, updateMask);
            // End snippet
        }
    }
}
