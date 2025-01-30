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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcav = Google.Cloud.ApiHub.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedApiHubClientSnippets
    {
        /// <summary>Snippet for CreateApi</summary>
        public void CreateApiRequestObject()
        {
            // Snippet: CreateApi(CreateApiRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::CreateApiRequest request = new gcav::CreateApiRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ApiId = "",
                Api = new gcav::Api(),
            };
            // Make the request
            gcav::Api response = apiHubClient.CreateApi(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApiAsync</summary>
        public async Task CreateApiRequestObjectAsync()
        {
            // Snippet: CreateApiAsync(CreateApiRequest, CallSettings)
            // Additional: CreateApiAsync(CreateApiRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::CreateApiRequest request = new gcav::CreateApiRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ApiId = "",
                Api = new gcav::Api(),
            };
            // Make the request
            gcav::Api response = await apiHubClient.CreateApiAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApi</summary>
        public void CreateApi()
        {
            // Snippet: CreateApi(string, Api, string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcav::Api api = new gcav::Api();
            string apiId = "";
            // Make the request
            gcav::Api response = apiHubClient.CreateApi(parent, api, apiId);
            // End snippet
        }

        /// <summary>Snippet for CreateApiAsync</summary>
        public async Task CreateApiAsync()
        {
            // Snippet: CreateApiAsync(string, Api, string, CallSettings)
            // Additional: CreateApiAsync(string, Api, string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcav::Api api = new gcav::Api();
            string apiId = "";
            // Make the request
            gcav::Api response = await apiHubClient.CreateApiAsync(parent, api, apiId);
            // End snippet
        }

        /// <summary>Snippet for CreateApi</summary>
        public void CreateApiResourceNames()
        {
            // Snippet: CreateApi(LocationName, Api, string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcav::Api api = new gcav::Api();
            string apiId = "";
            // Make the request
            gcav::Api response = apiHubClient.CreateApi(parent, api, apiId);
            // End snippet
        }

        /// <summary>Snippet for CreateApiAsync</summary>
        public async Task CreateApiResourceNamesAsync()
        {
            // Snippet: CreateApiAsync(LocationName, Api, string, CallSettings)
            // Additional: CreateApiAsync(LocationName, Api, string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcav::Api api = new gcav::Api();
            string apiId = "";
            // Make the request
            gcav::Api response = await apiHubClient.CreateApiAsync(parent, api, apiId);
            // End snippet
        }

        /// <summary>Snippet for GetApi</summary>
        public void GetApiRequestObject()
        {
            // Snippet: GetApi(GetApiRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::GetApiRequest request = new gcav::GetApiRequest
            {
                ApiName = gcav::ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            // Make the request
            gcav::Api response = apiHubClient.GetApi(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiAsync</summary>
        public async Task GetApiRequestObjectAsync()
        {
            // Snippet: GetApiAsync(GetApiRequest, CallSettings)
            // Additional: GetApiAsync(GetApiRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetApiRequest request = new gcav::GetApiRequest
            {
                ApiName = gcav::ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            // Make the request
            gcav::Api response = await apiHubClient.GetApiAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApi</summary>
        public void GetApi()
        {
            // Snippet: GetApi(string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            // Make the request
            gcav::Api response = apiHubClient.GetApi(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiAsync</summary>
        public async Task GetApiAsync()
        {
            // Snippet: GetApiAsync(string, CallSettings)
            // Additional: GetApiAsync(string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            // Make the request
            gcav::Api response = await apiHubClient.GetApiAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApi</summary>
        public void GetApiResourceNames()
        {
            // Snippet: GetApi(ApiName, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::ApiName name = gcav::ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            // Make the request
            gcav::Api response = apiHubClient.GetApi(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiAsync</summary>
        public async Task GetApiResourceNamesAsync()
        {
            // Snippet: GetApiAsync(ApiName, CallSettings)
            // Additional: GetApiAsync(ApiName, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ApiName name = gcav::ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            // Make the request
            gcav::Api response = await apiHubClient.GetApiAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListApis</summary>
        public void ListApisRequestObject()
        {
            // Snippet: ListApis(ListApisRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::ListApisRequest request = new gcav::ListApisRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcav::ListApisResponse, gcav::Api> response = apiHubClient.ListApis(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Api item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListApisResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Api item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Api> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Api item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApisAsync</summary>
        public async Task ListApisRequestObjectAsync()
        {
            // Snippet: ListApisAsync(ListApisRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListApisRequest request = new gcav::ListApisRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListApisResponse, gcav::Api> response = apiHubClient.ListApisAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Api item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListApisResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Api item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Api> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Api item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApis</summary>
        public void ListApis()
        {
            // Snippet: ListApis(string, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcav::ListApisResponse, gcav::Api> response = apiHubClient.ListApis(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Api item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListApisResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Api item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Api> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Api item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApisAsync</summary>
        public async Task ListApisAsync()
        {
            // Snippet: ListApisAsync(string, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcav::ListApisResponse, gcav::Api> response = apiHubClient.ListApisAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Api item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListApisResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Api item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Api> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Api item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApis</summary>
        public void ListApisResourceNames()
        {
            // Snippet: ListApis(LocationName, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcav::ListApisResponse, gcav::Api> response = apiHubClient.ListApis(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Api item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListApisResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Api item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Api> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Api item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApisAsync</summary>
        public async Task ListApisResourceNamesAsync()
        {
            // Snippet: ListApisAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcav::ListApisResponse, gcav::Api> response = apiHubClient.ListApisAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Api item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListApisResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Api item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Api> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Api item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateApi</summary>
        public void UpdateApiRequestObject()
        {
            // Snippet: UpdateApi(UpdateApiRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::UpdateApiRequest request = new gcav::UpdateApiRequest
            {
                Api = new gcav::Api(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::Api response = apiHubClient.UpdateApi(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApiAsync</summary>
        public async Task UpdateApiRequestObjectAsync()
        {
            // Snippet: UpdateApiAsync(UpdateApiRequest, CallSettings)
            // Additional: UpdateApiAsync(UpdateApiRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::UpdateApiRequest request = new gcav::UpdateApiRequest
            {
                Api = new gcav::Api(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::Api response = await apiHubClient.UpdateApiAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApi</summary>
        public void UpdateApi()
        {
            // Snippet: UpdateApi(Api, FieldMask, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::Api api = new gcav::Api();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::Api response = apiHubClient.UpdateApi(api, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateApiAsync</summary>
        public async Task UpdateApiAsync()
        {
            // Snippet: UpdateApiAsync(Api, FieldMask, CallSettings)
            // Additional: UpdateApiAsync(Api, FieldMask, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::Api api = new gcav::Api();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::Api response = await apiHubClient.UpdateApiAsync(api, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteApi</summary>
        public void DeleteApiRequestObject()
        {
            // Snippet: DeleteApi(DeleteApiRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::DeleteApiRequest request = new gcav::DeleteApiRequest
            {
                ApiName = gcav::ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                Force = false,
            };
            // Make the request
            apiHubClient.DeleteApi(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiAsync</summary>
        public async Task DeleteApiRequestObjectAsync()
        {
            // Snippet: DeleteApiAsync(DeleteApiRequest, CallSettings)
            // Additional: DeleteApiAsync(DeleteApiRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::DeleteApiRequest request = new gcav::DeleteApiRequest
            {
                ApiName = gcav::ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                Force = false,
            };
            // Make the request
            await apiHubClient.DeleteApiAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApi</summary>
        public void DeleteApi()
        {
            // Snippet: DeleteApi(string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            // Make the request
            apiHubClient.DeleteApi(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiAsync</summary>
        public async Task DeleteApiAsync()
        {
            // Snippet: DeleteApiAsync(string, CallSettings)
            // Additional: DeleteApiAsync(string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            // Make the request
            await apiHubClient.DeleteApiAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApi</summary>
        public void DeleteApiResourceNames()
        {
            // Snippet: DeleteApi(ApiName, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::ApiName name = gcav::ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            // Make the request
            apiHubClient.DeleteApi(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiAsync</summary>
        public async Task DeleteApiResourceNamesAsync()
        {
            // Snippet: DeleteApiAsync(ApiName, CallSettings)
            // Additional: DeleteApiAsync(ApiName, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ApiName name = gcav::ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            // Make the request
            await apiHubClient.DeleteApiAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateVersion</summary>
        public void CreateVersionRequestObject()
        {
            // Snippet: CreateVersion(CreateVersionRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::CreateVersionRequest request = new gcav::CreateVersionRequest
            {
                ParentAsApiName = gcav::ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                VersionId = "",
                Version = new gcav::Version(),
            };
            // Make the request
            gcav::Version response = apiHubClient.CreateVersion(request);
            // End snippet
        }

        /// <summary>Snippet for CreateVersionAsync</summary>
        public async Task CreateVersionRequestObjectAsync()
        {
            // Snippet: CreateVersionAsync(CreateVersionRequest, CallSettings)
            // Additional: CreateVersionAsync(CreateVersionRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::CreateVersionRequest request = new gcav::CreateVersionRequest
            {
                ParentAsApiName = gcav::ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                VersionId = "",
                Version = new gcav::Version(),
            };
            // Make the request
            gcav::Version response = await apiHubClient.CreateVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateVersion</summary>
        public void CreateVersion()
        {
            // Snippet: CreateVersion(string, Version, string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            gcav::Version version = new gcav::Version();
            string versionId = "";
            // Make the request
            gcav::Version response = apiHubClient.CreateVersion(parent, version, versionId);
            // End snippet
        }

        /// <summary>Snippet for CreateVersionAsync</summary>
        public async Task CreateVersionAsync()
        {
            // Snippet: CreateVersionAsync(string, Version, string, CallSettings)
            // Additional: CreateVersionAsync(string, Version, string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            gcav::Version version = new gcav::Version();
            string versionId = "";
            // Make the request
            gcav::Version response = await apiHubClient.CreateVersionAsync(parent, version, versionId);
            // End snippet
        }

        /// <summary>Snippet for CreateVersion</summary>
        public void CreateVersionResourceNames()
        {
            // Snippet: CreateVersion(ApiName, Version, string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::ApiName parent = gcav::ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            gcav::Version version = new gcav::Version();
            string versionId = "";
            // Make the request
            gcav::Version response = apiHubClient.CreateVersion(parent, version, versionId);
            // End snippet
        }

        /// <summary>Snippet for CreateVersionAsync</summary>
        public async Task CreateVersionResourceNamesAsync()
        {
            // Snippet: CreateVersionAsync(ApiName, Version, string, CallSettings)
            // Additional: CreateVersionAsync(ApiName, Version, string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ApiName parent = gcav::ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            gcav::Version version = new gcav::Version();
            string versionId = "";
            // Make the request
            gcav::Version response = await apiHubClient.CreateVersionAsync(parent, version, versionId);
            // End snippet
        }

        /// <summary>Snippet for GetVersion</summary>
        public void GetVersionRequestObject()
        {
            // Snippet: GetVersion(GetVersionRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::GetVersionRequest request = new gcav::GetVersionRequest
            {
                VersionName = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            // Make the request
            gcav::Version response = apiHubClient.GetVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetVersionAsync</summary>
        public async Task GetVersionRequestObjectAsync()
        {
            // Snippet: GetVersionAsync(GetVersionRequest, CallSettings)
            // Additional: GetVersionAsync(GetVersionRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetVersionRequest request = new gcav::GetVersionRequest
            {
                VersionName = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            // Make the request
            gcav::Version response = await apiHubClient.GetVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVersion</summary>
        public void GetVersion()
        {
            // Snippet: GetVersion(string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            // Make the request
            gcav::Version response = apiHubClient.GetVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetVersionAsync</summary>
        public async Task GetVersionAsync()
        {
            // Snippet: GetVersionAsync(string, CallSettings)
            // Additional: GetVersionAsync(string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            // Make the request
            gcav::Version response = await apiHubClient.GetVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVersion</summary>
        public void GetVersionResourceNames()
        {
            // Snippet: GetVersion(VersionName, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::VersionName name = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            // Make the request
            gcav::Version response = apiHubClient.GetVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetVersionAsync</summary>
        public async Task GetVersionResourceNamesAsync()
        {
            // Snippet: GetVersionAsync(VersionName, CallSettings)
            // Additional: GetVersionAsync(VersionName, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::VersionName name = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            // Make the request
            gcav::Version response = await apiHubClient.GetVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListVersions</summary>
        public void ListVersionsRequestObject()
        {
            // Snippet: ListVersions(ListVersionsRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::ListVersionsRequest request = new gcav::ListVersionsRequest
            {
                ParentAsApiName = gcav::ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcav::ListVersionsResponse, gcav::Version> response = apiHubClient.ListVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Version item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListVersionsResponse page in response.AsRawResponses())
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
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListVersionsRequest request = new gcav::ListVersionsRequest
            {
                ParentAsApiName = gcav::ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListVersionsResponse, gcav::Version> response = apiHubClient.ListVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Version item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListVersionsResponse page) =>
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
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            // Make the request
            PagedEnumerable<gcav::ListVersionsResponse, gcav::Version> response = apiHubClient.ListVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Version item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListVersionsResponse page in response.AsRawResponses())
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
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            // Make the request
            PagedAsyncEnumerable<gcav::ListVersionsResponse, gcav::Version> response = apiHubClient.ListVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Version item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListVersionsResponse page) =>
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
        public void ListVersionsResourceNames()
        {
            // Snippet: ListVersions(ApiName, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::ApiName parent = gcav::ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            // Make the request
            PagedEnumerable<gcav::ListVersionsResponse, gcav::Version> response = apiHubClient.ListVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Version item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListVersionsResponse page in response.AsRawResponses())
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
        public async Task ListVersionsResourceNamesAsync()
        {
            // Snippet: ListVersionsAsync(ApiName, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ApiName parent = gcav::ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            // Make the request
            PagedAsyncEnumerable<gcav::ListVersionsResponse, gcav::Version> response = apiHubClient.ListVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Version item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListVersionsResponse page) =>
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

        /// <summary>Snippet for UpdateVersion</summary>
        public void UpdateVersionRequestObject()
        {
            // Snippet: UpdateVersion(UpdateVersionRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::UpdateVersionRequest request = new gcav::UpdateVersionRequest
            {
                Version = new gcav::Version(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::Version response = apiHubClient.UpdateVersion(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateVersionAsync</summary>
        public async Task UpdateVersionRequestObjectAsync()
        {
            // Snippet: UpdateVersionAsync(UpdateVersionRequest, CallSettings)
            // Additional: UpdateVersionAsync(UpdateVersionRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::UpdateVersionRequest request = new gcav::UpdateVersionRequest
            {
                Version = new gcav::Version(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::Version response = await apiHubClient.UpdateVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateVersion</summary>
        public void UpdateVersion()
        {
            // Snippet: UpdateVersion(Version, FieldMask, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::Version version = new gcav::Version();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::Version response = apiHubClient.UpdateVersion(version, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateVersionAsync</summary>
        public async Task UpdateVersionAsync()
        {
            // Snippet: UpdateVersionAsync(Version, FieldMask, CallSettings)
            // Additional: UpdateVersionAsync(Version, FieldMask, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::Version version = new gcav::Version();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::Version response = await apiHubClient.UpdateVersionAsync(version, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteVersion</summary>
        public void DeleteVersionRequestObject()
        {
            // Snippet: DeleteVersion(DeleteVersionRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::DeleteVersionRequest request = new gcav::DeleteVersionRequest
            {
                VersionName = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                Force = false,
            };
            // Make the request
            apiHubClient.DeleteVersion(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteVersionAsync</summary>
        public async Task DeleteVersionRequestObjectAsync()
        {
            // Snippet: DeleteVersionAsync(DeleteVersionRequest, CallSettings)
            // Additional: DeleteVersionAsync(DeleteVersionRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::DeleteVersionRequest request = new gcav::DeleteVersionRequest
            {
                VersionName = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                Force = false,
            };
            // Make the request
            await apiHubClient.DeleteVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteVersion</summary>
        public void DeleteVersion()
        {
            // Snippet: DeleteVersion(string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            // Make the request
            apiHubClient.DeleteVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteVersionAsync</summary>
        public async Task DeleteVersionAsync()
        {
            // Snippet: DeleteVersionAsync(string, CallSettings)
            // Additional: DeleteVersionAsync(string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            // Make the request
            await apiHubClient.DeleteVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteVersion</summary>
        public void DeleteVersionResourceNames()
        {
            // Snippet: DeleteVersion(VersionName, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::VersionName name = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            // Make the request
            apiHubClient.DeleteVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteVersionAsync</summary>
        public async Task DeleteVersionResourceNamesAsync()
        {
            // Snippet: DeleteVersionAsync(VersionName, CallSettings)
            // Additional: DeleteVersionAsync(VersionName, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::VersionName name = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            // Make the request
            await apiHubClient.DeleteVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSpec</summary>
        public void CreateSpecRequestObject()
        {
            // Snippet: CreateSpec(CreateSpecRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::CreateSpecRequest request = new gcav::CreateSpecRequest
            {
                ParentAsVersionName = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                SpecId = "",
                Spec = new gcav::Spec(),
            };
            // Make the request
            gcav::Spec response = apiHubClient.CreateSpec(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSpecAsync</summary>
        public async Task CreateSpecRequestObjectAsync()
        {
            // Snippet: CreateSpecAsync(CreateSpecRequest, CallSettings)
            // Additional: CreateSpecAsync(CreateSpecRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::CreateSpecRequest request = new gcav::CreateSpecRequest
            {
                ParentAsVersionName = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                SpecId = "",
                Spec = new gcav::Spec(),
            };
            // Make the request
            gcav::Spec response = await apiHubClient.CreateSpecAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSpec</summary>
        public void CreateSpec()
        {
            // Snippet: CreateSpec(string, Spec, string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            gcav::Spec spec = new gcav::Spec();
            string specId = "";
            // Make the request
            gcav::Spec response = apiHubClient.CreateSpec(parent, spec, specId);
            // End snippet
        }

        /// <summary>Snippet for CreateSpecAsync</summary>
        public async Task CreateSpecAsync()
        {
            // Snippet: CreateSpecAsync(string, Spec, string, CallSettings)
            // Additional: CreateSpecAsync(string, Spec, string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            gcav::Spec spec = new gcav::Spec();
            string specId = "";
            // Make the request
            gcav::Spec response = await apiHubClient.CreateSpecAsync(parent, spec, specId);
            // End snippet
        }

        /// <summary>Snippet for CreateSpec</summary>
        public void CreateSpecResourceNames()
        {
            // Snippet: CreateSpec(VersionName, Spec, string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::VersionName parent = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            gcav::Spec spec = new gcav::Spec();
            string specId = "";
            // Make the request
            gcav::Spec response = apiHubClient.CreateSpec(parent, spec, specId);
            // End snippet
        }

        /// <summary>Snippet for CreateSpecAsync</summary>
        public async Task CreateSpecResourceNamesAsync()
        {
            // Snippet: CreateSpecAsync(VersionName, Spec, string, CallSettings)
            // Additional: CreateSpecAsync(VersionName, Spec, string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::VersionName parent = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            gcav::Spec spec = new gcav::Spec();
            string specId = "";
            // Make the request
            gcav::Spec response = await apiHubClient.CreateSpecAsync(parent, spec, specId);
            // End snippet
        }

        /// <summary>Snippet for GetSpec</summary>
        public void GetSpecRequestObject()
        {
            // Snippet: GetSpec(GetSpecRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::GetSpecRequest request = new gcav::GetSpecRequest
            {
                SpecName = gcav::SpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            // Make the request
            gcav::Spec response = apiHubClient.GetSpec(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpecAsync</summary>
        public async Task GetSpecRequestObjectAsync()
        {
            // Snippet: GetSpecAsync(GetSpecRequest, CallSettings)
            // Additional: GetSpecAsync(GetSpecRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetSpecRequest request = new gcav::GetSpecRequest
            {
                SpecName = gcav::SpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            // Make the request
            gcav::Spec response = await apiHubClient.GetSpecAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpec</summary>
        public void GetSpec()
        {
            // Snippet: GetSpec(string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/specs/[SPEC]";
            // Make the request
            gcav::Spec response = apiHubClient.GetSpec(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpecAsync</summary>
        public async Task GetSpecAsync()
        {
            // Snippet: GetSpecAsync(string, CallSettings)
            // Additional: GetSpecAsync(string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/specs/[SPEC]";
            // Make the request
            gcav::Spec response = await apiHubClient.GetSpecAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpec</summary>
        public void GetSpecResourceNames()
        {
            // Snippet: GetSpec(SpecName, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::SpecName name = gcav::SpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            // Make the request
            gcav::Spec response = apiHubClient.GetSpec(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpecAsync</summary>
        public async Task GetSpecResourceNamesAsync()
        {
            // Snippet: GetSpecAsync(SpecName, CallSettings)
            // Additional: GetSpecAsync(SpecName, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::SpecName name = gcav::SpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            // Make the request
            gcav::Spec response = await apiHubClient.GetSpecAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpecContents</summary>
        public void GetSpecContentsRequestObject()
        {
            // Snippet: GetSpecContents(GetSpecContentsRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::GetSpecContentsRequest request = new gcav::GetSpecContentsRequest
            {
                SpecName = gcav::SpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            // Make the request
            gcav::SpecContents response = apiHubClient.GetSpecContents(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpecContentsAsync</summary>
        public async Task GetSpecContentsRequestObjectAsync()
        {
            // Snippet: GetSpecContentsAsync(GetSpecContentsRequest, CallSettings)
            // Additional: GetSpecContentsAsync(GetSpecContentsRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetSpecContentsRequest request = new gcav::GetSpecContentsRequest
            {
                SpecName = gcav::SpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            // Make the request
            gcav::SpecContents response = await apiHubClient.GetSpecContentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpecContents</summary>
        public void GetSpecContents()
        {
            // Snippet: GetSpecContents(string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/specs/[SPEC]";
            // Make the request
            gcav::SpecContents response = apiHubClient.GetSpecContents(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpecContentsAsync</summary>
        public async Task GetSpecContentsAsync()
        {
            // Snippet: GetSpecContentsAsync(string, CallSettings)
            // Additional: GetSpecContentsAsync(string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/specs/[SPEC]";
            // Make the request
            gcav::SpecContents response = await apiHubClient.GetSpecContentsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpecContents</summary>
        public void GetSpecContentsResourceNames()
        {
            // Snippet: GetSpecContents(SpecName, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::SpecName name = gcav::SpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            // Make the request
            gcav::SpecContents response = apiHubClient.GetSpecContents(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpecContentsAsync</summary>
        public async Task GetSpecContentsResourceNamesAsync()
        {
            // Snippet: GetSpecContentsAsync(SpecName, CallSettings)
            // Additional: GetSpecContentsAsync(SpecName, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::SpecName name = gcav::SpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            // Make the request
            gcav::SpecContents response = await apiHubClient.GetSpecContentsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSpecs</summary>
        public void ListSpecsRequestObject()
        {
            // Snippet: ListSpecs(ListSpecsRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::ListSpecsRequest request = new gcav::ListSpecsRequest
            {
                ParentAsVersionName = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcav::ListSpecsResponse, gcav::Spec> response = apiHubClient.ListSpecs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Spec item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListSpecsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Spec item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Spec> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Spec item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpecsAsync</summary>
        public async Task ListSpecsRequestObjectAsync()
        {
            // Snippet: ListSpecsAsync(ListSpecsRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListSpecsRequest request = new gcav::ListSpecsRequest
            {
                ParentAsVersionName = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListSpecsResponse, gcav::Spec> response = apiHubClient.ListSpecsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Spec item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListSpecsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Spec item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Spec> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Spec item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpecs</summary>
        public void ListSpecs()
        {
            // Snippet: ListSpecs(string, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            // Make the request
            PagedEnumerable<gcav::ListSpecsResponse, gcav::Spec> response = apiHubClient.ListSpecs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Spec item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListSpecsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Spec item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Spec> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Spec item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpecsAsync</summary>
        public async Task ListSpecsAsync()
        {
            // Snippet: ListSpecsAsync(string, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            // Make the request
            PagedAsyncEnumerable<gcav::ListSpecsResponse, gcav::Spec> response = apiHubClient.ListSpecsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Spec item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListSpecsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Spec item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Spec> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Spec item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpecs</summary>
        public void ListSpecsResourceNames()
        {
            // Snippet: ListSpecs(VersionName, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::VersionName parent = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            // Make the request
            PagedEnumerable<gcav::ListSpecsResponse, gcav::Spec> response = apiHubClient.ListSpecs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Spec item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListSpecsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Spec item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Spec> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Spec item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpecsAsync</summary>
        public async Task ListSpecsResourceNamesAsync()
        {
            // Snippet: ListSpecsAsync(VersionName, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::VersionName parent = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            // Make the request
            PagedAsyncEnumerable<gcav::ListSpecsResponse, gcav::Spec> response = apiHubClient.ListSpecsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Spec item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListSpecsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Spec item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Spec> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Spec item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateSpec</summary>
        public void UpdateSpecRequestObject()
        {
            // Snippet: UpdateSpec(UpdateSpecRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::UpdateSpecRequest request = new gcav::UpdateSpecRequest
            {
                Spec = new gcav::Spec(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::Spec response = apiHubClient.UpdateSpec(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpecAsync</summary>
        public async Task UpdateSpecRequestObjectAsync()
        {
            // Snippet: UpdateSpecAsync(UpdateSpecRequest, CallSettings)
            // Additional: UpdateSpecAsync(UpdateSpecRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::UpdateSpecRequest request = new gcav::UpdateSpecRequest
            {
                Spec = new gcav::Spec(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::Spec response = await apiHubClient.UpdateSpecAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpec</summary>
        public void UpdateSpec()
        {
            // Snippet: UpdateSpec(Spec, FieldMask, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::Spec spec = new gcav::Spec();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::Spec response = apiHubClient.UpdateSpec(spec, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpecAsync</summary>
        public async Task UpdateSpecAsync()
        {
            // Snippet: UpdateSpecAsync(Spec, FieldMask, CallSettings)
            // Additional: UpdateSpecAsync(Spec, FieldMask, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::Spec spec = new gcav::Spec();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::Spec response = await apiHubClient.UpdateSpecAsync(spec, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpec</summary>
        public void DeleteSpecRequestObject()
        {
            // Snippet: DeleteSpec(DeleteSpecRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::DeleteSpecRequest request = new gcav::DeleteSpecRequest
            {
                SpecName = gcav::SpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            // Make the request
            apiHubClient.DeleteSpec(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpecAsync</summary>
        public async Task DeleteSpecRequestObjectAsync()
        {
            // Snippet: DeleteSpecAsync(DeleteSpecRequest, CallSettings)
            // Additional: DeleteSpecAsync(DeleteSpecRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::DeleteSpecRequest request = new gcav::DeleteSpecRequest
            {
                SpecName = gcav::SpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            // Make the request
            await apiHubClient.DeleteSpecAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpec</summary>
        public void DeleteSpec()
        {
            // Snippet: DeleteSpec(string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/specs/[SPEC]";
            // Make the request
            apiHubClient.DeleteSpec(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpecAsync</summary>
        public async Task DeleteSpecAsync()
        {
            // Snippet: DeleteSpecAsync(string, CallSettings)
            // Additional: DeleteSpecAsync(string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/specs/[SPEC]";
            // Make the request
            await apiHubClient.DeleteSpecAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpec</summary>
        public void DeleteSpecResourceNames()
        {
            // Snippet: DeleteSpec(SpecName, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::SpecName name = gcav::SpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            // Make the request
            apiHubClient.DeleteSpec(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpecAsync</summary>
        public async Task DeleteSpecResourceNamesAsync()
        {
            // Snippet: DeleteSpecAsync(SpecName, CallSettings)
            // Additional: DeleteSpecAsync(SpecName, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::SpecName name = gcav::SpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            // Make the request
            await apiHubClient.DeleteSpecAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiOperation</summary>
        public void GetApiOperationRequestObject()
        {
            // Snippet: GetApiOperation(GetApiOperationRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::GetApiOperationRequest request = new gcav::GetApiOperationRequest
            {
                ApiOperationName = gcav::ApiOperationName.FromProjectLocationApiVersionOperation("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[OPERATION]"),
            };
            // Make the request
            gcav::ApiOperation response = apiHubClient.GetApiOperation(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiOperationAsync</summary>
        public async Task GetApiOperationRequestObjectAsync()
        {
            // Snippet: GetApiOperationAsync(GetApiOperationRequest, CallSettings)
            // Additional: GetApiOperationAsync(GetApiOperationRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetApiOperationRequest request = new gcav::GetApiOperationRequest
            {
                ApiOperationName = gcav::ApiOperationName.FromProjectLocationApiVersionOperation("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[OPERATION]"),
            };
            // Make the request
            gcav::ApiOperation response = await apiHubClient.GetApiOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiOperation</summary>
        public void GetApiOperation()
        {
            // Snippet: GetApiOperation(string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/operations/[OPERATION]";
            // Make the request
            gcav::ApiOperation response = apiHubClient.GetApiOperation(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiOperationAsync</summary>
        public async Task GetApiOperationAsync()
        {
            // Snippet: GetApiOperationAsync(string, CallSettings)
            // Additional: GetApiOperationAsync(string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/operations/[OPERATION]";
            // Make the request
            gcav::ApiOperation response = await apiHubClient.GetApiOperationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiOperation</summary>
        public void GetApiOperationResourceNames()
        {
            // Snippet: GetApiOperation(ApiOperationName, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::ApiOperationName name = gcav::ApiOperationName.FromProjectLocationApiVersionOperation("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[OPERATION]");
            // Make the request
            gcav::ApiOperation response = apiHubClient.GetApiOperation(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiOperationAsync</summary>
        public async Task GetApiOperationResourceNamesAsync()
        {
            // Snippet: GetApiOperationAsync(ApiOperationName, CallSettings)
            // Additional: GetApiOperationAsync(ApiOperationName, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ApiOperationName name = gcav::ApiOperationName.FromProjectLocationApiVersionOperation("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[OPERATION]");
            // Make the request
            gcav::ApiOperation response = await apiHubClient.GetApiOperationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListApiOperations</summary>
        public void ListApiOperationsRequestObject()
        {
            // Snippet: ListApiOperations(ListApiOperationsRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::ListApiOperationsRequest request = new gcav::ListApiOperationsRequest
            {
                ParentAsVersionName = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcav::ListApiOperationsResponse, gcav::ApiOperation> response = apiHubClient.ListApiOperations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::ApiOperation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListApiOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::ApiOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::ApiOperation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::ApiOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiOperationsAsync</summary>
        public async Task ListApiOperationsRequestObjectAsync()
        {
            // Snippet: ListApiOperationsAsync(ListApiOperationsRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListApiOperationsRequest request = new gcav::ListApiOperationsRequest
            {
                ParentAsVersionName = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListApiOperationsResponse, gcav::ApiOperation> response = apiHubClient.ListApiOperationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::ApiOperation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListApiOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::ApiOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::ApiOperation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::ApiOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiOperations</summary>
        public void ListApiOperations()
        {
            // Snippet: ListApiOperations(string, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            // Make the request
            PagedEnumerable<gcav::ListApiOperationsResponse, gcav::ApiOperation> response = apiHubClient.ListApiOperations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::ApiOperation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListApiOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::ApiOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::ApiOperation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::ApiOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiOperationsAsync</summary>
        public async Task ListApiOperationsAsync()
        {
            // Snippet: ListApiOperationsAsync(string, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            // Make the request
            PagedAsyncEnumerable<gcav::ListApiOperationsResponse, gcav::ApiOperation> response = apiHubClient.ListApiOperationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::ApiOperation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListApiOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::ApiOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::ApiOperation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::ApiOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiOperations</summary>
        public void ListApiOperationsResourceNames()
        {
            // Snippet: ListApiOperations(VersionName, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::VersionName parent = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            // Make the request
            PagedEnumerable<gcav::ListApiOperationsResponse, gcav::ApiOperation> response = apiHubClient.ListApiOperations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::ApiOperation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListApiOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::ApiOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::ApiOperation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::ApiOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiOperationsAsync</summary>
        public async Task ListApiOperationsResourceNamesAsync()
        {
            // Snippet: ListApiOperationsAsync(VersionName, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::VersionName parent = gcav::VersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            // Make the request
            PagedAsyncEnumerable<gcav::ListApiOperationsResponse, gcav::ApiOperation> response = apiHubClient.ListApiOperationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::ApiOperation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListApiOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::ApiOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::ApiOperation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::ApiOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDefinition</summary>
        public void GetDefinitionRequestObject()
        {
            // Snippet: GetDefinition(GetDefinitionRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::GetDefinitionRequest request = new gcav::GetDefinitionRequest
            {
                DefinitionName = gcav::DefinitionName.FromProjectLocationApiVersionDefinition("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[DEFINITION]"),
            };
            // Make the request
            gcav::Definition response = apiHubClient.GetDefinition(request);
            // End snippet
        }

        /// <summary>Snippet for GetDefinitionAsync</summary>
        public async Task GetDefinitionRequestObjectAsync()
        {
            // Snippet: GetDefinitionAsync(GetDefinitionRequest, CallSettings)
            // Additional: GetDefinitionAsync(GetDefinitionRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetDefinitionRequest request = new gcav::GetDefinitionRequest
            {
                DefinitionName = gcav::DefinitionName.FromProjectLocationApiVersionDefinition("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[DEFINITION]"),
            };
            // Make the request
            gcav::Definition response = await apiHubClient.GetDefinitionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDefinition</summary>
        public void GetDefinition()
        {
            // Snippet: GetDefinition(string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/definitions/[DEFINITION]";
            // Make the request
            gcav::Definition response = apiHubClient.GetDefinition(name);
            // End snippet
        }

        /// <summary>Snippet for GetDefinitionAsync</summary>
        public async Task GetDefinitionAsync()
        {
            // Snippet: GetDefinitionAsync(string, CallSettings)
            // Additional: GetDefinitionAsync(string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/definitions/[DEFINITION]";
            // Make the request
            gcav::Definition response = await apiHubClient.GetDefinitionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDefinition</summary>
        public void GetDefinitionResourceNames()
        {
            // Snippet: GetDefinition(DefinitionName, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::DefinitionName name = gcav::DefinitionName.FromProjectLocationApiVersionDefinition("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[DEFINITION]");
            // Make the request
            gcav::Definition response = apiHubClient.GetDefinition(name);
            // End snippet
        }

        /// <summary>Snippet for GetDefinitionAsync</summary>
        public async Task GetDefinitionResourceNamesAsync()
        {
            // Snippet: GetDefinitionAsync(DefinitionName, CallSettings)
            // Additional: GetDefinitionAsync(DefinitionName, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::DefinitionName name = gcav::DefinitionName.FromProjectLocationApiVersionDefinition("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[DEFINITION]");
            // Make the request
            gcav::Definition response = await apiHubClient.GetDefinitionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeploymentRequestObject()
        {
            // Snippet: CreateDeployment(CreateDeploymentRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::CreateDeploymentRequest request = new gcav::CreateDeploymentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeploymentId = "",
                Deployment = new gcav::Deployment(),
            };
            // Make the request
            gcav::Deployment response = apiHubClient.CreateDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeploymentRequestObjectAsync()
        {
            // Snippet: CreateDeploymentAsync(CreateDeploymentRequest, CallSettings)
            // Additional: CreateDeploymentAsync(CreateDeploymentRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::CreateDeploymentRequest request = new gcav::CreateDeploymentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeploymentId = "",
                Deployment = new gcav::Deployment(),
            };
            // Make the request
            gcav::Deployment response = await apiHubClient.CreateDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeployment()
        {
            // Snippet: CreateDeployment(string, Deployment, string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcav::Deployment deployment = new gcav::Deployment();
            string deploymentId = "";
            // Make the request
            gcav::Deployment response = apiHubClient.CreateDeployment(parent, deployment, deploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeploymentAsync()
        {
            // Snippet: CreateDeploymentAsync(string, Deployment, string, CallSettings)
            // Additional: CreateDeploymentAsync(string, Deployment, string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcav::Deployment deployment = new gcav::Deployment();
            string deploymentId = "";
            // Make the request
            gcav::Deployment response = await apiHubClient.CreateDeploymentAsync(parent, deployment, deploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeploymentResourceNames()
        {
            // Snippet: CreateDeployment(LocationName, Deployment, string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcav::Deployment deployment = new gcav::Deployment();
            string deploymentId = "";
            // Make the request
            gcav::Deployment response = apiHubClient.CreateDeployment(parent, deployment, deploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeploymentResourceNamesAsync()
        {
            // Snippet: CreateDeploymentAsync(LocationName, Deployment, string, CallSettings)
            // Additional: CreateDeploymentAsync(LocationName, Deployment, string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcav::Deployment deployment = new gcav::Deployment();
            string deploymentId = "";
            // Make the request
            gcav::Deployment response = await apiHubClient.CreateDeploymentAsync(parent, deployment, deploymentId);
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeploymentRequestObject()
        {
            // Snippet: GetDeployment(GetDeploymentRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::GetDeploymentRequest request = new gcav::GetDeploymentRequest
            {
                DeploymentName = gcav::DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            // Make the request
            gcav::Deployment response = apiHubClient.GetDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentRequestObjectAsync()
        {
            // Snippet: GetDeploymentAsync(GetDeploymentRequest, CallSettings)
            // Additional: GetDeploymentAsync(GetDeploymentRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetDeploymentRequest request = new gcav::GetDeploymentRequest
            {
                DeploymentName = gcav::DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            // Make the request
            gcav::Deployment response = await apiHubClient.GetDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeployment()
        {
            // Snippet: GetDeployment(string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            // Make the request
            gcav::Deployment response = apiHubClient.GetDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentAsync()
        {
            // Snippet: GetDeploymentAsync(string, CallSettings)
            // Additional: GetDeploymentAsync(string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            // Make the request
            gcav::Deployment response = await apiHubClient.GetDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeploymentResourceNames()
        {
            // Snippet: GetDeployment(DeploymentName, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::DeploymentName name = gcav::DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            gcav::Deployment response = apiHubClient.GetDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentResourceNamesAsync()
        {
            // Snippet: GetDeploymentAsync(DeploymentName, CallSettings)
            // Additional: GetDeploymentAsync(DeploymentName, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::DeploymentName name = gcav::DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            gcav::Deployment response = await apiHubClient.GetDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeployments</summary>
        public void ListDeploymentsRequestObject()
        {
            // Snippet: ListDeployments(ListDeploymentsRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::ListDeploymentsRequest request = new gcav::ListDeploymentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcav::ListDeploymentsResponse, gcav::Deployment> response = apiHubClient.ListDeployments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentsAsync</summary>
        public async Task ListDeploymentsRequestObjectAsync()
        {
            // Snippet: ListDeploymentsAsync(ListDeploymentsRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListDeploymentsRequest request = new gcav::ListDeploymentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListDeploymentsResponse, gcav::Deployment> response = apiHubClient.ListDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Deployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeployments</summary>
        public void ListDeployments()
        {
            // Snippet: ListDeployments(string, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcav::ListDeploymentsResponse, gcav::Deployment> response = apiHubClient.ListDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentsAsync</summary>
        public async Task ListDeploymentsAsync()
        {
            // Snippet: ListDeploymentsAsync(string, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcav::ListDeploymentsResponse, gcav::Deployment> response = apiHubClient.ListDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Deployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeployments</summary>
        public void ListDeploymentsResourceNames()
        {
            // Snippet: ListDeployments(LocationName, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcav::ListDeploymentsResponse, gcav::Deployment> response = apiHubClient.ListDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentsAsync</summary>
        public async Task ListDeploymentsResourceNamesAsync()
        {
            // Snippet: ListDeploymentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcav::ListDeploymentsResponse, gcav::Deployment> response = apiHubClient.ListDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Deployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateDeployment</summary>
        public void UpdateDeploymentRequestObject()
        {
            // Snippet: UpdateDeployment(UpdateDeploymentRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::UpdateDeploymentRequest request = new gcav::UpdateDeploymentRequest
            {
                Deployment = new gcav::Deployment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::Deployment response = apiHubClient.UpdateDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeploymentAsync</summary>
        public async Task UpdateDeploymentRequestObjectAsync()
        {
            // Snippet: UpdateDeploymentAsync(UpdateDeploymentRequest, CallSettings)
            // Additional: UpdateDeploymentAsync(UpdateDeploymentRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::UpdateDeploymentRequest request = new gcav::UpdateDeploymentRequest
            {
                Deployment = new gcav::Deployment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::Deployment response = await apiHubClient.UpdateDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeployment</summary>
        public void UpdateDeployment()
        {
            // Snippet: UpdateDeployment(Deployment, FieldMask, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::Deployment deployment = new gcav::Deployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::Deployment response = apiHubClient.UpdateDeployment(deployment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeploymentAsync</summary>
        public async Task UpdateDeploymentAsync()
        {
            // Snippet: UpdateDeploymentAsync(Deployment, FieldMask, CallSettings)
            // Additional: UpdateDeploymentAsync(Deployment, FieldMask, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::Deployment deployment = new gcav::Deployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::Deployment response = await apiHubClient.UpdateDeploymentAsync(deployment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployment</summary>
        public void DeleteDeploymentRequestObject()
        {
            // Snippet: DeleteDeployment(DeleteDeploymentRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::DeleteDeploymentRequest request = new gcav::DeleteDeploymentRequest
            {
                DeploymentName = gcav::DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            // Make the request
            apiHubClient.DeleteDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentAsync</summary>
        public async Task DeleteDeploymentRequestObjectAsync()
        {
            // Snippet: DeleteDeploymentAsync(DeleteDeploymentRequest, CallSettings)
            // Additional: DeleteDeploymentAsync(DeleteDeploymentRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::DeleteDeploymentRequest request = new gcav::DeleteDeploymentRequest
            {
                DeploymentName = gcav::DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            // Make the request
            await apiHubClient.DeleteDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployment</summary>
        public void DeleteDeployment()
        {
            // Snippet: DeleteDeployment(string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            // Make the request
            apiHubClient.DeleteDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentAsync</summary>
        public async Task DeleteDeploymentAsync()
        {
            // Snippet: DeleteDeploymentAsync(string, CallSettings)
            // Additional: DeleteDeploymentAsync(string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            // Make the request
            await apiHubClient.DeleteDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployment</summary>
        public void DeleteDeploymentResourceNames()
        {
            // Snippet: DeleteDeployment(DeploymentName, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::DeploymentName name = gcav::DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            apiHubClient.DeleteDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentAsync</summary>
        public async Task DeleteDeploymentResourceNamesAsync()
        {
            // Snippet: DeleteDeploymentAsync(DeploymentName, CallSettings)
            // Additional: DeleteDeploymentAsync(DeploymentName, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::DeploymentName name = gcav::DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            await apiHubClient.DeleteDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAttribute</summary>
        public void CreateAttributeRequestObject()
        {
            // Snippet: CreateAttribute(CreateAttributeRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::CreateAttributeRequest request = new gcav::CreateAttributeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AttributeId = "",
                Attribute = new gcav::Attribute(),
            };
            // Make the request
            gcav::Attribute response = apiHubClient.CreateAttribute(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAttributeAsync</summary>
        public async Task CreateAttributeRequestObjectAsync()
        {
            // Snippet: CreateAttributeAsync(CreateAttributeRequest, CallSettings)
            // Additional: CreateAttributeAsync(CreateAttributeRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::CreateAttributeRequest request = new gcav::CreateAttributeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AttributeId = "",
                Attribute = new gcav::Attribute(),
            };
            // Make the request
            gcav::Attribute response = await apiHubClient.CreateAttributeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAttribute</summary>
        public void CreateAttribute()
        {
            // Snippet: CreateAttribute(string, Attribute, string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcav::Attribute attribute = new gcav::Attribute();
            string attributeId = "";
            // Make the request
            gcav::Attribute response = apiHubClient.CreateAttribute(parent, attribute, attributeId);
            // End snippet
        }

        /// <summary>Snippet for CreateAttributeAsync</summary>
        public async Task CreateAttributeAsync()
        {
            // Snippet: CreateAttributeAsync(string, Attribute, string, CallSettings)
            // Additional: CreateAttributeAsync(string, Attribute, string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcav::Attribute attribute = new gcav::Attribute();
            string attributeId = "";
            // Make the request
            gcav::Attribute response = await apiHubClient.CreateAttributeAsync(parent, attribute, attributeId);
            // End snippet
        }

        /// <summary>Snippet for CreateAttribute</summary>
        public void CreateAttributeResourceNames()
        {
            // Snippet: CreateAttribute(LocationName, Attribute, string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcav::Attribute attribute = new gcav::Attribute();
            string attributeId = "";
            // Make the request
            gcav::Attribute response = apiHubClient.CreateAttribute(parent, attribute, attributeId);
            // End snippet
        }

        /// <summary>Snippet for CreateAttributeAsync</summary>
        public async Task CreateAttributeResourceNamesAsync()
        {
            // Snippet: CreateAttributeAsync(LocationName, Attribute, string, CallSettings)
            // Additional: CreateAttributeAsync(LocationName, Attribute, string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcav::Attribute attribute = new gcav::Attribute();
            string attributeId = "";
            // Make the request
            gcav::Attribute response = await apiHubClient.CreateAttributeAsync(parent, attribute, attributeId);
            // End snippet
        }

        /// <summary>Snippet for GetAttribute</summary>
        public void GetAttributeRequestObject()
        {
            // Snippet: GetAttribute(GetAttributeRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::GetAttributeRequest request = new gcav::GetAttributeRequest
            {
                AttributeName = gcav::AttributeName.FromProjectLocationAttribute("[PROJECT]", "[LOCATION]", "[ATTRIBUTE]"),
            };
            // Make the request
            gcav::Attribute response = apiHubClient.GetAttribute(request);
            // End snippet
        }

        /// <summary>Snippet for GetAttributeAsync</summary>
        public async Task GetAttributeRequestObjectAsync()
        {
            // Snippet: GetAttributeAsync(GetAttributeRequest, CallSettings)
            // Additional: GetAttributeAsync(GetAttributeRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetAttributeRequest request = new gcav::GetAttributeRequest
            {
                AttributeName = gcav::AttributeName.FromProjectLocationAttribute("[PROJECT]", "[LOCATION]", "[ATTRIBUTE]"),
            };
            // Make the request
            gcav::Attribute response = await apiHubClient.GetAttributeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAttribute</summary>
        public void GetAttribute()
        {
            // Snippet: GetAttribute(string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/attributes/[ATTRIBUTE]";
            // Make the request
            gcav::Attribute response = apiHubClient.GetAttribute(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttributeAsync</summary>
        public async Task GetAttributeAsync()
        {
            // Snippet: GetAttributeAsync(string, CallSettings)
            // Additional: GetAttributeAsync(string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/attributes/[ATTRIBUTE]";
            // Make the request
            gcav::Attribute response = await apiHubClient.GetAttributeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttribute</summary>
        public void GetAttributeResourceNames()
        {
            // Snippet: GetAttribute(AttributeName, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::AttributeName name = gcav::AttributeName.FromProjectLocationAttribute("[PROJECT]", "[LOCATION]", "[ATTRIBUTE]");
            // Make the request
            gcav::Attribute response = apiHubClient.GetAttribute(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttributeAsync</summary>
        public async Task GetAttributeResourceNamesAsync()
        {
            // Snippet: GetAttributeAsync(AttributeName, CallSettings)
            // Additional: GetAttributeAsync(AttributeName, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::AttributeName name = gcav::AttributeName.FromProjectLocationAttribute("[PROJECT]", "[LOCATION]", "[ATTRIBUTE]");
            // Make the request
            gcav::Attribute response = await apiHubClient.GetAttributeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAttribute</summary>
        public void UpdateAttributeRequestObject()
        {
            // Snippet: UpdateAttribute(UpdateAttributeRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::UpdateAttributeRequest request = new gcav::UpdateAttributeRequest
            {
                Attribute = new gcav::Attribute(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::Attribute response = apiHubClient.UpdateAttribute(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAttributeAsync</summary>
        public async Task UpdateAttributeRequestObjectAsync()
        {
            // Snippet: UpdateAttributeAsync(UpdateAttributeRequest, CallSettings)
            // Additional: UpdateAttributeAsync(UpdateAttributeRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::UpdateAttributeRequest request = new gcav::UpdateAttributeRequest
            {
                Attribute = new gcav::Attribute(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::Attribute response = await apiHubClient.UpdateAttributeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAttribute</summary>
        public void UpdateAttribute()
        {
            // Snippet: UpdateAttribute(Attribute, FieldMask, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::Attribute attribute = new gcav::Attribute();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::Attribute response = apiHubClient.UpdateAttribute(attribute, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAttributeAsync</summary>
        public async Task UpdateAttributeAsync()
        {
            // Snippet: UpdateAttributeAsync(Attribute, FieldMask, CallSettings)
            // Additional: UpdateAttributeAsync(Attribute, FieldMask, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::Attribute attribute = new gcav::Attribute();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::Attribute response = await apiHubClient.UpdateAttributeAsync(attribute, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteAttribute</summary>
        public void DeleteAttributeRequestObject()
        {
            // Snippet: DeleteAttribute(DeleteAttributeRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::DeleteAttributeRequest request = new gcav::DeleteAttributeRequest
            {
                AttributeName = gcav::AttributeName.FromProjectLocationAttribute("[PROJECT]", "[LOCATION]", "[ATTRIBUTE]"),
            };
            // Make the request
            apiHubClient.DeleteAttribute(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAttributeAsync</summary>
        public async Task DeleteAttributeRequestObjectAsync()
        {
            // Snippet: DeleteAttributeAsync(DeleteAttributeRequest, CallSettings)
            // Additional: DeleteAttributeAsync(DeleteAttributeRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::DeleteAttributeRequest request = new gcav::DeleteAttributeRequest
            {
                AttributeName = gcav::AttributeName.FromProjectLocationAttribute("[PROJECT]", "[LOCATION]", "[ATTRIBUTE]"),
            };
            // Make the request
            await apiHubClient.DeleteAttributeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAttribute</summary>
        public void DeleteAttribute()
        {
            // Snippet: DeleteAttribute(string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/attributes/[ATTRIBUTE]";
            // Make the request
            apiHubClient.DeleteAttribute(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAttributeAsync</summary>
        public async Task DeleteAttributeAsync()
        {
            // Snippet: DeleteAttributeAsync(string, CallSettings)
            // Additional: DeleteAttributeAsync(string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/attributes/[ATTRIBUTE]";
            // Make the request
            await apiHubClient.DeleteAttributeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAttribute</summary>
        public void DeleteAttributeResourceNames()
        {
            // Snippet: DeleteAttribute(AttributeName, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::AttributeName name = gcav::AttributeName.FromProjectLocationAttribute("[PROJECT]", "[LOCATION]", "[ATTRIBUTE]");
            // Make the request
            apiHubClient.DeleteAttribute(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAttributeAsync</summary>
        public async Task DeleteAttributeResourceNamesAsync()
        {
            // Snippet: DeleteAttributeAsync(AttributeName, CallSettings)
            // Additional: DeleteAttributeAsync(AttributeName, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::AttributeName name = gcav::AttributeName.FromProjectLocationAttribute("[PROJECT]", "[LOCATION]", "[ATTRIBUTE]");
            // Make the request
            await apiHubClient.DeleteAttributeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAttributes</summary>
        public void ListAttributesRequestObject()
        {
            // Snippet: ListAttributes(ListAttributesRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::ListAttributesRequest request = new gcav::ListAttributesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcav::ListAttributesResponse, gcav::Attribute> response = apiHubClient.ListAttributes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Attribute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListAttributesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Attribute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Attribute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Attribute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttributesAsync</summary>
        public async Task ListAttributesRequestObjectAsync()
        {
            // Snippet: ListAttributesAsync(ListAttributesRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListAttributesRequest request = new gcav::ListAttributesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListAttributesResponse, gcav::Attribute> response = apiHubClient.ListAttributesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Attribute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListAttributesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Attribute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Attribute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Attribute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttributes</summary>
        public void ListAttributes()
        {
            // Snippet: ListAttributes(string, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcav::ListAttributesResponse, gcav::Attribute> response = apiHubClient.ListAttributes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Attribute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListAttributesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Attribute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Attribute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Attribute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttributesAsync</summary>
        public async Task ListAttributesAsync()
        {
            // Snippet: ListAttributesAsync(string, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcav::ListAttributesResponse, gcav::Attribute> response = apiHubClient.ListAttributesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Attribute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListAttributesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Attribute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Attribute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Attribute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttributes</summary>
        public void ListAttributesResourceNames()
        {
            // Snippet: ListAttributes(LocationName, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcav::ListAttributesResponse, gcav::Attribute> response = apiHubClient.ListAttributes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Attribute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListAttributesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Attribute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Attribute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Attribute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttributesAsync</summary>
        public async Task ListAttributesResourceNamesAsync()
        {
            // Snippet: ListAttributesAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcav::ListAttributesResponse, gcav::Attribute> response = apiHubClient.ListAttributesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Attribute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListAttributesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Attribute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Attribute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Attribute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchResources</summary>
        public void SearchResourcesRequestObject()
        {
            // Snippet: SearchResources(SearchResourcesRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::SearchResourcesRequest request = new gcav::SearchResourcesRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcav::SearchResourcesResponse, gcav::SearchResult> response = apiHubClient.SearchResources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::SearchResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::SearchResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::SearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::SearchResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::SearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchResourcesAsync</summary>
        public async Task SearchResourcesRequestObjectAsync()
        {
            // Snippet: SearchResourcesAsync(SearchResourcesRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::SearchResourcesRequest request = new gcav::SearchResourcesRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcav::SearchResourcesResponse, gcav::SearchResult> response = apiHubClient.SearchResourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::SearchResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::SearchResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::SearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::SearchResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::SearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchResources</summary>
        public void SearchResources()
        {
            // Snippet: SearchResources(string, string, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            string query = "";
            // Make the request
            PagedEnumerable<gcav::SearchResourcesResponse, gcav::SearchResult> response = apiHubClient.SearchResources(location, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::SearchResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::SearchResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::SearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::SearchResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::SearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchResourcesAsync</summary>
        public async Task SearchResourcesAsync()
        {
            // Snippet: SearchResourcesAsync(string, string, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            string query = "";
            // Make the request
            PagedAsyncEnumerable<gcav::SearchResourcesResponse, gcav::SearchResult> response = apiHubClient.SearchResourcesAsync(location, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::SearchResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::SearchResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::SearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::SearchResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::SearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchResources</summary>
        public void SearchResourcesResourceNames()
        {
            // Snippet: SearchResources(LocationName, string, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string query = "";
            // Make the request
            PagedEnumerable<gcav::SearchResourcesResponse, gcav::SearchResult> response = apiHubClient.SearchResources(location, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::SearchResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::SearchResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::SearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::SearchResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::SearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchResourcesAsync</summary>
        public async Task SearchResourcesResourceNamesAsync()
        {
            // Snippet: SearchResourcesAsync(LocationName, string, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string query = "";
            // Make the request
            PagedAsyncEnumerable<gcav::SearchResourcesResponse, gcav::SearchResult> response = apiHubClient.SearchResourcesAsync(location, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::SearchResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::SearchResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::SearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::SearchResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::SearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateExternalApi</summary>
        public void CreateExternalApiRequestObject()
        {
            // Snippet: CreateExternalApi(CreateExternalApiRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::CreateExternalApiRequest request = new gcav::CreateExternalApiRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExternalApiId = "",
                ExternalApi = new gcav::ExternalApi(),
            };
            // Make the request
            gcav::ExternalApi response = apiHubClient.CreateExternalApi(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExternalApiAsync</summary>
        public async Task CreateExternalApiRequestObjectAsync()
        {
            // Snippet: CreateExternalApiAsync(CreateExternalApiRequest, CallSettings)
            // Additional: CreateExternalApiAsync(CreateExternalApiRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::CreateExternalApiRequest request = new gcav::CreateExternalApiRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExternalApiId = "",
                ExternalApi = new gcav::ExternalApi(),
            };
            // Make the request
            gcav::ExternalApi response = await apiHubClient.CreateExternalApiAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExternalApi</summary>
        public void CreateExternalApi()
        {
            // Snippet: CreateExternalApi(string, ExternalApi, string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcav::ExternalApi externalApi = new gcav::ExternalApi();
            string externalApiId = "";
            // Make the request
            gcav::ExternalApi response = apiHubClient.CreateExternalApi(parent, externalApi, externalApiId);
            // End snippet
        }

        /// <summary>Snippet for CreateExternalApiAsync</summary>
        public async Task CreateExternalApiAsync()
        {
            // Snippet: CreateExternalApiAsync(string, ExternalApi, string, CallSettings)
            // Additional: CreateExternalApiAsync(string, ExternalApi, string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcav::ExternalApi externalApi = new gcav::ExternalApi();
            string externalApiId = "";
            // Make the request
            gcav::ExternalApi response = await apiHubClient.CreateExternalApiAsync(parent, externalApi, externalApiId);
            // End snippet
        }

        /// <summary>Snippet for CreateExternalApi</summary>
        public void CreateExternalApiResourceNames()
        {
            // Snippet: CreateExternalApi(LocationName, ExternalApi, string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcav::ExternalApi externalApi = new gcav::ExternalApi();
            string externalApiId = "";
            // Make the request
            gcav::ExternalApi response = apiHubClient.CreateExternalApi(parent, externalApi, externalApiId);
            // End snippet
        }

        /// <summary>Snippet for CreateExternalApiAsync</summary>
        public async Task CreateExternalApiResourceNamesAsync()
        {
            // Snippet: CreateExternalApiAsync(LocationName, ExternalApi, string, CallSettings)
            // Additional: CreateExternalApiAsync(LocationName, ExternalApi, string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcav::ExternalApi externalApi = new gcav::ExternalApi();
            string externalApiId = "";
            // Make the request
            gcav::ExternalApi response = await apiHubClient.CreateExternalApiAsync(parent, externalApi, externalApiId);
            // End snippet
        }

        /// <summary>Snippet for GetExternalApi</summary>
        public void GetExternalApiRequestObject()
        {
            // Snippet: GetExternalApi(GetExternalApiRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::GetExternalApiRequest request = new gcav::GetExternalApiRequest
            {
                ExternalApiName = gcav::ExternalApiName.FromProjectLocationExternalApi("[PROJECT]", "[LOCATION]", "[EXTERNAL_API]"),
            };
            // Make the request
            gcav::ExternalApi response = apiHubClient.GetExternalApi(request);
            // End snippet
        }

        /// <summary>Snippet for GetExternalApiAsync</summary>
        public async Task GetExternalApiRequestObjectAsync()
        {
            // Snippet: GetExternalApiAsync(GetExternalApiRequest, CallSettings)
            // Additional: GetExternalApiAsync(GetExternalApiRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetExternalApiRequest request = new gcav::GetExternalApiRequest
            {
                ExternalApiName = gcav::ExternalApiName.FromProjectLocationExternalApi("[PROJECT]", "[LOCATION]", "[EXTERNAL_API]"),
            };
            // Make the request
            gcav::ExternalApi response = await apiHubClient.GetExternalApiAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExternalApi</summary>
        public void GetExternalApi()
        {
            // Snippet: GetExternalApi(string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/externalApis/[EXTERNAL_API]";
            // Make the request
            gcav::ExternalApi response = apiHubClient.GetExternalApi(name);
            // End snippet
        }

        /// <summary>Snippet for GetExternalApiAsync</summary>
        public async Task GetExternalApiAsync()
        {
            // Snippet: GetExternalApiAsync(string, CallSettings)
            // Additional: GetExternalApiAsync(string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/externalApis/[EXTERNAL_API]";
            // Make the request
            gcav::ExternalApi response = await apiHubClient.GetExternalApiAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExternalApi</summary>
        public void GetExternalApiResourceNames()
        {
            // Snippet: GetExternalApi(ExternalApiName, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::ExternalApiName name = gcav::ExternalApiName.FromProjectLocationExternalApi("[PROJECT]", "[LOCATION]", "[EXTERNAL_API]");
            // Make the request
            gcav::ExternalApi response = apiHubClient.GetExternalApi(name);
            // End snippet
        }

        /// <summary>Snippet for GetExternalApiAsync</summary>
        public async Task GetExternalApiResourceNamesAsync()
        {
            // Snippet: GetExternalApiAsync(ExternalApiName, CallSettings)
            // Additional: GetExternalApiAsync(ExternalApiName, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ExternalApiName name = gcav::ExternalApiName.FromProjectLocationExternalApi("[PROJECT]", "[LOCATION]", "[EXTERNAL_API]");
            // Make the request
            gcav::ExternalApi response = await apiHubClient.GetExternalApiAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateExternalApi</summary>
        public void UpdateExternalApiRequestObject()
        {
            // Snippet: UpdateExternalApi(UpdateExternalApiRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::UpdateExternalApiRequest request = new gcav::UpdateExternalApiRequest
            {
                ExternalApi = new gcav::ExternalApi(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::ExternalApi response = apiHubClient.UpdateExternalApi(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExternalApiAsync</summary>
        public async Task UpdateExternalApiRequestObjectAsync()
        {
            // Snippet: UpdateExternalApiAsync(UpdateExternalApiRequest, CallSettings)
            // Additional: UpdateExternalApiAsync(UpdateExternalApiRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::UpdateExternalApiRequest request = new gcav::UpdateExternalApiRequest
            {
                ExternalApi = new gcav::ExternalApi(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::ExternalApi response = await apiHubClient.UpdateExternalApiAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExternalApi</summary>
        public void UpdateExternalApi()
        {
            // Snippet: UpdateExternalApi(ExternalApi, FieldMask, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::ExternalApi externalApi = new gcav::ExternalApi();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::ExternalApi response = apiHubClient.UpdateExternalApi(externalApi, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateExternalApiAsync</summary>
        public async Task UpdateExternalApiAsync()
        {
            // Snippet: UpdateExternalApiAsync(ExternalApi, FieldMask, CallSettings)
            // Additional: UpdateExternalApiAsync(ExternalApi, FieldMask, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ExternalApi externalApi = new gcav::ExternalApi();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::ExternalApi response = await apiHubClient.UpdateExternalApiAsync(externalApi, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalApi</summary>
        public void DeleteExternalApiRequestObject()
        {
            // Snippet: DeleteExternalApi(DeleteExternalApiRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::DeleteExternalApiRequest request = new gcav::DeleteExternalApiRequest
            {
                ExternalApiName = gcav::ExternalApiName.FromProjectLocationExternalApi("[PROJECT]", "[LOCATION]", "[EXTERNAL_API]"),
            };
            // Make the request
            apiHubClient.DeleteExternalApi(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalApiAsync</summary>
        public async Task DeleteExternalApiRequestObjectAsync()
        {
            // Snippet: DeleteExternalApiAsync(DeleteExternalApiRequest, CallSettings)
            // Additional: DeleteExternalApiAsync(DeleteExternalApiRequest, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::DeleteExternalApiRequest request = new gcav::DeleteExternalApiRequest
            {
                ExternalApiName = gcav::ExternalApiName.FromProjectLocationExternalApi("[PROJECT]", "[LOCATION]", "[EXTERNAL_API]"),
            };
            // Make the request
            await apiHubClient.DeleteExternalApiAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalApi</summary>
        public void DeleteExternalApi()
        {
            // Snippet: DeleteExternalApi(string, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/externalApis/[EXTERNAL_API]";
            // Make the request
            apiHubClient.DeleteExternalApi(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalApiAsync</summary>
        public async Task DeleteExternalApiAsync()
        {
            // Snippet: DeleteExternalApiAsync(string, CallSettings)
            // Additional: DeleteExternalApiAsync(string, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/externalApis/[EXTERNAL_API]";
            // Make the request
            await apiHubClient.DeleteExternalApiAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalApi</summary>
        public void DeleteExternalApiResourceNames()
        {
            // Snippet: DeleteExternalApi(ExternalApiName, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::ExternalApiName name = gcav::ExternalApiName.FromProjectLocationExternalApi("[PROJECT]", "[LOCATION]", "[EXTERNAL_API]");
            // Make the request
            apiHubClient.DeleteExternalApi(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExternalApiAsync</summary>
        public async Task DeleteExternalApiResourceNamesAsync()
        {
            // Snippet: DeleteExternalApiAsync(ExternalApiName, CallSettings)
            // Additional: DeleteExternalApiAsync(ExternalApiName, CancellationToken)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ExternalApiName name = gcav::ExternalApiName.FromProjectLocationExternalApi("[PROJECT]", "[LOCATION]", "[EXTERNAL_API]");
            // Make the request
            await apiHubClient.DeleteExternalApiAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListExternalApis</summary>
        public void ListExternalApisRequestObject()
        {
            // Snippet: ListExternalApis(ListExternalApisRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            gcav::ListExternalApisRequest request = new gcav::ListExternalApisRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<gcav::ListExternalApisResponse, gcav::ExternalApi> response = apiHubClient.ListExternalApis(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::ExternalApi item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListExternalApisResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::ExternalApi item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::ExternalApi> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::ExternalApi item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExternalApisAsync</summary>
        public async Task ListExternalApisRequestObjectAsync()
        {
            // Snippet: ListExternalApisAsync(ListExternalApisRequest, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListExternalApisRequest request = new gcav::ListExternalApisRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListExternalApisResponse, gcav::ExternalApi> response = apiHubClient.ListExternalApisAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::ExternalApi item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListExternalApisResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::ExternalApi item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::ExternalApi> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::ExternalApi item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExternalApis</summary>
        public void ListExternalApis()
        {
            // Snippet: ListExternalApis(string, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcav::ListExternalApisResponse, gcav::ExternalApi> response = apiHubClient.ListExternalApis(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::ExternalApi item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListExternalApisResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::ExternalApi item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::ExternalApi> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::ExternalApi item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExternalApisAsync</summary>
        public async Task ListExternalApisAsync()
        {
            // Snippet: ListExternalApisAsync(string, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcav::ListExternalApisResponse, gcav::ExternalApi> response = apiHubClient.ListExternalApisAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::ExternalApi item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListExternalApisResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::ExternalApi item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::ExternalApi> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::ExternalApi item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExternalApis</summary>
        public void ListExternalApisResourceNames()
        {
            // Snippet: ListExternalApis(LocationName, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = gcav::ApiHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcav::ListExternalApisResponse, gcav::ExternalApi> response = apiHubClient.ListExternalApis(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::ExternalApi item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListExternalApisResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::ExternalApi item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::ExternalApi> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::ExternalApi item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExternalApisAsync</summary>
        public async Task ListExternalApisResourceNamesAsync()
        {
            // Snippet: ListExternalApisAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcav::ApiHubClient apiHubClient = await gcav::ApiHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcav::ListExternalApisResponse, gcav::ExternalApi> response = apiHubClient.ListExternalApisAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::ExternalApi item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListExternalApisResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::ExternalApi item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::ExternalApi> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::ExternalApi item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
