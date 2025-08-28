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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.CloudSecurityCompliance.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDeploymentClientSnippets
    {
        /// <summary>Snippet for CreateFrameworkDeployment</summary>
        public void CreateFrameworkDeploymentRequestObject()
        {
            // Snippet: CreateFrameworkDeployment(CreateFrameworkDeploymentRequest, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            CreateFrameworkDeploymentRequest request = new CreateFrameworkDeploymentRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                FrameworkDeploymentId = "",
                FrameworkDeployment = new FrameworkDeployment(),
            };
            // Make the request
            Operation<FrameworkDeployment, OperationMetadata> response = deploymentClient.CreateFrameworkDeployment(request);

            // Poll until the returned long-running operation is complete
            Operation<FrameworkDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FrameworkDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FrameworkDeployment, OperationMetadata> retrievedResponse = deploymentClient.PollOnceCreateFrameworkDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FrameworkDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFrameworkDeploymentAsync</summary>
        public async Task CreateFrameworkDeploymentRequestObjectAsync()
        {
            // Snippet: CreateFrameworkDeploymentAsync(CreateFrameworkDeploymentRequest, CallSettings)
            // Additional: CreateFrameworkDeploymentAsync(CreateFrameworkDeploymentRequest, CancellationToken)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            CreateFrameworkDeploymentRequest request = new CreateFrameworkDeploymentRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                FrameworkDeploymentId = "",
                FrameworkDeployment = new FrameworkDeployment(),
            };
            // Make the request
            Operation<FrameworkDeployment, OperationMetadata> response = await deploymentClient.CreateFrameworkDeploymentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FrameworkDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FrameworkDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FrameworkDeployment, OperationMetadata> retrievedResponse = await deploymentClient.PollOnceCreateFrameworkDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FrameworkDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFrameworkDeployment</summary>
        public void CreateFrameworkDeployment()
        {
            // Snippet: CreateFrameworkDeployment(string, FrameworkDeployment, string, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            FrameworkDeployment frameworkDeployment = new FrameworkDeployment();
            string frameworkDeploymentId = "";
            // Make the request
            Operation<FrameworkDeployment, OperationMetadata> response = deploymentClient.CreateFrameworkDeployment(parent, frameworkDeployment, frameworkDeploymentId);

            // Poll until the returned long-running operation is complete
            Operation<FrameworkDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FrameworkDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FrameworkDeployment, OperationMetadata> retrievedResponse = deploymentClient.PollOnceCreateFrameworkDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FrameworkDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFrameworkDeploymentAsync</summary>
        public async Task CreateFrameworkDeploymentAsync()
        {
            // Snippet: CreateFrameworkDeploymentAsync(string, FrameworkDeployment, string, CallSettings)
            // Additional: CreateFrameworkDeploymentAsync(string, FrameworkDeployment, string, CancellationToken)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            FrameworkDeployment frameworkDeployment = new FrameworkDeployment();
            string frameworkDeploymentId = "";
            // Make the request
            Operation<FrameworkDeployment, OperationMetadata> response = await deploymentClient.CreateFrameworkDeploymentAsync(parent, frameworkDeployment, frameworkDeploymentId);

            // Poll until the returned long-running operation is complete
            Operation<FrameworkDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FrameworkDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FrameworkDeployment, OperationMetadata> retrievedResponse = await deploymentClient.PollOnceCreateFrameworkDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FrameworkDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFrameworkDeployment</summary>
        public void CreateFrameworkDeploymentResourceNames()
        {
            // Snippet: CreateFrameworkDeployment(OrganizationLocationName, FrameworkDeployment, string, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            FrameworkDeployment frameworkDeployment = new FrameworkDeployment();
            string frameworkDeploymentId = "";
            // Make the request
            Operation<FrameworkDeployment, OperationMetadata> response = deploymentClient.CreateFrameworkDeployment(parent, frameworkDeployment, frameworkDeploymentId);

            // Poll until the returned long-running operation is complete
            Operation<FrameworkDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FrameworkDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FrameworkDeployment, OperationMetadata> retrievedResponse = deploymentClient.PollOnceCreateFrameworkDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FrameworkDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFrameworkDeploymentAsync</summary>
        public async Task CreateFrameworkDeploymentResourceNamesAsync()
        {
            // Snippet: CreateFrameworkDeploymentAsync(OrganizationLocationName, FrameworkDeployment, string, CallSettings)
            // Additional: CreateFrameworkDeploymentAsync(OrganizationLocationName, FrameworkDeployment, string, CancellationToken)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            FrameworkDeployment frameworkDeployment = new FrameworkDeployment();
            string frameworkDeploymentId = "";
            // Make the request
            Operation<FrameworkDeployment, OperationMetadata> response = await deploymentClient.CreateFrameworkDeploymentAsync(parent, frameworkDeployment, frameworkDeploymentId);

            // Poll until the returned long-running operation is complete
            Operation<FrameworkDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FrameworkDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FrameworkDeployment, OperationMetadata> retrievedResponse = await deploymentClient.PollOnceCreateFrameworkDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FrameworkDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFrameworkDeployment</summary>
        public void DeleteFrameworkDeploymentRequestObject()
        {
            // Snippet: DeleteFrameworkDeployment(DeleteFrameworkDeploymentRequest, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            DeleteFrameworkDeploymentRequest request = new DeleteFrameworkDeploymentRequest
            {
                FrameworkDeploymentName = FrameworkDeploymentName.FromOrganizationLocationFrameworkDeployment("[ORGANIZATION]", "[LOCATION]", "[FRAMEWORK_DEPLOYMENT]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = deploymentClient.DeleteFrameworkDeployment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = deploymentClient.PollOnceDeleteFrameworkDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFrameworkDeploymentAsync</summary>
        public async Task DeleteFrameworkDeploymentRequestObjectAsync()
        {
            // Snippet: DeleteFrameworkDeploymentAsync(DeleteFrameworkDeploymentRequest, CallSettings)
            // Additional: DeleteFrameworkDeploymentAsync(DeleteFrameworkDeploymentRequest, CancellationToken)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFrameworkDeploymentRequest request = new DeleteFrameworkDeploymentRequest
            {
                FrameworkDeploymentName = FrameworkDeploymentName.FromOrganizationLocationFrameworkDeployment("[ORGANIZATION]", "[LOCATION]", "[FRAMEWORK_DEPLOYMENT]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await deploymentClient.DeleteFrameworkDeploymentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await deploymentClient.PollOnceDeleteFrameworkDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFrameworkDeployment</summary>
        public void DeleteFrameworkDeployment()
        {
            // Snippet: DeleteFrameworkDeployment(string, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/frameworkDeployments/[FRAMEWORK_DEPLOYMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = deploymentClient.DeleteFrameworkDeployment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = deploymentClient.PollOnceDeleteFrameworkDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFrameworkDeploymentAsync</summary>
        public async Task DeleteFrameworkDeploymentAsync()
        {
            // Snippet: DeleteFrameworkDeploymentAsync(string, CallSettings)
            // Additional: DeleteFrameworkDeploymentAsync(string, CancellationToken)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/frameworkDeployments/[FRAMEWORK_DEPLOYMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await deploymentClient.DeleteFrameworkDeploymentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await deploymentClient.PollOnceDeleteFrameworkDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFrameworkDeployment</summary>
        public void DeleteFrameworkDeploymentResourceNames()
        {
            // Snippet: DeleteFrameworkDeployment(FrameworkDeploymentName, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            FrameworkDeploymentName name = FrameworkDeploymentName.FromOrganizationLocationFrameworkDeployment("[ORGANIZATION]", "[LOCATION]", "[FRAMEWORK_DEPLOYMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = deploymentClient.DeleteFrameworkDeployment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = deploymentClient.PollOnceDeleteFrameworkDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFrameworkDeploymentAsync</summary>
        public async Task DeleteFrameworkDeploymentResourceNamesAsync()
        {
            // Snippet: DeleteFrameworkDeploymentAsync(FrameworkDeploymentName, CallSettings)
            // Additional: DeleteFrameworkDeploymentAsync(FrameworkDeploymentName, CancellationToken)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            FrameworkDeploymentName name = FrameworkDeploymentName.FromOrganizationLocationFrameworkDeployment("[ORGANIZATION]", "[LOCATION]", "[FRAMEWORK_DEPLOYMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await deploymentClient.DeleteFrameworkDeploymentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await deploymentClient.PollOnceDeleteFrameworkDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetFrameworkDeployment</summary>
        public void GetFrameworkDeploymentRequestObject()
        {
            // Snippet: GetFrameworkDeployment(GetFrameworkDeploymentRequest, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            GetFrameworkDeploymentRequest request = new GetFrameworkDeploymentRequest
            {
                FrameworkDeploymentName = FrameworkDeploymentName.FromOrganizationLocationFrameworkDeployment("[ORGANIZATION]", "[LOCATION]", "[FRAMEWORK_DEPLOYMENT]"),
            };
            // Make the request
            FrameworkDeployment response = deploymentClient.GetFrameworkDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetFrameworkDeploymentAsync</summary>
        public async Task GetFrameworkDeploymentRequestObjectAsync()
        {
            // Snippet: GetFrameworkDeploymentAsync(GetFrameworkDeploymentRequest, CallSettings)
            // Additional: GetFrameworkDeploymentAsync(GetFrameworkDeploymentRequest, CancellationToken)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            GetFrameworkDeploymentRequest request = new GetFrameworkDeploymentRequest
            {
                FrameworkDeploymentName = FrameworkDeploymentName.FromOrganizationLocationFrameworkDeployment("[ORGANIZATION]", "[LOCATION]", "[FRAMEWORK_DEPLOYMENT]"),
            };
            // Make the request
            FrameworkDeployment response = await deploymentClient.GetFrameworkDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFrameworkDeployment</summary>
        public void GetFrameworkDeployment()
        {
            // Snippet: GetFrameworkDeployment(string, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/frameworkDeployments/[FRAMEWORK_DEPLOYMENT]";
            // Make the request
            FrameworkDeployment response = deploymentClient.GetFrameworkDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetFrameworkDeploymentAsync</summary>
        public async Task GetFrameworkDeploymentAsync()
        {
            // Snippet: GetFrameworkDeploymentAsync(string, CallSettings)
            // Additional: GetFrameworkDeploymentAsync(string, CancellationToken)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/frameworkDeployments/[FRAMEWORK_DEPLOYMENT]";
            // Make the request
            FrameworkDeployment response = await deploymentClient.GetFrameworkDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFrameworkDeployment</summary>
        public void GetFrameworkDeploymentResourceNames()
        {
            // Snippet: GetFrameworkDeployment(FrameworkDeploymentName, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            FrameworkDeploymentName name = FrameworkDeploymentName.FromOrganizationLocationFrameworkDeployment("[ORGANIZATION]", "[LOCATION]", "[FRAMEWORK_DEPLOYMENT]");
            // Make the request
            FrameworkDeployment response = deploymentClient.GetFrameworkDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetFrameworkDeploymentAsync</summary>
        public async Task GetFrameworkDeploymentResourceNamesAsync()
        {
            // Snippet: GetFrameworkDeploymentAsync(FrameworkDeploymentName, CallSettings)
            // Additional: GetFrameworkDeploymentAsync(FrameworkDeploymentName, CancellationToken)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            FrameworkDeploymentName name = FrameworkDeploymentName.FromOrganizationLocationFrameworkDeployment("[ORGANIZATION]", "[LOCATION]", "[FRAMEWORK_DEPLOYMENT]");
            // Make the request
            FrameworkDeployment response = await deploymentClient.GetFrameworkDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkDeployments</summary>
        public void ListFrameworkDeploymentsRequestObject()
        {
            // Snippet: ListFrameworkDeployments(ListFrameworkDeploymentsRequest, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            ListFrameworkDeploymentsRequest request = new ListFrameworkDeploymentsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListFrameworkDeploymentsResponse, FrameworkDeployment> response = deploymentClient.ListFrameworkDeployments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FrameworkDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFrameworkDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkDeploymentsAsync</summary>
        public async Task ListFrameworkDeploymentsRequestObjectAsync()
        {
            // Snippet: ListFrameworkDeploymentsAsync(ListFrameworkDeploymentsRequest, CallSettings)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            ListFrameworkDeploymentsRequest request = new ListFrameworkDeploymentsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFrameworkDeploymentsResponse, FrameworkDeployment> response = deploymentClient.ListFrameworkDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FrameworkDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFrameworkDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkDeployments</summary>
        public void ListFrameworkDeployments()
        {
            // Snippet: ListFrameworkDeployments(string, string, int?, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFrameworkDeploymentsResponse, FrameworkDeployment> response = deploymentClient.ListFrameworkDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FrameworkDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFrameworkDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkDeploymentsAsync</summary>
        public async Task ListFrameworkDeploymentsAsync()
        {
            // Snippet: ListFrameworkDeploymentsAsync(string, string, int?, CallSettings)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFrameworkDeploymentsResponse, FrameworkDeployment> response = deploymentClient.ListFrameworkDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FrameworkDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFrameworkDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkDeployments</summary>
        public void ListFrameworkDeploymentsResourceNames()
        {
            // Snippet: ListFrameworkDeployments(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFrameworkDeploymentsResponse, FrameworkDeployment> response = deploymentClient.ListFrameworkDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FrameworkDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFrameworkDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkDeploymentsAsync</summary>
        public async Task ListFrameworkDeploymentsResourceNamesAsync()
        {
            // Snippet: ListFrameworkDeploymentsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFrameworkDeploymentsResponse, FrameworkDeployment> response = deploymentClient.ListFrameworkDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FrameworkDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFrameworkDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCloudControlDeployment</summary>
        public void GetCloudControlDeploymentRequestObject()
        {
            // Snippet: GetCloudControlDeployment(GetCloudControlDeploymentRequest, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            GetCloudControlDeploymentRequest request = new GetCloudControlDeploymentRequest
            {
                CloudControlDeploymentName = CloudControlDeploymentName.FromOrganizationLocationCloudControlDeployment("[ORGANIZATION]", "[LOCATION]", "[CLOUD_CONTROL_DEPLOYMENT]"),
            };
            // Make the request
            CloudControlDeployment response = deploymentClient.GetCloudControlDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetCloudControlDeploymentAsync</summary>
        public async Task GetCloudControlDeploymentRequestObjectAsync()
        {
            // Snippet: GetCloudControlDeploymentAsync(GetCloudControlDeploymentRequest, CallSettings)
            // Additional: GetCloudControlDeploymentAsync(GetCloudControlDeploymentRequest, CancellationToken)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            GetCloudControlDeploymentRequest request = new GetCloudControlDeploymentRequest
            {
                CloudControlDeploymentName = CloudControlDeploymentName.FromOrganizationLocationCloudControlDeployment("[ORGANIZATION]", "[LOCATION]", "[CLOUD_CONTROL_DEPLOYMENT]"),
            };
            // Make the request
            CloudControlDeployment response = await deploymentClient.GetCloudControlDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCloudControlDeployment</summary>
        public void GetCloudControlDeployment()
        {
            // Snippet: GetCloudControlDeployment(string, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/cloudControlDeployments/[CLOUD_CONTROL_DEPLOYMENT]";
            // Make the request
            CloudControlDeployment response = deploymentClient.GetCloudControlDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloudControlDeploymentAsync</summary>
        public async Task GetCloudControlDeploymentAsync()
        {
            // Snippet: GetCloudControlDeploymentAsync(string, CallSettings)
            // Additional: GetCloudControlDeploymentAsync(string, CancellationToken)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/cloudControlDeployments/[CLOUD_CONTROL_DEPLOYMENT]";
            // Make the request
            CloudControlDeployment response = await deploymentClient.GetCloudControlDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloudControlDeployment</summary>
        public void GetCloudControlDeploymentResourceNames()
        {
            // Snippet: GetCloudControlDeployment(CloudControlDeploymentName, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            CloudControlDeploymentName name = CloudControlDeploymentName.FromOrganizationLocationCloudControlDeployment("[ORGANIZATION]", "[LOCATION]", "[CLOUD_CONTROL_DEPLOYMENT]");
            // Make the request
            CloudControlDeployment response = deploymentClient.GetCloudControlDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloudControlDeploymentAsync</summary>
        public async Task GetCloudControlDeploymentResourceNamesAsync()
        {
            // Snippet: GetCloudControlDeploymentAsync(CloudControlDeploymentName, CallSettings)
            // Additional: GetCloudControlDeploymentAsync(CloudControlDeploymentName, CancellationToken)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            CloudControlDeploymentName name = CloudControlDeploymentName.FromOrganizationLocationCloudControlDeployment("[ORGANIZATION]", "[LOCATION]", "[CLOUD_CONTROL_DEPLOYMENT]");
            // Make the request
            CloudControlDeployment response = await deploymentClient.GetCloudControlDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCloudControlDeployments</summary>
        public void ListCloudControlDeploymentsRequestObject()
        {
            // Snippet: ListCloudControlDeployments(ListCloudControlDeploymentsRequest, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            ListCloudControlDeploymentsRequest request = new ListCloudControlDeploymentsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCloudControlDeploymentsResponse, CloudControlDeployment> response = deploymentClient.ListCloudControlDeployments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudControlDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloudControlDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudControlDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudControlDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudControlDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudControlDeploymentsAsync</summary>
        public async Task ListCloudControlDeploymentsRequestObjectAsync()
        {
            // Snippet: ListCloudControlDeploymentsAsync(ListCloudControlDeploymentsRequest, CallSettings)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            ListCloudControlDeploymentsRequest request = new ListCloudControlDeploymentsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCloudControlDeploymentsResponse, CloudControlDeployment> response = deploymentClient.ListCloudControlDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudControlDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloudControlDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudControlDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudControlDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudControlDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudControlDeployments</summary>
        public void ListCloudControlDeployments()
        {
            // Snippet: ListCloudControlDeployments(string, string, int?, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCloudControlDeploymentsResponse, CloudControlDeployment> response = deploymentClient.ListCloudControlDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudControlDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloudControlDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudControlDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudControlDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudControlDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudControlDeploymentsAsync</summary>
        public async Task ListCloudControlDeploymentsAsync()
        {
            // Snippet: ListCloudControlDeploymentsAsync(string, string, int?, CallSettings)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCloudControlDeploymentsResponse, CloudControlDeployment> response = deploymentClient.ListCloudControlDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudControlDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloudControlDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudControlDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudControlDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudControlDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudControlDeployments</summary>
        public void ListCloudControlDeploymentsResourceNames()
        {
            // Snippet: ListCloudControlDeployments(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DeploymentClient deploymentClient = DeploymentClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCloudControlDeploymentsResponse, CloudControlDeployment> response = deploymentClient.ListCloudControlDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudControlDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloudControlDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudControlDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudControlDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudControlDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudControlDeploymentsAsync</summary>
        public async Task ListCloudControlDeploymentsResourceNamesAsync()
        {
            // Snippet: ListCloudControlDeploymentsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DeploymentClient deploymentClient = await DeploymentClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCloudControlDeploymentsResponse, CloudControlDeployment> response = deploymentClient.ListCloudControlDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudControlDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloudControlDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudControlDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudControlDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudControlDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
