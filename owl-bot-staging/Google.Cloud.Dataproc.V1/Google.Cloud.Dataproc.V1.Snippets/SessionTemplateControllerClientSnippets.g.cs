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
    using Google.Cloud.Dataproc.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSessionTemplateControllerClientSnippets
    {
        /// <summary>Snippet for CreateSessionTemplate</summary>
        public void CreateSessionTemplateRequestObject()
        {
            // Snippet: CreateSessionTemplate(CreateSessionTemplateRequest, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = SessionTemplateControllerClient.Create();
            // Initialize request argument(s)
            CreateSessionTemplateRequest request = new CreateSessionTemplateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SessionTemplate = new SessionTemplate(),
            };
            // Make the request
            SessionTemplate response = sessionTemplateControllerClient.CreateSessionTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionTemplateAsync</summary>
        public async Task CreateSessionTemplateRequestObjectAsync()
        {
            // Snippet: CreateSessionTemplateAsync(CreateSessionTemplateRequest, CallSettings)
            // Additional: CreateSessionTemplateAsync(CreateSessionTemplateRequest, CancellationToken)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = await SessionTemplateControllerClient.CreateAsync();
            // Initialize request argument(s)
            CreateSessionTemplateRequest request = new CreateSessionTemplateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SessionTemplate = new SessionTemplate(),
            };
            // Make the request
            SessionTemplate response = await sessionTemplateControllerClient.CreateSessionTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionTemplate</summary>
        public void CreateSessionTemplate()
        {
            // Snippet: CreateSessionTemplate(string, SessionTemplate, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = SessionTemplateControllerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SessionTemplate sessionTemplate = new SessionTemplate();
            // Make the request
            SessionTemplate response = sessionTemplateControllerClient.CreateSessionTemplate(parent, sessionTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionTemplateAsync</summary>
        public async Task CreateSessionTemplateAsync()
        {
            // Snippet: CreateSessionTemplateAsync(string, SessionTemplate, CallSettings)
            // Additional: CreateSessionTemplateAsync(string, SessionTemplate, CancellationToken)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = await SessionTemplateControllerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SessionTemplate sessionTemplate = new SessionTemplate();
            // Make the request
            SessionTemplate response = await sessionTemplateControllerClient.CreateSessionTemplateAsync(parent, sessionTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionTemplate</summary>
        public void CreateSessionTemplateResourceNames()
        {
            // Snippet: CreateSessionTemplate(LocationName, SessionTemplate, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = SessionTemplateControllerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SessionTemplate sessionTemplate = new SessionTemplate();
            // Make the request
            SessionTemplate response = sessionTemplateControllerClient.CreateSessionTemplate(parent, sessionTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionTemplateAsync</summary>
        public async Task CreateSessionTemplateResourceNamesAsync()
        {
            // Snippet: CreateSessionTemplateAsync(LocationName, SessionTemplate, CallSettings)
            // Additional: CreateSessionTemplateAsync(LocationName, SessionTemplate, CancellationToken)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = await SessionTemplateControllerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SessionTemplate sessionTemplate = new SessionTemplate();
            // Make the request
            SessionTemplate response = await sessionTemplateControllerClient.CreateSessionTemplateAsync(parent, sessionTemplate);
            // End snippet
        }

        /// <summary>Snippet for UpdateSessionTemplate</summary>
        public void UpdateSessionTemplateRequestObject()
        {
            // Snippet: UpdateSessionTemplate(UpdateSessionTemplateRequest, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = SessionTemplateControllerClient.Create();
            // Initialize request argument(s)
            UpdateSessionTemplateRequest request = new UpdateSessionTemplateRequest
            {
                SessionTemplate = new SessionTemplate(),
            };
            // Make the request
            SessionTemplate response = sessionTemplateControllerClient.UpdateSessionTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSessionTemplateAsync</summary>
        public async Task UpdateSessionTemplateRequestObjectAsync()
        {
            // Snippet: UpdateSessionTemplateAsync(UpdateSessionTemplateRequest, CallSettings)
            // Additional: UpdateSessionTemplateAsync(UpdateSessionTemplateRequest, CancellationToken)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = await SessionTemplateControllerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSessionTemplateRequest request = new UpdateSessionTemplateRequest
            {
                SessionTemplate = new SessionTemplate(),
            };
            // Make the request
            SessionTemplate response = await sessionTemplateControllerClient.UpdateSessionTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSessionTemplate</summary>
        public void UpdateSessionTemplate()
        {
            // Snippet: UpdateSessionTemplate(SessionTemplate, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = SessionTemplateControllerClient.Create();
            // Initialize request argument(s)
            SessionTemplate sessionTemplate = new SessionTemplate();
            // Make the request
            SessionTemplate response = sessionTemplateControllerClient.UpdateSessionTemplate(sessionTemplate);
            // End snippet
        }

        /// <summary>Snippet for UpdateSessionTemplateAsync</summary>
        public async Task UpdateSessionTemplateAsync()
        {
            // Snippet: UpdateSessionTemplateAsync(SessionTemplate, CallSettings)
            // Additional: UpdateSessionTemplateAsync(SessionTemplate, CancellationToken)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = await SessionTemplateControllerClient.CreateAsync();
            // Initialize request argument(s)
            SessionTemplate sessionTemplate = new SessionTemplate();
            // Make the request
            SessionTemplate response = await sessionTemplateControllerClient.UpdateSessionTemplateAsync(sessionTemplate);
            // End snippet
        }

        /// <summary>Snippet for GetSessionTemplate</summary>
        public void GetSessionTemplateRequestObject()
        {
            // Snippet: GetSessionTemplate(GetSessionTemplateRequest, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = SessionTemplateControllerClient.Create();
            // Initialize request argument(s)
            GetSessionTemplateRequest request = new GetSessionTemplateRequest
            {
                SessionTemplateName = SessionTemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
            };
            // Make the request
            SessionTemplate response = sessionTemplateControllerClient.GetSessionTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetSessionTemplateAsync</summary>
        public async Task GetSessionTemplateRequestObjectAsync()
        {
            // Snippet: GetSessionTemplateAsync(GetSessionTemplateRequest, CallSettings)
            // Additional: GetSessionTemplateAsync(GetSessionTemplateRequest, CancellationToken)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = await SessionTemplateControllerClient.CreateAsync();
            // Initialize request argument(s)
            GetSessionTemplateRequest request = new GetSessionTemplateRequest
            {
                SessionTemplateName = SessionTemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
            };
            // Make the request
            SessionTemplate response = await sessionTemplateControllerClient.GetSessionTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSessionTemplate</summary>
        public void GetSessionTemplate()
        {
            // Snippet: GetSessionTemplate(string, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = SessionTemplateControllerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sessionTemplates/[TEMPLATE]";
            // Make the request
            SessionTemplate response = sessionTemplateControllerClient.GetSessionTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetSessionTemplateAsync</summary>
        public async Task GetSessionTemplateAsync()
        {
            // Snippet: GetSessionTemplateAsync(string, CallSettings)
            // Additional: GetSessionTemplateAsync(string, CancellationToken)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = await SessionTemplateControllerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sessionTemplates/[TEMPLATE]";
            // Make the request
            SessionTemplate response = await sessionTemplateControllerClient.GetSessionTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSessionTemplate</summary>
        public void GetSessionTemplateResourceNames()
        {
            // Snippet: GetSessionTemplate(SessionTemplateName, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = SessionTemplateControllerClient.Create();
            // Initialize request argument(s)
            SessionTemplateName name = SessionTemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]");
            // Make the request
            SessionTemplate response = sessionTemplateControllerClient.GetSessionTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetSessionTemplateAsync</summary>
        public async Task GetSessionTemplateResourceNamesAsync()
        {
            // Snippet: GetSessionTemplateAsync(SessionTemplateName, CallSettings)
            // Additional: GetSessionTemplateAsync(SessionTemplateName, CancellationToken)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = await SessionTemplateControllerClient.CreateAsync();
            // Initialize request argument(s)
            SessionTemplateName name = SessionTemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]");
            // Make the request
            SessionTemplate response = await sessionTemplateControllerClient.GetSessionTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSessionTemplates</summary>
        public void ListSessionTemplatesRequestObject()
        {
            // Snippet: ListSessionTemplates(ListSessionTemplatesRequest, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = SessionTemplateControllerClient.Create();
            // Initialize request argument(s)
            ListSessionTemplatesRequest request = new ListSessionTemplatesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListSessionTemplatesResponse, SessionTemplate> response = sessionTemplateControllerClient.ListSessionTemplates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SessionTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSessionTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessionTemplatesAsync</summary>
        public async Task ListSessionTemplatesRequestObjectAsync()
        {
            // Snippet: ListSessionTemplatesAsync(ListSessionTemplatesRequest, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = await SessionTemplateControllerClient.CreateAsync();
            // Initialize request argument(s)
            ListSessionTemplatesRequest request = new ListSessionTemplatesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSessionTemplatesResponse, SessionTemplate> response = sessionTemplateControllerClient.ListSessionTemplatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SessionTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSessionTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessionTemplates</summary>
        public void ListSessionTemplates()
        {
            // Snippet: ListSessionTemplates(string, string, int?, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = SessionTemplateControllerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSessionTemplatesResponse, SessionTemplate> response = sessionTemplateControllerClient.ListSessionTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SessionTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSessionTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessionTemplatesAsync</summary>
        public async Task ListSessionTemplatesAsync()
        {
            // Snippet: ListSessionTemplatesAsync(string, string, int?, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = await SessionTemplateControllerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSessionTemplatesResponse, SessionTemplate> response = sessionTemplateControllerClient.ListSessionTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SessionTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSessionTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessionTemplates</summary>
        public void ListSessionTemplatesResourceNames()
        {
            // Snippet: ListSessionTemplates(LocationName, string, int?, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = SessionTemplateControllerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSessionTemplatesResponse, SessionTemplate> response = sessionTemplateControllerClient.ListSessionTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SessionTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSessionTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessionTemplatesAsync</summary>
        public async Task ListSessionTemplatesResourceNamesAsync()
        {
            // Snippet: ListSessionTemplatesAsync(LocationName, string, int?, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = await SessionTemplateControllerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSessionTemplatesResponse, SessionTemplate> response = sessionTemplateControllerClient.ListSessionTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SessionTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSessionTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionTemplate</summary>
        public void DeleteSessionTemplateRequestObject()
        {
            // Snippet: DeleteSessionTemplate(DeleteSessionTemplateRequest, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = SessionTemplateControllerClient.Create();
            // Initialize request argument(s)
            DeleteSessionTemplateRequest request = new DeleteSessionTemplateRequest
            {
                SessionTemplateName = SessionTemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
            };
            // Make the request
            sessionTemplateControllerClient.DeleteSessionTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionTemplateAsync</summary>
        public async Task DeleteSessionTemplateRequestObjectAsync()
        {
            // Snippet: DeleteSessionTemplateAsync(DeleteSessionTemplateRequest, CallSettings)
            // Additional: DeleteSessionTemplateAsync(DeleteSessionTemplateRequest, CancellationToken)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = await SessionTemplateControllerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSessionTemplateRequest request = new DeleteSessionTemplateRequest
            {
                SessionTemplateName = SessionTemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
            };
            // Make the request
            await sessionTemplateControllerClient.DeleteSessionTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionTemplate</summary>
        public void DeleteSessionTemplate()
        {
            // Snippet: DeleteSessionTemplate(string, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = SessionTemplateControllerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sessionTemplates/[TEMPLATE]";
            // Make the request
            sessionTemplateControllerClient.DeleteSessionTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionTemplateAsync</summary>
        public async Task DeleteSessionTemplateAsync()
        {
            // Snippet: DeleteSessionTemplateAsync(string, CallSettings)
            // Additional: DeleteSessionTemplateAsync(string, CancellationToken)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = await SessionTemplateControllerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sessionTemplates/[TEMPLATE]";
            // Make the request
            await sessionTemplateControllerClient.DeleteSessionTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionTemplate</summary>
        public void DeleteSessionTemplateResourceNames()
        {
            // Snippet: DeleteSessionTemplate(SessionTemplateName, CallSettings)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = SessionTemplateControllerClient.Create();
            // Initialize request argument(s)
            SessionTemplateName name = SessionTemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]");
            // Make the request
            sessionTemplateControllerClient.DeleteSessionTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionTemplateAsync</summary>
        public async Task DeleteSessionTemplateResourceNamesAsync()
        {
            // Snippet: DeleteSessionTemplateAsync(SessionTemplateName, CallSettings)
            // Additional: DeleteSessionTemplateAsync(SessionTemplateName, CancellationToken)
            // Create client
            SessionTemplateControllerClient sessionTemplateControllerClient = await SessionTemplateControllerClient.CreateAsync();
            // Initialize request argument(s)
            SessionTemplateName name = SessionTemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]");
            // Make the request
            await sessionTemplateControllerClient.DeleteSessionTemplateAsync(name);
            // End snippet
        }
    }
}
