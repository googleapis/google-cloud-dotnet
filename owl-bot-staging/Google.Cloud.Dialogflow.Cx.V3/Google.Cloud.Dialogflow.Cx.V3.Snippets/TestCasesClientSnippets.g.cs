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
    using Google.Cloud.Dialogflow.Cx.V3;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTestCasesClientSnippets
    {
        /// <summary>Snippet for ListTestCases</summary>
        public void ListTestCasesRequestObject()
        {
            // Snippet: ListTestCases(ListTestCasesRequest, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            ListTestCasesRequest request = new ListTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                View = ListTestCasesRequest.Types.TestCaseView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListTestCasesResponse, TestCase> response = testCasesClient.ListTestCases(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TestCase item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTestCasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TestCase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TestCase> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TestCase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTestCasesAsync</summary>
        public async Task ListTestCasesRequestObjectAsync()
        {
            // Snippet: ListTestCasesAsync(ListTestCasesRequest, CallSettings)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            ListTestCasesRequest request = new ListTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                View = ListTestCasesRequest.Types.TestCaseView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListTestCasesResponse, TestCase> response = testCasesClient.ListTestCasesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TestCase item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTestCasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TestCase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TestCase> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TestCase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTestCases</summary>
        public void ListTestCases()
        {
            // Snippet: ListTestCases(string, string, int?, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            PagedEnumerable<ListTestCasesResponse, TestCase> response = testCasesClient.ListTestCases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TestCase item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTestCasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TestCase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TestCase> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TestCase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTestCasesAsync</summary>
        public async Task ListTestCasesAsync()
        {
            // Snippet: ListTestCasesAsync(string, string, int?, CallSettings)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            PagedAsyncEnumerable<ListTestCasesResponse, TestCase> response = testCasesClient.ListTestCasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TestCase item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTestCasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TestCase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TestCase> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TestCase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTestCases</summary>
        public void ListTestCasesResourceNames()
        {
            // Snippet: ListTestCases(AgentName, string, int?, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            PagedEnumerable<ListTestCasesResponse, TestCase> response = testCasesClient.ListTestCases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TestCase item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTestCasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TestCase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TestCase> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TestCase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTestCasesAsync</summary>
        public async Task ListTestCasesResourceNamesAsync()
        {
            // Snippet: ListTestCasesAsync(AgentName, string, int?, CallSettings)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            PagedAsyncEnumerable<ListTestCasesResponse, TestCase> response = testCasesClient.ListTestCasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TestCase item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTestCasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TestCase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TestCase> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TestCase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteTestCases</summary>
        public void BatchDeleteTestCasesRequestObject()
        {
            // Snippet: BatchDeleteTestCases(BatchDeleteTestCasesRequest, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            BatchDeleteTestCasesRequest request = new BatchDeleteTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                TestCaseNames =
                {
                    TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                },
            };
            // Make the request
            testCasesClient.BatchDeleteTestCases(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteTestCasesAsync</summary>
        public async Task BatchDeleteTestCasesRequestObjectAsync()
        {
            // Snippet: BatchDeleteTestCasesAsync(BatchDeleteTestCasesRequest, CallSettings)
            // Additional: BatchDeleteTestCasesAsync(BatchDeleteTestCasesRequest, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteTestCasesRequest request = new BatchDeleteTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                TestCaseNames =
                {
                    TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                },
            };
            // Make the request
            await testCasesClient.BatchDeleteTestCasesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteTestCases</summary>
        public void BatchDeleteTestCases()
        {
            // Snippet: BatchDeleteTestCases(string, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            testCasesClient.BatchDeleteTestCases(parent);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteTestCasesAsync</summary>
        public async Task BatchDeleteTestCasesAsync()
        {
            // Snippet: BatchDeleteTestCasesAsync(string, CallSettings)
            // Additional: BatchDeleteTestCasesAsync(string, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            await testCasesClient.BatchDeleteTestCasesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteTestCases</summary>
        public void BatchDeleteTestCasesResourceNames()
        {
            // Snippet: BatchDeleteTestCases(AgentName, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            testCasesClient.BatchDeleteTestCases(parent);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteTestCasesAsync</summary>
        public async Task BatchDeleteTestCasesResourceNamesAsync()
        {
            // Snippet: BatchDeleteTestCasesAsync(AgentName, CallSettings)
            // Additional: BatchDeleteTestCasesAsync(AgentName, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            await testCasesClient.BatchDeleteTestCasesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for GetTestCase</summary>
        public void GetTestCaseRequestObject()
        {
            // Snippet: GetTestCase(GetTestCaseRequest, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            GetTestCaseRequest request = new GetTestCaseRequest
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
            };
            // Make the request
            TestCase response = testCasesClient.GetTestCase(request);
            // End snippet
        }

        /// <summary>Snippet for GetTestCaseAsync</summary>
        public async Task GetTestCaseRequestObjectAsync()
        {
            // Snippet: GetTestCaseAsync(GetTestCaseRequest, CallSettings)
            // Additional: GetTestCaseAsync(GetTestCaseRequest, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            GetTestCaseRequest request = new GetTestCaseRequest
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
            };
            // Make the request
            TestCase response = await testCasesClient.GetTestCaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTestCase</summary>
        public void GetTestCase()
        {
            // Snippet: GetTestCase(string, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/testCases/[TEST_CASE]";
            // Make the request
            TestCase response = testCasesClient.GetTestCase(name);
            // End snippet
        }

        /// <summary>Snippet for GetTestCaseAsync</summary>
        public async Task GetTestCaseAsync()
        {
            // Snippet: GetTestCaseAsync(string, CallSettings)
            // Additional: GetTestCaseAsync(string, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/testCases/[TEST_CASE]";
            // Make the request
            TestCase response = await testCasesClient.GetTestCaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTestCase</summary>
        public void GetTestCaseResourceNames()
        {
            // Snippet: GetTestCase(TestCaseName, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            TestCaseName name = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]");
            // Make the request
            TestCase response = testCasesClient.GetTestCase(name);
            // End snippet
        }

        /// <summary>Snippet for GetTestCaseAsync</summary>
        public async Task GetTestCaseResourceNamesAsync()
        {
            // Snippet: GetTestCaseAsync(TestCaseName, CallSettings)
            // Additional: GetTestCaseAsync(TestCaseName, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            TestCaseName name = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]");
            // Make the request
            TestCase response = await testCasesClient.GetTestCaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTestCase</summary>
        public void CreateTestCaseRequestObject()
        {
            // Snippet: CreateTestCase(CreateTestCaseRequest, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            CreateTestCaseRequest request = new CreateTestCaseRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                TestCase = new TestCase(),
            };
            // Make the request
            TestCase response = testCasesClient.CreateTestCase(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTestCaseAsync</summary>
        public async Task CreateTestCaseRequestObjectAsync()
        {
            // Snippet: CreateTestCaseAsync(CreateTestCaseRequest, CallSettings)
            // Additional: CreateTestCaseAsync(CreateTestCaseRequest, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            CreateTestCaseRequest request = new CreateTestCaseRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                TestCase = new TestCase(),
            };
            // Make the request
            TestCase response = await testCasesClient.CreateTestCaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTestCase</summary>
        public void CreateTestCase()
        {
            // Snippet: CreateTestCase(string, TestCase, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            TestCase testCase = new TestCase();
            // Make the request
            TestCase response = testCasesClient.CreateTestCase(parent, testCase);
            // End snippet
        }

        /// <summary>Snippet for CreateTestCaseAsync</summary>
        public async Task CreateTestCaseAsync()
        {
            // Snippet: CreateTestCaseAsync(string, TestCase, CallSettings)
            // Additional: CreateTestCaseAsync(string, TestCase, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            TestCase testCase = new TestCase();
            // Make the request
            TestCase response = await testCasesClient.CreateTestCaseAsync(parent, testCase);
            // End snippet
        }

        /// <summary>Snippet for CreateTestCase</summary>
        public void CreateTestCaseResourceNames()
        {
            // Snippet: CreateTestCase(AgentName, TestCase, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            TestCase testCase = new TestCase();
            // Make the request
            TestCase response = testCasesClient.CreateTestCase(parent, testCase);
            // End snippet
        }

        /// <summary>Snippet for CreateTestCaseAsync</summary>
        public async Task CreateTestCaseResourceNamesAsync()
        {
            // Snippet: CreateTestCaseAsync(AgentName, TestCase, CallSettings)
            // Additional: CreateTestCaseAsync(AgentName, TestCase, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            TestCase testCase = new TestCase();
            // Make the request
            TestCase response = await testCasesClient.CreateTestCaseAsync(parent, testCase);
            // End snippet
        }

        /// <summary>Snippet for UpdateTestCase</summary>
        public void UpdateTestCaseRequestObject()
        {
            // Snippet: UpdateTestCase(UpdateTestCaseRequest, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            UpdateTestCaseRequest request = new UpdateTestCaseRequest
            {
                TestCase = new TestCase(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TestCase response = testCasesClient.UpdateTestCase(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTestCaseAsync</summary>
        public async Task UpdateTestCaseRequestObjectAsync()
        {
            // Snippet: UpdateTestCaseAsync(UpdateTestCaseRequest, CallSettings)
            // Additional: UpdateTestCaseAsync(UpdateTestCaseRequest, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTestCaseRequest request = new UpdateTestCaseRequest
            {
                TestCase = new TestCase(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TestCase response = await testCasesClient.UpdateTestCaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTestCase</summary>
        public void UpdateTestCase()
        {
            // Snippet: UpdateTestCase(TestCase, FieldMask, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            TestCase testCase = new TestCase();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TestCase response = testCasesClient.UpdateTestCase(testCase, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTestCaseAsync</summary>
        public async Task UpdateTestCaseAsync()
        {
            // Snippet: UpdateTestCaseAsync(TestCase, FieldMask, CallSettings)
            // Additional: UpdateTestCaseAsync(TestCase, FieldMask, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            TestCase testCase = new TestCase();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TestCase response = await testCasesClient.UpdateTestCaseAsync(testCase, updateMask);
            // End snippet
        }

        /// <summary>Snippet for RunTestCase</summary>
        public void RunTestCaseRequestObject()
        {
            // Snippet: RunTestCase(RunTestCaseRequest, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            RunTestCaseRequest request = new RunTestCaseRequest
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            Operation<RunTestCaseResponse, RunTestCaseMetadata> response = testCasesClient.RunTestCase(request);

            // Poll until the returned long-running operation is complete
            Operation<RunTestCaseResponse, RunTestCaseMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RunTestCaseResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunTestCaseResponse, RunTestCaseMetadata> retrievedResponse = testCasesClient.PollOnceRunTestCase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunTestCaseResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunTestCaseAsync</summary>
        public async Task RunTestCaseRequestObjectAsync()
        {
            // Snippet: RunTestCaseAsync(RunTestCaseRequest, CallSettings)
            // Additional: RunTestCaseAsync(RunTestCaseRequest, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            RunTestCaseRequest request = new RunTestCaseRequest
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            Operation<RunTestCaseResponse, RunTestCaseMetadata> response = await testCasesClient.RunTestCaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RunTestCaseResponse, RunTestCaseMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RunTestCaseResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunTestCaseResponse, RunTestCaseMetadata> retrievedResponse = await testCasesClient.PollOnceRunTestCaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunTestCaseResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchRunTestCases</summary>
        public void BatchRunTestCasesRequestObject()
        {
            // Snippet: BatchRunTestCases(BatchRunTestCasesRequest, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            BatchRunTestCasesRequest request = new BatchRunTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                TestCasesAsTestCaseNames =
                {
                    TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                },
            };
            // Make the request
            Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata> response = testCasesClient.BatchRunTestCases(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchRunTestCasesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata> retrievedResponse = testCasesClient.PollOnceBatchRunTestCases(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchRunTestCasesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchRunTestCasesAsync</summary>
        public async Task BatchRunTestCasesRequestObjectAsync()
        {
            // Snippet: BatchRunTestCasesAsync(BatchRunTestCasesRequest, CallSettings)
            // Additional: BatchRunTestCasesAsync(BatchRunTestCasesRequest, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            BatchRunTestCasesRequest request = new BatchRunTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                TestCasesAsTestCaseNames =
                {
                    TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                },
            };
            // Make the request
            Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata> response = await testCasesClient.BatchRunTestCasesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchRunTestCasesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchRunTestCasesResponse, BatchRunTestCasesMetadata> retrievedResponse = await testCasesClient.PollOnceBatchRunTestCasesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchRunTestCasesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CalculateCoverage</summary>
        public void CalculateCoverageRequestObject()
        {
            // Snippet: CalculateCoverage(CalculateCoverageRequest, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            CalculateCoverageRequest request = new CalculateCoverageRequest
            {
                Type = CalculateCoverageRequest.Types.CoverageType.Unspecified,
                AgentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            // Make the request
            CalculateCoverageResponse response = testCasesClient.CalculateCoverage(request);
            // End snippet
        }

        /// <summary>Snippet for CalculateCoverageAsync</summary>
        public async Task CalculateCoverageRequestObjectAsync()
        {
            // Snippet: CalculateCoverageAsync(CalculateCoverageRequest, CallSettings)
            // Additional: CalculateCoverageAsync(CalculateCoverageRequest, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            CalculateCoverageRequest request = new CalculateCoverageRequest
            {
                Type = CalculateCoverageRequest.Types.CoverageType.Unspecified,
                AgentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            // Make the request
            CalculateCoverageResponse response = await testCasesClient.CalculateCoverageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportTestCases</summary>
        public void ImportTestCasesRequestObject()
        {
            // Snippet: ImportTestCases(ImportTestCasesRequest, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            ImportTestCasesRequest request = new ImportTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                GcsUri = "",
            };
            // Make the request
            Operation<ImportTestCasesResponse, ImportTestCasesMetadata> response = testCasesClient.ImportTestCases(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportTestCasesResponse, ImportTestCasesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportTestCasesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportTestCasesResponse, ImportTestCasesMetadata> retrievedResponse = testCasesClient.PollOnceImportTestCases(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportTestCasesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportTestCasesAsync</summary>
        public async Task ImportTestCasesRequestObjectAsync()
        {
            // Snippet: ImportTestCasesAsync(ImportTestCasesRequest, CallSettings)
            // Additional: ImportTestCasesAsync(ImportTestCasesRequest, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            ImportTestCasesRequest request = new ImportTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                GcsUri = "",
            };
            // Make the request
            Operation<ImportTestCasesResponse, ImportTestCasesMetadata> response = await testCasesClient.ImportTestCasesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportTestCasesResponse, ImportTestCasesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportTestCasesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportTestCasesResponse, ImportTestCasesMetadata> retrievedResponse = await testCasesClient.PollOnceImportTestCasesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportTestCasesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportTestCases</summary>
        public void ExportTestCasesRequestObject()
        {
            // Snippet: ExportTestCases(ExportTestCasesRequest, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            ExportTestCasesRequest request = new ExportTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                GcsUri = "",
                DataFormat = ExportTestCasesRequest.Types.DataFormat.Unspecified,
                Filter = "",
            };
            // Make the request
            Operation<ExportTestCasesResponse, ExportTestCasesMetadata> response = testCasesClient.ExportTestCases(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportTestCasesResponse, ExportTestCasesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportTestCasesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportTestCasesResponse, ExportTestCasesMetadata> retrievedResponse = testCasesClient.PollOnceExportTestCases(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportTestCasesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportTestCasesAsync</summary>
        public async Task ExportTestCasesRequestObjectAsync()
        {
            // Snippet: ExportTestCasesAsync(ExportTestCasesRequest, CallSettings)
            // Additional: ExportTestCasesAsync(ExportTestCasesRequest, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            ExportTestCasesRequest request = new ExportTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                GcsUri = "",
                DataFormat = ExportTestCasesRequest.Types.DataFormat.Unspecified,
                Filter = "",
            };
            // Make the request
            Operation<ExportTestCasesResponse, ExportTestCasesMetadata> response = await testCasesClient.ExportTestCasesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportTestCasesResponse, ExportTestCasesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportTestCasesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportTestCasesResponse, ExportTestCasesMetadata> retrievedResponse = await testCasesClient.PollOnceExportTestCasesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportTestCasesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListTestCaseResults</summary>
        public void ListTestCaseResultsRequestObject()
        {
            // Snippet: ListTestCaseResults(ListTestCaseResultsRequest, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            ListTestCaseResultsRequest request = new ListTestCaseResultsRequest
            {
                ParentAsTestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListTestCaseResultsResponse, TestCaseResult> response = testCasesClient.ListTestCaseResults(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TestCaseResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTestCaseResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TestCaseResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TestCaseResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TestCaseResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTestCaseResultsAsync</summary>
        public async Task ListTestCaseResultsRequestObjectAsync()
        {
            // Snippet: ListTestCaseResultsAsync(ListTestCaseResultsRequest, CallSettings)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            ListTestCaseResultsRequest request = new ListTestCaseResultsRequest
            {
                ParentAsTestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTestCaseResultsResponse, TestCaseResult> response = testCasesClient.ListTestCaseResultsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TestCaseResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTestCaseResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TestCaseResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TestCaseResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TestCaseResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTestCaseResults</summary>
        public void ListTestCaseResults()
        {
            // Snippet: ListTestCaseResults(string, string, int?, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/testCases/[TEST_CASE]";
            // Make the request
            PagedEnumerable<ListTestCaseResultsResponse, TestCaseResult> response = testCasesClient.ListTestCaseResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TestCaseResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTestCaseResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TestCaseResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TestCaseResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TestCaseResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTestCaseResultsAsync</summary>
        public async Task ListTestCaseResultsAsync()
        {
            // Snippet: ListTestCaseResultsAsync(string, string, int?, CallSettings)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/testCases/[TEST_CASE]";
            // Make the request
            PagedAsyncEnumerable<ListTestCaseResultsResponse, TestCaseResult> response = testCasesClient.ListTestCaseResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TestCaseResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTestCaseResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TestCaseResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TestCaseResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TestCaseResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTestCaseResults</summary>
        public void ListTestCaseResultsResourceNames()
        {
            // Snippet: ListTestCaseResults(TestCaseName, string, int?, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            TestCaseName parent = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]");
            // Make the request
            PagedEnumerable<ListTestCaseResultsResponse, TestCaseResult> response = testCasesClient.ListTestCaseResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TestCaseResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTestCaseResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TestCaseResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TestCaseResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TestCaseResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTestCaseResultsAsync</summary>
        public async Task ListTestCaseResultsResourceNamesAsync()
        {
            // Snippet: ListTestCaseResultsAsync(TestCaseName, string, int?, CallSettings)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            TestCaseName parent = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]");
            // Make the request
            PagedAsyncEnumerable<ListTestCaseResultsResponse, TestCaseResult> response = testCasesClient.ListTestCaseResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TestCaseResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTestCaseResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TestCaseResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TestCaseResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TestCaseResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTestCaseResult</summary>
        public void GetTestCaseResultRequestObject()
        {
            // Snippet: GetTestCaseResult(GetTestCaseResultRequest, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            GetTestCaseResultRequest request = new GetTestCaseResultRequest
            {
                TestCaseResultName = TestCaseResultName.FromProjectLocationAgentTestCaseResult("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]", "[RESULT]"),
            };
            // Make the request
            TestCaseResult response = testCasesClient.GetTestCaseResult(request);
            // End snippet
        }

        /// <summary>Snippet for GetTestCaseResultAsync</summary>
        public async Task GetTestCaseResultRequestObjectAsync()
        {
            // Snippet: GetTestCaseResultAsync(GetTestCaseResultRequest, CallSettings)
            // Additional: GetTestCaseResultAsync(GetTestCaseResultRequest, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            GetTestCaseResultRequest request = new GetTestCaseResultRequest
            {
                TestCaseResultName = TestCaseResultName.FromProjectLocationAgentTestCaseResult("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]", "[RESULT]"),
            };
            // Make the request
            TestCaseResult response = await testCasesClient.GetTestCaseResultAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTestCaseResult</summary>
        public void GetTestCaseResult()
        {
            // Snippet: GetTestCaseResult(string, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/testCases/[TEST_CASE]/results/[RESULT]";
            // Make the request
            TestCaseResult response = testCasesClient.GetTestCaseResult(name);
            // End snippet
        }

        /// <summary>Snippet for GetTestCaseResultAsync</summary>
        public async Task GetTestCaseResultAsync()
        {
            // Snippet: GetTestCaseResultAsync(string, CallSettings)
            // Additional: GetTestCaseResultAsync(string, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/testCases/[TEST_CASE]/results/[RESULT]";
            // Make the request
            TestCaseResult response = await testCasesClient.GetTestCaseResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTestCaseResult</summary>
        public void GetTestCaseResultResourceNames()
        {
            // Snippet: GetTestCaseResult(TestCaseResultName, CallSettings)
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            TestCaseResultName name = TestCaseResultName.FromProjectLocationAgentTestCaseResult("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]", "[RESULT]");
            // Make the request
            TestCaseResult response = testCasesClient.GetTestCaseResult(name);
            // End snippet
        }

        /// <summary>Snippet for GetTestCaseResultAsync</summary>
        public async Task GetTestCaseResultResourceNamesAsync()
        {
            // Snippet: GetTestCaseResultAsync(TestCaseResultName, CallSettings)
            // Additional: GetTestCaseResultAsync(TestCaseResultName, CancellationToken)
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            TestCaseResultName name = TestCaseResultName.FromProjectLocationAgentTestCaseResult("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]", "[RESULT]");
            // Make the request
            TestCaseResult response = await testCasesClient.GetTestCaseResultAsync(name);
            // End snippet
        }
    }
}
