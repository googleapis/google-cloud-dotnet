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
    using Google.Cloud.Dialogflow.Cx.V3;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedExamplesClientSnippets
    {
        /// <summary>Snippet for CreateExample</summary>
        public void CreateExampleRequestObject()
        {
            // Snippet: CreateExample(CreateExampleRequest, CallSettings)
            // Create client
            ExamplesClient examplesClient = ExamplesClient.Create();
            // Initialize request argument(s)
            CreateExampleRequest request = new CreateExampleRequest
            {
                ParentAsPlaybookName = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]"),
                Example = new Example(),
            };
            // Make the request
            Example response = examplesClient.CreateExample(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExampleAsync</summary>
        public async Task CreateExampleRequestObjectAsync()
        {
            // Snippet: CreateExampleAsync(CreateExampleRequest, CallSettings)
            // Additional: CreateExampleAsync(CreateExampleRequest, CancellationToken)
            // Create client
            ExamplesClient examplesClient = await ExamplesClient.CreateAsync();
            // Initialize request argument(s)
            CreateExampleRequest request = new CreateExampleRequest
            {
                ParentAsPlaybookName = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]"),
                Example = new Example(),
            };
            // Make the request
            Example response = await examplesClient.CreateExampleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExample</summary>
        public void CreateExample()
        {
            // Snippet: CreateExample(string, Example, CallSettings)
            // Create client
            ExamplesClient examplesClient = ExamplesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]";
            Example example = new Example();
            // Make the request
            Example response = examplesClient.CreateExample(parent, example);
            // End snippet
        }

        /// <summary>Snippet for CreateExampleAsync</summary>
        public async Task CreateExampleAsync()
        {
            // Snippet: CreateExampleAsync(string, Example, CallSettings)
            // Additional: CreateExampleAsync(string, Example, CancellationToken)
            // Create client
            ExamplesClient examplesClient = await ExamplesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]";
            Example example = new Example();
            // Make the request
            Example response = await examplesClient.CreateExampleAsync(parent, example);
            // End snippet
        }

        /// <summary>Snippet for CreateExample</summary>
        public void CreateExampleResourceNames()
        {
            // Snippet: CreateExample(PlaybookName, Example, CallSettings)
            // Create client
            ExamplesClient examplesClient = ExamplesClient.Create();
            // Initialize request argument(s)
            PlaybookName parent = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]");
            Example example = new Example();
            // Make the request
            Example response = examplesClient.CreateExample(parent, example);
            // End snippet
        }

        /// <summary>Snippet for CreateExampleAsync</summary>
        public async Task CreateExampleResourceNamesAsync()
        {
            // Snippet: CreateExampleAsync(PlaybookName, Example, CallSettings)
            // Additional: CreateExampleAsync(PlaybookName, Example, CancellationToken)
            // Create client
            ExamplesClient examplesClient = await ExamplesClient.CreateAsync();
            // Initialize request argument(s)
            PlaybookName parent = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]");
            Example example = new Example();
            // Make the request
            Example response = await examplesClient.CreateExampleAsync(parent, example);
            // End snippet
        }

        /// <summary>Snippet for DeleteExample</summary>
        public void DeleteExampleRequestObject()
        {
            // Snippet: DeleteExample(DeleteExampleRequest, CallSettings)
            // Create client
            ExamplesClient examplesClient = ExamplesClient.Create();
            // Initialize request argument(s)
            DeleteExampleRequest request = new DeleteExampleRequest
            {
                ExampleName = ExampleName.FromProjectLocationAgentPlaybookExample("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[EXAMPLE]"),
            };
            // Make the request
            examplesClient.DeleteExample(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteExampleAsync</summary>
        public async Task DeleteExampleRequestObjectAsync()
        {
            // Snippet: DeleteExampleAsync(DeleteExampleRequest, CallSettings)
            // Additional: DeleteExampleAsync(DeleteExampleRequest, CancellationToken)
            // Create client
            ExamplesClient examplesClient = await ExamplesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteExampleRequest request = new DeleteExampleRequest
            {
                ExampleName = ExampleName.FromProjectLocationAgentPlaybookExample("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[EXAMPLE]"),
            };
            // Make the request
            await examplesClient.DeleteExampleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteExample</summary>
        public void DeleteExample()
        {
            // Snippet: DeleteExample(string, CallSettings)
            // Create client
            ExamplesClient examplesClient = ExamplesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]/examples/[EXAMPLE]";
            // Make the request
            examplesClient.DeleteExample(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExampleAsync</summary>
        public async Task DeleteExampleAsync()
        {
            // Snippet: DeleteExampleAsync(string, CallSettings)
            // Additional: DeleteExampleAsync(string, CancellationToken)
            // Create client
            ExamplesClient examplesClient = await ExamplesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]/examples/[EXAMPLE]";
            // Make the request
            await examplesClient.DeleteExampleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExample</summary>
        public void DeleteExampleResourceNames()
        {
            // Snippet: DeleteExample(ExampleName, CallSettings)
            // Create client
            ExamplesClient examplesClient = ExamplesClient.Create();
            // Initialize request argument(s)
            ExampleName name = ExampleName.FromProjectLocationAgentPlaybookExample("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[EXAMPLE]");
            // Make the request
            examplesClient.DeleteExample(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExampleAsync</summary>
        public async Task DeleteExampleResourceNamesAsync()
        {
            // Snippet: DeleteExampleAsync(ExampleName, CallSettings)
            // Additional: DeleteExampleAsync(ExampleName, CancellationToken)
            // Create client
            ExamplesClient examplesClient = await ExamplesClient.CreateAsync();
            // Initialize request argument(s)
            ExampleName name = ExampleName.FromProjectLocationAgentPlaybookExample("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[EXAMPLE]");
            // Make the request
            await examplesClient.DeleteExampleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListExamples</summary>
        public void ListExamplesRequestObject()
        {
            // Snippet: ListExamples(ListExamplesRequest, CallSettings)
            // Create client
            ExamplesClient examplesClient = ExamplesClient.Create();
            // Initialize request argument(s)
            ListExamplesRequest request = new ListExamplesRequest
            {
                ParentAsPlaybookName = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]"),
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<ListExamplesResponse, Example> response = examplesClient.ListExamples(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamplesAsync</summary>
        public async Task ListExamplesRequestObjectAsync()
        {
            // Snippet: ListExamplesAsync(ListExamplesRequest, CallSettings)
            // Create client
            ExamplesClient examplesClient = await ExamplesClient.CreateAsync();
            // Initialize request argument(s)
            ListExamplesRequest request = new ListExamplesRequest
            {
                ParentAsPlaybookName = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]"),
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListExamplesResponse, Example> response = examplesClient.ListExamplesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamples</summary>
        public void ListExamples()
        {
            // Snippet: ListExamples(string, string, int?, CallSettings)
            // Create client
            ExamplesClient examplesClient = ExamplesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]";
            // Make the request
            PagedEnumerable<ListExamplesResponse, Example> response = examplesClient.ListExamples(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamplesAsync</summary>
        public async Task ListExamplesAsync()
        {
            // Snippet: ListExamplesAsync(string, string, int?, CallSettings)
            // Create client
            ExamplesClient examplesClient = await ExamplesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]";
            // Make the request
            PagedAsyncEnumerable<ListExamplesResponse, Example> response = examplesClient.ListExamplesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamples</summary>
        public void ListExamplesResourceNames()
        {
            // Snippet: ListExamples(PlaybookName, string, int?, CallSettings)
            // Create client
            ExamplesClient examplesClient = ExamplesClient.Create();
            // Initialize request argument(s)
            PlaybookName parent = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]");
            // Make the request
            PagedEnumerable<ListExamplesResponse, Example> response = examplesClient.ListExamples(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamplesAsync</summary>
        public async Task ListExamplesResourceNamesAsync()
        {
            // Snippet: ListExamplesAsync(PlaybookName, string, int?, CallSettings)
            // Create client
            ExamplesClient examplesClient = await ExamplesClient.CreateAsync();
            // Initialize request argument(s)
            PlaybookName parent = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]");
            // Make the request
            PagedAsyncEnumerable<ListExamplesResponse, Example> response = examplesClient.ListExamplesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetExample</summary>
        public void GetExampleRequestObject()
        {
            // Snippet: GetExample(GetExampleRequest, CallSettings)
            // Create client
            ExamplesClient examplesClient = ExamplesClient.Create();
            // Initialize request argument(s)
            GetExampleRequest request = new GetExampleRequest
            {
                ExampleName = ExampleName.FromProjectLocationAgentPlaybookExample("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[EXAMPLE]"),
            };
            // Make the request
            Example response = examplesClient.GetExample(request);
            // End snippet
        }

        /// <summary>Snippet for GetExampleAsync</summary>
        public async Task GetExampleRequestObjectAsync()
        {
            // Snippet: GetExampleAsync(GetExampleRequest, CallSettings)
            // Additional: GetExampleAsync(GetExampleRequest, CancellationToken)
            // Create client
            ExamplesClient examplesClient = await ExamplesClient.CreateAsync();
            // Initialize request argument(s)
            GetExampleRequest request = new GetExampleRequest
            {
                ExampleName = ExampleName.FromProjectLocationAgentPlaybookExample("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[EXAMPLE]"),
            };
            // Make the request
            Example response = await examplesClient.GetExampleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExample</summary>
        public void GetExample()
        {
            // Snippet: GetExample(string, CallSettings)
            // Create client
            ExamplesClient examplesClient = ExamplesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]/examples/[EXAMPLE]";
            // Make the request
            Example response = examplesClient.GetExample(name);
            // End snippet
        }

        /// <summary>Snippet for GetExampleAsync</summary>
        public async Task GetExampleAsync()
        {
            // Snippet: GetExampleAsync(string, CallSettings)
            // Additional: GetExampleAsync(string, CancellationToken)
            // Create client
            ExamplesClient examplesClient = await ExamplesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]/examples/[EXAMPLE]";
            // Make the request
            Example response = await examplesClient.GetExampleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExample</summary>
        public void GetExampleResourceNames()
        {
            // Snippet: GetExample(ExampleName, CallSettings)
            // Create client
            ExamplesClient examplesClient = ExamplesClient.Create();
            // Initialize request argument(s)
            ExampleName name = ExampleName.FromProjectLocationAgentPlaybookExample("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[EXAMPLE]");
            // Make the request
            Example response = examplesClient.GetExample(name);
            // End snippet
        }

        /// <summary>Snippet for GetExampleAsync</summary>
        public async Task GetExampleResourceNamesAsync()
        {
            // Snippet: GetExampleAsync(ExampleName, CallSettings)
            // Additional: GetExampleAsync(ExampleName, CancellationToken)
            // Create client
            ExamplesClient examplesClient = await ExamplesClient.CreateAsync();
            // Initialize request argument(s)
            ExampleName name = ExampleName.FromProjectLocationAgentPlaybookExample("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[EXAMPLE]");
            // Make the request
            Example response = await examplesClient.GetExampleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateExample</summary>
        public void UpdateExampleRequestObject()
        {
            // Snippet: UpdateExample(UpdateExampleRequest, CallSettings)
            // Create client
            ExamplesClient examplesClient = ExamplesClient.Create();
            // Initialize request argument(s)
            UpdateExampleRequest request = new UpdateExampleRequest
            {
                Example = new Example(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Example response = examplesClient.UpdateExample(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExampleAsync</summary>
        public async Task UpdateExampleRequestObjectAsync()
        {
            // Snippet: UpdateExampleAsync(UpdateExampleRequest, CallSettings)
            // Additional: UpdateExampleAsync(UpdateExampleRequest, CancellationToken)
            // Create client
            ExamplesClient examplesClient = await ExamplesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateExampleRequest request = new UpdateExampleRequest
            {
                Example = new Example(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Example response = await examplesClient.UpdateExampleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExample</summary>
        public void UpdateExample()
        {
            // Snippet: UpdateExample(Example, FieldMask, CallSettings)
            // Create client
            ExamplesClient examplesClient = ExamplesClient.Create();
            // Initialize request argument(s)
            Example example = new Example();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Example response = examplesClient.UpdateExample(example, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateExampleAsync</summary>
        public async Task UpdateExampleAsync()
        {
            // Snippet: UpdateExampleAsync(Example, FieldMask, CallSettings)
            // Additional: UpdateExampleAsync(Example, FieldMask, CancellationToken)
            // Create client
            ExamplesClient examplesClient = await ExamplesClient.CreateAsync();
            // Initialize request argument(s)
            Example example = new Example();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Example response = await examplesClient.UpdateExampleAsync(example, updateMask);
            // End snippet
        }
    }
}
