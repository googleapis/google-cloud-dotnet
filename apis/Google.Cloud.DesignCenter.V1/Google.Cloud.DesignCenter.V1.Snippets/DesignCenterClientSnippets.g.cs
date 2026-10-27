// Copyright 2026 Google LLC
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
    using Google.Cloud.DesignCenter.V1;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDesignCenterClientSnippets
    {
        /// <summary>Snippet for GetSpace</summary>
        public void GetSpaceRequestObject()
        {
            // Snippet: GetSpace(GetSpaceRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GetSpaceRequest request = new GetSpaceRequest
            {
                SpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
            };
            // Make the request
            Space response = designCenterClient.GetSpace(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceAsync</summary>
        public async Task GetSpaceRequestObjectAsync()
        {
            // Snippet: GetSpaceAsync(GetSpaceRequest, CallSettings)
            // Additional: GetSpaceAsync(GetSpaceRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetSpaceRequest request = new GetSpaceRequest
            {
                SpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
            };
            // Make the request
            Space response = await designCenterClient.GetSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpace</summary>
        public void GetSpace()
        {
            // Snippet: GetSpace(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            // Make the request
            Space response = designCenterClient.GetSpace(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceAsync</summary>
        public async Task GetSpaceAsync()
        {
            // Snippet: GetSpaceAsync(string, CallSettings)
            // Additional: GetSpaceAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            // Make the request
            Space response = await designCenterClient.GetSpaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpace</summary>
        public void GetSpaceResourceNames()
        {
            // Snippet: GetSpace(SpaceName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            // Make the request
            Space response = designCenterClient.GetSpace(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceAsync</summary>
        public async Task GetSpaceResourceNamesAsync()
        {
            // Snippet: GetSpaceAsync(SpaceName, CallSettings)
            // Additional: GetSpaceAsync(SpaceName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            // Make the request
            Space response = await designCenterClient.GetSpaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSpaces</summary>
        public void ListSpacesRequestObject()
        {
            // Snippet: ListSpaces(ListSpacesRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ListSpacesRequest request = new ListSpacesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSpacesResponse, Space> response = designCenterClient.ListSpaces(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Space item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSpacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Space item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Space> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Space item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpacesAsync</summary>
        public async Task ListSpacesRequestObjectAsync()
        {
            // Snippet: ListSpacesAsync(ListSpacesRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListSpacesRequest request = new ListSpacesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSpacesResponse, Space> response = designCenterClient.ListSpacesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Space item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSpacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Space item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Space> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Space item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpaces</summary>
        public void ListSpaces()
        {
            // Snippet: ListSpaces(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSpacesResponse, Space> response = designCenterClient.ListSpaces(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Space item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSpacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Space item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Space> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Space item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpacesAsync</summary>
        public async Task ListSpacesAsync()
        {
            // Snippet: ListSpacesAsync(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSpacesResponse, Space> response = designCenterClient.ListSpacesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Space item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSpacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Space item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Space> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Space item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpaces</summary>
        public void ListSpacesResourceNames()
        {
            // Snippet: ListSpaces(LocationName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSpacesResponse, Space> response = designCenterClient.ListSpaces(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Space item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSpacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Space item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Space> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Space item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpacesAsync</summary>
        public async Task ListSpacesResourceNamesAsync()
        {
            // Snippet: ListSpacesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSpacesResponse, Space> response = designCenterClient.ListSpacesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Space item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSpacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Space item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Space> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Space item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateSpace</summary>
        public void CreateSpaceRequestObject()
        {
            // Snippet: CreateSpace(CreateSpaceRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CreateSpaceRequest request = new CreateSpaceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SpaceId = "",
                Space = new Space(),
            };
            // Make the request
            Space response = designCenterClient.CreateSpace(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSpaceAsync</summary>
        public async Task CreateSpaceRequestObjectAsync()
        {
            // Snippet: CreateSpaceAsync(CreateSpaceRequest, CallSettings)
            // Additional: CreateSpaceAsync(CreateSpaceRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateSpaceRequest request = new CreateSpaceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SpaceId = "",
                Space = new Space(),
            };
            // Make the request
            Space response = await designCenterClient.CreateSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSpace</summary>
        public void CreateSpace()
        {
            // Snippet: CreateSpace(string, Space, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Space space = new Space();
            string spaceId = "";
            // Make the request
            Space response = designCenterClient.CreateSpace(parent, space, spaceId);
            // End snippet
        }

        /// <summary>Snippet for CreateSpaceAsync</summary>
        public async Task CreateSpaceAsync()
        {
            // Snippet: CreateSpaceAsync(string, Space, string, CallSettings)
            // Additional: CreateSpaceAsync(string, Space, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Space space = new Space();
            string spaceId = "";
            // Make the request
            Space response = await designCenterClient.CreateSpaceAsync(parent, space, spaceId);
            // End snippet
        }

        /// <summary>Snippet for CreateSpace</summary>
        public void CreateSpaceResourceNames()
        {
            // Snippet: CreateSpace(LocationName, Space, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Space space = new Space();
            string spaceId = "";
            // Make the request
            Space response = designCenterClient.CreateSpace(parent, space, spaceId);
            // End snippet
        }

        /// <summary>Snippet for CreateSpaceAsync</summary>
        public async Task CreateSpaceResourceNamesAsync()
        {
            // Snippet: CreateSpaceAsync(LocationName, Space, string, CallSettings)
            // Additional: CreateSpaceAsync(LocationName, Space, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Space space = new Space();
            string spaceId = "";
            // Make the request
            Space response = await designCenterClient.CreateSpaceAsync(parent, space, spaceId);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpace</summary>
        public void UpdateSpaceRequestObject()
        {
            // Snippet: UpdateSpace(UpdateSpaceRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            UpdateSpaceRequest request = new UpdateSpaceRequest
            {
                UpdateMask = new FieldMask(),
                Space = new Space(),
            };
            // Make the request
            Space response = designCenterClient.UpdateSpace(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpaceAsync</summary>
        public async Task UpdateSpaceRequestObjectAsync()
        {
            // Snippet: UpdateSpaceAsync(UpdateSpaceRequest, CallSettings)
            // Additional: UpdateSpaceAsync(UpdateSpaceRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSpaceRequest request = new UpdateSpaceRequest
            {
                UpdateMask = new FieldMask(),
                Space = new Space(),
            };
            // Make the request
            Space response = await designCenterClient.UpdateSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpace</summary>
        public void UpdateSpace()
        {
            // Snippet: UpdateSpace(Space, FieldMask, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            Space space = new Space();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Space response = designCenterClient.UpdateSpace(space, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpaceAsync</summary>
        public async Task UpdateSpaceAsync()
        {
            // Snippet: UpdateSpaceAsync(Space, FieldMask, CallSettings)
            // Additional: UpdateSpaceAsync(Space, FieldMask, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            Space space = new Space();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Space response = await designCenterClient.UpdateSpaceAsync(space, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpace</summary>
        public void DeleteSpaceRequestObject()
        {
            // Snippet: DeleteSpace(DeleteSpaceRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            DeleteSpaceRequest request = new DeleteSpaceRequest
            {
                SpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                Force = false,
            };
            // Make the request
            designCenterClient.DeleteSpace(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpaceAsync</summary>
        public async Task DeleteSpaceRequestObjectAsync()
        {
            // Snippet: DeleteSpaceAsync(DeleteSpaceRequest, CallSettings)
            // Additional: DeleteSpaceAsync(DeleteSpaceRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSpaceRequest request = new DeleteSpaceRequest
            {
                SpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                Force = false,
            };
            // Make the request
            await designCenterClient.DeleteSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpace</summary>
        public void DeleteSpace()
        {
            // Snippet: DeleteSpace(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            // Make the request
            designCenterClient.DeleteSpace(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpaceAsync</summary>
        public async Task DeleteSpaceAsync()
        {
            // Snippet: DeleteSpaceAsync(string, CallSettings)
            // Additional: DeleteSpaceAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            // Make the request
            await designCenterClient.DeleteSpaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpace</summary>
        public void DeleteSpaceResourceNames()
        {
            // Snippet: DeleteSpace(SpaceName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            // Make the request
            designCenterClient.DeleteSpace(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpaceAsync</summary>
        public async Task DeleteSpaceResourceNamesAsync()
        {
            // Snippet: DeleteSpaceAsync(SpaceName, CallSettings)
            // Additional: DeleteSpaceAsync(SpaceName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            // Make the request
            await designCenterClient.DeleteSpaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplate</summary>
        public void GetApplicationTemplateRequestObject()
        {
            // Snippet: GetApplicationTemplate(GetApplicationTemplateRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GetApplicationTemplateRequest request = new GetApplicationTemplateRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
            };
            // Make the request
            ApplicationTemplate response = designCenterClient.GetApplicationTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplateAsync</summary>
        public async Task GetApplicationTemplateRequestObjectAsync()
        {
            // Snippet: GetApplicationTemplateAsync(GetApplicationTemplateRequest, CallSettings)
            // Additional: GetApplicationTemplateAsync(GetApplicationTemplateRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetApplicationTemplateRequest request = new GetApplicationTemplateRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
            };
            // Make the request
            ApplicationTemplate response = await designCenterClient.GetApplicationTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplate</summary>
        public void GetApplicationTemplate()
        {
            // Snippet: GetApplicationTemplate(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            ApplicationTemplate response = designCenterClient.GetApplicationTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplateAsync</summary>
        public async Task GetApplicationTemplateAsync()
        {
            // Snippet: GetApplicationTemplateAsync(string, CallSettings)
            // Additional: GetApplicationTemplateAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            ApplicationTemplate response = await designCenterClient.GetApplicationTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplate</summary>
        public void GetApplicationTemplateResourceNames()
        {
            // Snippet: GetApplicationTemplate(ApplicationTemplateName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            ApplicationTemplate response = designCenterClient.GetApplicationTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplateAsync</summary>
        public async Task GetApplicationTemplateResourceNamesAsync()
        {
            // Snippet: GetApplicationTemplateAsync(ApplicationTemplateName, CallSettings)
            // Additional: GetApplicationTemplateAsync(ApplicationTemplateName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            ApplicationTemplate response = await designCenterClient.GetApplicationTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplates</summary>
        public void ListApplicationTemplatesRequestObject()
        {
            // Snippet: ListApplicationTemplates(ListApplicationTemplatesRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ListApplicationTemplatesRequest request = new ListApplicationTemplatesRequest
            {
                ParentAsSpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListApplicationTemplatesResponse, ApplicationTemplate> response = designCenterClient.ListApplicationTemplates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApplicationTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplatesAsync</summary>
        public async Task ListApplicationTemplatesRequestObjectAsync()
        {
            // Snippet: ListApplicationTemplatesAsync(ListApplicationTemplatesRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListApplicationTemplatesRequest request = new ListApplicationTemplatesRequest
            {
                ParentAsSpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListApplicationTemplatesResponse, ApplicationTemplate> response = designCenterClient.ListApplicationTemplatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ApplicationTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListApplicationTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplates</summary>
        public void ListApplicationTemplates()
        {
            // Snippet: ListApplicationTemplates(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            // Make the request
            PagedEnumerable<ListApplicationTemplatesResponse, ApplicationTemplate> response = designCenterClient.ListApplicationTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApplicationTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplatesAsync</summary>
        public async Task ListApplicationTemplatesAsync()
        {
            // Snippet: ListApplicationTemplatesAsync(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            // Make the request
            PagedAsyncEnumerable<ListApplicationTemplatesResponse, ApplicationTemplate> response = designCenterClient.ListApplicationTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ApplicationTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListApplicationTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplates</summary>
        public void ListApplicationTemplatesResourceNames()
        {
            // Snippet: ListApplicationTemplates(SpaceName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            // Make the request
            PagedEnumerable<ListApplicationTemplatesResponse, ApplicationTemplate> response = designCenterClient.ListApplicationTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApplicationTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplatesAsync</summary>
        public async Task ListApplicationTemplatesResourceNamesAsync()
        {
            // Snippet: ListApplicationTemplatesAsync(SpaceName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            // Make the request
            PagedAsyncEnumerable<ListApplicationTemplatesResponse, ApplicationTemplate> response = designCenterClient.ListApplicationTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ApplicationTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListApplicationTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationTemplate</summary>
        public void CreateApplicationTemplateRequestObject()
        {
            // Snippet: CreateApplicationTemplate(CreateApplicationTemplateRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CreateApplicationTemplateRequest request = new CreateApplicationTemplateRequest
            {
                ParentAsSpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                ApplicationTemplateId = "",
                ApplicationTemplate = new ApplicationTemplate(),
            };
            // Make the request
            ApplicationTemplate response = designCenterClient.CreateApplicationTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationTemplateAsync</summary>
        public async Task CreateApplicationTemplateRequestObjectAsync()
        {
            // Snippet: CreateApplicationTemplateAsync(CreateApplicationTemplateRequest, CallSettings)
            // Additional: CreateApplicationTemplateAsync(CreateApplicationTemplateRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateApplicationTemplateRequest request = new CreateApplicationTemplateRequest
            {
                ParentAsSpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                ApplicationTemplateId = "",
                ApplicationTemplate = new ApplicationTemplate(),
            };
            // Make the request
            ApplicationTemplate response = await designCenterClient.CreateApplicationTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationTemplate</summary>
        public void CreateApplicationTemplate()
        {
            // Snippet: CreateApplicationTemplate(string, ApplicationTemplate, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            ApplicationTemplate applicationTemplate = new ApplicationTemplate();
            string applicationTemplateId = "";
            // Make the request
            ApplicationTemplate response = designCenterClient.CreateApplicationTemplate(parent, applicationTemplate, applicationTemplateId);
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationTemplateAsync</summary>
        public async Task CreateApplicationTemplateAsync()
        {
            // Snippet: CreateApplicationTemplateAsync(string, ApplicationTemplate, string, CallSettings)
            // Additional: CreateApplicationTemplateAsync(string, ApplicationTemplate, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            ApplicationTemplate applicationTemplate = new ApplicationTemplate();
            string applicationTemplateId = "";
            // Make the request
            ApplicationTemplate response = await designCenterClient.CreateApplicationTemplateAsync(parent, applicationTemplate, applicationTemplateId);
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationTemplate</summary>
        public void CreateApplicationTemplateResourceNames()
        {
            // Snippet: CreateApplicationTemplate(SpaceName, ApplicationTemplate, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            ApplicationTemplate applicationTemplate = new ApplicationTemplate();
            string applicationTemplateId = "";
            // Make the request
            ApplicationTemplate response = designCenterClient.CreateApplicationTemplate(parent, applicationTemplate, applicationTemplateId);
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationTemplateAsync</summary>
        public async Task CreateApplicationTemplateResourceNamesAsync()
        {
            // Snippet: CreateApplicationTemplateAsync(SpaceName, ApplicationTemplate, string, CallSettings)
            // Additional: CreateApplicationTemplateAsync(SpaceName, ApplicationTemplate, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            ApplicationTemplate applicationTemplate = new ApplicationTemplate();
            string applicationTemplateId = "";
            // Make the request
            ApplicationTemplate response = await designCenterClient.CreateApplicationTemplateAsync(parent, applicationTemplate, applicationTemplateId);
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationTemplate</summary>
        public void UpdateApplicationTemplateRequestObject()
        {
            // Snippet: UpdateApplicationTemplate(UpdateApplicationTemplateRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            UpdateApplicationTemplateRequest request = new UpdateApplicationTemplateRequest
            {
                UpdateMask = new FieldMask(),
                ApplicationTemplate = new ApplicationTemplate(),
            };
            // Make the request
            ApplicationTemplate response = designCenterClient.UpdateApplicationTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationTemplateAsync</summary>
        public async Task UpdateApplicationTemplateRequestObjectAsync()
        {
            // Snippet: UpdateApplicationTemplateAsync(UpdateApplicationTemplateRequest, CallSettings)
            // Additional: UpdateApplicationTemplateAsync(UpdateApplicationTemplateRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateApplicationTemplateRequest request = new UpdateApplicationTemplateRequest
            {
                UpdateMask = new FieldMask(),
                ApplicationTemplate = new ApplicationTemplate(),
            };
            // Make the request
            ApplicationTemplate response = await designCenterClient.UpdateApplicationTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationTemplate</summary>
        public void UpdateApplicationTemplate()
        {
            // Snippet: UpdateApplicationTemplate(ApplicationTemplate, FieldMask, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplate applicationTemplate = new ApplicationTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ApplicationTemplate response = designCenterClient.UpdateApplicationTemplate(applicationTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationTemplateAsync</summary>
        public async Task UpdateApplicationTemplateAsync()
        {
            // Snippet: UpdateApplicationTemplateAsync(ApplicationTemplate, FieldMask, CallSettings)
            // Additional: UpdateApplicationTemplateAsync(ApplicationTemplate, FieldMask, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplate applicationTemplate = new ApplicationTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ApplicationTemplate response = await designCenterClient.UpdateApplicationTemplateAsync(applicationTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationTemplate</summary>
        public void ImportApplicationTemplateRequestObject()
        {
            // Snippet: ImportApplicationTemplate(ImportApplicationTemplateRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ImportApplicationTemplateRequest request = new ImportApplicationTemplateRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                ApplicationTemplateRevisionUriAsApplicationTemplateRevisionName = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]"),
                Annotations = { { "", "" }, },
            };
            // Make the request
            ApplicationTemplate response = designCenterClient.ImportApplicationTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationTemplateAsync</summary>
        public async Task ImportApplicationTemplateRequestObjectAsync()
        {
            // Snippet: ImportApplicationTemplateAsync(ImportApplicationTemplateRequest, CallSettings)
            // Additional: ImportApplicationTemplateAsync(ImportApplicationTemplateRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ImportApplicationTemplateRequest request = new ImportApplicationTemplateRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                ApplicationTemplateRevisionUriAsApplicationTemplateRevisionName = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]"),
                Annotations = { { "", "" }, },
            };
            // Make the request
            ApplicationTemplate response = await designCenterClient.ImportApplicationTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationTemplate</summary>
        public void ImportApplicationTemplate()
        {
            // Snippet: ImportApplicationTemplate(string, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            string applicationTemplateRevisionUri = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/revisions/[REVISION]";
            // Make the request
            ApplicationTemplate response = designCenterClient.ImportApplicationTemplate(name, applicationTemplateRevisionUri);
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationTemplateAsync</summary>
        public async Task ImportApplicationTemplateAsync()
        {
            // Snippet: ImportApplicationTemplateAsync(string, string, CallSettings)
            // Additional: ImportApplicationTemplateAsync(string, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            string applicationTemplateRevisionUri = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/revisions/[REVISION]";
            // Make the request
            ApplicationTemplate response = await designCenterClient.ImportApplicationTemplateAsync(name, applicationTemplateRevisionUri);
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationTemplate</summary>
        public void ImportApplicationTemplateResourceNames()
        {
            // Snippet: ImportApplicationTemplate(ApplicationTemplateName, ApplicationTemplateRevisionName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            ApplicationTemplateRevisionName applicationTemplateRevisionUri = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]");
            // Make the request
            ApplicationTemplate response = designCenterClient.ImportApplicationTemplate(name, applicationTemplateRevisionUri);
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationTemplateAsync</summary>
        public async Task ImportApplicationTemplateResourceNamesAsync()
        {
            // Snippet: ImportApplicationTemplateAsync(ApplicationTemplateName, ApplicationTemplateRevisionName, CallSettings)
            // Additional: ImportApplicationTemplateAsync(ApplicationTemplateName, ApplicationTemplateRevisionName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            ApplicationTemplateRevisionName applicationTemplateRevisionUri = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]");
            // Make the request
            ApplicationTemplate response = await designCenterClient.ImportApplicationTemplateAsync(name, applicationTemplateRevisionUri);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationTemplate</summary>
        public void DeleteApplicationTemplateRequestObject()
        {
            // Snippet: DeleteApplicationTemplate(DeleteApplicationTemplateRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            DeleteApplicationTemplateRequest request = new DeleteApplicationTemplateRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                Force = false,
            };
            // Make the request
            designCenterClient.DeleteApplicationTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationTemplateAsync</summary>
        public async Task DeleteApplicationTemplateRequestObjectAsync()
        {
            // Snippet: DeleteApplicationTemplateAsync(DeleteApplicationTemplateRequest, CallSettings)
            // Additional: DeleteApplicationTemplateAsync(DeleteApplicationTemplateRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteApplicationTemplateRequest request = new DeleteApplicationTemplateRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                Force = false,
            };
            // Make the request
            await designCenterClient.DeleteApplicationTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationTemplate</summary>
        public void DeleteApplicationTemplate()
        {
            // Snippet: DeleteApplicationTemplate(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            designCenterClient.DeleteApplicationTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationTemplateAsync</summary>
        public async Task DeleteApplicationTemplateAsync()
        {
            // Snippet: DeleteApplicationTemplateAsync(string, CallSettings)
            // Additional: DeleteApplicationTemplateAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            await designCenterClient.DeleteApplicationTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationTemplate</summary>
        public void DeleteApplicationTemplateResourceNames()
        {
            // Snippet: DeleteApplicationTemplate(ApplicationTemplateName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            designCenterClient.DeleteApplicationTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationTemplateAsync</summary>
        public async Task DeleteApplicationTemplateResourceNamesAsync()
        {
            // Snippet: DeleteApplicationTemplateAsync(ApplicationTemplateName, CallSettings)
            // Additional: DeleteApplicationTemplateAsync(ApplicationTemplateName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            await designCenterClient.DeleteApplicationTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CommitApplicationTemplate</summary>
        public void CommitApplicationTemplateRequestObject()
        {
            // Snippet: CommitApplicationTemplate(CommitApplicationTemplateRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CommitApplicationTemplateRequest request = new CommitApplicationTemplateRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
            };
            // Make the request
            ApplicationTemplateRevision response = designCenterClient.CommitApplicationTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for CommitApplicationTemplateAsync</summary>
        public async Task CommitApplicationTemplateRequestObjectAsync()
        {
            // Snippet: CommitApplicationTemplateAsync(CommitApplicationTemplateRequest, CallSettings)
            // Additional: CommitApplicationTemplateAsync(CommitApplicationTemplateRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CommitApplicationTemplateRequest request = new CommitApplicationTemplateRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
            };
            // Make the request
            ApplicationTemplateRevision response = await designCenterClient.CommitApplicationTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CommitApplicationTemplate</summary>
        public void CommitApplicationTemplate()
        {
            // Snippet: CommitApplicationTemplate(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            ApplicationTemplateRevision response = designCenterClient.CommitApplicationTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for CommitApplicationTemplateAsync</summary>
        public async Task CommitApplicationTemplateAsync()
        {
            // Snippet: CommitApplicationTemplateAsync(string, CallSettings)
            // Additional: CommitApplicationTemplateAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            ApplicationTemplateRevision response = await designCenterClient.CommitApplicationTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CommitApplicationTemplate</summary>
        public void CommitApplicationTemplateResourceNames()
        {
            // Snippet: CommitApplicationTemplate(ApplicationTemplateName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            ApplicationTemplateRevision response = designCenterClient.CommitApplicationTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for CommitApplicationTemplateAsync</summary>
        public async Task CommitApplicationTemplateResourceNamesAsync()
        {
            // Snippet: CommitApplicationTemplateAsync(ApplicationTemplateName, CallSettings)
            // Additional: CommitApplicationTemplateAsync(ApplicationTemplateName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            ApplicationTemplateRevision response = await designCenterClient.CommitApplicationTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SnapshotApplicationTemplate</summary>
        public void SnapshotApplicationTemplateRequestObject()
        {
            // Snippet: SnapshotApplicationTemplate(SnapshotApplicationTemplateRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            SnapshotApplicationTemplateRequest request = new SnapshotApplicationTemplateRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
            };
            // Make the request
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> response = designCenterClient.SnapshotApplicationTemplate(request);

            // Poll until the returned long-running operation is complete
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SnapshotApplicationTemplateResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceSnapshotApplicationTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SnapshotApplicationTemplateResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SnapshotApplicationTemplateAsync</summary>
        public async Task SnapshotApplicationTemplateRequestObjectAsync()
        {
            // Snippet: SnapshotApplicationTemplateAsync(SnapshotApplicationTemplateRequest, CallSettings)
            // Additional: SnapshotApplicationTemplateAsync(SnapshotApplicationTemplateRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotApplicationTemplateRequest request = new SnapshotApplicationTemplateRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
            };
            // Make the request
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> response = await designCenterClient.SnapshotApplicationTemplateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SnapshotApplicationTemplateResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceSnapshotApplicationTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SnapshotApplicationTemplateResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SnapshotApplicationTemplate</summary>
        public void SnapshotApplicationTemplate()
        {
            // Snippet: SnapshotApplicationTemplate(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> response = designCenterClient.SnapshotApplicationTemplate(name);

            // Poll until the returned long-running operation is complete
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SnapshotApplicationTemplateResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceSnapshotApplicationTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SnapshotApplicationTemplateResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SnapshotApplicationTemplateAsync</summary>
        public async Task SnapshotApplicationTemplateAsync()
        {
            // Snippet: SnapshotApplicationTemplateAsync(string, CallSettings)
            // Additional: SnapshotApplicationTemplateAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> response = await designCenterClient.SnapshotApplicationTemplateAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SnapshotApplicationTemplateResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceSnapshotApplicationTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SnapshotApplicationTemplateResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SnapshotApplicationTemplate</summary>
        public void SnapshotApplicationTemplateResourceNames()
        {
            // Snippet: SnapshotApplicationTemplate(ApplicationTemplateName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> response = designCenterClient.SnapshotApplicationTemplate(name);

            // Poll until the returned long-running operation is complete
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SnapshotApplicationTemplateResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceSnapshotApplicationTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SnapshotApplicationTemplateResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SnapshotApplicationTemplateAsync</summary>
        public async Task SnapshotApplicationTemplateResourceNamesAsync()
        {
            // Snippet: SnapshotApplicationTemplateAsync(ApplicationTemplateName, CallSettings)
            // Additional: SnapshotApplicationTemplateAsync(ApplicationTemplateName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> response = await designCenterClient.SnapshotApplicationTemplateAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SnapshotApplicationTemplateResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SnapshotApplicationTemplateResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceSnapshotApplicationTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SnapshotApplicationTemplateResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateIaC</summary>
        public void GenerateApplicationTemplateIaCRequestObject()
        {
            // Snippet: GenerateApplicationTemplateIaC(GenerateApplicationTemplateIaCRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GenerateApplicationTemplateIaCRequest request = new GenerateApplicationTemplateIaCRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                IacFormat = GenerateApplicationTemplateIaCRequest.Types.IACFormat.Unspecified,
                ArtifactLocation = new ArtifactLocation(),
            };
            // Make the request
            GenerateApplicationTemplateIaCResponse response = designCenterClient.GenerateApplicationTemplateIaC(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateIaCAsync</summary>
        public async Task GenerateApplicationTemplateIaCRequestObjectAsync()
        {
            // Snippet: GenerateApplicationTemplateIaCAsync(GenerateApplicationTemplateIaCRequest, CallSettings)
            // Additional: GenerateApplicationTemplateIaCAsync(GenerateApplicationTemplateIaCRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GenerateApplicationTemplateIaCRequest request = new GenerateApplicationTemplateIaCRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                IacFormat = GenerateApplicationTemplateIaCRequest.Types.IACFormat.Unspecified,
                ArtifactLocation = new ArtifactLocation(),
            };
            // Make the request
            GenerateApplicationTemplateIaCResponse response = await designCenterClient.GenerateApplicationTemplateIaCAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateIaC</summary>
        public void GenerateApplicationTemplateIaC()
        {
            // Snippet: GenerateApplicationTemplateIaC(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            GenerateApplicationTemplateIaCResponse response = designCenterClient.GenerateApplicationTemplateIaC(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateIaCAsync</summary>
        public async Task GenerateApplicationTemplateIaCAsync()
        {
            // Snippet: GenerateApplicationTemplateIaCAsync(string, CallSettings)
            // Additional: GenerateApplicationTemplateIaCAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            GenerateApplicationTemplateIaCResponse response = await designCenterClient.GenerateApplicationTemplateIaCAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateIaC</summary>
        public void GenerateApplicationTemplateIaCResourceNames()
        {
            // Snippet: GenerateApplicationTemplateIaC(ApplicationTemplateName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            GenerateApplicationTemplateIaCResponse response = designCenterClient.GenerateApplicationTemplateIaC(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateIaCAsync</summary>
        public async Task GenerateApplicationTemplateIaCResourceNamesAsync()
        {
            // Snippet: GenerateApplicationTemplateIaCAsync(ApplicationTemplateName, CallSettings)
            // Additional: GenerateApplicationTemplateIaCAsync(ApplicationTemplateName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            GenerateApplicationTemplateIaCResponse response = await designCenterClient.GenerateApplicationTemplateIaCAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationTemplateIaC</summary>
        public void ExportApplicationTemplateIaCRequestObject()
        {
            // Snippet: ExportApplicationTemplateIaC(ExportApplicationTemplateIaCRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ExportApplicationTemplateIaCRequest request = new ExportApplicationTemplateIaCRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                ArtifactLocation = new ArtifactLocation(),
                ExportIacConfig = new ExportIaCConfig(),
            };
            // Make the request
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> response = designCenterClient.ExportApplicationTemplateIaC(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportApplicationTemplateIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceExportApplicationTemplateIaC(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationTemplateIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationTemplateIaCAsync</summary>
        public async Task ExportApplicationTemplateIaCRequestObjectAsync()
        {
            // Snippet: ExportApplicationTemplateIaCAsync(ExportApplicationTemplateIaCRequest, CallSettings)
            // Additional: ExportApplicationTemplateIaCAsync(ExportApplicationTemplateIaCRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ExportApplicationTemplateIaCRequest request = new ExportApplicationTemplateIaCRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                ArtifactLocation = new ArtifactLocation(),
                ExportIacConfig = new ExportIaCConfig(),
            };
            // Make the request
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> response = await designCenterClient.ExportApplicationTemplateIaCAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportApplicationTemplateIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceExportApplicationTemplateIaCAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationTemplateIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationTemplateIaC</summary>
        public void ExportApplicationTemplateIaC()
        {
            // Snippet: ExportApplicationTemplateIaC(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> response = designCenterClient.ExportApplicationTemplateIaC(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportApplicationTemplateIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceExportApplicationTemplateIaC(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationTemplateIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationTemplateIaCAsync</summary>
        public async Task ExportApplicationTemplateIaCAsync()
        {
            // Snippet: ExportApplicationTemplateIaCAsync(string, CallSettings)
            // Additional: ExportApplicationTemplateIaCAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> response = await designCenterClient.ExportApplicationTemplateIaCAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportApplicationTemplateIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceExportApplicationTemplateIaCAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationTemplateIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationTemplateIaC</summary>
        public void ExportApplicationTemplateIaCResourceNames()
        {
            // Snippet: ExportApplicationTemplateIaC(ApplicationTemplateName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> response = designCenterClient.ExportApplicationTemplateIaC(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportApplicationTemplateIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceExportApplicationTemplateIaC(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationTemplateIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationTemplateIaCAsync</summary>
        public async Task ExportApplicationTemplateIaCResourceNamesAsync()
        {
            // Snippet: ExportApplicationTemplateIaCAsync(ApplicationTemplateName, CallSettings)
            // Additional: ExportApplicationTemplateIaCAsync(ApplicationTemplateName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> response = await designCenterClient.ExportApplicationTemplateIaCAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportApplicationTemplateIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceExportApplicationTemplateIaCAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationTemplateIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateRevisionIaC</summary>
        public void GenerateApplicationTemplateRevisionIaCRequestObject()
        {
            // Snippet: GenerateApplicationTemplateRevisionIaC(GenerateApplicationTemplateRevisionIaCRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GenerateApplicationTemplateRevisionIaCRequest request = new GenerateApplicationTemplateRevisionIaCRequest
            {
                ApplicationTemplateRevisionName = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]"),
                IacFormat = GenerateApplicationTemplateRevisionIaCRequest.Types.IACFormat.Unspecified,
                ArtifactLocation = new ArtifactLocation(),
            };
            // Make the request
            GenerateApplicationTemplateRevisionIaCResponse response = designCenterClient.GenerateApplicationTemplateRevisionIaC(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateRevisionIaCAsync</summary>
        public async Task GenerateApplicationTemplateRevisionIaCRequestObjectAsync()
        {
            // Snippet: GenerateApplicationTemplateRevisionIaCAsync(GenerateApplicationTemplateRevisionIaCRequest, CallSettings)
            // Additional: GenerateApplicationTemplateRevisionIaCAsync(GenerateApplicationTemplateRevisionIaCRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GenerateApplicationTemplateRevisionIaCRequest request = new GenerateApplicationTemplateRevisionIaCRequest
            {
                ApplicationTemplateRevisionName = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]"),
                IacFormat = GenerateApplicationTemplateRevisionIaCRequest.Types.IACFormat.Unspecified,
                ArtifactLocation = new ArtifactLocation(),
            };
            // Make the request
            GenerateApplicationTemplateRevisionIaCResponse response = await designCenterClient.GenerateApplicationTemplateRevisionIaCAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateRevisionIaC</summary>
        public void GenerateApplicationTemplateRevisionIaC()
        {
            // Snippet: GenerateApplicationTemplateRevisionIaC(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/revisions/[REVISION]";
            // Make the request
            GenerateApplicationTemplateRevisionIaCResponse response = designCenterClient.GenerateApplicationTemplateRevisionIaC(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateRevisionIaCAsync</summary>
        public async Task GenerateApplicationTemplateRevisionIaCAsync()
        {
            // Snippet: GenerateApplicationTemplateRevisionIaCAsync(string, CallSettings)
            // Additional: GenerateApplicationTemplateRevisionIaCAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/revisions/[REVISION]";
            // Make the request
            GenerateApplicationTemplateRevisionIaCResponse response = await designCenterClient.GenerateApplicationTemplateRevisionIaCAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateRevisionIaC</summary>
        public void GenerateApplicationTemplateRevisionIaCResourceNames()
        {
            // Snippet: GenerateApplicationTemplateRevisionIaC(ApplicationTemplateRevisionName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateRevisionName name = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]");
            // Make the request
            GenerateApplicationTemplateRevisionIaCResponse response = designCenterClient.GenerateApplicationTemplateRevisionIaC(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateRevisionIaCAsync</summary>
        public async Task GenerateApplicationTemplateRevisionIaCResourceNamesAsync()
        {
            // Snippet: GenerateApplicationTemplateRevisionIaCAsync(ApplicationTemplateRevisionName, CallSettings)
            // Additional: GenerateApplicationTemplateRevisionIaCAsync(ApplicationTemplateRevisionName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateRevisionName name = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]");
            // Make the request
            GenerateApplicationTemplateRevisionIaCResponse response = await designCenterClient.GenerateApplicationTemplateRevisionIaCAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationTemplateRevisionIaC</summary>
        public void ExportApplicationTemplateRevisionIaCRequestObject()
        {
            // Snippet: ExportApplicationTemplateRevisionIaC(ExportApplicationTemplateRevisionIaCRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ExportApplicationTemplateRevisionIaCRequest request = new ExportApplicationTemplateRevisionIaCRequest
            {
                ApplicationTemplateRevisionName = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]"),
                ArtifactLocation = new ArtifactLocation(),
                ExportIacConfig = new ExportIaCConfig(),
            };
            // Make the request
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> response = designCenterClient.ExportApplicationTemplateRevisionIaC(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportApplicationTemplateRevisionIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceExportApplicationTemplateRevisionIaC(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationTemplateRevisionIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationTemplateRevisionIaCAsync</summary>
        public async Task ExportApplicationTemplateRevisionIaCRequestObjectAsync()
        {
            // Snippet: ExportApplicationTemplateRevisionIaCAsync(ExportApplicationTemplateRevisionIaCRequest, CallSettings)
            // Additional: ExportApplicationTemplateRevisionIaCAsync(ExportApplicationTemplateRevisionIaCRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ExportApplicationTemplateRevisionIaCRequest request = new ExportApplicationTemplateRevisionIaCRequest
            {
                ApplicationTemplateRevisionName = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]"),
                ArtifactLocation = new ArtifactLocation(),
                ExportIacConfig = new ExportIaCConfig(),
            };
            // Make the request
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> response = await designCenterClient.ExportApplicationTemplateRevisionIaCAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportApplicationTemplateRevisionIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceExportApplicationTemplateRevisionIaCAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationTemplateRevisionIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationTemplateRevisionIaC</summary>
        public void ExportApplicationTemplateRevisionIaC()
        {
            // Snippet: ExportApplicationTemplateRevisionIaC(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/revisions/[REVISION]";
            // Make the request
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> response = designCenterClient.ExportApplicationTemplateRevisionIaC(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportApplicationTemplateRevisionIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceExportApplicationTemplateRevisionIaC(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationTemplateRevisionIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationTemplateRevisionIaCAsync</summary>
        public async Task ExportApplicationTemplateRevisionIaCAsync()
        {
            // Snippet: ExportApplicationTemplateRevisionIaCAsync(string, CallSettings)
            // Additional: ExportApplicationTemplateRevisionIaCAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/revisions/[REVISION]";
            // Make the request
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> response = await designCenterClient.ExportApplicationTemplateRevisionIaCAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportApplicationTemplateRevisionIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceExportApplicationTemplateRevisionIaCAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationTemplateRevisionIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationTemplateRevisionIaC</summary>
        public void ExportApplicationTemplateRevisionIaCResourceNames()
        {
            // Snippet: ExportApplicationTemplateRevisionIaC(ApplicationTemplateRevisionName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateRevisionName name = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]");
            // Make the request
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> response = designCenterClient.ExportApplicationTemplateRevisionIaC(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportApplicationTemplateRevisionIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceExportApplicationTemplateRevisionIaC(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationTemplateRevisionIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationTemplateRevisionIaCAsync</summary>
        public async Task ExportApplicationTemplateRevisionIaCResourceNamesAsync()
        {
            // Snippet: ExportApplicationTemplateRevisionIaCAsync(ApplicationTemplateRevisionName, CallSettings)
            // Additional: ExportApplicationTemplateRevisionIaCAsync(ApplicationTemplateRevisionName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateRevisionName name = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]");
            // Make the request
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> response = await designCenterClient.ExportApplicationTemplateRevisionIaCAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportApplicationTemplateRevisionIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceExportApplicationTemplateRevisionIaCAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationTemplateRevisionIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetComponent</summary>
        public void GetComponentRequestObject()
        {
            // Snippet: GetComponent(GetComponentRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GetComponentRequest request = new GetComponentRequest
            {
                ComponentName = ComponentName.FromProjectLocationSpaceApplicationTemplateComponent("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]"),
            };
            // Make the request
            Component response = designCenterClient.GetComponent(request);
            // End snippet
        }

        /// <summary>Snippet for GetComponentAsync</summary>
        public async Task GetComponentRequestObjectAsync()
        {
            // Snippet: GetComponentAsync(GetComponentRequest, CallSettings)
            // Additional: GetComponentAsync(GetComponentRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetComponentRequest request = new GetComponentRequest
            {
                ComponentName = ComponentName.FromProjectLocationSpaceApplicationTemplateComponent("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]"),
            };
            // Make the request
            Component response = await designCenterClient.GetComponentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetComponent</summary>
        public void GetComponent()
        {
            // Snippet: GetComponent(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/components/[COMPONENT]";
            // Make the request
            Component response = designCenterClient.GetComponent(name);
            // End snippet
        }

        /// <summary>Snippet for GetComponentAsync</summary>
        public async Task GetComponentAsync()
        {
            // Snippet: GetComponentAsync(string, CallSettings)
            // Additional: GetComponentAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/components/[COMPONENT]";
            // Make the request
            Component response = await designCenterClient.GetComponentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetComponent</summary>
        public void GetComponentResourceNames()
        {
            // Snippet: GetComponent(ComponentName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ComponentName name = ComponentName.FromProjectLocationSpaceApplicationTemplateComponent("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]");
            // Make the request
            Component response = designCenterClient.GetComponent(name);
            // End snippet
        }

        /// <summary>Snippet for GetComponentAsync</summary>
        public async Task GetComponentResourceNamesAsync()
        {
            // Snippet: GetComponentAsync(ComponentName, CallSettings)
            // Additional: GetComponentAsync(ComponentName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ComponentName name = ComponentName.FromProjectLocationSpaceApplicationTemplateComponent("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]");
            // Make the request
            Component response = await designCenterClient.GetComponentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListComponents</summary>
        public void ListComponentsRequestObject()
        {
            // Snippet: ListComponents(ListComponentsRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ListComponentsRequest request = new ListComponentsRequest
            {
                ParentAsApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListComponentsResponse, Component> response = designCenterClient.ListComponents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Component item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListComponentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Component item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Component> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Component item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListComponentsAsync</summary>
        public async Task ListComponentsRequestObjectAsync()
        {
            // Snippet: ListComponentsAsync(ListComponentsRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListComponentsRequest request = new ListComponentsRequest
            {
                ParentAsApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListComponentsResponse, Component> response = designCenterClient.ListComponentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Component item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListComponentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Component item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Component> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Component item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListComponents</summary>
        public void ListComponents()
        {
            // Snippet: ListComponents(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            PagedEnumerable<ListComponentsResponse, Component> response = designCenterClient.ListComponents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Component item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListComponentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Component item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Component> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Component item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListComponentsAsync</summary>
        public async Task ListComponentsAsync()
        {
            // Snippet: ListComponentsAsync(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            PagedAsyncEnumerable<ListComponentsResponse, Component> response = designCenterClient.ListComponentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Component item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListComponentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Component item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Component> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Component item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListComponents</summary>
        public void ListComponentsResourceNames()
        {
            // Snippet: ListComponents(ApplicationTemplateName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateName parent = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            PagedEnumerable<ListComponentsResponse, Component> response = designCenterClient.ListComponents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Component item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListComponentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Component item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Component> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Component item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListComponentsAsync</summary>
        public async Task ListComponentsResourceNamesAsync()
        {
            // Snippet: ListComponentsAsync(ApplicationTemplateName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateName parent = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            PagedAsyncEnumerable<ListComponentsResponse, Component> response = designCenterClient.ListComponentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Component item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListComponentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Component item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Component> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Component item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateComponent</summary>
        public void CreateComponentRequestObject()
        {
            // Snippet: CreateComponent(CreateComponentRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CreateComponentRequest request = new CreateComponentRequest
            {
                ParentAsApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                ComponentId = "",
                Component = new Component(),
            };
            // Make the request
            Component response = designCenterClient.CreateComponent(request);
            // End snippet
        }

        /// <summary>Snippet for CreateComponentAsync</summary>
        public async Task CreateComponentRequestObjectAsync()
        {
            // Snippet: CreateComponentAsync(CreateComponentRequest, CallSettings)
            // Additional: CreateComponentAsync(CreateComponentRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateComponentRequest request = new CreateComponentRequest
            {
                ParentAsApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                ComponentId = "",
                Component = new Component(),
            };
            // Make the request
            Component response = await designCenterClient.CreateComponentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateComponent</summary>
        public void CreateComponent()
        {
            // Snippet: CreateComponent(string, Component, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            Component component = new Component();
            string componentId = "";
            // Make the request
            Component response = designCenterClient.CreateComponent(parent, component, componentId);
            // End snippet
        }

        /// <summary>Snippet for CreateComponentAsync</summary>
        public async Task CreateComponentAsync()
        {
            // Snippet: CreateComponentAsync(string, Component, string, CallSettings)
            // Additional: CreateComponentAsync(string, Component, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            Component component = new Component();
            string componentId = "";
            // Make the request
            Component response = await designCenterClient.CreateComponentAsync(parent, component, componentId);
            // End snippet
        }

        /// <summary>Snippet for CreateComponent</summary>
        public void CreateComponentResourceNames()
        {
            // Snippet: CreateComponent(ApplicationTemplateName, Component, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateName parent = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            Component component = new Component();
            string componentId = "";
            // Make the request
            Component response = designCenterClient.CreateComponent(parent, component, componentId);
            // End snippet
        }

        /// <summary>Snippet for CreateComponentAsync</summary>
        public async Task CreateComponentResourceNamesAsync()
        {
            // Snippet: CreateComponentAsync(ApplicationTemplateName, Component, string, CallSettings)
            // Additional: CreateComponentAsync(ApplicationTemplateName, Component, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateName parent = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            Component component = new Component();
            string componentId = "";
            // Make the request
            Component response = await designCenterClient.CreateComponentAsync(parent, component, componentId);
            // End snippet
        }

        /// <summary>Snippet for UpdateComponent</summary>
        public void UpdateComponentRequestObject()
        {
            // Snippet: UpdateComponent(UpdateComponentRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            UpdateComponentRequest request = new UpdateComponentRequest
            {
                UpdateMask = new FieldMask(),
                Component = new Component(),
            };
            // Make the request
            Component response = designCenterClient.UpdateComponent(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateComponentAsync</summary>
        public async Task UpdateComponentRequestObjectAsync()
        {
            // Snippet: UpdateComponentAsync(UpdateComponentRequest, CallSettings)
            // Additional: UpdateComponentAsync(UpdateComponentRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateComponentRequest request = new UpdateComponentRequest
            {
                UpdateMask = new FieldMask(),
                Component = new Component(),
            };
            // Make the request
            Component response = await designCenterClient.UpdateComponentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateComponent</summary>
        public void UpdateComponent()
        {
            // Snippet: UpdateComponent(Component, FieldMask, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            Component component = new Component();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Component response = designCenterClient.UpdateComponent(component, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateComponentAsync</summary>
        public async Task UpdateComponentAsync()
        {
            // Snippet: UpdateComponentAsync(Component, FieldMask, CallSettings)
            // Additional: UpdateComponentAsync(Component, FieldMask, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            Component component = new Component();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Component response = await designCenterClient.UpdateComponentAsync(component, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteComponent</summary>
        public void DeleteComponentRequestObject()
        {
            // Snippet: DeleteComponent(DeleteComponentRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            DeleteComponentRequest request = new DeleteComponentRequest
            {
                ComponentName = ComponentName.FromProjectLocationSpaceApplicationTemplateComponent("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]"),
                Force = false,
            };
            // Make the request
            designCenterClient.DeleteComponent(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteComponentAsync</summary>
        public async Task DeleteComponentRequestObjectAsync()
        {
            // Snippet: DeleteComponentAsync(DeleteComponentRequest, CallSettings)
            // Additional: DeleteComponentAsync(DeleteComponentRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteComponentRequest request = new DeleteComponentRequest
            {
                ComponentName = ComponentName.FromProjectLocationSpaceApplicationTemplateComponent("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]"),
                Force = false,
            };
            // Make the request
            await designCenterClient.DeleteComponentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteComponent</summary>
        public void DeleteComponent()
        {
            // Snippet: DeleteComponent(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/components/[COMPONENT]";
            // Make the request
            designCenterClient.DeleteComponent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteComponentAsync</summary>
        public async Task DeleteComponentAsync()
        {
            // Snippet: DeleteComponentAsync(string, CallSettings)
            // Additional: DeleteComponentAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/components/[COMPONENT]";
            // Make the request
            await designCenterClient.DeleteComponentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteComponent</summary>
        public void DeleteComponentResourceNames()
        {
            // Snippet: DeleteComponent(ComponentName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ComponentName name = ComponentName.FromProjectLocationSpaceApplicationTemplateComponent("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]");
            // Make the request
            designCenterClient.DeleteComponent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteComponentAsync</summary>
        public async Task DeleteComponentResourceNamesAsync()
        {
            // Snippet: DeleteComponentAsync(ComponentName, CallSettings)
            // Additional: DeleteComponentAsync(ComponentName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ComponentName name = ComponentName.FromProjectLocationSpaceApplicationTemplateComponent("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]");
            // Make the request
            await designCenterClient.DeleteComponentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnectionRequestObject()
        {
            // Snippet: GetConnection(GetConnectionRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationSpaceApplicationTemplateComponentConnection("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]", "[CONNECTION]"),
            };
            // Make the request
            Connection response = designCenterClient.GetConnection(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionRequestObjectAsync()
        {
            // Snippet: GetConnectionAsync(GetConnectionRequest, CallSettings)
            // Additional: GetConnectionAsync(GetConnectionRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationSpaceApplicationTemplateComponentConnection("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]", "[CONNECTION]"),
            };
            // Make the request
            Connection response = await designCenterClient.GetConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnection()
        {
            // Snippet: GetConnection(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/components/[COMPONENT]/connections/[CONNECTION]";
            // Make the request
            Connection response = designCenterClient.GetConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionAsync()
        {
            // Snippet: GetConnectionAsync(string, CallSettings)
            // Additional: GetConnectionAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/components/[COMPONENT]/connections/[CONNECTION]";
            // Make the request
            Connection response = await designCenterClient.GetConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnectionResourceNames()
        {
            // Snippet: GetConnection(ConnectionName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationSpaceApplicationTemplateComponentConnection("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]", "[CONNECTION]");
            // Make the request
            Connection response = designCenterClient.GetConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionResourceNamesAsync()
        {
            // Snippet: GetConnectionAsync(ConnectionName, CallSettings)
            // Additional: GetConnectionAsync(ConnectionName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationSpaceApplicationTemplateComponentConnection("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]", "[CONNECTION]");
            // Make the request
            Connection response = await designCenterClient.GetConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConnections</summary>
        public void ListConnectionsRequestObject()
        {
            // Snippet: ListConnections(ListConnectionsRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ListConnectionsRequest request = new ListConnectionsRequest
            {
                ParentAsComponentName = ComponentName.FromProjectLocationSpaceApplicationTemplateComponent("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListConnectionsResponse, Connection> response = designCenterClient.ListConnections(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionsAsync</summary>
        public async Task ListConnectionsRequestObjectAsync()
        {
            // Snippet: ListConnectionsAsync(ListConnectionsRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListConnectionsRequest request = new ListConnectionsRequest
            {
                ParentAsComponentName = ComponentName.FromProjectLocationSpaceApplicationTemplateComponent("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListConnectionsResponse, Connection> response = designCenterClient.ListConnectionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnections</summary>
        public void ListConnections()
        {
            // Snippet: ListConnections(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/components/[COMPONENT]";
            // Make the request
            PagedEnumerable<ListConnectionsResponse, Connection> response = designCenterClient.ListConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionsAsync</summary>
        public async Task ListConnectionsAsync()
        {
            // Snippet: ListConnectionsAsync(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/components/[COMPONENT]";
            // Make the request
            PagedAsyncEnumerable<ListConnectionsResponse, Connection> response = designCenterClient.ListConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnections</summary>
        public void ListConnectionsResourceNames()
        {
            // Snippet: ListConnections(ComponentName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ComponentName parent = ComponentName.FromProjectLocationSpaceApplicationTemplateComponent("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]");
            // Make the request
            PagedEnumerable<ListConnectionsResponse, Connection> response = designCenterClient.ListConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionsAsync</summary>
        public async Task ListConnectionsResourceNamesAsync()
        {
            // Snippet: ListConnectionsAsync(ComponentName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ComponentName parent = ComponentName.FromProjectLocationSpaceApplicationTemplateComponent("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]");
            // Make the request
            PagedAsyncEnumerable<ListConnectionsResponse, Connection> response = designCenterClient.ListConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateConnection</summary>
        public void CreateConnectionRequestObject()
        {
            // Snippet: CreateConnection(CreateConnectionRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsComponentName = ComponentName.FromProjectLocationSpaceApplicationTemplateComponent("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]"),
                ConnectionId = "",
                Connection = new Connection(),
            };
            // Make the request
            Connection response = designCenterClient.CreateConnection(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionAsync</summary>
        public async Task CreateConnectionRequestObjectAsync()
        {
            // Snippet: CreateConnectionAsync(CreateConnectionRequest, CallSettings)
            // Additional: CreateConnectionAsync(CreateConnectionRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsComponentName = ComponentName.FromProjectLocationSpaceApplicationTemplateComponent("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]"),
                ConnectionId = "",
                Connection = new Connection(),
            };
            // Make the request
            Connection response = await designCenterClient.CreateConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConnection</summary>
        public void CreateConnection()
        {
            // Snippet: CreateConnection(string, Connection, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/components/[COMPONENT]";
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Connection response = designCenterClient.CreateConnection(parent, connection, connectionId);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionAsync</summary>
        public async Task CreateConnectionAsync()
        {
            // Snippet: CreateConnectionAsync(string, Connection, string, CallSettings)
            // Additional: CreateConnectionAsync(string, Connection, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/components/[COMPONENT]";
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Connection response = await designCenterClient.CreateConnectionAsync(parent, connection, connectionId);
            // End snippet
        }

        /// <summary>Snippet for CreateConnection</summary>
        public void CreateConnectionResourceNames()
        {
            // Snippet: CreateConnection(ComponentName, Connection, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ComponentName parent = ComponentName.FromProjectLocationSpaceApplicationTemplateComponent("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]");
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Connection response = designCenterClient.CreateConnection(parent, connection, connectionId);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionAsync</summary>
        public async Task CreateConnectionResourceNamesAsync()
        {
            // Snippet: CreateConnectionAsync(ComponentName, Connection, string, CallSettings)
            // Additional: CreateConnectionAsync(ComponentName, Connection, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ComponentName parent = ComponentName.FromProjectLocationSpaceApplicationTemplateComponent("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]");
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Connection response = await designCenterClient.CreateConnectionAsync(parent, connection, connectionId);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnection</summary>
        public void UpdateConnectionRequestObject()
        {
            // Snippet: UpdateConnection(UpdateConnectionRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                UpdateMask = new FieldMask(),
                Connection = new Connection(),
            };
            // Make the request
            Connection response = designCenterClient.UpdateConnection(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionAsync</summary>
        public async Task UpdateConnectionRequestObjectAsync()
        {
            // Snippet: UpdateConnectionAsync(UpdateConnectionRequest, CallSettings)
            // Additional: UpdateConnectionAsync(UpdateConnectionRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                UpdateMask = new FieldMask(),
                Connection = new Connection(),
            };
            // Make the request
            Connection response = await designCenterClient.UpdateConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnection</summary>
        public void UpdateConnection()
        {
            // Snippet: UpdateConnection(Connection, FieldMask, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            Connection connection = new Connection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Connection response = designCenterClient.UpdateConnection(connection, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionAsync</summary>
        public async Task UpdateConnectionAsync()
        {
            // Snippet: UpdateConnectionAsync(Connection, FieldMask, CallSettings)
            // Additional: UpdateConnectionAsync(Connection, FieldMask, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            Connection connection = new Connection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Connection response = await designCenterClient.UpdateConnectionAsync(connection, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnection</summary>
        public void DeleteConnectionRequestObject()
        {
            // Snippet: DeleteConnection(DeleteConnectionRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationSpaceApplicationTemplateComponentConnection("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]", "[CONNECTION]"),
            };
            // Make the request
            designCenterClient.DeleteConnection(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionAsync</summary>
        public async Task DeleteConnectionRequestObjectAsync()
        {
            // Snippet: DeleteConnectionAsync(DeleteConnectionRequest, CallSettings)
            // Additional: DeleteConnectionAsync(DeleteConnectionRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationSpaceApplicationTemplateComponentConnection("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]", "[CONNECTION]"),
            };
            // Make the request
            await designCenterClient.DeleteConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnection</summary>
        public void DeleteConnection()
        {
            // Snippet: DeleteConnection(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/components/[COMPONENT]/connections/[CONNECTION]";
            // Make the request
            designCenterClient.DeleteConnection(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionAsync</summary>
        public async Task DeleteConnectionAsync()
        {
            // Snippet: DeleteConnectionAsync(string, CallSettings)
            // Additional: DeleteConnectionAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/components/[COMPONENT]/connections/[CONNECTION]";
            // Make the request
            await designCenterClient.DeleteConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnection</summary>
        public void DeleteConnectionResourceNames()
        {
            // Snippet: DeleteConnection(ConnectionName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationSpaceApplicationTemplateComponentConnection("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]", "[CONNECTION]");
            // Make the request
            designCenterClient.DeleteConnection(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionAsync</summary>
        public async Task DeleteConnectionResourceNamesAsync()
        {
            // Snippet: DeleteConnectionAsync(ConnectionName, CallSettings)
            // Additional: DeleteConnectionAsync(ConnectionName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationSpaceApplicationTemplateComponentConnection("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[COMPONENT]", "[CONNECTION]");
            // Make the request
            await designCenterClient.DeleteConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplateRevision</summary>
        public void GetApplicationTemplateRevisionRequestObject()
        {
            // Snippet: GetApplicationTemplateRevision(GetApplicationTemplateRevisionRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GetApplicationTemplateRevisionRequest request = new GetApplicationTemplateRevisionRequest
            {
                ApplicationTemplateRevisionName = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]"),
            };
            // Make the request
            ApplicationTemplateRevision response = designCenterClient.GetApplicationTemplateRevision(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplateRevisionAsync</summary>
        public async Task GetApplicationTemplateRevisionRequestObjectAsync()
        {
            // Snippet: GetApplicationTemplateRevisionAsync(GetApplicationTemplateRevisionRequest, CallSettings)
            // Additional: GetApplicationTemplateRevisionAsync(GetApplicationTemplateRevisionRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetApplicationTemplateRevisionRequest request = new GetApplicationTemplateRevisionRequest
            {
                ApplicationTemplateRevisionName = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]"),
            };
            // Make the request
            ApplicationTemplateRevision response = await designCenterClient.GetApplicationTemplateRevisionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplateRevision</summary>
        public void GetApplicationTemplateRevision()
        {
            // Snippet: GetApplicationTemplateRevision(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/revisions/[REVISION]";
            // Make the request
            ApplicationTemplateRevision response = designCenterClient.GetApplicationTemplateRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplateRevisionAsync</summary>
        public async Task GetApplicationTemplateRevisionAsync()
        {
            // Snippet: GetApplicationTemplateRevisionAsync(string, CallSettings)
            // Additional: GetApplicationTemplateRevisionAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/revisions/[REVISION]";
            // Make the request
            ApplicationTemplateRevision response = await designCenterClient.GetApplicationTemplateRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplateRevision</summary>
        public void GetApplicationTemplateRevisionResourceNames()
        {
            // Snippet: GetApplicationTemplateRevision(ApplicationTemplateRevisionName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateRevisionName name = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]");
            // Make the request
            ApplicationTemplateRevision response = designCenterClient.GetApplicationTemplateRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplateRevisionAsync</summary>
        public async Task GetApplicationTemplateRevisionResourceNamesAsync()
        {
            // Snippet: GetApplicationTemplateRevisionAsync(ApplicationTemplateRevisionName, CallSettings)
            // Additional: GetApplicationTemplateRevisionAsync(ApplicationTemplateRevisionName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateRevisionName name = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]");
            // Make the request
            ApplicationTemplateRevision response = await designCenterClient.GetApplicationTemplateRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplateRevisions</summary>
        public void ListApplicationTemplateRevisionsRequestObject()
        {
            // Snippet: ListApplicationTemplateRevisions(ListApplicationTemplateRevisionsRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ListApplicationTemplateRevisionsRequest request = new ListApplicationTemplateRevisionsRequest
            {
                ParentAsApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListApplicationTemplateRevisionsResponse, ApplicationTemplateRevision> response = designCenterClient.ListApplicationTemplateRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApplicationTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplateRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplateRevisionsAsync</summary>
        public async Task ListApplicationTemplateRevisionsRequestObjectAsync()
        {
            // Snippet: ListApplicationTemplateRevisionsAsync(ListApplicationTemplateRevisionsRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListApplicationTemplateRevisionsRequest request = new ListApplicationTemplateRevisionsRequest
            {
                ParentAsApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListApplicationTemplateRevisionsResponse, ApplicationTemplateRevision> response = designCenterClient.ListApplicationTemplateRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ApplicationTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListApplicationTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplateRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplateRevisions</summary>
        public void ListApplicationTemplateRevisions()
        {
            // Snippet: ListApplicationTemplateRevisions(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            PagedEnumerable<ListApplicationTemplateRevisionsResponse, ApplicationTemplateRevision> response = designCenterClient.ListApplicationTemplateRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApplicationTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplateRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplateRevisionsAsync</summary>
        public async Task ListApplicationTemplateRevisionsAsync()
        {
            // Snippet: ListApplicationTemplateRevisionsAsync(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            PagedAsyncEnumerable<ListApplicationTemplateRevisionsResponse, ApplicationTemplateRevision> response = designCenterClient.ListApplicationTemplateRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ApplicationTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListApplicationTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplateRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplateRevisions</summary>
        public void ListApplicationTemplateRevisionsResourceNames()
        {
            // Snippet: ListApplicationTemplateRevisions(ApplicationTemplateName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateName parent = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            PagedEnumerable<ListApplicationTemplateRevisionsResponse, ApplicationTemplateRevision> response = designCenterClient.ListApplicationTemplateRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApplicationTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplateRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplateRevisionsAsync</summary>
        public async Task ListApplicationTemplateRevisionsResourceNamesAsync()
        {
            // Snippet: ListApplicationTemplateRevisionsAsync(ApplicationTemplateName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateName parent = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            PagedAsyncEnumerable<ListApplicationTemplateRevisionsResponse, ApplicationTemplateRevision> response = designCenterClient.ListApplicationTemplateRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ApplicationTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListApplicationTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplateRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationTemplateRevision</summary>
        public void DeleteApplicationTemplateRevisionRequestObject()
        {
            // Snippet: DeleteApplicationTemplateRevision(DeleteApplicationTemplateRevisionRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            DeleteApplicationTemplateRevisionRequest request = new DeleteApplicationTemplateRevisionRequest
            {
                ApplicationTemplateRevisionName = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]"),
            };
            // Make the request
            designCenterClient.DeleteApplicationTemplateRevision(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationTemplateRevisionAsync</summary>
        public async Task DeleteApplicationTemplateRevisionRequestObjectAsync()
        {
            // Snippet: DeleteApplicationTemplateRevisionAsync(DeleteApplicationTemplateRevisionRequest, CallSettings)
            // Additional: DeleteApplicationTemplateRevisionAsync(DeleteApplicationTemplateRevisionRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteApplicationTemplateRevisionRequest request = new DeleteApplicationTemplateRevisionRequest
            {
                ApplicationTemplateRevisionName = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]"),
            };
            // Make the request
            await designCenterClient.DeleteApplicationTemplateRevisionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationTemplateRevision</summary>
        public void DeleteApplicationTemplateRevision()
        {
            // Snippet: DeleteApplicationTemplateRevision(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/revisions/[REVISION]";
            // Make the request
            designCenterClient.DeleteApplicationTemplateRevision(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationTemplateRevisionAsync</summary>
        public async Task DeleteApplicationTemplateRevisionAsync()
        {
            // Snippet: DeleteApplicationTemplateRevisionAsync(string, CallSettings)
            // Additional: DeleteApplicationTemplateRevisionAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/revisions/[REVISION]";
            // Make the request
            await designCenterClient.DeleteApplicationTemplateRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationTemplateRevision</summary>
        public void DeleteApplicationTemplateRevisionResourceNames()
        {
            // Snippet: DeleteApplicationTemplateRevision(ApplicationTemplateRevisionName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateRevisionName name = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]");
            // Make the request
            designCenterClient.DeleteApplicationTemplateRevision(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationTemplateRevisionAsync</summary>
        public async Task DeleteApplicationTemplateRevisionResourceNamesAsync()
        {
            // Snippet: DeleteApplicationTemplateRevisionAsync(ApplicationTemplateRevisionName, CallSettings)
            // Additional: DeleteApplicationTemplateRevisionAsync(ApplicationTemplateRevisionName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateRevisionName name = ApplicationTemplateRevisionName.FromProjectLocationSpaceApplicationTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[REVISION]");
            // Make the request
            await designCenterClient.DeleteApplicationTemplateRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCatalog</summary>
        public void GetCatalogRequestObject()
        {
            // Snippet: GetCatalog(GetCatalogRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GetCatalogRequest request = new GetCatalogRequest
            {
                CatalogName = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]"),
            };
            // Make the request
            Catalog response = designCenterClient.GetCatalog(request);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogAsync</summary>
        public async Task GetCatalogRequestObjectAsync()
        {
            // Snippet: GetCatalogAsync(GetCatalogRequest, CallSettings)
            // Additional: GetCatalogAsync(GetCatalogRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetCatalogRequest request = new GetCatalogRequest
            {
                CatalogName = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]"),
            };
            // Make the request
            Catalog response = await designCenterClient.GetCatalogAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCatalog</summary>
        public void GetCatalog()
        {
            // Snippet: GetCatalog(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]";
            // Make the request
            Catalog response = designCenterClient.GetCatalog(name);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogAsync</summary>
        public async Task GetCatalogAsync()
        {
            // Snippet: GetCatalogAsync(string, CallSettings)
            // Additional: GetCatalogAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]";
            // Make the request
            Catalog response = await designCenterClient.GetCatalogAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCatalog</summary>
        public void GetCatalogResourceNames()
        {
            // Snippet: GetCatalog(CatalogName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CatalogName name = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]");
            // Make the request
            Catalog response = designCenterClient.GetCatalog(name);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogAsync</summary>
        public async Task GetCatalogResourceNamesAsync()
        {
            // Snippet: GetCatalogAsync(CatalogName, CallSettings)
            // Additional: GetCatalogAsync(CatalogName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName name = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]");
            // Make the request
            Catalog response = await designCenterClient.GetCatalogAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCatalogs</summary>
        public void ListCatalogsRequestObject()
        {
            // Snippet: ListCatalogs(ListCatalogsRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ListCatalogsRequest request = new ListCatalogsRequest
            {
                ParentAsSpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCatalogsResponse, Catalog> response = designCenterClient.ListCatalogs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Catalog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCatalogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Catalog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Catalog> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Catalog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogsAsync</summary>
        public async Task ListCatalogsRequestObjectAsync()
        {
            // Snippet: ListCatalogsAsync(ListCatalogsRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListCatalogsRequest request = new ListCatalogsRequest
            {
                ParentAsSpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCatalogsResponse, Catalog> response = designCenterClient.ListCatalogsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Catalog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCatalogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Catalog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Catalog> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Catalog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogs</summary>
        public void ListCatalogs()
        {
            // Snippet: ListCatalogs(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            // Make the request
            PagedEnumerable<ListCatalogsResponse, Catalog> response = designCenterClient.ListCatalogs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Catalog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCatalogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Catalog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Catalog> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Catalog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogsAsync</summary>
        public async Task ListCatalogsAsync()
        {
            // Snippet: ListCatalogsAsync(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            // Make the request
            PagedAsyncEnumerable<ListCatalogsResponse, Catalog> response = designCenterClient.ListCatalogsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Catalog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCatalogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Catalog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Catalog> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Catalog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogs</summary>
        public void ListCatalogsResourceNames()
        {
            // Snippet: ListCatalogs(SpaceName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            // Make the request
            PagedEnumerable<ListCatalogsResponse, Catalog> response = designCenterClient.ListCatalogs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Catalog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCatalogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Catalog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Catalog> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Catalog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogsAsync</summary>
        public async Task ListCatalogsResourceNamesAsync()
        {
            // Snippet: ListCatalogsAsync(SpaceName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            // Make the request
            PagedAsyncEnumerable<ListCatalogsResponse, Catalog> response = designCenterClient.ListCatalogsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Catalog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCatalogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Catalog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Catalog> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Catalog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateCatalog</summary>
        public void CreateCatalogRequestObject()
        {
            // Snippet: CreateCatalog(CreateCatalogRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CreateCatalogRequest request = new CreateCatalogRequest
            {
                ParentAsSpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                CatalogId = "",
                Catalog = new Catalog(),
            };
            // Make the request
            Catalog response = designCenterClient.CreateCatalog(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogAsync</summary>
        public async Task CreateCatalogRequestObjectAsync()
        {
            // Snippet: CreateCatalogAsync(CreateCatalogRequest, CallSettings)
            // Additional: CreateCatalogAsync(CreateCatalogRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateCatalogRequest request = new CreateCatalogRequest
            {
                ParentAsSpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                CatalogId = "",
                Catalog = new Catalog(),
            };
            // Make the request
            Catalog response = await designCenterClient.CreateCatalogAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCatalog</summary>
        public void CreateCatalog()
        {
            // Snippet: CreateCatalog(string, Catalog, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            Catalog catalog = new Catalog();
            string catalogId = "";
            // Make the request
            Catalog response = designCenterClient.CreateCatalog(parent, catalog, catalogId);
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogAsync</summary>
        public async Task CreateCatalogAsync()
        {
            // Snippet: CreateCatalogAsync(string, Catalog, string, CallSettings)
            // Additional: CreateCatalogAsync(string, Catalog, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            Catalog catalog = new Catalog();
            string catalogId = "";
            // Make the request
            Catalog response = await designCenterClient.CreateCatalogAsync(parent, catalog, catalogId);
            // End snippet
        }

        /// <summary>Snippet for CreateCatalog</summary>
        public void CreateCatalogResourceNames()
        {
            // Snippet: CreateCatalog(SpaceName, Catalog, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            Catalog catalog = new Catalog();
            string catalogId = "";
            // Make the request
            Catalog response = designCenterClient.CreateCatalog(parent, catalog, catalogId);
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogAsync</summary>
        public async Task CreateCatalogResourceNamesAsync()
        {
            // Snippet: CreateCatalogAsync(SpaceName, Catalog, string, CallSettings)
            // Additional: CreateCatalogAsync(SpaceName, Catalog, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            Catalog catalog = new Catalog();
            string catalogId = "";
            // Make the request
            Catalog response = await designCenterClient.CreateCatalogAsync(parent, catalog, catalogId);
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalog</summary>
        public void UpdateCatalogRequestObject()
        {
            // Snippet: UpdateCatalog(UpdateCatalogRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            UpdateCatalogRequest request = new UpdateCatalogRequest
            {
                UpdateMask = new FieldMask(),
                Catalog = new Catalog(),
            };
            // Make the request
            Catalog response = designCenterClient.UpdateCatalog(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalogAsync</summary>
        public async Task UpdateCatalogRequestObjectAsync()
        {
            // Snippet: UpdateCatalogAsync(UpdateCatalogRequest, CallSettings)
            // Additional: UpdateCatalogAsync(UpdateCatalogRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCatalogRequest request = new UpdateCatalogRequest
            {
                UpdateMask = new FieldMask(),
                Catalog = new Catalog(),
            };
            // Make the request
            Catalog response = await designCenterClient.UpdateCatalogAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalog</summary>
        public void UpdateCatalog()
        {
            // Snippet: UpdateCatalog(Catalog, FieldMask, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            Catalog catalog = new Catalog();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Catalog response = designCenterClient.UpdateCatalog(catalog, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalogAsync</summary>
        public async Task UpdateCatalogAsync()
        {
            // Snippet: UpdateCatalogAsync(Catalog, FieldMask, CallSettings)
            // Additional: UpdateCatalogAsync(Catalog, FieldMask, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            Catalog catalog = new Catalog();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Catalog response = await designCenterClient.UpdateCatalogAsync(catalog, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalog</summary>
        public void DeleteCatalogRequestObject()
        {
            // Snippet: DeleteCatalog(DeleteCatalogRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            DeleteCatalogRequest request = new DeleteCatalogRequest
            {
                CatalogName = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = designCenterClient.DeleteCatalog(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeleteCatalog(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogAsync</summary>
        public async Task DeleteCatalogRequestObjectAsync()
        {
            // Snippet: DeleteCatalogAsync(DeleteCatalogRequest, CallSettings)
            // Additional: DeleteCatalogAsync(DeleteCatalogRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCatalogRequest request = new DeleteCatalogRequest
            {
                CatalogName = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await designCenterClient.DeleteCatalogAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeleteCatalogAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalog</summary>
        public void DeleteCatalog()
        {
            // Snippet: DeleteCatalog(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = designCenterClient.DeleteCatalog(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeleteCatalog(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogAsync</summary>
        public async Task DeleteCatalogAsync()
        {
            // Snippet: DeleteCatalogAsync(string, CallSettings)
            // Additional: DeleteCatalogAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await designCenterClient.DeleteCatalogAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeleteCatalogAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalog</summary>
        public void DeleteCatalogResourceNames()
        {
            // Snippet: DeleteCatalog(CatalogName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CatalogName name = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = designCenterClient.DeleteCatalog(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeleteCatalog(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogAsync</summary>
        public async Task DeleteCatalogResourceNamesAsync()
        {
            // Snippet: DeleteCatalogAsync(CatalogName, CallSettings)
            // Additional: DeleteCatalogAsync(CatalogName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName name = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await designCenterClient.DeleteCatalogAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeleteCatalogAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogTemplate</summary>
        public void CreateCatalogTemplateRequestObject()
        {
            // Snippet: CreateCatalogTemplate(CreateCatalogTemplateRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CreateCatalogTemplateRequest request = new CreateCatalogTemplateRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]"),
                CatalogTemplateId = "",
                CatalogTemplate = new CatalogTemplate(),
            };
            // Make the request
            CatalogTemplate response = designCenterClient.CreateCatalogTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogTemplateAsync</summary>
        public async Task CreateCatalogTemplateRequestObjectAsync()
        {
            // Snippet: CreateCatalogTemplateAsync(CreateCatalogTemplateRequest, CallSettings)
            // Additional: CreateCatalogTemplateAsync(CreateCatalogTemplateRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateCatalogTemplateRequest request = new CreateCatalogTemplateRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]"),
                CatalogTemplateId = "",
                CatalogTemplate = new CatalogTemplate(),
            };
            // Make the request
            CatalogTemplate response = await designCenterClient.CreateCatalogTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogTemplate</summary>
        public void CreateCatalogTemplate()
        {
            // Snippet: CreateCatalogTemplate(string, CatalogTemplate, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]";
            CatalogTemplate catalogTemplate = new CatalogTemplate();
            string catalogTemplateId = "";
            // Make the request
            CatalogTemplate response = designCenterClient.CreateCatalogTemplate(parent, catalogTemplate, catalogTemplateId);
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogTemplateAsync</summary>
        public async Task CreateCatalogTemplateAsync()
        {
            // Snippet: CreateCatalogTemplateAsync(string, CatalogTemplate, string, CallSettings)
            // Additional: CreateCatalogTemplateAsync(string, CatalogTemplate, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]";
            CatalogTemplate catalogTemplate = new CatalogTemplate();
            string catalogTemplateId = "";
            // Make the request
            CatalogTemplate response = await designCenterClient.CreateCatalogTemplateAsync(parent, catalogTemplate, catalogTemplateId);
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogTemplate</summary>
        public void CreateCatalogTemplateResourceNames()
        {
            // Snippet: CreateCatalogTemplate(CatalogName, CatalogTemplate, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]");
            CatalogTemplate catalogTemplate = new CatalogTemplate();
            string catalogTemplateId = "";
            // Make the request
            CatalogTemplate response = designCenterClient.CreateCatalogTemplate(parent, catalogTemplate, catalogTemplateId);
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogTemplateAsync</summary>
        public async Task CreateCatalogTemplateResourceNamesAsync()
        {
            // Snippet: CreateCatalogTemplateAsync(CatalogName, CatalogTemplate, string, CallSettings)
            // Additional: CreateCatalogTemplateAsync(CatalogName, CatalogTemplate, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]");
            CatalogTemplate catalogTemplate = new CatalogTemplate();
            string catalogTemplateId = "";
            // Make the request
            CatalogTemplate response = await designCenterClient.CreateCatalogTemplateAsync(parent, catalogTemplate, catalogTemplateId);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogTemplate</summary>
        public void GetCatalogTemplateRequestObject()
        {
            // Snippet: GetCatalogTemplate(GetCatalogTemplateRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GetCatalogTemplateRequest request = new GetCatalogTemplateRequest
            {
                CatalogTemplateName = CatalogTemplateName.FromProjectLocationSpaceCatalogCatalogTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]"),
            };
            // Make the request
            CatalogTemplate response = designCenterClient.GetCatalogTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogTemplateAsync</summary>
        public async Task GetCatalogTemplateRequestObjectAsync()
        {
            // Snippet: GetCatalogTemplateAsync(GetCatalogTemplateRequest, CallSettings)
            // Additional: GetCatalogTemplateAsync(GetCatalogTemplateRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetCatalogTemplateRequest request = new GetCatalogTemplateRequest
            {
                CatalogTemplateName = CatalogTemplateName.FromProjectLocationSpaceCatalogCatalogTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]"),
            };
            // Make the request
            CatalogTemplate response = await designCenterClient.GetCatalogTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogTemplate</summary>
        public void GetCatalogTemplate()
        {
            // Snippet: GetCatalogTemplate(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/templates/[CATALOG_TEMPLATE]";
            // Make the request
            CatalogTemplate response = designCenterClient.GetCatalogTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogTemplateAsync</summary>
        public async Task GetCatalogTemplateAsync()
        {
            // Snippet: GetCatalogTemplateAsync(string, CallSettings)
            // Additional: GetCatalogTemplateAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/templates/[CATALOG_TEMPLATE]";
            // Make the request
            CatalogTemplate response = await designCenterClient.GetCatalogTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogTemplate</summary>
        public void GetCatalogTemplateResourceNames()
        {
            // Snippet: GetCatalogTemplate(CatalogTemplateName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CatalogTemplateName name = CatalogTemplateName.FromProjectLocationSpaceCatalogCatalogTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]");
            // Make the request
            CatalogTemplate response = designCenterClient.GetCatalogTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogTemplateAsync</summary>
        public async Task GetCatalogTemplateResourceNamesAsync()
        {
            // Snippet: GetCatalogTemplateAsync(CatalogTemplateName, CallSettings)
            // Additional: GetCatalogTemplateAsync(CatalogTemplateName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CatalogTemplateName name = CatalogTemplateName.FromProjectLocationSpaceCatalogCatalogTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]");
            // Make the request
            CatalogTemplate response = await designCenterClient.GetCatalogTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCatalogTemplates</summary>
        public void ListCatalogTemplatesRequestObject()
        {
            // Snippet: ListCatalogTemplates(ListCatalogTemplatesRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ListCatalogTemplatesRequest request = new ListCatalogTemplatesRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCatalogTemplatesResponse, CatalogTemplate> response = designCenterClient.ListCatalogTemplates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CatalogTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCatalogTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogTemplatesAsync</summary>
        public async Task ListCatalogTemplatesRequestObjectAsync()
        {
            // Snippet: ListCatalogTemplatesAsync(ListCatalogTemplatesRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListCatalogTemplatesRequest request = new ListCatalogTemplatesRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCatalogTemplatesResponse, CatalogTemplate> response = designCenterClient.ListCatalogTemplatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CatalogTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCatalogTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogTemplates</summary>
        public void ListCatalogTemplates()
        {
            // Snippet: ListCatalogTemplates(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]";
            // Make the request
            PagedEnumerable<ListCatalogTemplatesResponse, CatalogTemplate> response = designCenterClient.ListCatalogTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CatalogTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCatalogTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogTemplatesAsync</summary>
        public async Task ListCatalogTemplatesAsync()
        {
            // Snippet: ListCatalogTemplatesAsync(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]";
            // Make the request
            PagedAsyncEnumerable<ListCatalogTemplatesResponse, CatalogTemplate> response = designCenterClient.ListCatalogTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CatalogTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCatalogTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogTemplates</summary>
        public void ListCatalogTemplatesResourceNames()
        {
            // Snippet: ListCatalogTemplates(CatalogName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]");
            // Make the request
            PagedEnumerable<ListCatalogTemplatesResponse, CatalogTemplate> response = designCenterClient.ListCatalogTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CatalogTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCatalogTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogTemplatesAsync</summary>
        public async Task ListCatalogTemplatesResourceNamesAsync()
        {
            // Snippet: ListCatalogTemplatesAsync(CatalogName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]");
            // Make the request
            PagedAsyncEnumerable<ListCatalogTemplatesResponse, CatalogTemplate> response = designCenterClient.ListCatalogTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CatalogTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCatalogTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalogTemplate</summary>
        public void UpdateCatalogTemplateRequestObject()
        {
            // Snippet: UpdateCatalogTemplate(UpdateCatalogTemplateRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            UpdateCatalogTemplateRequest request = new UpdateCatalogTemplateRequest
            {
                UpdateMask = new FieldMask(),
                CatalogTemplate = new CatalogTemplate(),
            };
            // Make the request
            CatalogTemplate response = designCenterClient.UpdateCatalogTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalogTemplateAsync</summary>
        public async Task UpdateCatalogTemplateRequestObjectAsync()
        {
            // Snippet: UpdateCatalogTemplateAsync(UpdateCatalogTemplateRequest, CallSettings)
            // Additional: UpdateCatalogTemplateAsync(UpdateCatalogTemplateRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCatalogTemplateRequest request = new UpdateCatalogTemplateRequest
            {
                UpdateMask = new FieldMask(),
                CatalogTemplate = new CatalogTemplate(),
            };
            // Make the request
            CatalogTemplate response = await designCenterClient.UpdateCatalogTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalogTemplate</summary>
        public void UpdateCatalogTemplate()
        {
            // Snippet: UpdateCatalogTemplate(CatalogTemplate, FieldMask, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CatalogTemplate catalogTemplate = new CatalogTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CatalogTemplate response = designCenterClient.UpdateCatalogTemplate(catalogTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalogTemplateAsync</summary>
        public async Task UpdateCatalogTemplateAsync()
        {
            // Snippet: UpdateCatalogTemplateAsync(CatalogTemplate, FieldMask, CallSettings)
            // Additional: UpdateCatalogTemplateAsync(CatalogTemplate, FieldMask, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CatalogTemplate catalogTemplate = new CatalogTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CatalogTemplate response = await designCenterClient.UpdateCatalogTemplateAsync(catalogTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogTemplate</summary>
        public void DeleteCatalogTemplateRequestObject()
        {
            // Snippet: DeleteCatalogTemplate(DeleteCatalogTemplateRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            DeleteCatalogTemplateRequest request = new DeleteCatalogTemplateRequest
            {
                CatalogTemplateName = CatalogTemplateName.FromProjectLocationSpaceCatalogCatalogTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = designCenterClient.DeleteCatalogTemplate(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeleteCatalogTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogTemplateAsync</summary>
        public async Task DeleteCatalogTemplateRequestObjectAsync()
        {
            // Snippet: DeleteCatalogTemplateAsync(DeleteCatalogTemplateRequest, CallSettings)
            // Additional: DeleteCatalogTemplateAsync(DeleteCatalogTemplateRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCatalogTemplateRequest request = new DeleteCatalogTemplateRequest
            {
                CatalogTemplateName = CatalogTemplateName.FromProjectLocationSpaceCatalogCatalogTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await designCenterClient.DeleteCatalogTemplateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeleteCatalogTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogTemplate</summary>
        public void DeleteCatalogTemplate()
        {
            // Snippet: DeleteCatalogTemplate(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/templates/[CATALOG_TEMPLATE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = designCenterClient.DeleteCatalogTemplate(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeleteCatalogTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogTemplateAsync</summary>
        public async Task DeleteCatalogTemplateAsync()
        {
            // Snippet: DeleteCatalogTemplateAsync(string, CallSettings)
            // Additional: DeleteCatalogTemplateAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/templates/[CATALOG_TEMPLATE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await designCenterClient.DeleteCatalogTemplateAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeleteCatalogTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogTemplate</summary>
        public void DeleteCatalogTemplateResourceNames()
        {
            // Snippet: DeleteCatalogTemplate(CatalogTemplateName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CatalogTemplateName name = CatalogTemplateName.FromProjectLocationSpaceCatalogCatalogTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = designCenterClient.DeleteCatalogTemplate(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeleteCatalogTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogTemplateAsync</summary>
        public async Task DeleteCatalogTemplateResourceNamesAsync()
        {
            // Snippet: DeleteCatalogTemplateAsync(CatalogTemplateName, CallSettings)
            // Additional: DeleteCatalogTemplateAsync(CatalogTemplateName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CatalogTemplateName name = CatalogTemplateName.FromProjectLocationSpaceCatalogCatalogTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await designCenterClient.DeleteCatalogTemplateAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeleteCatalogTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateShare</summary>
        public void CreateShareRequestObject()
        {
            // Snippet: CreateShare(CreateShareRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CreateShareRequest request = new CreateShareRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]"),
                ShareId = "",
                Share = new Share(),
            };
            // Make the request
            Operation<Share, OperationMetadata> response = designCenterClient.CreateShare(request);

            // Poll until the returned long-running operation is complete
            Operation<Share, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Share result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Share, OperationMetadata> retrievedResponse = designCenterClient.PollOnceCreateShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Share retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateShareAsync</summary>
        public async Task CreateShareRequestObjectAsync()
        {
            // Snippet: CreateShareAsync(CreateShareRequest, CallSettings)
            // Additional: CreateShareAsync(CreateShareRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateShareRequest request = new CreateShareRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]"),
                ShareId = "",
                Share = new Share(),
            };
            // Make the request
            Operation<Share, OperationMetadata> response = await designCenterClient.CreateShareAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Share, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Share result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Share, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceCreateShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Share retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateShare</summary>
        public void CreateShare()
        {
            // Snippet: CreateShare(string, Share, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]";
            Share share = new Share();
            string shareId = "";
            // Make the request
            Operation<Share, OperationMetadata> response = designCenterClient.CreateShare(parent, share, shareId);

            // Poll until the returned long-running operation is complete
            Operation<Share, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Share result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Share, OperationMetadata> retrievedResponse = designCenterClient.PollOnceCreateShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Share retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateShareAsync</summary>
        public async Task CreateShareAsync()
        {
            // Snippet: CreateShareAsync(string, Share, string, CallSettings)
            // Additional: CreateShareAsync(string, Share, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]";
            Share share = new Share();
            string shareId = "";
            // Make the request
            Operation<Share, OperationMetadata> response = await designCenterClient.CreateShareAsync(parent, share, shareId);

            // Poll until the returned long-running operation is complete
            Operation<Share, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Share result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Share, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceCreateShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Share retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateShare</summary>
        public void CreateShareResourceNames()
        {
            // Snippet: CreateShare(CatalogName, Share, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]");
            Share share = new Share();
            string shareId = "";
            // Make the request
            Operation<Share, OperationMetadata> response = designCenterClient.CreateShare(parent, share, shareId);

            // Poll until the returned long-running operation is complete
            Operation<Share, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Share result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Share, OperationMetadata> retrievedResponse = designCenterClient.PollOnceCreateShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Share retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateShareAsync</summary>
        public async Task CreateShareResourceNamesAsync()
        {
            // Snippet: CreateShareAsync(CatalogName, Share, string, CallSettings)
            // Additional: CreateShareAsync(CatalogName, Share, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]");
            Share share = new Share();
            string shareId = "";
            // Make the request
            Operation<Share, OperationMetadata> response = await designCenterClient.CreateShareAsync(parent, share, shareId);

            // Poll until the returned long-running operation is complete
            Operation<Share, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Share result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Share, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceCreateShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Share retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListShares</summary>
        public void ListSharesRequestObject()
        {
            // Snippet: ListShares(ListSharesRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ListSharesRequest request = new ListSharesRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]"),
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSharesResponse, Share> response = designCenterClient.ListShares(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Share item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSharesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Share item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Share> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Share item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSharesAsync</summary>
        public async Task ListSharesRequestObjectAsync()
        {
            // Snippet: ListSharesAsync(ListSharesRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListSharesRequest request = new ListSharesRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]"),
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSharesResponse, Share> response = designCenterClient.ListSharesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Share item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSharesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Share item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Share> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Share item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListShares</summary>
        public void ListShares()
        {
            // Snippet: ListShares(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]";
            // Make the request
            PagedEnumerable<ListSharesResponse, Share> response = designCenterClient.ListShares(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Share item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSharesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Share item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Share> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Share item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSharesAsync</summary>
        public async Task ListSharesAsync()
        {
            // Snippet: ListSharesAsync(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]";
            // Make the request
            PagedAsyncEnumerable<ListSharesResponse, Share> response = designCenterClient.ListSharesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Share item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSharesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Share item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Share> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Share item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListShares</summary>
        public void ListSharesResourceNames()
        {
            // Snippet: ListShares(CatalogName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]");
            // Make the request
            PagedEnumerable<ListSharesResponse, Share> response = designCenterClient.ListShares(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Share item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSharesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Share item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Share> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Share item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSharesAsync</summary>
        public async Task ListSharesResourceNamesAsync()
        {
            // Snippet: ListSharesAsync(CatalogName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationSpaceCatalog("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]");
            // Make the request
            PagedAsyncEnumerable<ListSharesResponse, Share> response = designCenterClient.ListSharesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Share item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSharesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Share item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Share> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Share item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetShare</summary>
        public void GetShareRequestObject()
        {
            // Snippet: GetShare(GetShareRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GetShareRequest request = new GetShareRequest
            {
                ShareName = ShareName.FromProjectLocationSpaceCatalogShare("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[SHARE]"),
            };
            // Make the request
            Share response = designCenterClient.GetShare(request);
            // End snippet
        }

        /// <summary>Snippet for GetShareAsync</summary>
        public async Task GetShareRequestObjectAsync()
        {
            // Snippet: GetShareAsync(GetShareRequest, CallSettings)
            // Additional: GetShareAsync(GetShareRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetShareRequest request = new GetShareRequest
            {
                ShareName = ShareName.FromProjectLocationSpaceCatalogShare("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[SHARE]"),
            };
            // Make the request
            Share response = await designCenterClient.GetShareAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetShare</summary>
        public void GetShare()
        {
            // Snippet: GetShare(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/shares/[SHARE]";
            // Make the request
            Share response = designCenterClient.GetShare(name);
            // End snippet
        }

        /// <summary>Snippet for GetShareAsync</summary>
        public async Task GetShareAsync()
        {
            // Snippet: GetShareAsync(string, CallSettings)
            // Additional: GetShareAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/shares/[SHARE]";
            // Make the request
            Share response = await designCenterClient.GetShareAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetShare</summary>
        public void GetShareResourceNames()
        {
            // Snippet: GetShare(ShareName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ShareName name = ShareName.FromProjectLocationSpaceCatalogShare("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[SHARE]");
            // Make the request
            Share response = designCenterClient.GetShare(name);
            // End snippet
        }

        /// <summary>Snippet for GetShareAsync</summary>
        public async Task GetShareResourceNamesAsync()
        {
            // Snippet: GetShareAsync(ShareName, CallSettings)
            // Additional: GetShareAsync(ShareName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ShareName name = ShareName.FromProjectLocationSpaceCatalogShare("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[SHARE]");
            // Make the request
            Share response = await designCenterClient.GetShareAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteShare</summary>
        public void DeleteShareRequestObject()
        {
            // Snippet: DeleteShare(DeleteShareRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            DeleteShareRequest request = new DeleteShareRequest
            {
                ShareName = ShareName.FromProjectLocationSpaceCatalogShare("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[SHARE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = designCenterClient.DeleteShare(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeleteShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteShareAsync</summary>
        public async Task DeleteShareRequestObjectAsync()
        {
            // Snippet: DeleteShareAsync(DeleteShareRequest, CallSettings)
            // Additional: DeleteShareAsync(DeleteShareRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteShareRequest request = new DeleteShareRequest
            {
                ShareName = ShareName.FromProjectLocationSpaceCatalogShare("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[SHARE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await designCenterClient.DeleteShareAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeleteShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteShare</summary>
        public void DeleteShare()
        {
            // Snippet: DeleteShare(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/shares/[SHARE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = designCenterClient.DeleteShare(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeleteShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteShareAsync</summary>
        public async Task DeleteShareAsync()
        {
            // Snippet: DeleteShareAsync(string, CallSettings)
            // Additional: DeleteShareAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/shares/[SHARE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await designCenterClient.DeleteShareAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeleteShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteShare</summary>
        public void DeleteShareResourceNames()
        {
            // Snippet: DeleteShare(ShareName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ShareName name = ShareName.FromProjectLocationSpaceCatalogShare("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[SHARE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = designCenterClient.DeleteShare(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeleteShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteShareAsync</summary>
        public async Task DeleteShareResourceNamesAsync()
        {
            // Snippet: DeleteShareAsync(ShareName, CallSettings)
            // Additional: DeleteShareAsync(ShareName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ShareName name = ShareName.FromProjectLocationSpaceCatalogShare("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[SHARE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await designCenterClient.DeleteShareAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeleteShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SyncShare</summary>
        public void SyncShareRequestObject()
        {
            // Snippet: SyncShare(SyncShareRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            SyncShareRequest request = new SyncShareRequest
            {
                ShareName = ShareName.FromProjectLocationSpaceCatalogShare("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[SHARE]"),
            };
            // Make the request
            Operation<Share, OperationMetadata> response = designCenterClient.SyncShare(request);

            // Poll until the returned long-running operation is complete
            Operation<Share, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Share result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Share, OperationMetadata> retrievedResponse = designCenterClient.PollOnceSyncShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Share retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SyncShareAsync</summary>
        public async Task SyncShareRequestObjectAsync()
        {
            // Snippet: SyncShareAsync(SyncShareRequest, CallSettings)
            // Additional: SyncShareAsync(SyncShareRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            SyncShareRequest request = new SyncShareRequest
            {
                ShareName = ShareName.FromProjectLocationSpaceCatalogShare("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[SHARE]"),
            };
            // Make the request
            Operation<Share, OperationMetadata> response = await designCenterClient.SyncShareAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Share, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Share result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Share, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceSyncShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Share retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SyncShare</summary>
        public void SyncShare()
        {
            // Snippet: SyncShare(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/shares/[SHARE]";
            // Make the request
            Operation<Share, OperationMetadata> response = designCenterClient.SyncShare(name);

            // Poll until the returned long-running operation is complete
            Operation<Share, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Share result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Share, OperationMetadata> retrievedResponse = designCenterClient.PollOnceSyncShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Share retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SyncShareAsync</summary>
        public async Task SyncShareAsync()
        {
            // Snippet: SyncShareAsync(string, CallSettings)
            // Additional: SyncShareAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/shares/[SHARE]";
            // Make the request
            Operation<Share, OperationMetadata> response = await designCenterClient.SyncShareAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Share, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Share result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Share, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceSyncShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Share retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SyncShare</summary>
        public void SyncShareResourceNames()
        {
            // Snippet: SyncShare(ShareName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ShareName name = ShareName.FromProjectLocationSpaceCatalogShare("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[SHARE]");
            // Make the request
            Operation<Share, OperationMetadata> response = designCenterClient.SyncShare(name);

            // Poll until the returned long-running operation is complete
            Operation<Share, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Share result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Share, OperationMetadata> retrievedResponse = designCenterClient.PollOnceSyncShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Share retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SyncShareAsync</summary>
        public async Task SyncShareResourceNamesAsync()
        {
            // Snippet: SyncShareAsync(ShareName, CallSettings)
            // Additional: SyncShareAsync(ShareName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ShareName name = ShareName.FromProjectLocationSpaceCatalogShare("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[SHARE]");
            // Make the request
            Operation<Share, OperationMetadata> response = await designCenterClient.SyncShareAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Share, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Share result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Share, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceSyncShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Share retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetSharedTemplate</summary>
        public void GetSharedTemplateRequestObject()
        {
            // Snippet: GetSharedTemplate(GetSharedTemplateRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GetSharedTemplateRequest request = new GetSharedTemplateRequest
            {
                SharedTemplateName = SharedTemplateName.FromProjectLocationSpaceSharedTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[SHARED_TEMPLATE]"),
            };
            // Make the request
            SharedTemplate response = designCenterClient.GetSharedTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetSharedTemplateAsync</summary>
        public async Task GetSharedTemplateRequestObjectAsync()
        {
            // Snippet: GetSharedTemplateAsync(GetSharedTemplateRequest, CallSettings)
            // Additional: GetSharedTemplateAsync(GetSharedTemplateRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetSharedTemplateRequest request = new GetSharedTemplateRequest
            {
                SharedTemplateName = SharedTemplateName.FromProjectLocationSpaceSharedTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[SHARED_TEMPLATE]"),
            };
            // Make the request
            SharedTemplate response = await designCenterClient.GetSharedTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSharedTemplate</summary>
        public void GetSharedTemplate()
        {
            // Snippet: GetSharedTemplate(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/sharedTemplates/[SHARED_TEMPLATE]";
            // Make the request
            SharedTemplate response = designCenterClient.GetSharedTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetSharedTemplateAsync</summary>
        public async Task GetSharedTemplateAsync()
        {
            // Snippet: GetSharedTemplateAsync(string, CallSettings)
            // Additional: GetSharedTemplateAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/sharedTemplates/[SHARED_TEMPLATE]";
            // Make the request
            SharedTemplate response = await designCenterClient.GetSharedTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSharedTemplate</summary>
        public void GetSharedTemplateResourceNames()
        {
            // Snippet: GetSharedTemplate(SharedTemplateName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            SharedTemplateName name = SharedTemplateName.FromProjectLocationSpaceSharedTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[SHARED_TEMPLATE]");
            // Make the request
            SharedTemplate response = designCenterClient.GetSharedTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetSharedTemplateAsync</summary>
        public async Task GetSharedTemplateResourceNamesAsync()
        {
            // Snippet: GetSharedTemplateAsync(SharedTemplateName, CallSettings)
            // Additional: GetSharedTemplateAsync(SharedTemplateName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            SharedTemplateName name = SharedTemplateName.FromProjectLocationSpaceSharedTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[SHARED_TEMPLATE]");
            // Make the request
            SharedTemplate response = await designCenterClient.GetSharedTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSharedTemplates</summary>
        public void ListSharedTemplatesRequestObject()
        {
            // Snippet: ListSharedTemplates(ListSharedTemplatesRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ListSharedTemplatesRequest request = new ListSharedTemplatesRequest
            {
                ParentAsSpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSharedTemplatesResponse, SharedTemplate> response = designCenterClient.ListSharedTemplates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SharedTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSharedTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SharedTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SharedTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SharedTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSharedTemplatesAsync</summary>
        public async Task ListSharedTemplatesRequestObjectAsync()
        {
            // Snippet: ListSharedTemplatesAsync(ListSharedTemplatesRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListSharedTemplatesRequest request = new ListSharedTemplatesRequest
            {
                ParentAsSpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSharedTemplatesResponse, SharedTemplate> response = designCenterClient.ListSharedTemplatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SharedTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSharedTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SharedTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SharedTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SharedTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSharedTemplates</summary>
        public void ListSharedTemplates()
        {
            // Snippet: ListSharedTemplates(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            // Make the request
            PagedEnumerable<ListSharedTemplatesResponse, SharedTemplate> response = designCenterClient.ListSharedTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SharedTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSharedTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SharedTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SharedTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SharedTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSharedTemplatesAsync</summary>
        public async Task ListSharedTemplatesAsync()
        {
            // Snippet: ListSharedTemplatesAsync(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            // Make the request
            PagedAsyncEnumerable<ListSharedTemplatesResponse, SharedTemplate> response = designCenterClient.ListSharedTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SharedTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSharedTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SharedTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SharedTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SharedTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSharedTemplates</summary>
        public void ListSharedTemplatesResourceNames()
        {
            // Snippet: ListSharedTemplates(SpaceName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            // Make the request
            PagedEnumerable<ListSharedTemplatesResponse, SharedTemplate> response = designCenterClient.ListSharedTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SharedTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSharedTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SharedTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SharedTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SharedTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSharedTemplatesAsync</summary>
        public async Task ListSharedTemplatesResourceNamesAsync()
        {
            // Snippet: ListSharedTemplatesAsync(SpaceName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            // Make the request
            PagedAsyncEnumerable<ListSharedTemplatesResponse, SharedTemplate> response = designCenterClient.ListSharedTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SharedTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSharedTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SharedTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SharedTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SharedTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSharedTemplateRevision</summary>
        public void GetSharedTemplateRevisionRequestObject()
        {
            // Snippet: GetSharedTemplateRevision(GetSharedTemplateRevisionRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GetSharedTemplateRevisionRequest request = new GetSharedTemplateRevisionRequest
            {
                SharedTemplateRevisionName = SharedTemplateRevisionName.FromProjectLocationSpaceSharedTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[SHARED_TEMPLATE]", "[REVISION]"),
            };
            // Make the request
            SharedTemplateRevision response = designCenterClient.GetSharedTemplateRevision(request);
            // End snippet
        }

        /// <summary>Snippet for GetSharedTemplateRevisionAsync</summary>
        public async Task GetSharedTemplateRevisionRequestObjectAsync()
        {
            // Snippet: GetSharedTemplateRevisionAsync(GetSharedTemplateRevisionRequest, CallSettings)
            // Additional: GetSharedTemplateRevisionAsync(GetSharedTemplateRevisionRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetSharedTemplateRevisionRequest request = new GetSharedTemplateRevisionRequest
            {
                SharedTemplateRevisionName = SharedTemplateRevisionName.FromProjectLocationSpaceSharedTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[SHARED_TEMPLATE]", "[REVISION]"),
            };
            // Make the request
            SharedTemplateRevision response = await designCenterClient.GetSharedTemplateRevisionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSharedTemplateRevision</summary>
        public void GetSharedTemplateRevision()
        {
            // Snippet: GetSharedTemplateRevision(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/sharedTemplates/[SHARED_TEMPLATE]/revisions/[REVISION]";
            // Make the request
            SharedTemplateRevision response = designCenterClient.GetSharedTemplateRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetSharedTemplateRevisionAsync</summary>
        public async Task GetSharedTemplateRevisionAsync()
        {
            // Snippet: GetSharedTemplateRevisionAsync(string, CallSettings)
            // Additional: GetSharedTemplateRevisionAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/sharedTemplates/[SHARED_TEMPLATE]/revisions/[REVISION]";
            // Make the request
            SharedTemplateRevision response = await designCenterClient.GetSharedTemplateRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSharedTemplateRevision</summary>
        public void GetSharedTemplateRevisionResourceNames()
        {
            // Snippet: GetSharedTemplateRevision(SharedTemplateRevisionName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            SharedTemplateRevisionName name = SharedTemplateRevisionName.FromProjectLocationSpaceSharedTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[SHARED_TEMPLATE]", "[REVISION]");
            // Make the request
            SharedTemplateRevision response = designCenterClient.GetSharedTemplateRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetSharedTemplateRevisionAsync</summary>
        public async Task GetSharedTemplateRevisionResourceNamesAsync()
        {
            // Snippet: GetSharedTemplateRevisionAsync(SharedTemplateRevisionName, CallSettings)
            // Additional: GetSharedTemplateRevisionAsync(SharedTemplateRevisionName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            SharedTemplateRevisionName name = SharedTemplateRevisionName.FromProjectLocationSpaceSharedTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[SHARED_TEMPLATE]", "[REVISION]");
            // Make the request
            SharedTemplateRevision response = await designCenterClient.GetSharedTemplateRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSharedTemplateRevisions</summary>
        public void ListSharedTemplateRevisionsRequestObject()
        {
            // Snippet: ListSharedTemplateRevisions(ListSharedTemplateRevisionsRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ListSharedTemplateRevisionsRequest request = new ListSharedTemplateRevisionsRequest
            {
                ParentAsSharedTemplateName = SharedTemplateName.FromProjectLocationSpaceSharedTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[SHARED_TEMPLATE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSharedTemplateRevisionsResponse, SharedTemplateRevision> response = designCenterClient.ListSharedTemplateRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SharedTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSharedTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SharedTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SharedTemplateRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SharedTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSharedTemplateRevisionsAsync</summary>
        public async Task ListSharedTemplateRevisionsRequestObjectAsync()
        {
            // Snippet: ListSharedTemplateRevisionsAsync(ListSharedTemplateRevisionsRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListSharedTemplateRevisionsRequest request = new ListSharedTemplateRevisionsRequest
            {
                ParentAsSharedTemplateName = SharedTemplateName.FromProjectLocationSpaceSharedTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[SHARED_TEMPLATE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSharedTemplateRevisionsResponse, SharedTemplateRevision> response = designCenterClient.ListSharedTemplateRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SharedTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSharedTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SharedTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SharedTemplateRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SharedTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSharedTemplateRevisions</summary>
        public void ListSharedTemplateRevisions()
        {
            // Snippet: ListSharedTemplateRevisions(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/sharedTemplates/[SHARED_TEMPLATE]";
            // Make the request
            PagedEnumerable<ListSharedTemplateRevisionsResponse, SharedTemplateRevision> response = designCenterClient.ListSharedTemplateRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SharedTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSharedTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SharedTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SharedTemplateRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SharedTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSharedTemplateRevisionsAsync</summary>
        public async Task ListSharedTemplateRevisionsAsync()
        {
            // Snippet: ListSharedTemplateRevisionsAsync(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/sharedTemplates/[SHARED_TEMPLATE]";
            // Make the request
            PagedAsyncEnumerable<ListSharedTemplateRevisionsResponse, SharedTemplateRevision> response = designCenterClient.ListSharedTemplateRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SharedTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSharedTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SharedTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SharedTemplateRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SharedTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSharedTemplateRevisions</summary>
        public void ListSharedTemplateRevisionsResourceNames()
        {
            // Snippet: ListSharedTemplateRevisions(SharedTemplateName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            SharedTemplateName parent = SharedTemplateName.FromProjectLocationSpaceSharedTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[SHARED_TEMPLATE]");
            // Make the request
            PagedEnumerable<ListSharedTemplateRevisionsResponse, SharedTemplateRevision> response = designCenterClient.ListSharedTemplateRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SharedTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSharedTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SharedTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SharedTemplateRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SharedTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSharedTemplateRevisionsAsync</summary>
        public async Task ListSharedTemplateRevisionsResourceNamesAsync()
        {
            // Snippet: ListSharedTemplateRevisionsAsync(SharedTemplateName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            SharedTemplateName parent = SharedTemplateName.FromProjectLocationSpaceSharedTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[SHARED_TEMPLATE]");
            // Make the request
            PagedAsyncEnumerable<ListSharedTemplateRevisionsResponse, SharedTemplateRevision> response = designCenterClient.ListSharedTemplateRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SharedTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSharedTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SharedTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SharedTemplateRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SharedTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogTemplateRevision</summary>
        public void CreateCatalogTemplateRevisionRequestObject()
        {
            // Snippet: CreateCatalogTemplateRevision(CreateCatalogTemplateRevisionRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CreateCatalogTemplateRevisionRequest request = new CreateCatalogTemplateRevisionRequest
            {
                ParentAsCatalogTemplateName = CatalogTemplateName.FromProjectLocationSpaceCatalogCatalogTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]"),
                CatalogTemplateRevisionId = "",
                CatalogTemplateRevision = new CatalogTemplateRevision(),
            };
            // Make the request
            Operation<CatalogTemplateRevision, OperationMetadata> response = designCenterClient.CreateCatalogTemplateRevision(request);

            // Poll until the returned long-running operation is complete
            Operation<CatalogTemplateRevision, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CatalogTemplateRevision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CatalogTemplateRevision, OperationMetadata> retrievedResponse = designCenterClient.PollOnceCreateCatalogTemplateRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CatalogTemplateRevision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogTemplateRevisionAsync</summary>
        public async Task CreateCatalogTemplateRevisionRequestObjectAsync()
        {
            // Snippet: CreateCatalogTemplateRevisionAsync(CreateCatalogTemplateRevisionRequest, CallSettings)
            // Additional: CreateCatalogTemplateRevisionAsync(CreateCatalogTemplateRevisionRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateCatalogTemplateRevisionRequest request = new CreateCatalogTemplateRevisionRequest
            {
                ParentAsCatalogTemplateName = CatalogTemplateName.FromProjectLocationSpaceCatalogCatalogTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]"),
                CatalogTemplateRevisionId = "",
                CatalogTemplateRevision = new CatalogTemplateRevision(),
            };
            // Make the request
            Operation<CatalogTemplateRevision, OperationMetadata> response = await designCenterClient.CreateCatalogTemplateRevisionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CatalogTemplateRevision, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CatalogTemplateRevision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CatalogTemplateRevision, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceCreateCatalogTemplateRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CatalogTemplateRevision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogTemplateRevision</summary>
        public void CreateCatalogTemplateRevision()
        {
            // Snippet: CreateCatalogTemplateRevision(string, CatalogTemplateRevision, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/templates/[CATALOG_TEMPLATE]";
            CatalogTemplateRevision catalogTemplateRevision = new CatalogTemplateRevision();
            string catalogTemplateRevisionId = "";
            // Make the request
            Operation<CatalogTemplateRevision, OperationMetadata> response = designCenterClient.CreateCatalogTemplateRevision(parent, catalogTemplateRevision, catalogTemplateRevisionId);

            // Poll until the returned long-running operation is complete
            Operation<CatalogTemplateRevision, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CatalogTemplateRevision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CatalogTemplateRevision, OperationMetadata> retrievedResponse = designCenterClient.PollOnceCreateCatalogTemplateRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CatalogTemplateRevision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogTemplateRevisionAsync</summary>
        public async Task CreateCatalogTemplateRevisionAsync()
        {
            // Snippet: CreateCatalogTemplateRevisionAsync(string, CatalogTemplateRevision, string, CallSettings)
            // Additional: CreateCatalogTemplateRevisionAsync(string, CatalogTemplateRevision, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/templates/[CATALOG_TEMPLATE]";
            CatalogTemplateRevision catalogTemplateRevision = new CatalogTemplateRevision();
            string catalogTemplateRevisionId = "";
            // Make the request
            Operation<CatalogTemplateRevision, OperationMetadata> response = await designCenterClient.CreateCatalogTemplateRevisionAsync(parent, catalogTemplateRevision, catalogTemplateRevisionId);

            // Poll until the returned long-running operation is complete
            Operation<CatalogTemplateRevision, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CatalogTemplateRevision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CatalogTemplateRevision, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceCreateCatalogTemplateRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CatalogTemplateRevision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogTemplateRevision</summary>
        public void CreateCatalogTemplateRevisionResourceNames()
        {
            // Snippet: CreateCatalogTemplateRevision(CatalogTemplateName, CatalogTemplateRevision, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CatalogTemplateName parent = CatalogTemplateName.FromProjectLocationSpaceCatalogCatalogTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]");
            CatalogTemplateRevision catalogTemplateRevision = new CatalogTemplateRevision();
            string catalogTemplateRevisionId = "";
            // Make the request
            Operation<CatalogTemplateRevision, OperationMetadata> response = designCenterClient.CreateCatalogTemplateRevision(parent, catalogTemplateRevision, catalogTemplateRevisionId);

            // Poll until the returned long-running operation is complete
            Operation<CatalogTemplateRevision, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CatalogTemplateRevision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CatalogTemplateRevision, OperationMetadata> retrievedResponse = designCenterClient.PollOnceCreateCatalogTemplateRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CatalogTemplateRevision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogTemplateRevisionAsync</summary>
        public async Task CreateCatalogTemplateRevisionResourceNamesAsync()
        {
            // Snippet: CreateCatalogTemplateRevisionAsync(CatalogTemplateName, CatalogTemplateRevision, string, CallSettings)
            // Additional: CreateCatalogTemplateRevisionAsync(CatalogTemplateName, CatalogTemplateRevision, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CatalogTemplateName parent = CatalogTemplateName.FromProjectLocationSpaceCatalogCatalogTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]");
            CatalogTemplateRevision catalogTemplateRevision = new CatalogTemplateRevision();
            string catalogTemplateRevisionId = "";
            // Make the request
            Operation<CatalogTemplateRevision, OperationMetadata> response = await designCenterClient.CreateCatalogTemplateRevisionAsync(parent, catalogTemplateRevision, catalogTemplateRevisionId);

            // Poll until the returned long-running operation is complete
            Operation<CatalogTemplateRevision, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CatalogTemplateRevision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CatalogTemplateRevision, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceCreateCatalogTemplateRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CatalogTemplateRevision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetCatalogTemplateRevision</summary>
        public void GetCatalogTemplateRevisionRequestObject()
        {
            // Snippet: GetCatalogTemplateRevision(GetCatalogTemplateRevisionRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GetCatalogTemplateRevisionRequest request = new GetCatalogTemplateRevisionRequest
            {
                CatalogTemplateRevisionName = CatalogTemplateRevisionName.FromProjectLocationSpaceCatalogCatalogTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]", "[REVISION]"),
            };
            // Make the request
            CatalogTemplateRevision response = designCenterClient.GetCatalogTemplateRevision(request);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogTemplateRevisionAsync</summary>
        public async Task GetCatalogTemplateRevisionRequestObjectAsync()
        {
            // Snippet: GetCatalogTemplateRevisionAsync(GetCatalogTemplateRevisionRequest, CallSettings)
            // Additional: GetCatalogTemplateRevisionAsync(GetCatalogTemplateRevisionRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetCatalogTemplateRevisionRequest request = new GetCatalogTemplateRevisionRequest
            {
                CatalogTemplateRevisionName = CatalogTemplateRevisionName.FromProjectLocationSpaceCatalogCatalogTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]", "[REVISION]"),
            };
            // Make the request
            CatalogTemplateRevision response = await designCenterClient.GetCatalogTemplateRevisionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogTemplateRevision</summary>
        public void GetCatalogTemplateRevision()
        {
            // Snippet: GetCatalogTemplateRevision(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/templates/[CATALOG_TEMPLATE]/revisions/[REVISION]";
            // Make the request
            CatalogTemplateRevision response = designCenterClient.GetCatalogTemplateRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogTemplateRevisionAsync</summary>
        public async Task GetCatalogTemplateRevisionAsync()
        {
            // Snippet: GetCatalogTemplateRevisionAsync(string, CallSettings)
            // Additional: GetCatalogTemplateRevisionAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/templates/[CATALOG_TEMPLATE]/revisions/[REVISION]";
            // Make the request
            CatalogTemplateRevision response = await designCenterClient.GetCatalogTemplateRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogTemplateRevision</summary>
        public void GetCatalogTemplateRevisionResourceNames()
        {
            // Snippet: GetCatalogTemplateRevision(CatalogTemplateRevisionName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CatalogTemplateRevisionName name = CatalogTemplateRevisionName.FromProjectLocationSpaceCatalogCatalogTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]", "[REVISION]");
            // Make the request
            CatalogTemplateRevision response = designCenterClient.GetCatalogTemplateRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogTemplateRevisionAsync</summary>
        public async Task GetCatalogTemplateRevisionResourceNamesAsync()
        {
            // Snippet: GetCatalogTemplateRevisionAsync(CatalogTemplateRevisionName, CallSettings)
            // Additional: GetCatalogTemplateRevisionAsync(CatalogTemplateRevisionName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CatalogTemplateRevisionName name = CatalogTemplateRevisionName.FromProjectLocationSpaceCatalogCatalogTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]", "[REVISION]");
            // Make the request
            CatalogTemplateRevision response = await designCenterClient.GetCatalogTemplateRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCatalogTemplateRevisions</summary>
        public void ListCatalogTemplateRevisionsRequestObject()
        {
            // Snippet: ListCatalogTemplateRevisions(ListCatalogTemplateRevisionsRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ListCatalogTemplateRevisionsRequest request = new ListCatalogTemplateRevisionsRequest
            {
                ParentAsCatalogTemplateName = CatalogTemplateName.FromProjectLocationSpaceCatalogCatalogTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCatalogTemplateRevisionsResponse, CatalogTemplateRevision> response = designCenterClient.ListCatalogTemplateRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CatalogTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCatalogTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogTemplateRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogTemplateRevisionsAsync</summary>
        public async Task ListCatalogTemplateRevisionsRequestObjectAsync()
        {
            // Snippet: ListCatalogTemplateRevisionsAsync(ListCatalogTemplateRevisionsRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListCatalogTemplateRevisionsRequest request = new ListCatalogTemplateRevisionsRequest
            {
                ParentAsCatalogTemplateName = CatalogTemplateName.FromProjectLocationSpaceCatalogCatalogTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCatalogTemplateRevisionsResponse, CatalogTemplateRevision> response = designCenterClient.ListCatalogTemplateRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CatalogTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCatalogTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogTemplateRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogTemplateRevisions</summary>
        public void ListCatalogTemplateRevisions()
        {
            // Snippet: ListCatalogTemplateRevisions(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/templates/[CATALOG_TEMPLATE]";
            // Make the request
            PagedEnumerable<ListCatalogTemplateRevisionsResponse, CatalogTemplateRevision> response = designCenterClient.ListCatalogTemplateRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CatalogTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCatalogTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogTemplateRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogTemplateRevisionsAsync</summary>
        public async Task ListCatalogTemplateRevisionsAsync()
        {
            // Snippet: ListCatalogTemplateRevisionsAsync(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/templates/[CATALOG_TEMPLATE]";
            // Make the request
            PagedAsyncEnumerable<ListCatalogTemplateRevisionsResponse, CatalogTemplateRevision> response = designCenterClient.ListCatalogTemplateRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CatalogTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCatalogTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogTemplateRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogTemplateRevisions</summary>
        public void ListCatalogTemplateRevisionsResourceNames()
        {
            // Snippet: ListCatalogTemplateRevisions(CatalogTemplateName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CatalogTemplateName parent = CatalogTemplateName.FromProjectLocationSpaceCatalogCatalogTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]");
            // Make the request
            PagedEnumerable<ListCatalogTemplateRevisionsResponse, CatalogTemplateRevision> response = designCenterClient.ListCatalogTemplateRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CatalogTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCatalogTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogTemplateRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogTemplateRevisionsAsync</summary>
        public async Task ListCatalogTemplateRevisionsResourceNamesAsync()
        {
            // Snippet: ListCatalogTemplateRevisionsAsync(CatalogTemplateName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CatalogTemplateName parent = CatalogTemplateName.FromProjectLocationSpaceCatalogCatalogTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]");
            // Make the request
            PagedAsyncEnumerable<ListCatalogTemplateRevisionsResponse, CatalogTemplateRevision> response = designCenterClient.ListCatalogTemplateRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CatalogTemplateRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCatalogTemplateRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogTemplateRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogTemplateRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogTemplateRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogTemplateRevision</summary>
        public void DeleteCatalogTemplateRevisionRequestObject()
        {
            // Snippet: DeleteCatalogTemplateRevision(DeleteCatalogTemplateRevisionRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            DeleteCatalogTemplateRevisionRequest request = new DeleteCatalogTemplateRevisionRequest
            {
                CatalogTemplateRevisionName = CatalogTemplateRevisionName.FromProjectLocationSpaceCatalogCatalogTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]", "[REVISION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = designCenterClient.DeleteCatalogTemplateRevision(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeleteCatalogTemplateRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogTemplateRevisionAsync</summary>
        public async Task DeleteCatalogTemplateRevisionRequestObjectAsync()
        {
            // Snippet: DeleteCatalogTemplateRevisionAsync(DeleteCatalogTemplateRevisionRequest, CallSettings)
            // Additional: DeleteCatalogTemplateRevisionAsync(DeleteCatalogTemplateRevisionRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCatalogTemplateRevisionRequest request = new DeleteCatalogTemplateRevisionRequest
            {
                CatalogTemplateRevisionName = CatalogTemplateRevisionName.FromProjectLocationSpaceCatalogCatalogTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]", "[REVISION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await designCenterClient.DeleteCatalogTemplateRevisionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeleteCatalogTemplateRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogTemplateRevision</summary>
        public void DeleteCatalogTemplateRevision()
        {
            // Snippet: DeleteCatalogTemplateRevision(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/templates/[CATALOG_TEMPLATE]/revisions/[REVISION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = designCenterClient.DeleteCatalogTemplateRevision(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeleteCatalogTemplateRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogTemplateRevisionAsync</summary>
        public async Task DeleteCatalogTemplateRevisionAsync()
        {
            // Snippet: DeleteCatalogTemplateRevisionAsync(string, CallSettings)
            // Additional: DeleteCatalogTemplateRevisionAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/catalogs/[CATALOG]/templates/[CATALOG_TEMPLATE]/revisions/[REVISION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await designCenterClient.DeleteCatalogTemplateRevisionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeleteCatalogTemplateRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogTemplateRevision</summary>
        public void DeleteCatalogTemplateRevisionResourceNames()
        {
            // Snippet: DeleteCatalogTemplateRevision(CatalogTemplateRevisionName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CatalogTemplateRevisionName name = CatalogTemplateRevisionName.FromProjectLocationSpaceCatalogCatalogTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]", "[REVISION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = designCenterClient.DeleteCatalogTemplateRevision(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeleteCatalogTemplateRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogTemplateRevisionAsync</summary>
        public async Task DeleteCatalogTemplateRevisionResourceNamesAsync()
        {
            // Snippet: DeleteCatalogTemplateRevisionAsync(CatalogTemplateRevisionName, CallSettings)
            // Additional: DeleteCatalogTemplateRevisionAsync(CatalogTemplateRevisionName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CatalogTemplateRevisionName name = CatalogTemplateRevisionName.FromProjectLocationSpaceCatalogCatalogTemplateRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[CATALOG]", "[CATALOG_TEMPLATE]", "[REVISION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await designCenterClient.DeleteCatalogTemplateRevisionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeleteCatalogTemplateRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplication</summary>
        public void CreateApplicationRequestObject()
        {
            // Snippet: CreateApplication(CreateApplicationRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsSpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                ApplicationId = "",
                Application = new Application(),
            };
            // Make the request
            Application response = designCenterClient.CreateApplication(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationRequestObjectAsync()
        {
            // Snippet: CreateApplicationAsync(CreateApplicationRequest, CallSettings)
            // Additional: CreateApplicationAsync(CreateApplicationRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsSpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                ApplicationId = "",
                Application = new Application(),
            };
            // Make the request
            Application response = await designCenterClient.CreateApplicationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApplication</summary>
        public void CreateApplication()
        {
            // Snippet: CreateApplication(string, Application, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            Application application = new Application();
            string applicationId = "";
            // Make the request
            Application response = designCenterClient.CreateApplication(parent, application, applicationId);
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationAsync()
        {
            // Snippet: CreateApplicationAsync(string, Application, string, CallSettings)
            // Additional: CreateApplicationAsync(string, Application, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            Application application = new Application();
            string applicationId = "";
            // Make the request
            Application response = await designCenterClient.CreateApplicationAsync(parent, application, applicationId);
            // End snippet
        }

        /// <summary>Snippet for CreateApplication</summary>
        public void CreateApplicationResourceNames()
        {
            // Snippet: CreateApplication(SpaceName, Application, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            Application application = new Application();
            string applicationId = "";
            // Make the request
            Application response = designCenterClient.CreateApplication(parent, application, applicationId);
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationResourceNamesAsync()
        {
            // Snippet: CreateApplicationAsync(SpaceName, Application, string, CallSettings)
            // Additional: CreateApplicationAsync(SpaceName, Application, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            Application application = new Application();
            string applicationId = "";
            // Make the request
            Application response = await designCenterClient.CreateApplicationAsync(parent, application, applicationId);
            // End snippet
        }

        /// <summary>Snippet for GetApplication</summary>
        public void GetApplicationRequestObject()
        {
            // Snippet: GetApplication(GetApplicationRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
            };
            // Make the request
            Application response = designCenterClient.GetApplication(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationRequestObjectAsync()
        {
            // Snippet: GetApplicationAsync(GetApplicationRequest, CallSettings)
            // Additional: GetApplicationAsync(GetApplicationRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
            };
            // Make the request
            Application response = await designCenterClient.GetApplicationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplication</summary>
        public void GetApplication()
        {
            // Snippet: GetApplication(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            Application response = designCenterClient.GetApplication(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationAsync()
        {
            // Snippet: GetApplicationAsync(string, CallSettings)
            // Additional: GetApplicationAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            Application response = await designCenterClient.GetApplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplication</summary>
        public void GetApplicationResourceNames()
        {
            // Snippet: GetApplication(ApplicationName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            Application response = designCenterClient.GetApplication(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationResourceNamesAsync()
        {
            // Snippet: GetApplicationAsync(ApplicationName, CallSettings)
            // Additional: GetApplicationAsync(ApplicationName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            Application response = await designCenterClient.GetApplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListApplications</summary>
        public void ListApplicationsRequestObject()
        {
            // Snippet: ListApplications(ListApplicationsRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ListApplicationsRequest request = new ListApplicationsRequest
            {
                ParentAsSpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListApplicationsResponse, Application> response = designCenterClient.ListApplications(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationsAsync</summary>
        public async Task ListApplicationsRequestObjectAsync()
        {
            // Snippet: ListApplicationsAsync(ListApplicationsRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListApplicationsRequest request = new ListApplicationsRequest
            {
                ParentAsSpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListApplicationsResponse, Application> response = designCenterClient.ListApplicationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplications</summary>
        public void ListApplications()
        {
            // Snippet: ListApplications(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            // Make the request
            PagedEnumerable<ListApplicationsResponse, Application> response = designCenterClient.ListApplications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationsAsync</summary>
        public async Task ListApplicationsAsync()
        {
            // Snippet: ListApplicationsAsync(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            // Make the request
            PagedAsyncEnumerable<ListApplicationsResponse, Application> response = designCenterClient.ListApplicationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplications</summary>
        public void ListApplicationsResourceNames()
        {
            // Snippet: ListApplications(SpaceName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            // Make the request
            PagedEnumerable<ListApplicationsResponse, Application> response = designCenterClient.ListApplications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationsAsync</summary>
        public async Task ListApplicationsResourceNamesAsync()
        {
            // Snippet: ListApplicationsAsync(SpaceName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            // Make the request
            PagedAsyncEnumerable<ListApplicationsResponse, Application> response = designCenterClient.ListApplicationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateApplication</summary>
        public void UpdateApplicationRequestObject()
        {
            // Snippet: UpdateApplication(UpdateApplicationRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                UpdateMask = new FieldMask(),
                Application = new Application(),
            };
            // Make the request
            Application response = designCenterClient.UpdateApplication(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationAsync</summary>
        public async Task UpdateApplicationRequestObjectAsync()
        {
            // Snippet: UpdateApplicationAsync(UpdateApplicationRequest, CallSettings)
            // Additional: UpdateApplicationAsync(UpdateApplicationRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                UpdateMask = new FieldMask(),
                Application = new Application(),
            };
            // Make the request
            Application response = await designCenterClient.UpdateApplicationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApplication</summary>
        public void UpdateApplication()
        {
            // Snippet: UpdateApplication(Application, FieldMask, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            Application application = new Application();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Application response = designCenterClient.UpdateApplication(application, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationAsync</summary>
        public async Task UpdateApplicationAsync()
        {
            // Snippet: UpdateApplicationAsync(Application, FieldMask, CallSettings)
            // Additional: UpdateApplicationAsync(Application, FieldMask, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            Application application = new Application();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Application response = await designCenterClient.UpdateApplicationAsync(application, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteApplication</summary>
        public void DeleteApplicationRequestObject()
        {
            // Snippet: DeleteApplication(DeleteApplicationRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            DeleteApplicationRequest request = new DeleteApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = designCenterClient.DeleteApplication(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeleteApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationAsync</summary>
        public async Task DeleteApplicationRequestObjectAsync()
        {
            // Snippet: DeleteApplicationAsync(DeleteApplicationRequest, CallSettings)
            // Additional: DeleteApplicationAsync(DeleteApplicationRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteApplicationRequest request = new DeleteApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await designCenterClient.DeleteApplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeleteApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplication</summary>
        public void DeleteApplication()
        {
            // Snippet: DeleteApplication(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = designCenterClient.DeleteApplication(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeleteApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationAsync</summary>
        public async Task DeleteApplicationAsync()
        {
            // Snippet: DeleteApplicationAsync(string, CallSettings)
            // Additional: DeleteApplicationAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await designCenterClient.DeleteApplicationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeleteApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplication</summary>
        public void DeleteApplicationResourceNames()
        {
            // Snippet: DeleteApplication(ApplicationName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = designCenterClient.DeleteApplication(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeleteApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationAsync</summary>
        public async Task DeleteApplicationResourceNamesAsync()
        {
            // Snippet: DeleteApplicationAsync(ApplicationName, CallSettings)
            // Additional: DeleteApplicationAsync(ApplicationName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await designCenterClient.DeleteApplicationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeleteApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployApplication</summary>
        public void DeployApplicationRequestObject()
        {
            // Snippet: DeployApplication(DeployApplicationRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            DeployApplicationRequest request = new DeployApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
                Replace = false,
                WorkerPool = "",
                ServiceAccount = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<DeployApplicationResponse, OperationMetadata> response = designCenterClient.DeployApplication(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployApplicationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployApplicationResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeployApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployApplicationAsync</summary>
        public async Task DeployApplicationRequestObjectAsync()
        {
            // Snippet: DeployApplicationAsync(DeployApplicationRequest, CallSettings)
            // Additional: DeployApplicationAsync(DeployApplicationRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeployApplicationRequest request = new DeployApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
                Replace = false,
                WorkerPool = "",
                ServiceAccount = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<DeployApplicationResponse, OperationMetadata> response = await designCenterClient.DeployApplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployApplicationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployApplicationResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeployApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployApplication</summary>
        public void DeployApplication()
        {
            // Snippet: DeployApplication(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            Operation<DeployApplicationResponse, OperationMetadata> response = designCenterClient.DeployApplication(name);

            // Poll until the returned long-running operation is complete
            Operation<DeployApplicationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployApplicationResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeployApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployApplicationAsync</summary>
        public async Task DeployApplicationAsync()
        {
            // Snippet: DeployApplicationAsync(string, CallSettings)
            // Additional: DeployApplicationAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            Operation<DeployApplicationResponse, OperationMetadata> response = await designCenterClient.DeployApplicationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DeployApplicationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployApplicationResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeployApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployApplication</summary>
        public void DeployApplicationResourceNames()
        {
            // Snippet: DeployApplication(ApplicationName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            Operation<DeployApplicationResponse, OperationMetadata> response = designCenterClient.DeployApplication(name);

            // Poll until the returned long-running operation is complete
            Operation<DeployApplicationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployApplicationResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceDeployApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployApplicationAsync</summary>
        public async Task DeployApplicationResourceNamesAsync()
        {
            // Snippet: DeployApplicationAsync(ApplicationName, CallSettings)
            // Additional: DeployApplicationAsync(ApplicationName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            Operation<DeployApplicationResponse, OperationMetadata> response = await designCenterClient.DeployApplicationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DeployApplicationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployApplicationResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceDeployApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PreviewApplication</summary>
        public void PreviewApplicationRequestObject()
        {
            // Snippet: PreviewApplication(PreviewApplicationRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            PreviewApplicationRequest request = new PreviewApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
                WorkerPool = "",
                ServiceAccount = "",
            };
            // Make the request
            Operation<PreviewApplicationResponse, OperationMetadata> response = designCenterClient.PreviewApplication(request);

            // Poll until the returned long-running operation is complete
            Operation<PreviewApplicationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PreviewApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PreviewApplicationResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOncePreviewApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PreviewApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PreviewApplicationAsync</summary>
        public async Task PreviewApplicationRequestObjectAsync()
        {
            // Snippet: PreviewApplicationAsync(PreviewApplicationRequest, CallSettings)
            // Additional: PreviewApplicationAsync(PreviewApplicationRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            PreviewApplicationRequest request = new PreviewApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
                WorkerPool = "",
                ServiceAccount = "",
            };
            // Make the request
            Operation<PreviewApplicationResponse, OperationMetadata> response = await designCenterClient.PreviewApplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PreviewApplicationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PreviewApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PreviewApplicationResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOncePreviewApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PreviewApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PreviewApplication</summary>
        public void PreviewApplication()
        {
            // Snippet: PreviewApplication(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            Operation<PreviewApplicationResponse, OperationMetadata> response = designCenterClient.PreviewApplication(name);

            // Poll until the returned long-running operation is complete
            Operation<PreviewApplicationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PreviewApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PreviewApplicationResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOncePreviewApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PreviewApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PreviewApplicationAsync</summary>
        public async Task PreviewApplicationAsync()
        {
            // Snippet: PreviewApplicationAsync(string, CallSettings)
            // Additional: PreviewApplicationAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            Operation<PreviewApplicationResponse, OperationMetadata> response = await designCenterClient.PreviewApplicationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PreviewApplicationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PreviewApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PreviewApplicationResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOncePreviewApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PreviewApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PreviewApplication</summary>
        public void PreviewApplicationResourceNames()
        {
            // Snippet: PreviewApplication(ApplicationName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            Operation<PreviewApplicationResponse, OperationMetadata> response = designCenterClient.PreviewApplication(name);

            // Poll until the returned long-running operation is complete
            Operation<PreviewApplicationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PreviewApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PreviewApplicationResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOncePreviewApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PreviewApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PreviewApplicationAsync</summary>
        public async Task PreviewApplicationResourceNamesAsync()
        {
            // Snippet: PreviewApplicationAsync(ApplicationName, CallSettings)
            // Additional: PreviewApplicationAsync(ApplicationName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            Operation<PreviewApplicationResponse, OperationMetadata> response = await designCenterClient.PreviewApplicationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PreviewApplicationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PreviewApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PreviewApplicationResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOncePreviewApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PreviewApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchApplicationAssessmentReport</summary>
        public void FetchApplicationAssessmentReportRequestObject()
        {
            // Snippet: FetchApplicationAssessmentReport(FetchApplicationAssessmentReportRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            FetchApplicationAssessmentReportRequest request = new FetchApplicationAssessmentReportRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
            };
            // Make the request
            FetchApplicationAssessmentReportResponse response = designCenterClient.FetchApplicationAssessmentReport(request);
            // End snippet
        }

        /// <summary>Snippet for FetchApplicationAssessmentReportAsync</summary>
        public async Task FetchApplicationAssessmentReportRequestObjectAsync()
        {
            // Snippet: FetchApplicationAssessmentReportAsync(FetchApplicationAssessmentReportRequest, CallSettings)
            // Additional: FetchApplicationAssessmentReportAsync(FetchApplicationAssessmentReportRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            FetchApplicationAssessmentReportRequest request = new FetchApplicationAssessmentReportRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
            };
            // Make the request
            FetchApplicationAssessmentReportResponse response = await designCenterClient.FetchApplicationAssessmentReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchApplicationAssessmentReport</summary>
        public void FetchApplicationAssessmentReport()
        {
            // Snippet: FetchApplicationAssessmentReport(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            FetchApplicationAssessmentReportResponse response = designCenterClient.FetchApplicationAssessmentReport(name);
            // End snippet
        }

        /// <summary>Snippet for FetchApplicationAssessmentReportAsync</summary>
        public async Task FetchApplicationAssessmentReportAsync()
        {
            // Snippet: FetchApplicationAssessmentReportAsync(string, CallSettings)
            // Additional: FetchApplicationAssessmentReportAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            FetchApplicationAssessmentReportResponse response = await designCenterClient.FetchApplicationAssessmentReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for FetchApplicationAssessmentReport</summary>
        public void FetchApplicationAssessmentReportResourceNames()
        {
            // Snippet: FetchApplicationAssessmentReport(ApplicationName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            FetchApplicationAssessmentReportResponse response = designCenterClient.FetchApplicationAssessmentReport(name);
            // End snippet
        }

        /// <summary>Snippet for FetchApplicationAssessmentReportAsync</summary>
        public async Task FetchApplicationAssessmentReportResourceNamesAsync()
        {
            // Snippet: FetchApplicationAssessmentReportAsync(ApplicationName, CallSettings)
            // Additional: FetchApplicationAssessmentReportAsync(ApplicationName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            FetchApplicationAssessmentReportResponse response = await designCenterClient.FetchApplicationAssessmentReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationAssessmentReport</summary>
        public void GenerateApplicationAssessmentReportRequestObject()
        {
            // Snippet: GenerateApplicationAssessmentReport(GenerateApplicationAssessmentReportRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GenerateApplicationAssessmentReportRequest request = new GenerateApplicationAssessmentReportRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
            };
            // Make the request
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> response = designCenterClient.GenerateApplicationAssessmentReport(request);

            // Poll until the returned long-running operation is complete
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GenerateApplicationAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceGenerateApplicationAssessmentReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateApplicationAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationAssessmentReportAsync</summary>
        public async Task GenerateApplicationAssessmentReportRequestObjectAsync()
        {
            // Snippet: GenerateApplicationAssessmentReportAsync(GenerateApplicationAssessmentReportRequest, CallSettings)
            // Additional: GenerateApplicationAssessmentReportAsync(GenerateApplicationAssessmentReportRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GenerateApplicationAssessmentReportRequest request = new GenerateApplicationAssessmentReportRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
            };
            // Make the request
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> response = await designCenterClient.GenerateApplicationAssessmentReportAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GenerateApplicationAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceGenerateApplicationAssessmentReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateApplicationAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationAssessmentReport</summary>
        public void GenerateApplicationAssessmentReport()
        {
            // Snippet: GenerateApplicationAssessmentReport(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> response = designCenterClient.GenerateApplicationAssessmentReport(name);

            // Poll until the returned long-running operation is complete
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GenerateApplicationAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceGenerateApplicationAssessmentReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateApplicationAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationAssessmentReportAsync</summary>
        public async Task GenerateApplicationAssessmentReportAsync()
        {
            // Snippet: GenerateApplicationAssessmentReportAsync(string, CallSettings)
            // Additional: GenerateApplicationAssessmentReportAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> response = await designCenterClient.GenerateApplicationAssessmentReportAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GenerateApplicationAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceGenerateApplicationAssessmentReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateApplicationAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationAssessmentReport</summary>
        public void GenerateApplicationAssessmentReportResourceNames()
        {
            // Snippet: GenerateApplicationAssessmentReport(ApplicationName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> response = designCenterClient.GenerateApplicationAssessmentReport(name);

            // Poll until the returned long-running operation is complete
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GenerateApplicationAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceGenerateApplicationAssessmentReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateApplicationAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationAssessmentReportAsync</summary>
        public async Task GenerateApplicationAssessmentReportResourceNamesAsync()
        {
            // Snippet: GenerateApplicationAssessmentReportAsync(ApplicationName, CallSettings)
            // Additional: GenerateApplicationAssessmentReportAsync(ApplicationName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> response = await designCenterClient.GenerateApplicationAssessmentReportAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GenerateApplicationAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceGenerateApplicationAssessmentReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateApplicationAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateAssessmentReport</summary>
        public void GenerateApplicationTemplateAssessmentReportRequestObject()
        {
            // Snippet: GenerateApplicationTemplateAssessmentReport(GenerateApplicationTemplateAssessmentReportRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GenerateApplicationTemplateAssessmentReportRequest request = new GenerateApplicationTemplateAssessmentReportRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
            };
            // Make the request
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> response = designCenterClient.GenerateApplicationTemplateAssessmentReport(request);

            // Poll until the returned long-running operation is complete
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GenerateApplicationTemplateAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceGenerateApplicationTemplateAssessmentReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateApplicationTemplateAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateAssessmentReportAsync</summary>
        public async Task GenerateApplicationTemplateAssessmentReportRequestObjectAsync()
        {
            // Snippet: GenerateApplicationTemplateAssessmentReportAsync(GenerateApplicationTemplateAssessmentReportRequest, CallSettings)
            // Additional: GenerateApplicationTemplateAssessmentReportAsync(GenerateApplicationTemplateAssessmentReportRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GenerateApplicationTemplateAssessmentReportRequest request = new GenerateApplicationTemplateAssessmentReportRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
            };
            // Make the request
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> response = await designCenterClient.GenerateApplicationTemplateAssessmentReportAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GenerateApplicationTemplateAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceGenerateApplicationTemplateAssessmentReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateApplicationTemplateAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateAssessmentReport</summary>
        public void GenerateApplicationTemplateAssessmentReport()
        {
            // Snippet: GenerateApplicationTemplateAssessmentReport(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> response = designCenterClient.GenerateApplicationTemplateAssessmentReport(name);

            // Poll until the returned long-running operation is complete
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GenerateApplicationTemplateAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceGenerateApplicationTemplateAssessmentReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateApplicationTemplateAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateAssessmentReportAsync</summary>
        public async Task GenerateApplicationTemplateAssessmentReportAsync()
        {
            // Snippet: GenerateApplicationTemplateAssessmentReportAsync(string, CallSettings)
            // Additional: GenerateApplicationTemplateAssessmentReportAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> response = await designCenterClient.GenerateApplicationTemplateAssessmentReportAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GenerateApplicationTemplateAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceGenerateApplicationTemplateAssessmentReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateApplicationTemplateAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateAssessmentReport</summary>
        public void GenerateApplicationTemplateAssessmentReportResourceNames()
        {
            // Snippet: GenerateApplicationTemplateAssessmentReport(ApplicationTemplateName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> response = designCenterClient.GenerateApplicationTemplateAssessmentReport(name);

            // Poll until the returned long-running operation is complete
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GenerateApplicationTemplateAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceGenerateApplicationTemplateAssessmentReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateApplicationTemplateAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationTemplateAssessmentReportAsync</summary>
        public async Task GenerateApplicationTemplateAssessmentReportResourceNamesAsync()
        {
            // Snippet: GenerateApplicationTemplateAssessmentReportAsync(ApplicationTemplateName, CallSettings)
            // Additional: GenerateApplicationTemplateAssessmentReportAsync(ApplicationTemplateName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> response = await designCenterClient.GenerateApplicationTemplateAssessmentReportAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GenerateApplicationTemplateAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceGenerateApplicationTemplateAssessmentReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateApplicationTemplateAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateAssessmentReport</summary>
        public void GenerateAssessmentReportRequestObject()
        {
            // Snippet: GenerateAssessmentReport(GenerateAssessmentReportRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            GenerateAssessmentReportRequest request = new GenerateAssessmentReportRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> response = designCenterClient.GenerateAssessmentReport(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            GenerateAssessmentReportResponse result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceGenerateAssessmentReport(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                GenerateAssessmentReportResponse retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateAssessmentReportAsync</summary>
        public async Task GenerateAssessmentReportRequestObjectAsync()
        {
            // Snippet: GenerateAssessmentReportAsync(GenerateAssessmentReportRequest, CallSettings)
            // Additional: GenerateAssessmentReportAsync(GenerateAssessmentReportRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
#pragma warning disable CS0612
            GenerateAssessmentReportRequest request = new GenerateAssessmentReportRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> response = await designCenterClient.GenerateAssessmentReportAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            GenerateAssessmentReportResponse result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceGenerateAssessmentReportAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                GenerateAssessmentReportResponse retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateAssessmentReport</summary>
        public void GenerateAssessmentReport()
        {
            // Snippet: GenerateAssessmentReport(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string spaceName = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            // Make the request
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> response = designCenterClient.GenerateAssessmentReport(spaceName);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            GenerateAssessmentReportResponse result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceGenerateAssessmentReport(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                GenerateAssessmentReportResponse retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateAssessmentReportAsync</summary>
        public async Task GenerateAssessmentReportAsync()
        {
            // Snippet: GenerateAssessmentReportAsync(string, CallSettings)
            // Additional: GenerateAssessmentReportAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string spaceName = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            // Make the request
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> response = await designCenterClient.GenerateAssessmentReportAsync(spaceName);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            GenerateAssessmentReportResponse result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceGenerateAssessmentReportAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                GenerateAssessmentReportResponse retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateAssessmentReport</summary>
        public void GenerateAssessmentReportResourceNames()
        {
            // Snippet: GenerateAssessmentReport(SpaceName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            SpaceName spaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            // Make the request
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> response = designCenterClient.GenerateAssessmentReport(spaceName);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            GenerateAssessmentReportResponse result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceGenerateAssessmentReport(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                GenerateAssessmentReportResponse retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateAssessmentReportAsync</summary>
        public async Task GenerateAssessmentReportResourceNamesAsync()
        {
            // Snippet: GenerateAssessmentReportAsync(SpaceName, CallSettings)
            // Additional: GenerateAssessmentReportAsync(SpaceName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName spaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            // Make the request
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> response = await designCenterClient.GenerateAssessmentReportAsync(spaceName);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            GenerateAssessmentReportResponse result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<GenerateAssessmentReportResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceGenerateAssessmentReportAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                GenerateAssessmentReportResponse retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateTerraformPlanAssessmentReport</summary>
        public void GenerateTerraformPlanAssessmentReportRequestObject()
        {
            // Snippet: GenerateTerraformPlanAssessmentReport(GenerateTerraformPlanAssessmentReportRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GenerateTerraformPlanAssessmentReportRequest request = new GenerateTerraformPlanAssessmentReportRequest
            {
                SpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                TerraformPlan = ByteString.Empty,
                AdditionalFrameworks = { "", },
            };
            // Make the request
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> response = designCenterClient.GenerateTerraformPlanAssessmentReport(request);

            // Poll until the returned long-running operation is complete
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GenerateTerraformPlanAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceGenerateTerraformPlanAssessmentReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateTerraformPlanAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateTerraformPlanAssessmentReportAsync</summary>
        public async Task GenerateTerraformPlanAssessmentReportRequestObjectAsync()
        {
            // Snippet: GenerateTerraformPlanAssessmentReportAsync(GenerateTerraformPlanAssessmentReportRequest, CallSettings)
            // Additional: GenerateTerraformPlanAssessmentReportAsync(GenerateTerraformPlanAssessmentReportRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GenerateTerraformPlanAssessmentReportRequest request = new GenerateTerraformPlanAssessmentReportRequest
            {
                SpaceName = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]"),
                TerraformPlan = ByteString.Empty,
                AdditionalFrameworks = { "", },
            };
            // Make the request
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> response = await designCenterClient.GenerateTerraformPlanAssessmentReportAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GenerateTerraformPlanAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceGenerateTerraformPlanAssessmentReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateTerraformPlanAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateTerraformPlanAssessmentReport</summary>
        public void GenerateTerraformPlanAssessmentReport()
        {
            // Snippet: GenerateTerraformPlanAssessmentReport(string, ByteString, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            ByteString terraformPlan = ByteString.Empty;
            // Make the request
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> response = designCenterClient.GenerateTerraformPlanAssessmentReport(name, terraformPlan);

            // Poll until the returned long-running operation is complete
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GenerateTerraformPlanAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceGenerateTerraformPlanAssessmentReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateTerraformPlanAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateTerraformPlanAssessmentReportAsync</summary>
        public async Task GenerateTerraformPlanAssessmentReportAsync()
        {
            // Snippet: GenerateTerraformPlanAssessmentReportAsync(string, ByteString, CallSettings)
            // Additional: GenerateTerraformPlanAssessmentReportAsync(string, ByteString, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]";
            ByteString terraformPlan = ByteString.Empty;
            // Make the request
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> response = await designCenterClient.GenerateTerraformPlanAssessmentReportAsync(name, terraformPlan);

            // Poll until the returned long-running operation is complete
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GenerateTerraformPlanAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceGenerateTerraformPlanAssessmentReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateTerraformPlanAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateTerraformPlanAssessmentReport</summary>
        public void GenerateTerraformPlanAssessmentReportResourceNames()
        {
            // Snippet: GenerateTerraformPlanAssessmentReport(SpaceName, ByteString, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            ByteString terraformPlan = ByteString.Empty;
            // Make the request
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> response = designCenterClient.GenerateTerraformPlanAssessmentReport(name, terraformPlan);

            // Poll until the returned long-running operation is complete
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GenerateTerraformPlanAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceGenerateTerraformPlanAssessmentReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateTerraformPlanAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateTerraformPlanAssessmentReportAsync</summary>
        public async Task GenerateTerraformPlanAssessmentReportResourceNamesAsync()
        {
            // Snippet: GenerateTerraformPlanAssessmentReportAsync(SpaceName, ByteString, CallSettings)
            // Additional: GenerateTerraformPlanAssessmentReportAsync(SpaceName, ByteString, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromProjectLocationSpace("[PROJECT]", "[LOCATION]", "[SPACE]");
            ByteString terraformPlan = ByteString.Empty;
            // Make the request
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> response = await designCenterClient.GenerateTerraformPlanAssessmentReportAsync(name, terraformPlan);

            // Poll until the returned long-running operation is complete
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GenerateTerraformPlanAssessmentReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceGenerateTerraformPlanAssessmentReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateTerraformPlanAssessmentReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetPolicy</summary>
        public void GetPolicyRequestObject()
        {
            // Snippet: GetPolicy(GetPolicyRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GetPolicyRequest request = new GetPolicyRequest
            {
                PolicyName = PolicyName.FromProjectLocationSpaceApplicationTemplatePolicy("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[POLICY]"),
            };
            // Make the request
            Policy response = designCenterClient.GetPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyAsync</summary>
        public async Task GetPolicyRequestObjectAsync()
        {
            // Snippet: GetPolicyAsync(GetPolicyRequest, CallSettings)
            // Additional: GetPolicyAsync(GetPolicyRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetPolicyRequest request = new GetPolicyRequest
            {
                PolicyName = PolicyName.FromProjectLocationSpaceApplicationTemplatePolicy("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[POLICY]"),
            };
            // Make the request
            Policy response = await designCenterClient.GetPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPolicy</summary>
        public void GetPolicy()
        {
            // Snippet: GetPolicy(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/policies/[POLICY]";
            // Make the request
            Policy response = designCenterClient.GetPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyAsync</summary>
        public async Task GetPolicyAsync()
        {
            // Snippet: GetPolicyAsync(string, CallSettings)
            // Additional: GetPolicyAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/policies/[POLICY]";
            // Make the request
            Policy response = await designCenterClient.GetPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicy</summary>
        public void GetPolicyResourceNames()
        {
            // Snippet: GetPolicy(PolicyName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            PolicyName name = PolicyName.FromProjectLocationSpaceApplicationTemplatePolicy("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[POLICY]");
            // Make the request
            Policy response = designCenterClient.GetPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyAsync</summary>
        public async Task GetPolicyResourceNamesAsync()
        {
            // Snippet: GetPolicyAsync(PolicyName, CallSettings)
            // Additional: GetPolicyAsync(PolicyName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            PolicyName name = PolicyName.FromProjectLocationSpaceApplicationTemplatePolicy("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[POLICY]");
            // Make the request
            Policy response = await designCenterClient.GetPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPolicies</summary>
        public void ListPoliciesRequestObject()
        {
            // Snippet: ListPolicies(ListPoliciesRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ListPoliciesRequest request = new ListPoliciesRequest
            {
                ParentAsApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListPoliciesResponse, Policy> response = designCenterClient.ListPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Policy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPoliciesAsync</summary>
        public async Task ListPoliciesRequestObjectAsync()
        {
            // Snippet: ListPoliciesAsync(ListPoliciesRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListPoliciesRequest request = new ListPoliciesRequest
            {
                ParentAsApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPoliciesResponse, Policy> response = designCenterClient.ListPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Policy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicies</summary>
        public void ListPolicies()
        {
            // Snippet: ListPolicies(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            PagedEnumerable<ListPoliciesResponse, Policy> response = designCenterClient.ListPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Policy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPoliciesAsync</summary>
        public async Task ListPoliciesAsync()
        {
            // Snippet: ListPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            PagedAsyncEnumerable<ListPoliciesResponse, Policy> response = designCenterClient.ListPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Policy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicies</summary>
        public void ListPoliciesResourceNames()
        {
            // Snippet: ListPolicies(ApplicationTemplateName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateName parent = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            PagedEnumerable<ListPoliciesResponse, Policy> response = designCenterClient.ListPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Policy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPoliciesAsync</summary>
        public async Task ListPoliciesResourceNamesAsync()
        {
            // Snippet: ListPoliciesAsync(ApplicationTemplateName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateName parent = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            PagedAsyncEnumerable<ListPoliciesResponse, Policy> response = designCenterClient.ListPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Policy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreatePolicy</summary>
        public void CreatePolicyRequestObject()
        {
            // Snippet: CreatePolicy(CreatePolicyRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            CreatePolicyRequest request = new CreatePolicyRequest
            {
                ParentAsApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                PolicyId = "",
                Policy = new Policy(),
            };
            // Make the request
            Policy response = designCenterClient.CreatePolicy(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyAsync</summary>
        public async Task CreatePolicyRequestObjectAsync()
        {
            // Snippet: CreatePolicyAsync(CreatePolicyRequest, CallSettings)
            // Additional: CreatePolicyAsync(CreatePolicyRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreatePolicyRequest request = new CreatePolicyRequest
            {
                ParentAsApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                PolicyId = "",
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await designCenterClient.CreatePolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicy</summary>
        public void CreatePolicy()
        {
            // Snippet: CreatePolicy(string, Policy, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            Policy policy = new Policy();
            string policyId = "";
            // Make the request
            Policy response = designCenterClient.CreatePolicy(parent, policy, policyId);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyAsync</summary>
        public async Task CreatePolicyAsync()
        {
            // Snippet: CreatePolicyAsync(string, Policy, string, CallSettings)
            // Additional: CreatePolicyAsync(string, Policy, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            Policy policy = new Policy();
            string policyId = "";
            // Make the request
            Policy response = await designCenterClient.CreatePolicyAsync(parent, policy, policyId);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicy</summary>
        public void CreatePolicyResourceNames()
        {
            // Snippet: CreatePolicy(ApplicationTemplateName, Policy, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateName parent = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            Policy policy = new Policy();
            string policyId = "";
            // Make the request
            Policy response = designCenterClient.CreatePolicy(parent, policy, policyId);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyAsync</summary>
        public async Task CreatePolicyResourceNamesAsync()
        {
            // Snippet: CreatePolicyAsync(ApplicationTemplateName, Policy, string, CallSettings)
            // Additional: CreatePolicyAsync(ApplicationTemplateName, Policy, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateName parent = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            Policy policy = new Policy();
            string policyId = "";
            // Make the request
            Policy response = await designCenterClient.CreatePolicyAsync(parent, policy, policyId);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicy</summary>
        public void UpdatePolicyRequestObject()
        {
            // Snippet: UpdatePolicy(UpdatePolicyRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                UpdateMask = new FieldMask(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = designCenterClient.UpdatePolicy(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicyAsync</summary>
        public async Task UpdatePolicyRequestObjectAsync()
        {
            // Snippet: UpdatePolicyAsync(UpdatePolicyRequest, CallSettings)
            // Additional: UpdatePolicyAsync(UpdatePolicyRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                UpdateMask = new FieldMask(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await designCenterClient.UpdatePolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicy</summary>
        public void UpdatePolicy()
        {
            // Snippet: UpdatePolicy(Policy, FieldMask, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            Policy policy = new Policy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Policy response = designCenterClient.UpdatePolicy(policy, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicyAsync</summary>
        public async Task UpdatePolicyAsync()
        {
            // Snippet: UpdatePolicyAsync(Policy, FieldMask, CallSettings)
            // Additional: UpdatePolicyAsync(Policy, FieldMask, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            Policy policy = new Policy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Policy response = await designCenterClient.UpdatePolicyAsync(policy, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicy</summary>
        public void DeletePolicyRequestObject()
        {
            // Snippet: DeletePolicy(DeletePolicyRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            DeletePolicyRequest request = new DeletePolicyRequest
            {
                PolicyName = PolicyName.FromProjectLocationSpaceApplicationTemplatePolicy("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[POLICY]"),
            };
            // Make the request
            designCenterClient.DeletePolicy(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyAsync</summary>
        public async Task DeletePolicyRequestObjectAsync()
        {
            // Snippet: DeletePolicyAsync(DeletePolicyRequest, CallSettings)
            // Additional: DeletePolicyAsync(DeletePolicyRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeletePolicyRequest request = new DeletePolicyRequest
            {
                PolicyName = PolicyName.FromProjectLocationSpaceApplicationTemplatePolicy("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[POLICY]"),
            };
            // Make the request
            await designCenterClient.DeletePolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicy</summary>
        public void DeletePolicy()
        {
            // Snippet: DeletePolicy(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/policies/[POLICY]";
            // Make the request
            designCenterClient.DeletePolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyAsync</summary>
        public async Task DeletePolicyAsync()
        {
            // Snippet: DeletePolicyAsync(string, CallSettings)
            // Additional: DeletePolicyAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/policies/[POLICY]";
            // Make the request
            await designCenterClient.DeletePolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicy</summary>
        public void DeletePolicyResourceNames()
        {
            // Snippet: DeletePolicy(PolicyName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            PolicyName name = PolicyName.FromProjectLocationSpaceApplicationTemplatePolicy("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[POLICY]");
            // Make the request
            designCenterClient.DeletePolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyAsync</summary>
        public async Task DeletePolicyResourceNamesAsync()
        {
            // Snippet: DeletePolicyAsync(PolicyName, CallSettings)
            // Additional: DeletePolicyAsync(PolicyName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            PolicyName name = PolicyName.FromProjectLocationSpaceApplicationTemplatePolicy("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[POLICY]");
            // Make the request
            await designCenterClient.DeletePolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for FetchFrameworks</summary>
        public void FetchFrameworksRequestObject()
        {
            // Snippet: FetchFrameworks(FetchFrameworksRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            FetchFrameworksRequest request = new FetchFrameworksRequest
            {
                Parent = "",
                Projects = { "", },
                Filter = "",
            };
            // Make the request
            PagedEnumerable<FetchFrameworksResponse, Framework> response = designCenterClient.FetchFrameworks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Framework item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchFrameworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Framework item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Framework> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Framework item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchFrameworksAsync</summary>
        public async Task FetchFrameworksRequestObjectAsync()
        {
            // Snippet: FetchFrameworksAsync(FetchFrameworksRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            FetchFrameworksRequest request = new FetchFrameworksRequest
            {
                Parent = "",
                Projects = { "", },
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<FetchFrameworksResponse, Framework> response = designCenterClient.FetchFrameworksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Framework item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchFrameworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Framework item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Framework> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Framework item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchFrameworks</summary>
        public void FetchFrameworks()
        {
            // Snippet: FetchFrameworks(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<FetchFrameworksResponse, Framework> response = designCenterClient.FetchFrameworks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Framework item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchFrameworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Framework item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Framework> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Framework item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchFrameworksAsync</summary>
        public async Task FetchFrameworksAsync()
        {
            // Snippet: FetchFrameworksAsync(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<FetchFrameworksResponse, Framework> response = designCenterClient.FetchFrameworksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Framework item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchFrameworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Framework item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Framework> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Framework item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationIaC</summary>
        public void GenerateApplicationIaCRequestObject()
        {
            // Snippet: GenerateApplicationIaC(GenerateApplicationIaCRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GenerateApplicationIaCRequest request = new GenerateApplicationIaCRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
                IacFormat = IACFormat.Unspecified,
                ArtifactLocation = new ArtifactLocation(),
            };
            // Make the request
            GenerateApplicationIaCResponse response = designCenterClient.GenerateApplicationIaC(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationIaCAsync</summary>
        public async Task GenerateApplicationIaCRequestObjectAsync()
        {
            // Snippet: GenerateApplicationIaCAsync(GenerateApplicationIaCRequest, CallSettings)
            // Additional: GenerateApplicationIaCAsync(GenerateApplicationIaCRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GenerateApplicationIaCRequest request = new GenerateApplicationIaCRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
                IacFormat = IACFormat.Unspecified,
                ArtifactLocation = new ArtifactLocation(),
            };
            // Make the request
            GenerateApplicationIaCResponse response = await designCenterClient.GenerateApplicationIaCAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationIaC</summary>
        public void GenerateApplicationIaC()
        {
            // Snippet: GenerateApplicationIaC(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            GenerateApplicationIaCResponse response = designCenterClient.GenerateApplicationIaC(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationIaCAsync</summary>
        public async Task GenerateApplicationIaCAsync()
        {
            // Snippet: GenerateApplicationIaCAsync(string, CallSettings)
            // Additional: GenerateApplicationIaCAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            GenerateApplicationIaCResponse response = await designCenterClient.GenerateApplicationIaCAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationIaC</summary>
        public void GenerateApplicationIaCResourceNames()
        {
            // Snippet: GenerateApplicationIaC(ApplicationName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            GenerateApplicationIaCResponse response = designCenterClient.GenerateApplicationIaC(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateApplicationIaCAsync</summary>
        public async Task GenerateApplicationIaCResourceNamesAsync()
        {
            // Snippet: GenerateApplicationIaCAsync(ApplicationName, CallSettings)
            // Additional: GenerateApplicationIaCAsync(ApplicationName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            GenerateApplicationIaCResponse response = await designCenterClient.GenerateApplicationIaCAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationIaC</summary>
        public void ExportApplicationIaCRequestObject()
        {
            // Snippet: ExportApplicationIaC(ExportApplicationIaCRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ExportApplicationIaCRequest request = new ExportApplicationIaCRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
                IacFormat = IACFormat.Unspecified,
                ArtifactLocation = new ArtifactLocation(),
                ExportIacConfig = new ExportIaCConfig(),
            };
            // Make the request
            Operation<ExportApplicationIaCResponse, OperationMetadata> response = designCenterClient.ExportApplicationIaC(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationIaCResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportApplicationIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationIaCResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceExportApplicationIaC(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationIaCAsync</summary>
        public async Task ExportApplicationIaCRequestObjectAsync()
        {
            // Snippet: ExportApplicationIaCAsync(ExportApplicationIaCRequest, CallSettings)
            // Additional: ExportApplicationIaCAsync(ExportApplicationIaCRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ExportApplicationIaCRequest request = new ExportApplicationIaCRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
                IacFormat = IACFormat.Unspecified,
                ArtifactLocation = new ArtifactLocation(),
                ExportIacConfig = new ExportIaCConfig(),
            };
            // Make the request
            Operation<ExportApplicationIaCResponse, OperationMetadata> response = await designCenterClient.ExportApplicationIaCAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationIaCResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportApplicationIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationIaCResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceExportApplicationIaCAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationIaC</summary>
        public void ExportApplicationIaC()
        {
            // Snippet: ExportApplicationIaC(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            Operation<ExportApplicationIaCResponse, OperationMetadata> response = designCenterClient.ExportApplicationIaC(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationIaCResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportApplicationIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationIaCResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceExportApplicationIaC(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationIaCAsync</summary>
        public async Task ExportApplicationIaCAsync()
        {
            // Snippet: ExportApplicationIaCAsync(string, CallSettings)
            // Additional: ExportApplicationIaCAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            Operation<ExportApplicationIaCResponse, OperationMetadata> response = await designCenterClient.ExportApplicationIaCAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationIaCResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportApplicationIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationIaCResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceExportApplicationIaCAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationIaC</summary>
        public void ExportApplicationIaCResourceNames()
        {
            // Snippet: ExportApplicationIaC(ApplicationName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            Operation<ExportApplicationIaCResponse, OperationMetadata> response = designCenterClient.ExportApplicationIaC(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationIaCResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportApplicationIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationIaCResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceExportApplicationIaC(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApplicationIaCAsync</summary>
        public async Task ExportApplicationIaCResourceNamesAsync()
        {
            // Snippet: ExportApplicationIaCAsync(ApplicationName, CallSettings)
            // Additional: ExportApplicationIaCAsync(ApplicationName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            Operation<ExportApplicationIaCResponse, OperationMetadata> response = await designCenterClient.ExportApplicationIaCAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportApplicationIaCResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportApplicationIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportApplicationIaCResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceExportApplicationIaCAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportApplicationIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationTemplateIaC</summary>
        public void ImportApplicationTemplateIaCRequestObject()
        {
            // Snippet: ImportApplicationTemplateIaC(ImportApplicationTemplateIaCRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ImportApplicationTemplateIaCRequest request = new ImportApplicationTemplateIaCRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                GcsUri = "",
                AllowPartialImport = false,
                ValidateIac = false,
            };
            // Make the request
            ImportApplicationTemplateIaCResponse response = designCenterClient.ImportApplicationTemplateIaC(request);
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationTemplateIaCAsync</summary>
        public async Task ImportApplicationTemplateIaCRequestObjectAsync()
        {
            // Snippet: ImportApplicationTemplateIaCAsync(ImportApplicationTemplateIaCRequest, CallSettings)
            // Additional: ImportApplicationTemplateIaCAsync(ImportApplicationTemplateIaCRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ImportApplicationTemplateIaCRequest request = new ImportApplicationTemplateIaCRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                GcsUri = "",
                AllowPartialImport = false,
                ValidateIac = false,
            };
            // Make the request
            ImportApplicationTemplateIaCResponse response = await designCenterClient.ImportApplicationTemplateIaCAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationTemplateIaC</summary>
        public void ImportApplicationTemplateIaC()
        {
            // Snippet: ImportApplicationTemplateIaC(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            ImportApplicationTemplateIaCResponse response = designCenterClient.ImportApplicationTemplateIaC(name);
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationTemplateIaCAsync</summary>
        public async Task ImportApplicationTemplateIaCAsync()
        {
            // Snippet: ImportApplicationTemplateIaCAsync(string, CallSettings)
            // Additional: ImportApplicationTemplateIaCAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            ImportApplicationTemplateIaCResponse response = await designCenterClient.ImportApplicationTemplateIaCAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationTemplateIaC</summary>
        public void ImportApplicationTemplateIaCResourceNames()
        {
            // Snippet: ImportApplicationTemplateIaC(ApplicationTemplateName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            ImportApplicationTemplateIaCResponse response = designCenterClient.ImportApplicationTemplateIaC(name);
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationTemplateIaCAsync</summary>
        public async Task ImportApplicationTemplateIaCResourceNamesAsync()
        {
            // Snippet: ImportApplicationTemplateIaCAsync(ApplicationTemplateName, CallSettings)
            // Additional: ImportApplicationTemplateIaCAsync(ApplicationTemplateName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            ImportApplicationTemplateIaCResponse response = await designCenterClient.ImportApplicationTemplateIaCAsync(name);
            // End snippet
        }

        /// <summary>Snippet for IngestApplicationTemplateIaC</summary>
        public void IngestApplicationTemplateIaCRequestObject()
        {
            // Snippet: IngestApplicationTemplateIaC(IngestApplicationTemplateIaCRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            IngestApplicationTemplateIaCRequest request = new IngestApplicationTemplateIaCRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                GcsUri = "",
                ValidateCatalogCompatibility = false,
                RawTerraformImportEnabled = false,
            };
            // Make the request
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> response = designCenterClient.IngestApplicationTemplateIaC(request);

            // Poll until the returned long-running operation is complete
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IngestApplicationTemplateIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceIngestApplicationTemplateIaC(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IngestApplicationTemplateIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for IngestApplicationTemplateIaCAsync</summary>
        public async Task IngestApplicationTemplateIaCRequestObjectAsync()
        {
            // Snippet: IngestApplicationTemplateIaCAsync(IngestApplicationTemplateIaCRequest, CallSettings)
            // Additional: IngestApplicationTemplateIaCAsync(IngestApplicationTemplateIaCRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            IngestApplicationTemplateIaCRequest request = new IngestApplicationTemplateIaCRequest
            {
                ApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                GcsUri = "",
                ValidateCatalogCompatibility = false,
                RawTerraformImportEnabled = false,
            };
            // Make the request
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> response = await designCenterClient.IngestApplicationTemplateIaCAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IngestApplicationTemplateIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceIngestApplicationTemplateIaCAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IngestApplicationTemplateIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for IngestApplicationTemplateIaC</summary>
        public void IngestApplicationTemplateIaC()
        {
            // Snippet: IngestApplicationTemplateIaC(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> response = designCenterClient.IngestApplicationTemplateIaC(name);

            // Poll until the returned long-running operation is complete
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IngestApplicationTemplateIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceIngestApplicationTemplateIaC(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IngestApplicationTemplateIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for IngestApplicationTemplateIaCAsync</summary>
        public async Task IngestApplicationTemplateIaCAsync()
        {
            // Snippet: IngestApplicationTemplateIaCAsync(string, CallSettings)
            // Additional: IngestApplicationTemplateIaCAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> response = await designCenterClient.IngestApplicationTemplateIaCAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IngestApplicationTemplateIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceIngestApplicationTemplateIaCAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IngestApplicationTemplateIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for IngestApplicationTemplateIaC</summary>
        public void IngestApplicationTemplateIaCResourceNames()
        {
            // Snippet: IngestApplicationTemplateIaC(ApplicationTemplateName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> response = designCenterClient.IngestApplicationTemplateIaC(name);

            // Poll until the returned long-running operation is complete
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IngestApplicationTemplateIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceIngestApplicationTemplateIaC(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IngestApplicationTemplateIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for IngestApplicationTemplateIaCAsync</summary>
        public async Task IngestApplicationTemplateIaCResourceNamesAsync()
        {
            // Snippet: IngestApplicationTemplateIaCAsync(ApplicationTemplateName, CallSettings)
            // Additional: IngestApplicationTemplateIaCAsync(ApplicationTemplateName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateName name = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> response = await designCenterClient.IngestApplicationTemplateIaCAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IngestApplicationTemplateIaCResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceIngestApplicationTemplateIaCAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IngestApplicationTemplateIaCResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationIaC</summary>
        public void ImportApplicationIaCRequestObject()
        {
            // Snippet: ImportApplicationIaC(ImportApplicationIaCRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ImportApplicationIaCRequest request = new ImportApplicationIaCRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
                GcsUri = "",
                AllowPartialImport = false,
                ValidateIac = false,
            };
            // Make the request
            ImportApplicationIaCResponse response = designCenterClient.ImportApplicationIaC(request);
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationIaCAsync</summary>
        public async Task ImportApplicationIaCRequestObjectAsync()
        {
            // Snippet: ImportApplicationIaCAsync(ImportApplicationIaCRequest, CallSettings)
            // Additional: ImportApplicationIaCAsync(ImportApplicationIaCRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ImportApplicationIaCRequest request = new ImportApplicationIaCRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
                GcsUri = "",
                AllowPartialImport = false,
                ValidateIac = false,
            };
            // Make the request
            ImportApplicationIaCResponse response = await designCenterClient.ImportApplicationIaCAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationIaC</summary>
        public void ImportApplicationIaC()
        {
            // Snippet: ImportApplicationIaC(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            ImportApplicationIaCResponse response = designCenterClient.ImportApplicationIaC(name);
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationIaCAsync</summary>
        public async Task ImportApplicationIaCAsync()
        {
            // Snippet: ImportApplicationIaCAsync(string, CallSettings)
            // Additional: ImportApplicationIaCAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            ImportApplicationIaCResponse response = await designCenterClient.ImportApplicationIaCAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationIaC</summary>
        public void ImportApplicationIaCResourceNames()
        {
            // Snippet: ImportApplicationIaC(ApplicationName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            ImportApplicationIaCResponse response = designCenterClient.ImportApplicationIaC(name);
            // End snippet
        }

        /// <summary>Snippet for ImportApplicationIaCAsync</summary>
        public async Task ImportApplicationIaCResourceNamesAsync()
        {
            // Snippet: ImportApplicationIaCAsync(ApplicationName, CallSettings)
            // Additional: ImportApplicationIaCAsync(ApplicationName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            ImportApplicationIaCResponse response = await designCenterClient.ImportApplicationIaCAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RegisterAppHubApplicationResources</summary>
        public void RegisterAppHubApplicationResourcesRequestObject()
        {
            // Snippet: RegisterAppHubApplicationResources(RegisterAppHubApplicationResourcesRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            RegisterAppHubApplicationResourcesRequest request = new RegisterAppHubApplicationResourcesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TfstateContent = "",
                ApphubApplication = "",
            };
            // Make the request
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> response = designCenterClient.RegisterAppHubApplicationResources(request);

            // Poll until the returned long-running operation is complete
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RegisterAppHubApplicationResourcesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceRegisterAppHubApplicationResources(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RegisterAppHubApplicationResourcesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterAppHubApplicationResourcesAsync</summary>
        public async Task RegisterAppHubApplicationResourcesRequestObjectAsync()
        {
            // Snippet: RegisterAppHubApplicationResourcesAsync(RegisterAppHubApplicationResourcesRequest, CallSettings)
            // Additional: RegisterAppHubApplicationResourcesAsync(RegisterAppHubApplicationResourcesRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            RegisterAppHubApplicationResourcesRequest request = new RegisterAppHubApplicationResourcesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TfstateContent = "",
                ApphubApplication = "",
            };
            // Make the request
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> response = await designCenterClient.RegisterAppHubApplicationResourcesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RegisterAppHubApplicationResourcesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceRegisterAppHubApplicationResourcesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RegisterAppHubApplicationResourcesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterAppHubApplicationResources</summary>
        public void RegisterAppHubApplicationResources()
        {
            // Snippet: RegisterAppHubApplicationResources(string, string, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string apphubApplication = "";
            string tfstateContent = "";
            // Make the request
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> response = designCenterClient.RegisterAppHubApplicationResources(parent, apphubApplication, tfstateContent);

            // Poll until the returned long-running operation is complete
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RegisterAppHubApplicationResourcesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceRegisterAppHubApplicationResources(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RegisterAppHubApplicationResourcesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterAppHubApplicationResourcesAsync</summary>
        public async Task RegisterAppHubApplicationResourcesAsync()
        {
            // Snippet: RegisterAppHubApplicationResourcesAsync(string, string, string, CallSettings)
            // Additional: RegisterAppHubApplicationResourcesAsync(string, string, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string apphubApplication = "";
            string tfstateContent = "";
            // Make the request
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> response = await designCenterClient.RegisterAppHubApplicationResourcesAsync(parent, apphubApplication, tfstateContent);

            // Poll until the returned long-running operation is complete
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RegisterAppHubApplicationResourcesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceRegisterAppHubApplicationResourcesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RegisterAppHubApplicationResourcesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterAppHubApplicationResources</summary>
        public void RegisterAppHubApplicationResourcesResourceNames()
        {
            // Snippet: RegisterAppHubApplicationResources(LocationName, string, string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string apphubApplication = "";
            string tfstateContent = "";
            // Make the request
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> response = designCenterClient.RegisterAppHubApplicationResources(parent, apphubApplication, tfstateContent);

            // Poll until the returned long-running operation is complete
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RegisterAppHubApplicationResourcesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceRegisterAppHubApplicationResources(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RegisterAppHubApplicationResourcesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterAppHubApplicationResourcesAsync</summary>
        public async Task RegisterAppHubApplicationResourcesResourceNamesAsync()
        {
            // Snippet: RegisterAppHubApplicationResourcesAsync(LocationName, string, string, CallSettings)
            // Additional: RegisterAppHubApplicationResourcesAsync(LocationName, string, string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string apphubApplication = "";
            string tfstateContent = "";
            // Make the request
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> response = await designCenterClient.RegisterAppHubApplicationResourcesAsync(parent, apphubApplication, tfstateContent);

            // Poll until the returned long-running operation is complete
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RegisterAppHubApplicationResourcesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceRegisterAppHubApplicationResourcesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RegisterAppHubApplicationResourcesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplateSystemRevisions</summary>
        public void ListApplicationTemplateSystemRevisionsRequestObject()
        {
            // Snippet: ListApplicationTemplateSystemRevisions(ListApplicationTemplateSystemRevisionsRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ListApplicationTemplateSystemRevisionsRequest request = new ListApplicationTemplateSystemRevisionsRequest
            {
                ParentAsApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListApplicationTemplateSystemRevisionsResponse, ApplicationTemplateSystemRevision> response = designCenterClient.ListApplicationTemplateSystemRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApplicationTemplateSystemRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationTemplateSystemRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplateSystemRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplateSystemRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplateSystemRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplateSystemRevisionsAsync</summary>
        public async Task ListApplicationTemplateSystemRevisionsRequestObjectAsync()
        {
            // Snippet: ListApplicationTemplateSystemRevisionsAsync(ListApplicationTemplateSystemRevisionsRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListApplicationTemplateSystemRevisionsRequest request = new ListApplicationTemplateSystemRevisionsRequest
            {
                ParentAsApplicationTemplateName = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListApplicationTemplateSystemRevisionsResponse, ApplicationTemplateSystemRevision> response = designCenterClient.ListApplicationTemplateSystemRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ApplicationTemplateSystemRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListApplicationTemplateSystemRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplateSystemRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplateSystemRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplateSystemRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplateSystemRevisions</summary>
        public void ListApplicationTemplateSystemRevisions()
        {
            // Snippet: ListApplicationTemplateSystemRevisions(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            PagedEnumerable<ListApplicationTemplateSystemRevisionsResponse, ApplicationTemplateSystemRevision> response = designCenterClient.ListApplicationTemplateSystemRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApplicationTemplateSystemRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationTemplateSystemRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplateSystemRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplateSystemRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplateSystemRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplateSystemRevisionsAsync</summary>
        public async Task ListApplicationTemplateSystemRevisionsAsync()
        {
            // Snippet: ListApplicationTemplateSystemRevisionsAsync(string, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]";
            // Make the request
            PagedAsyncEnumerable<ListApplicationTemplateSystemRevisionsResponse, ApplicationTemplateSystemRevision> response = designCenterClient.ListApplicationTemplateSystemRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ApplicationTemplateSystemRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListApplicationTemplateSystemRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplateSystemRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplateSystemRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplateSystemRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplateSystemRevisions</summary>
        public void ListApplicationTemplateSystemRevisionsResourceNames()
        {
            // Snippet: ListApplicationTemplateSystemRevisions(ApplicationTemplateName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateName parent = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            PagedEnumerable<ListApplicationTemplateSystemRevisionsResponse, ApplicationTemplateSystemRevision> response = designCenterClient.ListApplicationTemplateSystemRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApplicationTemplateSystemRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationTemplateSystemRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplateSystemRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplateSystemRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplateSystemRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationTemplateSystemRevisionsAsync</summary>
        public async Task ListApplicationTemplateSystemRevisionsResourceNamesAsync()
        {
            // Snippet: ListApplicationTemplateSystemRevisionsAsync(ApplicationTemplateName, string, int?, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateName parent = ApplicationTemplateName.FromProjectLocationSpaceApplicationTemplate("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]");
            // Make the request
            PagedAsyncEnumerable<ListApplicationTemplateSystemRevisionsResponse, ApplicationTemplateSystemRevision> response = designCenterClient.ListApplicationTemplateSystemRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ApplicationTemplateSystemRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListApplicationTemplateSystemRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApplicationTemplateSystemRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApplicationTemplateSystemRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApplicationTemplateSystemRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplateSystemRevision</summary>
        public void GetApplicationTemplateSystemRevisionRequestObject()
        {
            // Snippet: GetApplicationTemplateSystemRevision(GetApplicationTemplateSystemRevisionRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            GetApplicationTemplateSystemRevisionRequest request = new GetApplicationTemplateSystemRevisionRequest
            {
                ApplicationTemplateSystemRevisionName = ApplicationTemplateSystemRevisionName.FromProjectLocationSpaceApplicationTemplateSystemRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[SYSTEM_REVISION]"),
            };
            // Make the request
            ApplicationTemplateSystemRevision response = designCenterClient.GetApplicationTemplateSystemRevision(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplateSystemRevisionAsync</summary>
        public async Task GetApplicationTemplateSystemRevisionRequestObjectAsync()
        {
            // Snippet: GetApplicationTemplateSystemRevisionAsync(GetApplicationTemplateSystemRevisionRequest, CallSettings)
            // Additional: GetApplicationTemplateSystemRevisionAsync(GetApplicationTemplateSystemRevisionRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetApplicationTemplateSystemRevisionRequest request = new GetApplicationTemplateSystemRevisionRequest
            {
                ApplicationTemplateSystemRevisionName = ApplicationTemplateSystemRevisionName.FromProjectLocationSpaceApplicationTemplateSystemRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[SYSTEM_REVISION]"),
            };
            // Make the request
            ApplicationTemplateSystemRevision response = await designCenterClient.GetApplicationTemplateSystemRevisionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplateSystemRevision</summary>
        public void GetApplicationTemplateSystemRevision()
        {
            // Snippet: GetApplicationTemplateSystemRevision(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/systemRevisions/[SYSTEM_REVISION]";
            // Make the request
            ApplicationTemplateSystemRevision response = designCenterClient.GetApplicationTemplateSystemRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplateSystemRevisionAsync</summary>
        public async Task GetApplicationTemplateSystemRevisionAsync()
        {
            // Snippet: GetApplicationTemplateSystemRevisionAsync(string, CallSettings)
            // Additional: GetApplicationTemplateSystemRevisionAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applicationTemplates/[APPLICATION_TEMPLATE]/systemRevisions/[SYSTEM_REVISION]";
            // Make the request
            ApplicationTemplateSystemRevision response = await designCenterClient.GetApplicationTemplateSystemRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplateSystemRevision</summary>
        public void GetApplicationTemplateSystemRevisionResourceNames()
        {
            // Snippet: GetApplicationTemplateSystemRevision(ApplicationTemplateSystemRevisionName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationTemplateSystemRevisionName name = ApplicationTemplateSystemRevisionName.FromProjectLocationSpaceApplicationTemplateSystemRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[SYSTEM_REVISION]");
            // Make the request
            ApplicationTemplateSystemRevision response = designCenterClient.GetApplicationTemplateSystemRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationTemplateSystemRevisionAsync</summary>
        public async Task GetApplicationTemplateSystemRevisionResourceNamesAsync()
        {
            // Snippet: GetApplicationTemplateSystemRevisionAsync(ApplicationTemplateSystemRevisionName, CallSettings)
            // Additional: GetApplicationTemplateSystemRevisionAsync(ApplicationTemplateSystemRevisionName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationTemplateSystemRevisionName name = ApplicationTemplateSystemRevisionName.FromProjectLocationSpaceApplicationTemplateSystemRevision("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION_TEMPLATE]", "[SYSTEM_REVISION]");
            // Make the request
            ApplicationTemplateSystemRevision response = await designCenterClient.GetApplicationTemplateSystemRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RecommendIAMRoles</summary>
        public void RecommendIAMRolesRequestObject()
        {
            // Snippet: RecommendIAMRoles(RecommendIAMRolesRequest, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            RecommendIAMRolesRequest request = new RecommendIAMRolesRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
            };
            // Make the request
            Operation<RecommendIAMRolesResponse, OperationMetadata> response = designCenterClient.RecommendIAMRoles(request);

            // Poll until the returned long-running operation is complete
            Operation<RecommendIAMRolesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RecommendIAMRolesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RecommendIAMRolesResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceRecommendIAMRoles(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RecommendIAMRolesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RecommendIAMRolesAsync</summary>
        public async Task RecommendIAMRolesRequestObjectAsync()
        {
            // Snippet: RecommendIAMRolesAsync(RecommendIAMRolesRequest, CallSettings)
            // Additional: RecommendIAMRolesAsync(RecommendIAMRolesRequest, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            RecommendIAMRolesRequest request = new RecommendIAMRolesRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]"),
            };
            // Make the request
            Operation<RecommendIAMRolesResponse, OperationMetadata> response = await designCenterClient.RecommendIAMRolesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RecommendIAMRolesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RecommendIAMRolesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RecommendIAMRolesResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceRecommendIAMRolesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RecommendIAMRolesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RecommendIAMRoles</summary>
        public void RecommendIAMRoles()
        {
            // Snippet: RecommendIAMRoles(string, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            Operation<RecommendIAMRolesResponse, OperationMetadata> response = designCenterClient.RecommendIAMRoles(name);

            // Poll until the returned long-running operation is complete
            Operation<RecommendIAMRolesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RecommendIAMRolesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RecommendIAMRolesResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceRecommendIAMRoles(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RecommendIAMRolesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RecommendIAMRolesAsync</summary>
        public async Task RecommendIAMRolesAsync()
        {
            // Snippet: RecommendIAMRolesAsync(string, CallSettings)
            // Additional: RecommendIAMRolesAsync(string, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spaces/[SPACE]/applications/[APPLICATION]";
            // Make the request
            Operation<RecommendIAMRolesResponse, OperationMetadata> response = await designCenterClient.RecommendIAMRolesAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<RecommendIAMRolesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RecommendIAMRolesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RecommendIAMRolesResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceRecommendIAMRolesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RecommendIAMRolesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RecommendIAMRoles</summary>
        public void RecommendIAMRolesResourceNames()
        {
            // Snippet: RecommendIAMRoles(ApplicationName, CallSettings)
            // Create client
            DesignCenterClient designCenterClient = DesignCenterClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            Operation<RecommendIAMRolesResponse, OperationMetadata> response = designCenterClient.RecommendIAMRoles(name);

            // Poll until the returned long-running operation is complete
            Operation<RecommendIAMRolesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RecommendIAMRolesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RecommendIAMRolesResponse, OperationMetadata> retrievedResponse = designCenterClient.PollOnceRecommendIAMRoles(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RecommendIAMRolesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RecommendIAMRolesAsync</summary>
        public async Task RecommendIAMRolesResourceNamesAsync()
        {
            // Snippet: RecommendIAMRolesAsync(ApplicationName, CallSettings)
            // Additional: RecommendIAMRolesAsync(ApplicationName, CancellationToken)
            // Create client
            DesignCenterClient designCenterClient = await DesignCenterClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationSpaceApplication("[PROJECT]", "[LOCATION]", "[SPACE]", "[APPLICATION]");
            // Make the request
            Operation<RecommendIAMRolesResponse, OperationMetadata> response = await designCenterClient.RecommendIAMRolesAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<RecommendIAMRolesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RecommendIAMRolesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RecommendIAMRolesResponse, OperationMetadata> retrievedResponse = await designCenterClient.PollOnceRecommendIAMRolesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RecommendIAMRolesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
