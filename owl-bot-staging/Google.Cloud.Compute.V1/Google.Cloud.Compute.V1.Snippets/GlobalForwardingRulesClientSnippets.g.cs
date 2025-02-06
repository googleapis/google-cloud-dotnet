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
    using Google.Cloud.Compute.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGlobalForwardingRulesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteGlobalForwardingRuleRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            DeleteGlobalForwardingRuleRequest request = new DeleteGlobalForwardingRuleRequest
            {
                RequestId = "",
                Project = "",
                ForwardingRule = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalForwardingRulesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalForwardingRulesClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteGlobalForwardingRuleRequest, CallSettings)
            // Additional: DeleteAsync(DeleteGlobalForwardingRuleRequest, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGlobalForwardingRuleRequest request = new DeleteGlobalForwardingRuleRequest
            {
                RequestId = "",
                Project = "",
                ForwardingRule = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalForwardingRulesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalForwardingRulesClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string forwardingRule = "";
            // Make the request
            lro::Operation<Operation, Operation> response = globalForwardingRulesClient.Delete(project, forwardingRule);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalForwardingRulesClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string forwardingRule = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await globalForwardingRulesClient.DeleteAsync(project, forwardingRule);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalForwardingRulesClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetGlobalForwardingRuleRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            GetGlobalForwardingRuleRequest request = new GetGlobalForwardingRuleRequest
            {
                Project = "",
                ForwardingRule = "",
            };
            // Make the request
            ForwardingRule response = globalForwardingRulesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetGlobalForwardingRuleRequest, CallSettings)
            // Additional: GetAsync(GetGlobalForwardingRuleRequest, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            GetGlobalForwardingRuleRequest request = new GetGlobalForwardingRuleRequest
            {
                Project = "",
                ForwardingRule = "",
            };
            // Make the request
            ForwardingRule response = await globalForwardingRulesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string forwardingRule = "";
            // Make the request
            ForwardingRule response = globalForwardingRulesClient.Get(project, forwardingRule);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string forwardingRule = "";
            // Make the request
            ForwardingRule response = await globalForwardingRulesClient.GetAsync(project, forwardingRule);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertGlobalForwardingRuleRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            InsertGlobalForwardingRuleRequest request = new InsertGlobalForwardingRuleRequest
            {
                RequestId = "",
                Project = "",
                ForwardingRuleResource = new ForwardingRule(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalForwardingRulesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalForwardingRulesClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertGlobalForwardingRuleRequest, CallSettings)
            // Additional: InsertAsync(InsertGlobalForwardingRuleRequest, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            InsertGlobalForwardingRuleRequest request = new InsertGlobalForwardingRuleRequest
            {
                RequestId = "",
                Project = "",
                ForwardingRuleResource = new ForwardingRule(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalForwardingRulesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalForwardingRulesClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, ForwardingRule, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            ForwardingRule forwardingRuleResource = new ForwardingRule();
            // Make the request
            lro::Operation<Operation, Operation> response = globalForwardingRulesClient.Insert(project, forwardingRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalForwardingRulesClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, ForwardingRule, CallSettings)
            // Additional: InsertAsync(string, ForwardingRule, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            ForwardingRule forwardingRuleResource = new ForwardingRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await globalForwardingRulesClient.InsertAsync(project, forwardingRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalForwardingRulesClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListGlobalForwardingRulesRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            ListGlobalForwardingRulesRequest request = new ListGlobalForwardingRulesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ForwardingRuleList, ForwardingRule> response = globalForwardingRulesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ForwardingRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ForwardingRuleList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForwardingRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForwardingRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForwardingRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListGlobalForwardingRulesRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            ListGlobalForwardingRulesRequest request = new ListGlobalForwardingRulesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ForwardingRuleList, ForwardingRule> response = globalForwardingRulesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ForwardingRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ForwardingRuleList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForwardingRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForwardingRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForwardingRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, int?, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<ForwardingRuleList, ForwardingRule> response = globalForwardingRulesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ForwardingRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ForwardingRuleList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForwardingRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForwardingRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForwardingRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, int?, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<ForwardingRuleList, ForwardingRule> response = globalForwardingRulesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ForwardingRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ForwardingRuleList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForwardingRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForwardingRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForwardingRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchGlobalForwardingRuleRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            PatchGlobalForwardingRuleRequest request = new PatchGlobalForwardingRuleRequest
            {
                RequestId = "",
                Project = "",
                ForwardingRule = "",
                ForwardingRuleResource = new ForwardingRule(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalForwardingRulesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalForwardingRulesClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchGlobalForwardingRuleRequest, CallSettings)
            // Additional: PatchAsync(PatchGlobalForwardingRuleRequest, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            PatchGlobalForwardingRuleRequest request = new PatchGlobalForwardingRuleRequest
            {
                RequestId = "",
                Project = "",
                ForwardingRule = "",
                ForwardingRuleResource = new ForwardingRule(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalForwardingRulesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalForwardingRulesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, ForwardingRule, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string forwardingRule = "";
            ForwardingRule forwardingRuleResource = new ForwardingRule();
            // Make the request
            lro::Operation<Operation, Operation> response = globalForwardingRulesClient.Patch(project, forwardingRule, forwardingRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalForwardingRulesClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, ForwardingRule, CallSettings)
            // Additional: PatchAsync(string, string, ForwardingRule, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string forwardingRule = "";
            ForwardingRule forwardingRuleResource = new ForwardingRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await globalForwardingRulesClient.PatchAsync(project, forwardingRule, forwardingRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalForwardingRulesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsGlobalForwardingRuleRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            SetLabelsGlobalForwardingRuleRequest request = new SetLabelsGlobalForwardingRuleRequest
            {
                Resource = "",
                Project = "",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalForwardingRulesClient.SetLabels(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalForwardingRulesClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsGlobalForwardingRuleRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsGlobalForwardingRuleRequest, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsGlobalForwardingRuleRequest request = new SetLabelsGlobalForwardingRuleRequest
            {
                Resource = "",
                Project = "",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalForwardingRulesClient.SetLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalForwardingRulesClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, GlobalSetLabelsRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = globalForwardingRulesClient.SetLabels(project, resource, globalSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalForwardingRulesClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await globalForwardingRulesClient.SetLabelsAsync(project, resource, globalSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalForwardingRulesClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetTarget</summary>
        public void SetTargetRequestObject()
        {
            // Snippet: SetTarget(SetTargetGlobalForwardingRuleRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            SetTargetGlobalForwardingRuleRequest request = new SetTargetGlobalForwardingRuleRequest
            {
                RequestId = "",
                Project = "",
                ForwardingRule = "",
                TargetReferenceResource = new TargetReference(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalForwardingRulesClient.SetTarget(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalForwardingRulesClient.PollOnceSetTarget(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetTargetAsync</summary>
        public async Task SetTargetRequestObjectAsync()
        {
            // Snippet: SetTargetAsync(SetTargetGlobalForwardingRuleRequest, CallSettings)
            // Additional: SetTargetAsync(SetTargetGlobalForwardingRuleRequest, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            SetTargetGlobalForwardingRuleRequest request = new SetTargetGlobalForwardingRuleRequest
            {
                RequestId = "",
                Project = "",
                ForwardingRule = "",
                TargetReferenceResource = new TargetReference(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalForwardingRulesClient.SetTargetAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalForwardingRulesClient.PollOnceSetTargetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetTarget</summary>
        public void SetTarget()
        {
            // Snippet: SetTarget(string, string, TargetReference, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string forwardingRule = "";
            TargetReference targetReferenceResource = new TargetReference();
            // Make the request
            lro::Operation<Operation, Operation> response = globalForwardingRulesClient.SetTarget(project, forwardingRule, targetReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalForwardingRulesClient.PollOnceSetTarget(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetTargetAsync</summary>
        public async Task SetTargetAsync()
        {
            // Snippet: SetTargetAsync(string, string, TargetReference, CallSettings)
            // Additional: SetTargetAsync(string, string, TargetReference, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string forwardingRule = "";
            TargetReference targetReferenceResource = new TargetReference();
            // Make the request
            lro::Operation<Operation, Operation> response = await globalForwardingRulesClient.SetTargetAsync(project, forwardingRule, targetReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalForwardingRulesClient.PollOnceSetTargetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
