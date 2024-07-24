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
    public sealed class AllGeneratedLicensesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteLicenseRequest, CallSettings)
            // Create client
            LicensesClient licensesClient = LicensesClient.Create();
            // Initialize request argument(s)
            DeleteLicenseRequest request = new DeleteLicenseRequest
            {
                RequestId = "",
                License = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = licensesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = licensesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteLicenseRequest, CallSettings)
            // Additional: DeleteAsync(DeleteLicenseRequest, CancellationToken)
            // Create client
            LicensesClient licensesClient = await LicensesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteLicenseRequest request = new DeleteLicenseRequest
            {
                RequestId = "",
                License = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await licensesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await licensesClient.PollOnceDeleteAsync(operationName);
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
            LicensesClient licensesClient = LicensesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string license = "";
            // Make the request
            lro::Operation<Operation, Operation> response = licensesClient.Delete(project, license);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = licensesClient.PollOnceDelete(operationName);
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
            LicensesClient licensesClient = await LicensesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string license = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await licensesClient.DeleteAsync(project, license);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await licensesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetLicenseRequest, CallSettings)
            // Create client
            LicensesClient licensesClient = LicensesClient.Create();
            // Initialize request argument(s)
            GetLicenseRequest request = new GetLicenseRequest
            {
                License = "",
                Project = "",
            };
            // Make the request
            License response = licensesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetLicenseRequest, CallSettings)
            // Additional: GetAsync(GetLicenseRequest, CancellationToken)
            // Create client
            LicensesClient licensesClient = await LicensesClient.CreateAsync();
            // Initialize request argument(s)
            GetLicenseRequest request = new GetLicenseRequest
            {
                License = "",
                Project = "",
            };
            // Make the request
            License response = await licensesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            LicensesClient licensesClient = LicensesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string license = "";
            // Make the request
            License response = licensesClient.Get(project, license);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            LicensesClient licensesClient = await LicensesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string license = "";
            // Make the request
            License response = await licensesClient.GetAsync(project, license);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyLicenseRequest, CallSettings)
            // Create client
            LicensesClient licensesClient = LicensesClient.Create();
            // Initialize request argument(s)
            GetIamPolicyLicenseRequest request = new GetIamPolicyLicenseRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = licensesClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyLicenseRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyLicenseRequest, CancellationToken)
            // Create client
            LicensesClient licensesClient = await LicensesClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyLicenseRequest request = new GetIamPolicyLicenseRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await licensesClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, CallSettings)
            // Create client
            LicensesClient licensesClient = LicensesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = licensesClient.GetIamPolicy(project, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, CancellationToken)
            // Create client
            LicensesClient licensesClient = await LicensesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = await licensesClient.GetIamPolicyAsync(project, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertLicenseRequest, CallSettings)
            // Create client
            LicensesClient licensesClient = LicensesClient.Create();
            // Initialize request argument(s)
            InsertLicenseRequest request = new InsertLicenseRequest
            {
                RequestId = "",
                Project = "",
                LicenseResource = new License(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = licensesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = licensesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertLicenseRequest, CallSettings)
            // Additional: InsertAsync(InsertLicenseRequest, CancellationToken)
            // Create client
            LicensesClient licensesClient = await LicensesClient.CreateAsync();
            // Initialize request argument(s)
            InsertLicenseRequest request = new InsertLicenseRequest
            {
                RequestId = "",
                Project = "",
                LicenseResource = new License(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await licensesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await licensesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, License, CallSettings)
            // Create client
            LicensesClient licensesClient = LicensesClient.Create();
            // Initialize request argument(s)
            string project = "";
            License licenseResource = new License();
            // Make the request
            lro::Operation<Operation, Operation> response = licensesClient.Insert(project, licenseResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = licensesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, License, CallSettings)
            // Additional: InsertAsync(string, License, CancellationToken)
            // Create client
            LicensesClient licensesClient = await LicensesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            License licenseResource = new License();
            // Make the request
            lro::Operation<Operation, Operation> response = await licensesClient.InsertAsync(project, licenseResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await licensesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListLicensesRequest, CallSettings)
            // Create client
            LicensesClient licensesClient = LicensesClient.Create();
            // Initialize request argument(s)
            ListLicensesRequest request = new ListLicensesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<LicensesListResponse, License> response = licensesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (License item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (LicensesListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (License item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<License> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (License item in singlePage)
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
            // Snippet: ListAsync(ListLicensesRequest, CallSettings)
            // Create client
            LicensesClient licensesClient = await LicensesClient.CreateAsync();
            // Initialize request argument(s)
            ListLicensesRequest request = new ListLicensesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<LicensesListResponse, License> response = licensesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((License item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((LicensesListResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (License item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<License> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (License item in singlePage)
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
            LicensesClient licensesClient = LicensesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<LicensesListResponse, License> response = licensesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (License item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (LicensesListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (License item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<License> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (License item in singlePage)
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
            LicensesClient licensesClient = await LicensesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<LicensesListResponse, License> response = licensesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((License item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((LicensesListResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (License item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<License> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (License item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyLicenseRequest, CallSettings)
            // Create client
            LicensesClient licensesClient = LicensesClient.Create();
            // Initialize request argument(s)
            SetIamPolicyLicenseRequest request = new SetIamPolicyLicenseRequest
            {
                Resource = "",
                Project = "",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            // Make the request
            Policy response = licensesClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyLicenseRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyLicenseRequest, CancellationToken)
            // Create client
            LicensesClient licensesClient = await LicensesClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyLicenseRequest request = new SetIamPolicyLicenseRequest
            {
                Resource = "",
                Project = "",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            // Make the request
            Policy response = await licensesClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, GlobalSetPolicyRequest, CallSettings)
            // Create client
            LicensesClient licensesClient = LicensesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = licensesClient.SetIamPolicy(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CancellationToken)
            // Create client
            LicensesClient licensesClient = await LicensesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = await licensesClient.SetIamPolicyAsync(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsLicenseRequest, CallSettings)
            // Create client
            LicensesClient licensesClient = LicensesClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsLicenseRequest request = new TestIamPermissionsLicenseRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = licensesClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsLicenseRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsLicenseRequest, CancellationToken)
            // Create client
            LicensesClient licensesClient = await LicensesClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsLicenseRequest request = new TestIamPermissionsLicenseRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await licensesClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, TestPermissionsRequest, CallSettings)
            // Create client
            LicensesClient licensesClient = LicensesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = licensesClient.TestIamPermissions(project, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            LicensesClient licensesClient = await LicensesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await licensesClient.TestIamPermissionsAsync(project, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
