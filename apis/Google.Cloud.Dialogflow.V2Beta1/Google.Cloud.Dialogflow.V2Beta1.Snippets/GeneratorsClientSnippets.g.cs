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
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGeneratorsClientSnippets
    {
        /// <summary>Snippet for CreateGenerator</summary>
        public void CreateGeneratorRequestObject()
        {
            // Snippet: CreateGenerator(CreateGeneratorRequest, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = GeneratorsClient.Create();
            // Initialize request argument(s)
            CreateGeneratorRequest request = new CreateGeneratorRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Generator = new Generator(),
                GeneratorId = "",
            };
            // Make the request
            Generator response = generatorsClient.CreateGenerator(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGeneratorAsync</summary>
        public async Task CreateGeneratorRequestObjectAsync()
        {
            // Snippet: CreateGeneratorAsync(CreateGeneratorRequest, CallSettings)
            // Additional: CreateGeneratorAsync(CreateGeneratorRequest, CancellationToken)
            // Create client
            GeneratorsClient generatorsClient = await GeneratorsClient.CreateAsync();
            // Initialize request argument(s)
            CreateGeneratorRequest request = new CreateGeneratorRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Generator = new Generator(),
                GeneratorId = "",
            };
            // Make the request
            Generator response = await generatorsClient.CreateGeneratorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGenerator</summary>
        public void CreateGenerator()
        {
            // Snippet: CreateGenerator(string, Generator, string, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = GeneratorsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Generator generator = new Generator();
            string generatorId = "";
            // Make the request
            Generator response = generatorsClient.CreateGenerator(parent, generator, generatorId);
            // End snippet
        }

        /// <summary>Snippet for CreateGeneratorAsync</summary>
        public async Task CreateGeneratorAsync()
        {
            // Snippet: CreateGeneratorAsync(string, Generator, string, CallSettings)
            // Additional: CreateGeneratorAsync(string, Generator, string, CancellationToken)
            // Create client
            GeneratorsClient generatorsClient = await GeneratorsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Generator generator = new Generator();
            string generatorId = "";
            // Make the request
            Generator response = await generatorsClient.CreateGeneratorAsync(parent, generator, generatorId);
            // End snippet
        }

        /// <summary>Snippet for CreateGenerator</summary>
        public void CreateGeneratorResourceNames()
        {
            // Snippet: CreateGenerator(ProjectName, Generator, string, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = GeneratorsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Generator generator = new Generator();
            string generatorId = "";
            // Make the request
            Generator response = generatorsClient.CreateGenerator(parent, generator, generatorId);
            // End snippet
        }

        /// <summary>Snippet for CreateGeneratorAsync</summary>
        public async Task CreateGeneratorResourceNamesAsync()
        {
            // Snippet: CreateGeneratorAsync(ProjectName, Generator, string, CallSettings)
            // Additional: CreateGeneratorAsync(ProjectName, Generator, string, CancellationToken)
            // Create client
            GeneratorsClient generatorsClient = await GeneratorsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Generator generator = new Generator();
            string generatorId = "";
            // Make the request
            Generator response = await generatorsClient.CreateGeneratorAsync(parent, generator, generatorId);
            // End snippet
        }

        /// <summary>Snippet for GetGenerator</summary>
        public void GetGeneratorRequestObject()
        {
            // Snippet: GetGenerator(GetGeneratorRequest, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = GeneratorsClient.Create();
            // Initialize request argument(s)
            GetGeneratorRequest request = new GetGeneratorRequest
            {
                GeneratorName = GeneratorName.FromProjectLocationGenerator("[PROJECT]", "[LOCATION]", "[GENERATOR]"),
            };
            // Make the request
            Generator response = generatorsClient.GetGenerator(request);
            // End snippet
        }

        /// <summary>Snippet for GetGeneratorAsync</summary>
        public async Task GetGeneratorRequestObjectAsync()
        {
            // Snippet: GetGeneratorAsync(GetGeneratorRequest, CallSettings)
            // Additional: GetGeneratorAsync(GetGeneratorRequest, CancellationToken)
            // Create client
            GeneratorsClient generatorsClient = await GeneratorsClient.CreateAsync();
            // Initialize request argument(s)
            GetGeneratorRequest request = new GetGeneratorRequest
            {
                GeneratorName = GeneratorName.FromProjectLocationGenerator("[PROJECT]", "[LOCATION]", "[GENERATOR]"),
            };
            // Make the request
            Generator response = await generatorsClient.GetGeneratorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGenerator</summary>
        public void GetGenerator()
        {
            // Snippet: GetGenerator(string, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = GeneratorsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/generators/[GENERATOR]";
            // Make the request
            Generator response = generatorsClient.GetGenerator(name);
            // End snippet
        }

        /// <summary>Snippet for GetGeneratorAsync</summary>
        public async Task GetGeneratorAsync()
        {
            // Snippet: GetGeneratorAsync(string, CallSettings)
            // Additional: GetGeneratorAsync(string, CancellationToken)
            // Create client
            GeneratorsClient generatorsClient = await GeneratorsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/generators/[GENERATOR]";
            // Make the request
            Generator response = await generatorsClient.GetGeneratorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGenerator</summary>
        public void GetGeneratorResourceNames()
        {
            // Snippet: GetGenerator(GeneratorName, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = GeneratorsClient.Create();
            // Initialize request argument(s)
            GeneratorName name = GeneratorName.FromProjectLocationGenerator("[PROJECT]", "[LOCATION]", "[GENERATOR]");
            // Make the request
            Generator response = generatorsClient.GetGenerator(name);
            // End snippet
        }

        /// <summary>Snippet for GetGeneratorAsync</summary>
        public async Task GetGeneratorResourceNamesAsync()
        {
            // Snippet: GetGeneratorAsync(GeneratorName, CallSettings)
            // Additional: GetGeneratorAsync(GeneratorName, CancellationToken)
            // Create client
            GeneratorsClient generatorsClient = await GeneratorsClient.CreateAsync();
            // Initialize request argument(s)
            GeneratorName name = GeneratorName.FromProjectLocationGenerator("[PROJECT]", "[LOCATION]", "[GENERATOR]");
            // Make the request
            Generator response = await generatorsClient.GetGeneratorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListGenerators</summary>
        public void ListGeneratorsRequestObject()
        {
            // Snippet: ListGenerators(ListGeneratorsRequest, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = GeneratorsClient.Create();
            // Initialize request argument(s)
            ListGeneratorsRequest request = new ListGeneratorsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListGeneratorsResponse, Generator> response = generatorsClient.ListGenerators(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Generator item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGeneratorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Generator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Generator> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Generator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGeneratorsAsync</summary>
        public async Task ListGeneratorsRequestObjectAsync()
        {
            // Snippet: ListGeneratorsAsync(ListGeneratorsRequest, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = await GeneratorsClient.CreateAsync();
            // Initialize request argument(s)
            ListGeneratorsRequest request = new ListGeneratorsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListGeneratorsResponse, Generator> response = generatorsClient.ListGeneratorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Generator item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGeneratorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Generator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Generator> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Generator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGenerators</summary>
        public void ListGenerators()
        {
            // Snippet: ListGenerators(string, string, int?, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = GeneratorsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListGeneratorsResponse, Generator> response = generatorsClient.ListGenerators(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Generator item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGeneratorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Generator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Generator> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Generator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGeneratorsAsync</summary>
        public async Task ListGeneratorsAsync()
        {
            // Snippet: ListGeneratorsAsync(string, string, int?, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = await GeneratorsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListGeneratorsResponse, Generator> response = generatorsClient.ListGeneratorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Generator item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGeneratorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Generator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Generator> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Generator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGenerators</summary>
        public void ListGeneratorsResourceNames()
        {
            // Snippet: ListGenerators(ProjectName, string, int?, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = GeneratorsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListGeneratorsResponse, Generator> response = generatorsClient.ListGenerators(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Generator item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGeneratorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Generator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Generator> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Generator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGeneratorsAsync</summary>
        public async Task ListGeneratorsResourceNamesAsync()
        {
            // Snippet: ListGeneratorsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = await GeneratorsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListGeneratorsResponse, Generator> response = generatorsClient.ListGeneratorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Generator item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGeneratorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Generator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Generator> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Generator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteGenerator</summary>
        public void DeleteGeneratorRequestObject()
        {
            // Snippet: DeleteGenerator(DeleteGeneratorRequest, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = GeneratorsClient.Create();
            // Initialize request argument(s)
            DeleteGeneratorRequest request = new DeleteGeneratorRequest
            {
                GeneratorName = GeneratorName.FromProjectLocationGenerator("[PROJECT]", "[LOCATION]", "[GENERATOR]"),
            };
            // Make the request
            generatorsClient.DeleteGenerator(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGeneratorAsync</summary>
        public async Task DeleteGeneratorRequestObjectAsync()
        {
            // Snippet: DeleteGeneratorAsync(DeleteGeneratorRequest, CallSettings)
            // Additional: DeleteGeneratorAsync(DeleteGeneratorRequest, CancellationToken)
            // Create client
            GeneratorsClient generatorsClient = await GeneratorsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGeneratorRequest request = new DeleteGeneratorRequest
            {
                GeneratorName = GeneratorName.FromProjectLocationGenerator("[PROJECT]", "[LOCATION]", "[GENERATOR]"),
            };
            // Make the request
            await generatorsClient.DeleteGeneratorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGenerator</summary>
        public void DeleteGenerator()
        {
            // Snippet: DeleteGenerator(string, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = GeneratorsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/generators/[GENERATOR]";
            // Make the request
            generatorsClient.DeleteGenerator(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGeneratorAsync</summary>
        public async Task DeleteGeneratorAsync()
        {
            // Snippet: DeleteGeneratorAsync(string, CallSettings)
            // Additional: DeleteGeneratorAsync(string, CancellationToken)
            // Create client
            GeneratorsClient generatorsClient = await GeneratorsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/generators/[GENERATOR]";
            // Make the request
            await generatorsClient.DeleteGeneratorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGenerator</summary>
        public void DeleteGeneratorResourceNames()
        {
            // Snippet: DeleteGenerator(GeneratorName, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = GeneratorsClient.Create();
            // Initialize request argument(s)
            GeneratorName name = GeneratorName.FromProjectLocationGenerator("[PROJECT]", "[LOCATION]", "[GENERATOR]");
            // Make the request
            generatorsClient.DeleteGenerator(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGeneratorAsync</summary>
        public async Task DeleteGeneratorResourceNamesAsync()
        {
            // Snippet: DeleteGeneratorAsync(GeneratorName, CallSettings)
            // Additional: DeleteGeneratorAsync(GeneratorName, CancellationToken)
            // Create client
            GeneratorsClient generatorsClient = await GeneratorsClient.CreateAsync();
            // Initialize request argument(s)
            GeneratorName name = GeneratorName.FromProjectLocationGenerator("[PROJECT]", "[LOCATION]", "[GENERATOR]");
            // Make the request
            await generatorsClient.DeleteGeneratorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateGenerator</summary>
        public void UpdateGeneratorRequestObject()
        {
            // Snippet: UpdateGenerator(UpdateGeneratorRequest, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = GeneratorsClient.Create();
            // Initialize request argument(s)
            UpdateGeneratorRequest request = new UpdateGeneratorRequest
            {
                Generator = new Generator(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Generator response = generatorsClient.UpdateGenerator(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGeneratorAsync</summary>
        public async Task UpdateGeneratorRequestObjectAsync()
        {
            // Snippet: UpdateGeneratorAsync(UpdateGeneratorRequest, CallSettings)
            // Additional: UpdateGeneratorAsync(UpdateGeneratorRequest, CancellationToken)
            // Create client
            GeneratorsClient generatorsClient = await GeneratorsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGeneratorRequest request = new UpdateGeneratorRequest
            {
                Generator = new Generator(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Generator response = await generatorsClient.UpdateGeneratorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGenerator</summary>
        public void UpdateGenerator()
        {
            // Snippet: UpdateGenerator(Generator, FieldMask, CallSettings)
            // Create client
            GeneratorsClient generatorsClient = GeneratorsClient.Create();
            // Initialize request argument(s)
            Generator generator = new Generator();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Generator response = generatorsClient.UpdateGenerator(generator, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateGeneratorAsync</summary>
        public async Task UpdateGeneratorAsync()
        {
            // Snippet: UpdateGeneratorAsync(Generator, FieldMask, CallSettings)
            // Additional: UpdateGeneratorAsync(Generator, FieldMask, CancellationToken)
            // Create client
            GeneratorsClient generatorsClient = await GeneratorsClient.CreateAsync();
            // Initialize request argument(s)
            Generator generator = new Generator();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Generator response = await generatorsClient.UpdateGeneratorAsync(generator, updateMask);
            // End snippet
        }
    }
}
