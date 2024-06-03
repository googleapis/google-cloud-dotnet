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
    using Google.Shopping.Merchant.Accounts.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedProgramsServiceClientSnippets
    {
        /// <summary>Snippet for GetProgram</summary>
        public void GetProgramRequestObject()
        {
            // Snippet: GetProgram(GetProgramRequest, CallSettings)
            // Create client
            ProgramsServiceClient programsServiceClient = ProgramsServiceClient.Create();
            // Initialize request argument(s)
            GetProgramRequest request = new GetProgramRequest
            {
                ProgramName = ProgramName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]"),
            };
            // Make the request
            Program response = programsServiceClient.GetProgram(request);
            // End snippet
        }

        /// <summary>Snippet for GetProgramAsync</summary>
        public async Task GetProgramRequestObjectAsync()
        {
            // Snippet: GetProgramAsync(GetProgramRequest, CallSettings)
            // Additional: GetProgramAsync(GetProgramRequest, CancellationToken)
            // Create client
            ProgramsServiceClient programsServiceClient = await ProgramsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProgramRequest request = new GetProgramRequest
            {
                ProgramName = ProgramName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]"),
            };
            // Make the request
            Program response = await programsServiceClient.GetProgramAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProgram</summary>
        public void GetProgram()
        {
            // Snippet: GetProgram(string, CallSettings)
            // Create client
            ProgramsServiceClient programsServiceClient = ProgramsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/programs/[PROGRAM]";
            // Make the request
            Program response = programsServiceClient.GetProgram(name);
            // End snippet
        }

        /// <summary>Snippet for GetProgramAsync</summary>
        public async Task GetProgramAsync()
        {
            // Snippet: GetProgramAsync(string, CallSettings)
            // Additional: GetProgramAsync(string, CancellationToken)
            // Create client
            ProgramsServiceClient programsServiceClient = await ProgramsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/programs/[PROGRAM]";
            // Make the request
            Program response = await programsServiceClient.GetProgramAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProgram</summary>
        public void GetProgramResourceNames()
        {
            // Snippet: GetProgram(ProgramName, CallSettings)
            // Create client
            ProgramsServiceClient programsServiceClient = ProgramsServiceClient.Create();
            // Initialize request argument(s)
            ProgramName name = ProgramName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]");
            // Make the request
            Program response = programsServiceClient.GetProgram(name);
            // End snippet
        }

        /// <summary>Snippet for GetProgramAsync</summary>
        public async Task GetProgramResourceNamesAsync()
        {
            // Snippet: GetProgramAsync(ProgramName, CallSettings)
            // Additional: GetProgramAsync(ProgramName, CancellationToken)
            // Create client
            ProgramsServiceClient programsServiceClient = await ProgramsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProgramName name = ProgramName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]");
            // Make the request
            Program response = await programsServiceClient.GetProgramAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPrograms</summary>
        public void ListProgramsRequestObject()
        {
            // Snippet: ListPrograms(ListProgramsRequest, CallSettings)
            // Create client
            ProgramsServiceClient programsServiceClient = ProgramsServiceClient.Create();
            // Initialize request argument(s)
            ListProgramsRequest request = new ListProgramsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListProgramsResponse, Program> response = programsServiceClient.ListPrograms(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Program item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProgramsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Program item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Program> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Program item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProgramsAsync</summary>
        public async Task ListProgramsRequestObjectAsync()
        {
            // Snippet: ListProgramsAsync(ListProgramsRequest, CallSettings)
            // Create client
            ProgramsServiceClient programsServiceClient = await ProgramsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListProgramsRequest request = new ListProgramsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListProgramsResponse, Program> response = programsServiceClient.ListProgramsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Program item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProgramsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Program item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Program> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Program item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrograms</summary>
        public void ListPrograms()
        {
            // Snippet: ListPrograms(string, string, int?, CallSettings)
            // Create client
            ProgramsServiceClient programsServiceClient = ProgramsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListProgramsResponse, Program> response = programsServiceClient.ListPrograms(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Program item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProgramsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Program item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Program> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Program item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProgramsAsync</summary>
        public async Task ListProgramsAsync()
        {
            // Snippet: ListProgramsAsync(string, string, int?, CallSettings)
            // Create client
            ProgramsServiceClient programsServiceClient = await ProgramsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListProgramsResponse, Program> response = programsServiceClient.ListProgramsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Program item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProgramsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Program item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Program> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Program item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrograms</summary>
        public void ListProgramsResourceNames()
        {
            // Snippet: ListPrograms(AccountName, string, int?, CallSettings)
            // Create client
            ProgramsServiceClient programsServiceClient = ProgramsServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListProgramsResponse, Program> response = programsServiceClient.ListPrograms(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Program item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProgramsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Program item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Program> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Program item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProgramsAsync</summary>
        public async Task ListProgramsResourceNamesAsync()
        {
            // Snippet: ListProgramsAsync(AccountName, string, int?, CallSettings)
            // Create client
            ProgramsServiceClient programsServiceClient = await ProgramsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListProgramsResponse, Program> response = programsServiceClient.ListProgramsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Program item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProgramsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Program item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Program> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Program item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for EnableProgram</summary>
        public void EnableProgramRequestObject()
        {
            // Snippet: EnableProgram(EnableProgramRequest, CallSettings)
            // Create client
            ProgramsServiceClient programsServiceClient = ProgramsServiceClient.Create();
            // Initialize request argument(s)
            EnableProgramRequest request = new EnableProgramRequest
            {
                ProgramName = ProgramName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]"),
            };
            // Make the request
            Program response = programsServiceClient.EnableProgram(request);
            // End snippet
        }

        /// <summary>Snippet for EnableProgramAsync</summary>
        public async Task EnableProgramRequestObjectAsync()
        {
            // Snippet: EnableProgramAsync(EnableProgramRequest, CallSettings)
            // Additional: EnableProgramAsync(EnableProgramRequest, CancellationToken)
            // Create client
            ProgramsServiceClient programsServiceClient = await ProgramsServiceClient.CreateAsync();
            // Initialize request argument(s)
            EnableProgramRequest request = new EnableProgramRequest
            {
                ProgramName = ProgramName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]"),
            };
            // Make the request
            Program response = await programsServiceClient.EnableProgramAsync(request);
            // End snippet
        }

        /// <summary>Snippet for EnableProgram</summary>
        public void EnableProgram()
        {
            // Snippet: EnableProgram(string, CallSettings)
            // Create client
            ProgramsServiceClient programsServiceClient = ProgramsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/programs/[PROGRAM]";
            // Make the request
            Program response = programsServiceClient.EnableProgram(name);
            // End snippet
        }

        /// <summary>Snippet for EnableProgramAsync</summary>
        public async Task EnableProgramAsync()
        {
            // Snippet: EnableProgramAsync(string, CallSettings)
            // Additional: EnableProgramAsync(string, CancellationToken)
            // Create client
            ProgramsServiceClient programsServiceClient = await ProgramsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/programs/[PROGRAM]";
            // Make the request
            Program response = await programsServiceClient.EnableProgramAsync(name);
            // End snippet
        }

        /// <summary>Snippet for EnableProgram</summary>
        public void EnableProgramResourceNames()
        {
            // Snippet: EnableProgram(ProgramName, CallSettings)
            // Create client
            ProgramsServiceClient programsServiceClient = ProgramsServiceClient.Create();
            // Initialize request argument(s)
            ProgramName name = ProgramName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]");
            // Make the request
            Program response = programsServiceClient.EnableProgram(name);
            // End snippet
        }

        /// <summary>Snippet for EnableProgramAsync</summary>
        public async Task EnableProgramResourceNamesAsync()
        {
            // Snippet: EnableProgramAsync(ProgramName, CallSettings)
            // Additional: EnableProgramAsync(ProgramName, CancellationToken)
            // Create client
            ProgramsServiceClient programsServiceClient = await ProgramsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProgramName name = ProgramName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]");
            // Make the request
            Program response = await programsServiceClient.EnableProgramAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DisableProgram</summary>
        public void DisableProgramRequestObject()
        {
            // Snippet: DisableProgram(DisableProgramRequest, CallSettings)
            // Create client
            ProgramsServiceClient programsServiceClient = ProgramsServiceClient.Create();
            // Initialize request argument(s)
            DisableProgramRequest request = new DisableProgramRequest
            {
                ProgramName = ProgramName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]"),
            };
            // Make the request
            Program response = programsServiceClient.DisableProgram(request);
            // End snippet
        }

        /// <summary>Snippet for DisableProgramAsync</summary>
        public async Task DisableProgramRequestObjectAsync()
        {
            // Snippet: DisableProgramAsync(DisableProgramRequest, CallSettings)
            // Additional: DisableProgramAsync(DisableProgramRequest, CancellationToken)
            // Create client
            ProgramsServiceClient programsServiceClient = await ProgramsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DisableProgramRequest request = new DisableProgramRequest
            {
                ProgramName = ProgramName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]"),
            };
            // Make the request
            Program response = await programsServiceClient.DisableProgramAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DisableProgram</summary>
        public void DisableProgram()
        {
            // Snippet: DisableProgram(string, CallSettings)
            // Create client
            ProgramsServiceClient programsServiceClient = ProgramsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/programs/[PROGRAM]";
            // Make the request
            Program response = programsServiceClient.DisableProgram(name);
            // End snippet
        }

        /// <summary>Snippet for DisableProgramAsync</summary>
        public async Task DisableProgramAsync()
        {
            // Snippet: DisableProgramAsync(string, CallSettings)
            // Additional: DisableProgramAsync(string, CancellationToken)
            // Create client
            ProgramsServiceClient programsServiceClient = await ProgramsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/programs/[PROGRAM]";
            // Make the request
            Program response = await programsServiceClient.DisableProgramAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DisableProgram</summary>
        public void DisableProgramResourceNames()
        {
            // Snippet: DisableProgram(ProgramName, CallSettings)
            // Create client
            ProgramsServiceClient programsServiceClient = ProgramsServiceClient.Create();
            // Initialize request argument(s)
            ProgramName name = ProgramName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]");
            // Make the request
            Program response = programsServiceClient.DisableProgram(name);
            // End snippet
        }

        /// <summary>Snippet for DisableProgramAsync</summary>
        public async Task DisableProgramResourceNamesAsync()
        {
            // Snippet: DisableProgramAsync(ProgramName, CallSettings)
            // Additional: DisableProgramAsync(ProgramName, CancellationToken)
            // Create client
            ProgramsServiceClient programsServiceClient = await ProgramsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProgramName name = ProgramName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]");
            // Make the request
            Program response = await programsServiceClient.DisableProgramAsync(name);
            // End snippet
        }
    }
}
