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
    using Google.Cloud.PubSub.V1;
    using Google.Protobuf;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSchemaServiceClientSnippets
    {
        /// <summary>Snippet for CreateSchema</summary>
        public void CreateSchemaRequestObject()
        {
            // Snippet: CreateSchema(CreateSchemaRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            CreateSchemaRequest request = new CreateSchemaRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Schema = new Schema(),
                SchemaId = "",
            };
            // Make the request
            Schema response = schemaServiceClient.CreateSchema(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSchemaAsync</summary>
        public async Task CreateSchemaRequestObjectAsync()
        {
            // Snippet: CreateSchemaAsync(CreateSchemaRequest, CallSettings)
            // Additional: CreateSchemaAsync(CreateSchemaRequest, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSchemaRequest request = new CreateSchemaRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Schema = new Schema(),
                SchemaId = "",
            };
            // Make the request
            Schema response = await schemaServiceClient.CreateSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSchema</summary>
        public void CreateSchema()
        {
            // Snippet: CreateSchema(string, Schema, string, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Schema schema = new Schema();
            string schemaId = "";
            // Make the request
            Schema response = schemaServiceClient.CreateSchema(parent, schema, schemaId);
            // End snippet
        }

        /// <summary>Snippet for CreateSchemaAsync</summary>
        public async Task CreateSchemaAsync()
        {
            // Snippet: CreateSchemaAsync(string, Schema, string, CallSettings)
            // Additional: CreateSchemaAsync(string, Schema, string, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Schema schema = new Schema();
            string schemaId = "";
            // Make the request
            Schema response = await schemaServiceClient.CreateSchemaAsync(parent, schema, schemaId);
            // End snippet
        }

        /// <summary>Snippet for CreateSchema</summary>
        public void CreateSchemaResourceNames()
        {
            // Snippet: CreateSchema(ProjectName, Schema, string, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Schema schema = new Schema();
            string schemaId = "";
            // Make the request
            Schema response = schemaServiceClient.CreateSchema(parent, schema, schemaId);
            // End snippet
        }

        /// <summary>Snippet for CreateSchemaAsync</summary>
        public async Task CreateSchemaResourceNamesAsync()
        {
            // Snippet: CreateSchemaAsync(ProjectName, Schema, string, CallSettings)
            // Additional: CreateSchemaAsync(ProjectName, Schema, string, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Schema schema = new Schema();
            string schemaId = "";
            // Make the request
            Schema response = await schemaServiceClient.CreateSchemaAsync(parent, schema, schemaId);
            // End snippet
        }

        /// <summary>Snippet for GetSchema</summary>
        public void GetSchemaRequestObject()
        {
            // Snippet: GetSchema(GetSchemaRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            GetSchemaRequest request = new GetSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                View = SchemaView.Unspecified,
            };
            // Make the request
            Schema response = schemaServiceClient.GetSchema(request);
            // End snippet
        }

        /// <summary>Snippet for GetSchemaAsync</summary>
        public async Task GetSchemaRequestObjectAsync()
        {
            // Snippet: GetSchemaAsync(GetSchemaRequest, CallSettings)
            // Additional: GetSchemaAsync(GetSchemaRequest, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSchemaRequest request = new GetSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                View = SchemaView.Unspecified,
            };
            // Make the request
            Schema response = await schemaServiceClient.GetSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSchema</summary>
        public void GetSchema()
        {
            // Snippet: GetSchema(string, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/schemas/[SCHEMA]";
            // Make the request
            Schema response = schemaServiceClient.GetSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetSchemaAsync</summary>
        public async Task GetSchemaAsync()
        {
            // Snippet: GetSchemaAsync(string, CallSettings)
            // Additional: GetSchemaAsync(string, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/schemas/[SCHEMA]";
            // Make the request
            Schema response = await schemaServiceClient.GetSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSchema</summary>
        public void GetSchemaResourceNames()
        {
            // Snippet: GetSchema(SchemaName, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]");
            // Make the request
            Schema response = schemaServiceClient.GetSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetSchemaAsync</summary>
        public async Task GetSchemaResourceNamesAsync()
        {
            // Snippet: GetSchemaAsync(SchemaName, CallSettings)
            // Additional: GetSchemaAsync(SchemaName, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]");
            // Make the request
            Schema response = await schemaServiceClient.GetSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSchemas</summary>
        public void ListSchemasRequestObject()
        {
            // Snippet: ListSchemas(ListSchemasRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            ListSchemasRequest request = new ListSchemasRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                View = SchemaView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListSchemasResponse, Schema> response = schemaServiceClient.ListSchemas(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Schema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchemasAsync</summary>
        public async Task ListSchemasRequestObjectAsync()
        {
            // Snippet: ListSchemasAsync(ListSchemasRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSchemasRequest request = new ListSchemasRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                View = SchemaView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListSchemasResponse, Schema> response = schemaServiceClient.ListSchemasAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Schema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchemas</summary>
        public void ListSchemas()
        {
            // Snippet: ListSchemas(string, string, int?, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListSchemasResponse, Schema> response = schemaServiceClient.ListSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Schema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchemasAsync</summary>
        public async Task ListSchemasAsync()
        {
            // Snippet: ListSchemasAsync(string, string, int?, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListSchemasResponse, Schema> response = schemaServiceClient.ListSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Schema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchemas</summary>
        public void ListSchemasResourceNames()
        {
            // Snippet: ListSchemas(ProjectName, string, int?, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListSchemasResponse, Schema> response = schemaServiceClient.ListSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Schema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchemasAsync</summary>
        public async Task ListSchemasResourceNamesAsync()
        {
            // Snippet: ListSchemasAsync(ProjectName, string, int?, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListSchemasResponse, Schema> response = schemaServiceClient.ListSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Schema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchemaRevisions</summary>
        public void ListSchemaRevisionsRequestObject()
        {
            // Snippet: ListSchemaRevisions(ListSchemaRevisionsRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            ListSchemaRevisionsRequest request = new ListSchemaRevisionsRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                View = SchemaView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListSchemaRevisionsResponse, Schema> response = schemaServiceClient.ListSchemaRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Schema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSchemaRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchemaRevisionsAsync</summary>
        public async Task ListSchemaRevisionsRequestObjectAsync()
        {
            // Snippet: ListSchemaRevisionsAsync(ListSchemaRevisionsRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSchemaRevisionsRequest request = new ListSchemaRevisionsRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                View = SchemaView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListSchemaRevisionsResponse, Schema> response = schemaServiceClient.ListSchemaRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Schema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSchemaRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchemaRevisions</summary>
        public void ListSchemaRevisions()
        {
            // Snippet: ListSchemaRevisions(string, string, int?, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/schemas/[SCHEMA]";
            // Make the request
            PagedEnumerable<ListSchemaRevisionsResponse, Schema> response = schemaServiceClient.ListSchemaRevisions(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Schema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSchemaRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchemaRevisionsAsync</summary>
        public async Task ListSchemaRevisionsAsync()
        {
            // Snippet: ListSchemaRevisionsAsync(string, string, int?, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/schemas/[SCHEMA]";
            // Make the request
            PagedAsyncEnumerable<ListSchemaRevisionsResponse, Schema> response = schemaServiceClient.ListSchemaRevisionsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Schema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSchemaRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchemaRevisions</summary>
        public void ListSchemaRevisionsResourceNames()
        {
            // Snippet: ListSchemaRevisions(SchemaName, string, int?, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]");
            // Make the request
            PagedEnumerable<ListSchemaRevisionsResponse, Schema> response = schemaServiceClient.ListSchemaRevisions(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Schema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSchemaRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchemaRevisionsAsync</summary>
        public async Task ListSchemaRevisionsResourceNamesAsync()
        {
            // Snippet: ListSchemaRevisionsAsync(SchemaName, string, int?, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]");
            // Make the request
            PagedAsyncEnumerable<ListSchemaRevisionsResponse, Schema> response = schemaServiceClient.ListSchemaRevisionsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Schema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSchemaRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CommitSchema</summary>
        public void CommitSchemaRequestObject()
        {
            // Snippet: CommitSchema(CommitSchemaRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            CommitSchemaRequest request = new CommitSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Schema = new Schema(),
            };
            // Make the request
            Schema response = schemaServiceClient.CommitSchema(request);
            // End snippet
        }

        /// <summary>Snippet for CommitSchemaAsync</summary>
        public async Task CommitSchemaRequestObjectAsync()
        {
            // Snippet: CommitSchemaAsync(CommitSchemaRequest, CallSettings)
            // Additional: CommitSchemaAsync(CommitSchemaRequest, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            CommitSchemaRequest request = new CommitSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Schema = new Schema(),
            };
            // Make the request
            Schema response = await schemaServiceClient.CommitSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CommitSchema</summary>
        public void CommitSchema()
        {
            // Snippet: CommitSchema(string, Schema, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/schemas/[SCHEMA]";
            Schema schema = new Schema();
            // Make the request
            Schema response = schemaServiceClient.CommitSchema(name, schema);
            // End snippet
        }

        /// <summary>Snippet for CommitSchemaAsync</summary>
        public async Task CommitSchemaAsync()
        {
            // Snippet: CommitSchemaAsync(string, Schema, CallSettings)
            // Additional: CommitSchemaAsync(string, Schema, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/schemas/[SCHEMA]";
            Schema schema = new Schema();
            // Make the request
            Schema response = await schemaServiceClient.CommitSchemaAsync(name, schema);
            // End snippet
        }

        /// <summary>Snippet for CommitSchema</summary>
        public void CommitSchemaResourceNames()
        {
            // Snippet: CommitSchema(SchemaName, Schema, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]");
            Schema schema = new Schema();
            // Make the request
            Schema response = schemaServiceClient.CommitSchema(name, schema);
            // End snippet
        }

        /// <summary>Snippet for CommitSchemaAsync</summary>
        public async Task CommitSchemaResourceNamesAsync()
        {
            // Snippet: CommitSchemaAsync(SchemaName, Schema, CallSettings)
            // Additional: CommitSchemaAsync(SchemaName, Schema, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]");
            Schema schema = new Schema();
            // Make the request
            Schema response = await schemaServiceClient.CommitSchemaAsync(name, schema);
            // End snippet
        }

        /// <summary>Snippet for RollbackSchema</summary>
        public void RollbackSchemaRequestObject()
        {
            // Snippet: RollbackSchema(RollbackSchemaRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            RollbackSchemaRequest request = new RollbackSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                RevisionId = "",
            };
            // Make the request
            Schema response = schemaServiceClient.RollbackSchema(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackSchemaAsync</summary>
        public async Task RollbackSchemaRequestObjectAsync()
        {
            // Snippet: RollbackSchemaAsync(RollbackSchemaRequest, CallSettings)
            // Additional: RollbackSchemaAsync(RollbackSchemaRequest, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            RollbackSchemaRequest request = new RollbackSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                RevisionId = "",
            };
            // Make the request
            Schema response = await schemaServiceClient.RollbackSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackSchema</summary>
        public void RollbackSchema()
        {
            // Snippet: RollbackSchema(string, string, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/schemas/[SCHEMA]";
            string revisionId = "";
            // Make the request
            Schema response = schemaServiceClient.RollbackSchema(name, revisionId);
            // End snippet
        }

        /// <summary>Snippet for RollbackSchemaAsync</summary>
        public async Task RollbackSchemaAsync()
        {
            // Snippet: RollbackSchemaAsync(string, string, CallSettings)
            // Additional: RollbackSchemaAsync(string, string, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/schemas/[SCHEMA]";
            string revisionId = "";
            // Make the request
            Schema response = await schemaServiceClient.RollbackSchemaAsync(name, revisionId);
            // End snippet
        }

        /// <summary>Snippet for RollbackSchema</summary>
        public void RollbackSchemaResourceNames()
        {
            // Snippet: RollbackSchema(SchemaName, string, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]");
            string revisionId = "";
            // Make the request
            Schema response = schemaServiceClient.RollbackSchema(name, revisionId);
            // End snippet
        }

        /// <summary>Snippet for RollbackSchemaAsync</summary>
        public async Task RollbackSchemaResourceNamesAsync()
        {
            // Snippet: RollbackSchemaAsync(SchemaName, string, CallSettings)
            // Additional: RollbackSchemaAsync(SchemaName, string, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]");
            string revisionId = "";
            // Make the request
            Schema response = await schemaServiceClient.RollbackSchemaAsync(name, revisionId);
            // End snippet
        }

        /// <summary>Snippet for DeleteSchemaRevision</summary>
        public void DeleteSchemaRevisionRequestObject()
        {
            // Snippet: DeleteSchemaRevision(DeleteSchemaRevisionRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            DeleteSchemaRevisionRequest request = new DeleteSchemaRevisionRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
            };
            // Make the request
            Schema response = schemaServiceClient.DeleteSchemaRevision(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSchemaRevisionAsync</summary>
        public async Task DeleteSchemaRevisionRequestObjectAsync()
        {
            // Snippet: DeleteSchemaRevisionAsync(DeleteSchemaRevisionRequest, CallSettings)
            // Additional: DeleteSchemaRevisionAsync(DeleteSchemaRevisionRequest, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSchemaRevisionRequest request = new DeleteSchemaRevisionRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
            };
            // Make the request
            Schema response = await schemaServiceClient.DeleteSchemaRevisionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSchemaRevision</summary>
        public void DeleteSchemaRevision()
        {
            // Snippet: DeleteSchemaRevision(string, string, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/schemas/[SCHEMA]";
            string revisionId = "";
            // Make the request
#pragma warning disable CS0612
            Schema response = schemaServiceClient.DeleteSchemaRevision(name, revisionId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for DeleteSchemaRevisionAsync</summary>
        public async Task DeleteSchemaRevisionAsync()
        {
            // Snippet: DeleteSchemaRevisionAsync(string, string, CallSettings)
            // Additional: DeleteSchemaRevisionAsync(string, string, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/schemas/[SCHEMA]";
            string revisionId = "";
            // Make the request
#pragma warning disable CS0612
            Schema response = await schemaServiceClient.DeleteSchemaRevisionAsync(name, revisionId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for DeleteSchemaRevision</summary>
        public void DeleteSchemaRevisionResourceNames()
        {
            // Snippet: DeleteSchemaRevision(SchemaName, string, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]");
            string revisionId = "";
            // Make the request
#pragma warning disable CS0612
            Schema response = schemaServiceClient.DeleteSchemaRevision(name, revisionId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for DeleteSchemaRevisionAsync</summary>
        public async Task DeleteSchemaRevisionResourceNamesAsync()
        {
            // Snippet: DeleteSchemaRevisionAsync(SchemaName, string, CallSettings)
            // Additional: DeleteSchemaRevisionAsync(SchemaName, string, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]");
            string revisionId = "";
            // Make the request
#pragma warning disable CS0612
            Schema response = await schemaServiceClient.DeleteSchemaRevisionAsync(name, revisionId);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for DeleteSchema</summary>
        public void DeleteSchemaRequestObject()
        {
            // Snippet: DeleteSchema(DeleteSchemaRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            DeleteSchemaRequest request = new DeleteSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
            };
            // Make the request
            schemaServiceClient.DeleteSchema(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSchemaAsync</summary>
        public async Task DeleteSchemaRequestObjectAsync()
        {
            // Snippet: DeleteSchemaAsync(DeleteSchemaRequest, CallSettings)
            // Additional: DeleteSchemaAsync(DeleteSchemaRequest, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSchemaRequest request = new DeleteSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
            };
            // Make the request
            await schemaServiceClient.DeleteSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSchema</summary>
        public void DeleteSchema()
        {
            // Snippet: DeleteSchema(string, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/schemas/[SCHEMA]";
            // Make the request
            schemaServiceClient.DeleteSchema(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSchemaAsync</summary>
        public async Task DeleteSchemaAsync()
        {
            // Snippet: DeleteSchemaAsync(string, CallSettings)
            // Additional: DeleteSchemaAsync(string, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/schemas/[SCHEMA]";
            // Make the request
            await schemaServiceClient.DeleteSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSchema</summary>
        public void DeleteSchemaResourceNames()
        {
            // Snippet: DeleteSchema(SchemaName, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]");
            // Make the request
            schemaServiceClient.DeleteSchema(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSchemaAsync</summary>
        public async Task DeleteSchemaResourceNamesAsync()
        {
            // Snippet: DeleteSchemaAsync(SchemaName, CallSettings)
            // Additional: DeleteSchemaAsync(SchemaName, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]");
            // Make the request
            await schemaServiceClient.DeleteSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ValidateSchema</summary>
        public void ValidateSchemaRequestObject()
        {
            // Snippet: ValidateSchema(ValidateSchemaRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            ValidateSchemaRequest request = new ValidateSchemaRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Schema = new Schema(),
            };
            // Make the request
            ValidateSchemaResponse response = schemaServiceClient.ValidateSchema(request);
            // End snippet
        }

        /// <summary>Snippet for ValidateSchemaAsync</summary>
        public async Task ValidateSchemaRequestObjectAsync()
        {
            // Snippet: ValidateSchemaAsync(ValidateSchemaRequest, CallSettings)
            // Additional: ValidateSchemaAsync(ValidateSchemaRequest, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            ValidateSchemaRequest request = new ValidateSchemaRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Schema = new Schema(),
            };
            // Make the request
            ValidateSchemaResponse response = await schemaServiceClient.ValidateSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ValidateSchema</summary>
        public void ValidateSchema()
        {
            // Snippet: ValidateSchema(string, Schema, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Schema schema = new Schema();
            // Make the request
            ValidateSchemaResponse response = schemaServiceClient.ValidateSchema(parent, schema);
            // End snippet
        }

        /// <summary>Snippet for ValidateSchemaAsync</summary>
        public async Task ValidateSchemaAsync()
        {
            // Snippet: ValidateSchemaAsync(string, Schema, CallSettings)
            // Additional: ValidateSchemaAsync(string, Schema, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Schema schema = new Schema();
            // Make the request
            ValidateSchemaResponse response = await schemaServiceClient.ValidateSchemaAsync(parent, schema);
            // End snippet
        }

        /// <summary>Snippet for ValidateSchema</summary>
        public void ValidateSchemaResourceNames()
        {
            // Snippet: ValidateSchema(ProjectName, Schema, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Schema schema = new Schema();
            // Make the request
            ValidateSchemaResponse response = schemaServiceClient.ValidateSchema(parent, schema);
            // End snippet
        }

        /// <summary>Snippet for ValidateSchemaAsync</summary>
        public async Task ValidateSchemaResourceNamesAsync()
        {
            // Snippet: ValidateSchemaAsync(ProjectName, Schema, CallSettings)
            // Additional: ValidateSchemaAsync(ProjectName, Schema, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Schema schema = new Schema();
            // Make the request
            ValidateSchemaResponse response = await schemaServiceClient.ValidateSchemaAsync(parent, schema);
            // End snippet
        }

        /// <summary>Snippet for ValidateMessage</summary>
        public void ValidateMessageRequestObject()
        {
            // Snippet: ValidateMessage(ValidateMessageRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            ValidateMessageRequest request = new ValidateMessageRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Message = ByteString.Empty,
                Encoding = Encoding.Unspecified,
            };
            // Make the request
            ValidateMessageResponse response = schemaServiceClient.ValidateMessage(request);
            // End snippet
        }

        /// <summary>Snippet for ValidateMessageAsync</summary>
        public async Task ValidateMessageRequestObjectAsync()
        {
            // Snippet: ValidateMessageAsync(ValidateMessageRequest, CallSettings)
            // Additional: ValidateMessageAsync(ValidateMessageRequest, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            ValidateMessageRequest request = new ValidateMessageRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Message = ByteString.Empty,
                Encoding = Encoding.Unspecified,
            };
            // Make the request
            ValidateMessageResponse response = await schemaServiceClient.ValidateMessageAsync(request);
            // End snippet
        }
    }
}
