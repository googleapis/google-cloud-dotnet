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
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPlaybooksClientSnippets
    {
        /// <summary>Snippet for CreatePlaybook</summary>
        public void CreatePlaybookRequestObject()
        {
            // Snippet: CreatePlaybook(CreatePlaybookRequest, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            CreatePlaybookRequest request = new CreatePlaybookRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Playbook = new Playbook(),
            };
            // Make the request
            Playbook response = playbooksClient.CreatePlaybook(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePlaybookAsync</summary>
        public async Task CreatePlaybookRequestObjectAsync()
        {
            // Snippet: CreatePlaybookAsync(CreatePlaybookRequest, CallSettings)
            // Additional: CreatePlaybookAsync(CreatePlaybookRequest, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            CreatePlaybookRequest request = new CreatePlaybookRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Playbook = new Playbook(),
            };
            // Make the request
            Playbook response = await playbooksClient.CreatePlaybookAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePlaybook</summary>
        public void CreatePlaybook()
        {
            // Snippet: CreatePlaybook(string, Playbook, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            Playbook playbook = new Playbook();
            // Make the request
            Playbook response = playbooksClient.CreatePlaybook(parent, playbook);
            // End snippet
        }

        /// <summary>Snippet for CreatePlaybookAsync</summary>
        public async Task CreatePlaybookAsync()
        {
            // Snippet: CreatePlaybookAsync(string, Playbook, CallSettings)
            // Additional: CreatePlaybookAsync(string, Playbook, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            Playbook playbook = new Playbook();
            // Make the request
            Playbook response = await playbooksClient.CreatePlaybookAsync(parent, playbook);
            // End snippet
        }

        /// <summary>Snippet for CreatePlaybook</summary>
        public void CreatePlaybookResourceNames()
        {
            // Snippet: CreatePlaybook(AgentName, Playbook, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            Playbook playbook = new Playbook();
            // Make the request
            Playbook response = playbooksClient.CreatePlaybook(parent, playbook);
            // End snippet
        }

        /// <summary>Snippet for CreatePlaybookAsync</summary>
        public async Task CreatePlaybookResourceNamesAsync()
        {
            // Snippet: CreatePlaybookAsync(AgentName, Playbook, CallSettings)
            // Additional: CreatePlaybookAsync(AgentName, Playbook, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            Playbook playbook = new Playbook();
            // Make the request
            Playbook response = await playbooksClient.CreatePlaybookAsync(parent, playbook);
            // End snippet
        }

        /// <summary>Snippet for DeletePlaybook</summary>
        public void DeletePlaybookRequestObject()
        {
            // Snippet: DeletePlaybook(DeletePlaybookRequest, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            DeletePlaybookRequest request = new DeletePlaybookRequest
            {
                PlaybookName = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]"),
            };
            // Make the request
            playbooksClient.DeletePlaybook(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePlaybookAsync</summary>
        public async Task DeletePlaybookRequestObjectAsync()
        {
            // Snippet: DeletePlaybookAsync(DeletePlaybookRequest, CallSettings)
            // Additional: DeletePlaybookAsync(DeletePlaybookRequest, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            DeletePlaybookRequest request = new DeletePlaybookRequest
            {
                PlaybookName = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]"),
            };
            // Make the request
            await playbooksClient.DeletePlaybookAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePlaybook</summary>
        public void DeletePlaybook()
        {
            // Snippet: DeletePlaybook(string, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]";
            // Make the request
            playbooksClient.DeletePlaybook(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePlaybookAsync</summary>
        public async Task DeletePlaybookAsync()
        {
            // Snippet: DeletePlaybookAsync(string, CallSettings)
            // Additional: DeletePlaybookAsync(string, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]";
            // Make the request
            await playbooksClient.DeletePlaybookAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePlaybook</summary>
        public void DeletePlaybookResourceNames()
        {
            // Snippet: DeletePlaybook(PlaybookName, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            PlaybookName name = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]");
            // Make the request
            playbooksClient.DeletePlaybook(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePlaybookAsync</summary>
        public async Task DeletePlaybookResourceNamesAsync()
        {
            // Snippet: DeletePlaybookAsync(PlaybookName, CallSettings)
            // Additional: DeletePlaybookAsync(PlaybookName, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            PlaybookName name = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]");
            // Make the request
            await playbooksClient.DeletePlaybookAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPlaybooks</summary>
        public void ListPlaybooksRequestObject()
        {
            // Snippet: ListPlaybooks(ListPlaybooksRequest, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            ListPlaybooksRequest request = new ListPlaybooksRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            // Make the request
            PagedEnumerable<ListPlaybooksResponse, Playbook> response = playbooksClient.ListPlaybooks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Playbook item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPlaybooksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Playbook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Playbook> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Playbook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlaybooksAsync</summary>
        public async Task ListPlaybooksRequestObjectAsync()
        {
            // Snippet: ListPlaybooksAsync(ListPlaybooksRequest, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            ListPlaybooksRequest request = new ListPlaybooksRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPlaybooksResponse, Playbook> response = playbooksClient.ListPlaybooksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Playbook item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPlaybooksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Playbook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Playbook> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Playbook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlaybooks</summary>
        public void ListPlaybooks()
        {
            // Snippet: ListPlaybooks(string, string, int?, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            PagedEnumerable<ListPlaybooksResponse, Playbook> response = playbooksClient.ListPlaybooks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Playbook item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPlaybooksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Playbook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Playbook> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Playbook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlaybooksAsync</summary>
        public async Task ListPlaybooksAsync()
        {
            // Snippet: ListPlaybooksAsync(string, string, int?, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            PagedAsyncEnumerable<ListPlaybooksResponse, Playbook> response = playbooksClient.ListPlaybooksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Playbook item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPlaybooksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Playbook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Playbook> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Playbook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlaybooks</summary>
        public void ListPlaybooksResourceNames()
        {
            // Snippet: ListPlaybooks(AgentName, string, int?, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            PagedEnumerable<ListPlaybooksResponse, Playbook> response = playbooksClient.ListPlaybooks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Playbook item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPlaybooksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Playbook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Playbook> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Playbook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlaybooksAsync</summary>
        public async Task ListPlaybooksResourceNamesAsync()
        {
            // Snippet: ListPlaybooksAsync(AgentName, string, int?, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            PagedAsyncEnumerable<ListPlaybooksResponse, Playbook> response = playbooksClient.ListPlaybooksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Playbook item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPlaybooksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Playbook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Playbook> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Playbook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPlaybook</summary>
        public void GetPlaybookRequestObject()
        {
            // Snippet: GetPlaybook(GetPlaybookRequest, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            GetPlaybookRequest request = new GetPlaybookRequest
            {
                PlaybookName = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]"),
            };
            // Make the request
            Playbook response = playbooksClient.GetPlaybook(request);
            // End snippet
        }

        /// <summary>Snippet for GetPlaybookAsync</summary>
        public async Task GetPlaybookRequestObjectAsync()
        {
            // Snippet: GetPlaybookAsync(GetPlaybookRequest, CallSettings)
            // Additional: GetPlaybookAsync(GetPlaybookRequest, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            GetPlaybookRequest request = new GetPlaybookRequest
            {
                PlaybookName = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]"),
            };
            // Make the request
            Playbook response = await playbooksClient.GetPlaybookAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPlaybook</summary>
        public void GetPlaybook()
        {
            // Snippet: GetPlaybook(string, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]";
            // Make the request
            Playbook response = playbooksClient.GetPlaybook(name);
            // End snippet
        }

        /// <summary>Snippet for GetPlaybookAsync</summary>
        public async Task GetPlaybookAsync()
        {
            // Snippet: GetPlaybookAsync(string, CallSettings)
            // Additional: GetPlaybookAsync(string, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]";
            // Make the request
            Playbook response = await playbooksClient.GetPlaybookAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPlaybook</summary>
        public void GetPlaybookResourceNames()
        {
            // Snippet: GetPlaybook(PlaybookName, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            PlaybookName name = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]");
            // Make the request
            Playbook response = playbooksClient.GetPlaybook(name);
            // End snippet
        }

        /// <summary>Snippet for GetPlaybookAsync</summary>
        public async Task GetPlaybookResourceNamesAsync()
        {
            // Snippet: GetPlaybookAsync(PlaybookName, CallSettings)
            // Additional: GetPlaybookAsync(PlaybookName, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            PlaybookName name = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]");
            // Make the request
            Playbook response = await playbooksClient.GetPlaybookAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ExportPlaybook</summary>
        public void ExportPlaybookRequestObject()
        {
            // Snippet: ExportPlaybook(ExportPlaybookRequest, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            ExportPlaybookRequest request = new ExportPlaybookRequest
            {
                PlaybookName = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]"),
                PlaybookUri = "",
                DataFormat = ExportPlaybookRequest.Types.DataFormat.Unspecified,
            };
            // Make the request
            Operation<ExportPlaybookResponse, Struct> response = playbooksClient.ExportPlaybook(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportPlaybookResponse, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportPlaybookResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportPlaybookResponse, Struct> retrievedResponse = playbooksClient.PollOnceExportPlaybook(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportPlaybookResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportPlaybookAsync</summary>
        public async Task ExportPlaybookRequestObjectAsync()
        {
            // Snippet: ExportPlaybookAsync(ExportPlaybookRequest, CallSettings)
            // Additional: ExportPlaybookAsync(ExportPlaybookRequest, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            ExportPlaybookRequest request = new ExportPlaybookRequest
            {
                PlaybookName = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]"),
                PlaybookUri = "",
                DataFormat = ExportPlaybookRequest.Types.DataFormat.Unspecified,
            };
            // Make the request
            Operation<ExportPlaybookResponse, Struct> response = await playbooksClient.ExportPlaybookAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportPlaybookResponse, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportPlaybookResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportPlaybookResponse, Struct> retrievedResponse = await playbooksClient.PollOnceExportPlaybookAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportPlaybookResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportPlaybook</summary>
        public void ImportPlaybookRequestObject()
        {
            // Snippet: ImportPlaybook(ImportPlaybookRequest, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            ImportPlaybookRequest request = new ImportPlaybookRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                PlaybookUri = "",
                ImportStrategy = new PlaybookImportStrategy(),
            };
            // Make the request
            Operation<ImportPlaybookResponse, Struct> response = playbooksClient.ImportPlaybook(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportPlaybookResponse, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportPlaybookResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportPlaybookResponse, Struct> retrievedResponse = playbooksClient.PollOnceImportPlaybook(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportPlaybookResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportPlaybookAsync</summary>
        public async Task ImportPlaybookRequestObjectAsync()
        {
            // Snippet: ImportPlaybookAsync(ImportPlaybookRequest, CallSettings)
            // Additional: ImportPlaybookAsync(ImportPlaybookRequest, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            ImportPlaybookRequest request = new ImportPlaybookRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                PlaybookUri = "",
                ImportStrategy = new PlaybookImportStrategy(),
            };
            // Make the request
            Operation<ImportPlaybookResponse, Struct> response = await playbooksClient.ImportPlaybookAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportPlaybookResponse, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportPlaybookResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportPlaybookResponse, Struct> retrievedResponse = await playbooksClient.PollOnceImportPlaybookAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportPlaybookResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePlaybook</summary>
        public void UpdatePlaybookRequestObject()
        {
            // Snippet: UpdatePlaybook(UpdatePlaybookRequest, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            UpdatePlaybookRequest request = new UpdatePlaybookRequest
            {
                Playbook = new Playbook(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Playbook response = playbooksClient.UpdatePlaybook(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePlaybookAsync</summary>
        public async Task UpdatePlaybookRequestObjectAsync()
        {
            // Snippet: UpdatePlaybookAsync(UpdatePlaybookRequest, CallSettings)
            // Additional: UpdatePlaybookAsync(UpdatePlaybookRequest, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePlaybookRequest request = new UpdatePlaybookRequest
            {
                Playbook = new Playbook(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Playbook response = await playbooksClient.UpdatePlaybookAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePlaybook</summary>
        public void UpdatePlaybook()
        {
            // Snippet: UpdatePlaybook(Playbook, FieldMask, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            Playbook playbook = new Playbook();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Playbook response = playbooksClient.UpdatePlaybook(playbook, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePlaybookAsync</summary>
        public async Task UpdatePlaybookAsync()
        {
            // Snippet: UpdatePlaybookAsync(Playbook, FieldMask, CallSettings)
            // Additional: UpdatePlaybookAsync(Playbook, FieldMask, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            Playbook playbook = new Playbook();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Playbook response = await playbooksClient.UpdatePlaybookAsync(playbook, updateMask);
            // End snippet
        }

        /// <summary>Snippet for CreatePlaybookVersion</summary>
        public void CreatePlaybookVersionRequestObject()
        {
            // Snippet: CreatePlaybookVersion(CreatePlaybookVersionRequest, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            CreatePlaybookVersionRequest request = new CreatePlaybookVersionRequest
            {
                ParentAsPlaybookName = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]"),
                PlaybookVersion = new PlaybookVersion(),
            };
            // Make the request
            PlaybookVersion response = playbooksClient.CreatePlaybookVersion(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePlaybookVersionAsync</summary>
        public async Task CreatePlaybookVersionRequestObjectAsync()
        {
            // Snippet: CreatePlaybookVersionAsync(CreatePlaybookVersionRequest, CallSettings)
            // Additional: CreatePlaybookVersionAsync(CreatePlaybookVersionRequest, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            CreatePlaybookVersionRequest request = new CreatePlaybookVersionRequest
            {
                ParentAsPlaybookName = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]"),
                PlaybookVersion = new PlaybookVersion(),
            };
            // Make the request
            PlaybookVersion response = await playbooksClient.CreatePlaybookVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePlaybookVersion</summary>
        public void CreatePlaybookVersion()
        {
            // Snippet: CreatePlaybookVersion(string, PlaybookVersion, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]";
            PlaybookVersion playbookVersion = new PlaybookVersion();
            // Make the request
            PlaybookVersion response = playbooksClient.CreatePlaybookVersion(parent, playbookVersion);
            // End snippet
        }

        /// <summary>Snippet for CreatePlaybookVersionAsync</summary>
        public async Task CreatePlaybookVersionAsync()
        {
            // Snippet: CreatePlaybookVersionAsync(string, PlaybookVersion, CallSettings)
            // Additional: CreatePlaybookVersionAsync(string, PlaybookVersion, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]";
            PlaybookVersion playbookVersion = new PlaybookVersion();
            // Make the request
            PlaybookVersion response = await playbooksClient.CreatePlaybookVersionAsync(parent, playbookVersion);
            // End snippet
        }

        /// <summary>Snippet for CreatePlaybookVersion</summary>
        public void CreatePlaybookVersionResourceNames()
        {
            // Snippet: CreatePlaybookVersion(PlaybookName, PlaybookVersion, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            PlaybookName parent = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]");
            PlaybookVersion playbookVersion = new PlaybookVersion();
            // Make the request
            PlaybookVersion response = playbooksClient.CreatePlaybookVersion(parent, playbookVersion);
            // End snippet
        }

        /// <summary>Snippet for CreatePlaybookVersionAsync</summary>
        public async Task CreatePlaybookVersionResourceNamesAsync()
        {
            // Snippet: CreatePlaybookVersionAsync(PlaybookName, PlaybookVersion, CallSettings)
            // Additional: CreatePlaybookVersionAsync(PlaybookName, PlaybookVersion, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            PlaybookName parent = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]");
            PlaybookVersion playbookVersion = new PlaybookVersion();
            // Make the request
            PlaybookVersion response = await playbooksClient.CreatePlaybookVersionAsync(parent, playbookVersion);
            // End snippet
        }

        /// <summary>Snippet for GetPlaybookVersion</summary>
        public void GetPlaybookVersionRequestObject()
        {
            // Snippet: GetPlaybookVersion(GetPlaybookVersionRequest, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            GetPlaybookVersionRequest request = new GetPlaybookVersionRequest
            {
                PlaybookVersionName = PlaybookVersionName.FromProjectLocationAgentPlaybookVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[VERSION]"),
            };
            // Make the request
            PlaybookVersion response = playbooksClient.GetPlaybookVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetPlaybookVersionAsync</summary>
        public async Task GetPlaybookVersionRequestObjectAsync()
        {
            // Snippet: GetPlaybookVersionAsync(GetPlaybookVersionRequest, CallSettings)
            // Additional: GetPlaybookVersionAsync(GetPlaybookVersionRequest, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            GetPlaybookVersionRequest request = new GetPlaybookVersionRequest
            {
                PlaybookVersionName = PlaybookVersionName.FromProjectLocationAgentPlaybookVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[VERSION]"),
            };
            // Make the request
            PlaybookVersion response = await playbooksClient.GetPlaybookVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPlaybookVersion</summary>
        public void GetPlaybookVersion()
        {
            // Snippet: GetPlaybookVersion(string, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]/versions/[VERSION]";
            // Make the request
            PlaybookVersion response = playbooksClient.GetPlaybookVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetPlaybookVersionAsync</summary>
        public async Task GetPlaybookVersionAsync()
        {
            // Snippet: GetPlaybookVersionAsync(string, CallSettings)
            // Additional: GetPlaybookVersionAsync(string, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]/versions/[VERSION]";
            // Make the request
            PlaybookVersion response = await playbooksClient.GetPlaybookVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPlaybookVersion</summary>
        public void GetPlaybookVersionResourceNames()
        {
            // Snippet: GetPlaybookVersion(PlaybookVersionName, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            PlaybookVersionName name = PlaybookVersionName.FromProjectLocationAgentPlaybookVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[VERSION]");
            // Make the request
            PlaybookVersion response = playbooksClient.GetPlaybookVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetPlaybookVersionAsync</summary>
        public async Task GetPlaybookVersionResourceNamesAsync()
        {
            // Snippet: GetPlaybookVersionAsync(PlaybookVersionName, CallSettings)
            // Additional: GetPlaybookVersionAsync(PlaybookVersionName, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            PlaybookVersionName name = PlaybookVersionName.FromProjectLocationAgentPlaybookVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[VERSION]");
            // Make the request
            PlaybookVersion response = await playbooksClient.GetPlaybookVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RestorePlaybookVersion</summary>
        public void RestorePlaybookVersionRequestObject()
        {
            // Snippet: RestorePlaybookVersion(RestorePlaybookVersionRequest, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            RestorePlaybookVersionRequest request = new RestorePlaybookVersionRequest
            {
                PlaybookVersionName = PlaybookVersionName.FromProjectLocationAgentPlaybookVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[VERSION]"),
            };
            // Make the request
            RestorePlaybookVersionResponse response = playbooksClient.RestorePlaybookVersion(request);
            // End snippet
        }

        /// <summary>Snippet for RestorePlaybookVersionAsync</summary>
        public async Task RestorePlaybookVersionRequestObjectAsync()
        {
            // Snippet: RestorePlaybookVersionAsync(RestorePlaybookVersionRequest, CallSettings)
            // Additional: RestorePlaybookVersionAsync(RestorePlaybookVersionRequest, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            RestorePlaybookVersionRequest request = new RestorePlaybookVersionRequest
            {
                PlaybookVersionName = PlaybookVersionName.FromProjectLocationAgentPlaybookVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[VERSION]"),
            };
            // Make the request
            RestorePlaybookVersionResponse response = await playbooksClient.RestorePlaybookVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RestorePlaybookVersion</summary>
        public void RestorePlaybookVersion()
        {
            // Snippet: RestorePlaybookVersion(string, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]/versions/[VERSION]";
            // Make the request
            RestorePlaybookVersionResponse response = playbooksClient.RestorePlaybookVersion(name);
            // End snippet
        }

        /// <summary>Snippet for RestorePlaybookVersionAsync</summary>
        public async Task RestorePlaybookVersionAsync()
        {
            // Snippet: RestorePlaybookVersionAsync(string, CallSettings)
            // Additional: RestorePlaybookVersionAsync(string, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]/versions/[VERSION]";
            // Make the request
            RestorePlaybookVersionResponse response = await playbooksClient.RestorePlaybookVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RestorePlaybookVersion</summary>
        public void RestorePlaybookVersionResourceNames()
        {
            // Snippet: RestorePlaybookVersion(PlaybookVersionName, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            PlaybookVersionName name = PlaybookVersionName.FromProjectLocationAgentPlaybookVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[VERSION]");
            // Make the request
            RestorePlaybookVersionResponse response = playbooksClient.RestorePlaybookVersion(name);
            // End snippet
        }

        /// <summary>Snippet for RestorePlaybookVersionAsync</summary>
        public async Task RestorePlaybookVersionResourceNamesAsync()
        {
            // Snippet: RestorePlaybookVersionAsync(PlaybookVersionName, CallSettings)
            // Additional: RestorePlaybookVersionAsync(PlaybookVersionName, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            PlaybookVersionName name = PlaybookVersionName.FromProjectLocationAgentPlaybookVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[VERSION]");
            // Make the request
            RestorePlaybookVersionResponse response = await playbooksClient.RestorePlaybookVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPlaybookVersions</summary>
        public void ListPlaybookVersionsRequestObject()
        {
            // Snippet: ListPlaybookVersions(ListPlaybookVersionsRequest, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            ListPlaybookVersionsRequest request = new ListPlaybookVersionsRequest
            {
                ParentAsPlaybookName = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]"),
            };
            // Make the request
            PagedEnumerable<ListPlaybookVersionsResponse, PlaybookVersion> response = playbooksClient.ListPlaybookVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PlaybookVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPlaybookVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PlaybookVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PlaybookVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PlaybookVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlaybookVersionsAsync</summary>
        public async Task ListPlaybookVersionsRequestObjectAsync()
        {
            // Snippet: ListPlaybookVersionsAsync(ListPlaybookVersionsRequest, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            ListPlaybookVersionsRequest request = new ListPlaybookVersionsRequest
            {
                ParentAsPlaybookName = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPlaybookVersionsResponse, PlaybookVersion> response = playbooksClient.ListPlaybookVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PlaybookVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPlaybookVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PlaybookVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PlaybookVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PlaybookVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlaybookVersions</summary>
        public void ListPlaybookVersions()
        {
            // Snippet: ListPlaybookVersions(string, string, int?, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]";
            // Make the request
            PagedEnumerable<ListPlaybookVersionsResponse, PlaybookVersion> response = playbooksClient.ListPlaybookVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PlaybookVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPlaybookVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PlaybookVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PlaybookVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PlaybookVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlaybookVersionsAsync</summary>
        public async Task ListPlaybookVersionsAsync()
        {
            // Snippet: ListPlaybookVersionsAsync(string, string, int?, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]";
            // Make the request
            PagedAsyncEnumerable<ListPlaybookVersionsResponse, PlaybookVersion> response = playbooksClient.ListPlaybookVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PlaybookVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPlaybookVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PlaybookVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PlaybookVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PlaybookVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlaybookVersions</summary>
        public void ListPlaybookVersionsResourceNames()
        {
            // Snippet: ListPlaybookVersions(PlaybookName, string, int?, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            PlaybookName parent = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]");
            // Make the request
            PagedEnumerable<ListPlaybookVersionsResponse, PlaybookVersion> response = playbooksClient.ListPlaybookVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PlaybookVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPlaybookVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PlaybookVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PlaybookVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PlaybookVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlaybookVersionsAsync</summary>
        public async Task ListPlaybookVersionsResourceNamesAsync()
        {
            // Snippet: ListPlaybookVersionsAsync(PlaybookName, string, int?, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            PlaybookName parent = PlaybookName.FromProjectLocationAgentPlaybook("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]");
            // Make the request
            PagedAsyncEnumerable<ListPlaybookVersionsResponse, PlaybookVersion> response = playbooksClient.ListPlaybookVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PlaybookVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPlaybookVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PlaybookVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PlaybookVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PlaybookVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeletePlaybookVersion</summary>
        public void DeletePlaybookVersionRequestObject()
        {
            // Snippet: DeletePlaybookVersion(DeletePlaybookVersionRequest, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            DeletePlaybookVersionRequest request = new DeletePlaybookVersionRequest
            {
                PlaybookVersionName = PlaybookVersionName.FromProjectLocationAgentPlaybookVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[VERSION]"),
            };
            // Make the request
            playbooksClient.DeletePlaybookVersion(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePlaybookVersionAsync</summary>
        public async Task DeletePlaybookVersionRequestObjectAsync()
        {
            // Snippet: DeletePlaybookVersionAsync(DeletePlaybookVersionRequest, CallSettings)
            // Additional: DeletePlaybookVersionAsync(DeletePlaybookVersionRequest, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            DeletePlaybookVersionRequest request = new DeletePlaybookVersionRequest
            {
                PlaybookVersionName = PlaybookVersionName.FromProjectLocationAgentPlaybookVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[VERSION]"),
            };
            // Make the request
            await playbooksClient.DeletePlaybookVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePlaybookVersion</summary>
        public void DeletePlaybookVersion()
        {
            // Snippet: DeletePlaybookVersion(string, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]/versions/[VERSION]";
            // Make the request
            playbooksClient.DeletePlaybookVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePlaybookVersionAsync</summary>
        public async Task DeletePlaybookVersionAsync()
        {
            // Snippet: DeletePlaybookVersionAsync(string, CallSettings)
            // Additional: DeletePlaybookVersionAsync(string, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/playbooks/[PLAYBOOK]/versions/[VERSION]";
            // Make the request
            await playbooksClient.DeletePlaybookVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePlaybookVersion</summary>
        public void DeletePlaybookVersionResourceNames()
        {
            // Snippet: DeletePlaybookVersion(PlaybookVersionName, CallSettings)
            // Create client
            PlaybooksClient playbooksClient = PlaybooksClient.Create();
            // Initialize request argument(s)
            PlaybookVersionName name = PlaybookVersionName.FromProjectLocationAgentPlaybookVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[VERSION]");
            // Make the request
            playbooksClient.DeletePlaybookVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePlaybookVersionAsync</summary>
        public async Task DeletePlaybookVersionResourceNamesAsync()
        {
            // Snippet: DeletePlaybookVersionAsync(PlaybookVersionName, CallSettings)
            // Additional: DeletePlaybookVersionAsync(PlaybookVersionName, CancellationToken)
            // Create client
            PlaybooksClient playbooksClient = await PlaybooksClient.CreateAsync();
            // Initialize request argument(s)
            PlaybookVersionName name = PlaybookVersionName.FromProjectLocationAgentPlaybookVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[PLAYBOOK]", "[VERSION]");
            // Make the request
            await playbooksClient.DeletePlaybookVersionAsync(name);
            // End snippet
        }
    }
}
