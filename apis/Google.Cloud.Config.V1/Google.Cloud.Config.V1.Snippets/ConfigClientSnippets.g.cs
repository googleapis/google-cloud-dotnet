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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Config.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedConfigClientSnippets
    {
        /// <summary>Snippet for ListDeployments</summary>
        public void ListDeploymentsRequestObject()
        {
            // Snippet: ListDeployments(ListDeploymentsRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDeploymentsResponse, Deployment> response = configClient.ListDeployments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentsAsync</summary>
        public async Task ListDeploymentsRequestObjectAsync()
        {
            // Snippet: ListDeploymentsAsync(ListDeploymentsRequest, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> response = configClient.ListDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeployments</summary>
        public void ListDeployments()
        {
            // Snippet: ListDeployments(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDeploymentsResponse, Deployment> response = configClient.ListDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentsAsync</summary>
        public async Task ListDeploymentsAsync()
        {
            // Snippet: ListDeploymentsAsync(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> response = configClient.ListDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeployments</summary>
        public void ListDeploymentsResourceNames()
        {
            // Snippet: ListDeployments(LocationName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDeploymentsResponse, Deployment> response = configClient.ListDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentsAsync</summary>
        public async Task ListDeploymentsResourceNamesAsync()
        {
            // Snippet: ListDeploymentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> response = configClient.ListDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeploymentRequestObject()
        {
            // Snippet: GetDeployment(GetDeploymentRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            // Make the request
            Deployment response = configClient.GetDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentRequestObjectAsync()
        {
            // Snippet: GetDeploymentAsync(GetDeploymentRequest, CallSettings)
            // Additional: GetDeploymentAsync(GetDeploymentRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            // Make the request
            Deployment response = await configClient.GetDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeployment()
        {
            // Snippet: GetDeployment(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            // Make the request
            Deployment response = configClient.GetDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentAsync()
        {
            // Snippet: GetDeploymentAsync(string, CallSettings)
            // Additional: GetDeploymentAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            // Make the request
            Deployment response = await configClient.GetDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeploymentResourceNames()
        {
            // Snippet: GetDeployment(DeploymentName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            Deployment response = configClient.GetDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentResourceNamesAsync()
        {
            // Snippet: GetDeploymentAsync(DeploymentName, CallSettings)
            // Additional: GetDeploymentAsync(DeploymentName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            Deployment response = await configClient.GetDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeploymentRequestObject()
        {
            // Snippet: CreateDeployment(CreateDeploymentRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            CreateDeploymentRequest request = new CreateDeploymentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeploymentId = "",
                Deployment = new Deployment(),
                RequestId = "",
            };
            // Make the request
            Operation<Deployment, OperationMetadata> response = configClient.CreateDeployment(request);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = configClient.PollOnceCreateDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeploymentRequestObjectAsync()
        {
            // Snippet: CreateDeploymentAsync(CreateDeploymentRequest, CallSettings)
            // Additional: CreateDeploymentAsync(CreateDeploymentRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            CreateDeploymentRequest request = new CreateDeploymentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeploymentId = "",
                Deployment = new Deployment(),
                RequestId = "",
            };
            // Make the request
            Operation<Deployment, OperationMetadata> response = await configClient.CreateDeploymentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = await configClient.PollOnceCreateDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeployment()
        {
            // Snippet: CreateDeployment(string, Deployment, string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Deployment deployment = new Deployment();
            string deploymentId = "";
            // Make the request
            Operation<Deployment, OperationMetadata> response = configClient.CreateDeployment(parent, deployment, deploymentId);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = configClient.PollOnceCreateDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeploymentAsync()
        {
            // Snippet: CreateDeploymentAsync(string, Deployment, string, CallSettings)
            // Additional: CreateDeploymentAsync(string, Deployment, string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Deployment deployment = new Deployment();
            string deploymentId = "";
            // Make the request
            Operation<Deployment, OperationMetadata> response = await configClient.CreateDeploymentAsync(parent, deployment, deploymentId);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = await configClient.PollOnceCreateDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeploymentResourceNames()
        {
            // Snippet: CreateDeployment(LocationName, Deployment, string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Deployment deployment = new Deployment();
            string deploymentId = "";
            // Make the request
            Operation<Deployment, OperationMetadata> response = configClient.CreateDeployment(parent, deployment, deploymentId);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = configClient.PollOnceCreateDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeploymentResourceNamesAsync()
        {
            // Snippet: CreateDeploymentAsync(LocationName, Deployment, string, CallSettings)
            // Additional: CreateDeploymentAsync(LocationName, Deployment, string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Deployment deployment = new Deployment();
            string deploymentId = "";
            // Make the request
            Operation<Deployment, OperationMetadata> response = await configClient.CreateDeploymentAsync(parent, deployment, deploymentId);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = await configClient.PollOnceCreateDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeployment</summary>
        public void UpdateDeploymentRequestObject()
        {
            // Snippet: UpdateDeployment(UpdateDeploymentRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            UpdateDeploymentRequest request = new UpdateDeploymentRequest
            {
                UpdateMask = new FieldMask(),
                Deployment = new Deployment(),
                RequestId = "",
            };
            // Make the request
            Operation<Deployment, OperationMetadata> response = configClient.UpdateDeployment(request);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = configClient.PollOnceUpdateDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeploymentAsync</summary>
        public async Task UpdateDeploymentRequestObjectAsync()
        {
            // Snippet: UpdateDeploymentAsync(UpdateDeploymentRequest, CallSettings)
            // Additional: UpdateDeploymentAsync(UpdateDeploymentRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDeploymentRequest request = new UpdateDeploymentRequest
            {
                UpdateMask = new FieldMask(),
                Deployment = new Deployment(),
                RequestId = "",
            };
            // Make the request
            Operation<Deployment, OperationMetadata> response = await configClient.UpdateDeploymentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = await configClient.PollOnceUpdateDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeployment</summary>
        public void UpdateDeployment()
        {
            // Snippet: UpdateDeployment(Deployment, FieldMask, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            Deployment deployment = new Deployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Deployment, OperationMetadata> response = configClient.UpdateDeployment(deployment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = configClient.PollOnceUpdateDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeploymentAsync</summary>
        public async Task UpdateDeploymentAsync()
        {
            // Snippet: UpdateDeploymentAsync(Deployment, FieldMask, CallSettings)
            // Additional: UpdateDeploymentAsync(Deployment, FieldMask, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            Deployment deployment = new Deployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Deployment, OperationMetadata> response = await configClient.UpdateDeploymentAsync(deployment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = await configClient.PollOnceUpdateDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployment</summary>
        public void DeleteDeploymentRequestObject()
        {
            // Snippet: DeleteDeployment(DeleteDeploymentRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeleteDeploymentRequest request = new DeleteDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                RequestId = "",
                Force = false,
                DeletePolicy = DeleteDeploymentRequest.Types.DeletePolicy.Unspecified,
            };
            // Make the request
            Operation<Deployment, OperationMetadata> response = configClient.DeleteDeployment(request);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = configClient.PollOnceDeleteDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentAsync</summary>
        public async Task DeleteDeploymentRequestObjectAsync()
        {
            // Snippet: DeleteDeploymentAsync(DeleteDeploymentRequest, CallSettings)
            // Additional: DeleteDeploymentAsync(DeleteDeploymentRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDeploymentRequest request = new DeleteDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                RequestId = "",
                Force = false,
                DeletePolicy = DeleteDeploymentRequest.Types.DeletePolicy.Unspecified,
            };
            // Make the request
            Operation<Deployment, OperationMetadata> response = await configClient.DeleteDeploymentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = await configClient.PollOnceDeleteDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployment</summary>
        public void DeleteDeployment()
        {
            // Snippet: DeleteDeployment(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            // Make the request
            Operation<Deployment, OperationMetadata> response = configClient.DeleteDeployment(name);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = configClient.PollOnceDeleteDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentAsync</summary>
        public async Task DeleteDeploymentAsync()
        {
            // Snippet: DeleteDeploymentAsync(string, CallSettings)
            // Additional: DeleteDeploymentAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            // Make the request
            Operation<Deployment, OperationMetadata> response = await configClient.DeleteDeploymentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = await configClient.PollOnceDeleteDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployment</summary>
        public void DeleteDeploymentResourceNames()
        {
            // Snippet: DeleteDeployment(DeploymentName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            Operation<Deployment, OperationMetadata> response = configClient.DeleteDeployment(name);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = configClient.PollOnceDeleteDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentAsync</summary>
        public async Task DeleteDeploymentResourceNamesAsync()
        {
            // Snippet: DeleteDeploymentAsync(DeploymentName, CallSettings)
            // Additional: DeleteDeploymentAsync(DeploymentName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            Operation<Deployment, OperationMetadata> response = await configClient.DeleteDeploymentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = await configClient.PollOnceDeleteDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListRevisions</summary>
        public void ListRevisionsRequestObject()
        {
            // Snippet: ListRevisions(ListRevisionsRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ListRevisionsRequest request = new ListRevisionsRequest
            {
                ParentAsDeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListRevisionsResponse, Revision> response = configClient.ListRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Revision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Revision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Revision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Revision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRevisionsAsync</summary>
        public async Task ListRevisionsRequestObjectAsync()
        {
            // Snippet: ListRevisionsAsync(ListRevisionsRequest, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ListRevisionsRequest request = new ListRevisionsRequest
            {
                ParentAsDeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRevisionsResponse, Revision> response = configClient.ListRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Revision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Revision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Revision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Revision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRevisions</summary>
        public void ListRevisions()
        {
            // Snippet: ListRevisions(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            // Make the request
            PagedEnumerable<ListRevisionsResponse, Revision> response = configClient.ListRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Revision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Revision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Revision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Revision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRevisionsAsync</summary>
        public async Task ListRevisionsAsync()
        {
            // Snippet: ListRevisionsAsync(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            // Make the request
            PagedAsyncEnumerable<ListRevisionsResponse, Revision> response = configClient.ListRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Revision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Revision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Revision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Revision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRevisions</summary>
        public void ListRevisionsResourceNames()
        {
            // Snippet: ListRevisions(DeploymentName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeploymentName parent = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            PagedEnumerable<ListRevisionsResponse, Revision> response = configClient.ListRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Revision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Revision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Revision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Revision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRevisionsAsync</summary>
        public async Task ListRevisionsResourceNamesAsync()
        {
            // Snippet: ListRevisionsAsync(DeploymentName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName parent = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            PagedAsyncEnumerable<ListRevisionsResponse, Revision> response = configClient.ListRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Revision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Revision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Revision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Revision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRevision</summary>
        public void GetRevisionRequestObject()
        {
            // Snippet: GetRevision(GetRevisionRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            GetRevisionRequest request = new GetRevisionRequest
            {
                RevisionName = RevisionName.FromProjectLocationDeploymentRevision("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[REVISION]"),
            };
            // Make the request
            Revision response = configClient.GetRevision(request);
            // End snippet
        }

        /// <summary>Snippet for GetRevisionAsync</summary>
        public async Task GetRevisionRequestObjectAsync()
        {
            // Snippet: GetRevisionAsync(GetRevisionRequest, CallSettings)
            // Additional: GetRevisionAsync(GetRevisionRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            GetRevisionRequest request = new GetRevisionRequest
            {
                RevisionName = RevisionName.FromProjectLocationDeploymentRevision("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[REVISION]"),
            };
            // Make the request
            Revision response = await configClient.GetRevisionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRevision</summary>
        public void GetRevision()
        {
            // Snippet: GetRevision(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]/revisions/[REVISION]";
            // Make the request
            Revision response = configClient.GetRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetRevisionAsync</summary>
        public async Task GetRevisionAsync()
        {
            // Snippet: GetRevisionAsync(string, CallSettings)
            // Additional: GetRevisionAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]/revisions/[REVISION]";
            // Make the request
            Revision response = await configClient.GetRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRevision</summary>
        public void GetRevisionResourceNames()
        {
            // Snippet: GetRevision(RevisionName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            RevisionName name = RevisionName.FromProjectLocationDeploymentRevision("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[REVISION]");
            // Make the request
            Revision response = configClient.GetRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetRevisionAsync</summary>
        public async Task GetRevisionResourceNamesAsync()
        {
            // Snippet: GetRevisionAsync(RevisionName, CallSettings)
            // Additional: GetRevisionAsync(RevisionName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            RevisionName name = RevisionName.FromProjectLocationDeploymentRevision("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[REVISION]");
            // Make the request
            Revision response = await configClient.GetRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetResource</summary>
        public void GetResourceRequestObject()
        {
            // Snippet: GetResource(GetResourceRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            GetResourceRequest request = new GetResourceRequest
            {
                ResourceName = ResourceName.FromProjectLocationDeploymentRevisionResource("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[REVISION]", "[RESOURCE]"),
            };
            // Make the request
            Resource response = configClient.GetResource(request);
            // End snippet
        }

        /// <summary>Snippet for GetResourceAsync</summary>
        public async Task GetResourceRequestObjectAsync()
        {
            // Snippet: GetResourceAsync(GetResourceRequest, CallSettings)
            // Additional: GetResourceAsync(GetResourceRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            GetResourceRequest request = new GetResourceRequest
            {
                ResourceName = ResourceName.FromProjectLocationDeploymentRevisionResource("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[REVISION]", "[RESOURCE]"),
            };
            // Make the request
            Resource response = await configClient.GetResourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetResource</summary>
        public void GetResource()
        {
            // Snippet: GetResource(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]/revisions/[REVISION]/resources/[RESOURCE]";
            // Make the request
            Resource response = configClient.GetResource(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceAsync</summary>
        public async Task GetResourceAsync()
        {
            // Snippet: GetResourceAsync(string, CallSettings)
            // Additional: GetResourceAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]/revisions/[REVISION]/resources/[RESOURCE]";
            // Make the request
            Resource response = await configClient.GetResourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetResource</summary>
        public void GetResourceResourceNames()
        {
            // Snippet: GetResource(ResourceName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ResourceName name = ResourceName.FromProjectLocationDeploymentRevisionResource("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[REVISION]", "[RESOURCE]");
            // Make the request
            Resource response = configClient.GetResource(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceAsync</summary>
        public async Task GetResourceResourceNamesAsync()
        {
            // Snippet: GetResourceAsync(ResourceName, CallSettings)
            // Additional: GetResourceAsync(ResourceName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ResourceName name = ResourceName.FromProjectLocationDeploymentRevisionResource("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[REVISION]", "[RESOURCE]");
            // Make the request
            Resource response = await configClient.GetResourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListResources</summary>
        public void ListResourcesRequestObject()
        {
            // Snippet: ListResources(ListResourcesRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ListResourcesRequest request = new ListResourcesRequest
            {
                ParentAsRevisionName = RevisionName.FromProjectLocationDeploymentRevision("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[REVISION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListResourcesResponse, Resource> response = configClient.ListResources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Resource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Resource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Resource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Resource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourcesAsync</summary>
        public async Task ListResourcesRequestObjectAsync()
        {
            // Snippet: ListResourcesAsync(ListResourcesRequest, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ListResourcesRequest request = new ListResourcesRequest
            {
                ParentAsRevisionName = RevisionName.FromProjectLocationDeploymentRevision("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[REVISION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListResourcesResponse, Resource> response = configClient.ListResourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Resource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Resource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Resource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Resource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResources</summary>
        public void ListResources()
        {
            // Snippet: ListResources(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]/revisions/[REVISION]";
            // Make the request
            PagedEnumerable<ListResourcesResponse, Resource> response = configClient.ListResources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Resource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Resource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Resource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Resource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourcesAsync</summary>
        public async Task ListResourcesAsync()
        {
            // Snippet: ListResourcesAsync(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]/revisions/[REVISION]";
            // Make the request
            PagedAsyncEnumerable<ListResourcesResponse, Resource> response = configClient.ListResourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Resource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Resource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Resource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Resource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResources</summary>
        public void ListResourcesResourceNames()
        {
            // Snippet: ListResources(RevisionName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            RevisionName parent = RevisionName.FromProjectLocationDeploymentRevision("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[REVISION]");
            // Make the request
            PagedEnumerable<ListResourcesResponse, Resource> response = configClient.ListResources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Resource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Resource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Resource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Resource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourcesAsync</summary>
        public async Task ListResourcesResourceNamesAsync()
        {
            // Snippet: ListResourcesAsync(RevisionName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            RevisionName parent = RevisionName.FromProjectLocationDeploymentRevision("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[REVISION]");
            // Make the request
            PagedAsyncEnumerable<ListResourcesResponse, Resource> response = configClient.ListResourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Resource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Resource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Resource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Resource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ExportDeploymentStatefile</summary>
        public void ExportDeploymentStatefileRequestObject()
        {
            // Snippet: ExportDeploymentStatefile(ExportDeploymentStatefileRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ExportDeploymentStatefileRequest request = new ExportDeploymentStatefileRequest
            {
                ParentAsDeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                Draft = false,
            };
            // Make the request
            Statefile response = configClient.ExportDeploymentStatefile(request);
            // End snippet
        }

        /// <summary>Snippet for ExportDeploymentStatefileAsync</summary>
        public async Task ExportDeploymentStatefileRequestObjectAsync()
        {
            // Snippet: ExportDeploymentStatefileAsync(ExportDeploymentStatefileRequest, CallSettings)
            // Additional: ExportDeploymentStatefileAsync(ExportDeploymentStatefileRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ExportDeploymentStatefileRequest request = new ExportDeploymentStatefileRequest
            {
                ParentAsDeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                Draft = false,
            };
            // Make the request
            Statefile response = await configClient.ExportDeploymentStatefileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ExportRevisionStatefile</summary>
        public void ExportRevisionStatefileRequestObject()
        {
            // Snippet: ExportRevisionStatefile(ExportRevisionStatefileRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ExportRevisionStatefileRequest request = new ExportRevisionStatefileRequest
            {
                ParentAsRevisionName = RevisionName.FromProjectLocationDeploymentRevision("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[REVISION]"),
            };
            // Make the request
            Statefile response = configClient.ExportRevisionStatefile(request);
            // End snippet
        }

        /// <summary>Snippet for ExportRevisionStatefileAsync</summary>
        public async Task ExportRevisionStatefileRequestObjectAsync()
        {
            // Snippet: ExportRevisionStatefileAsync(ExportRevisionStatefileRequest, CallSettings)
            // Additional: ExportRevisionStatefileAsync(ExportRevisionStatefileRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ExportRevisionStatefileRequest request = new ExportRevisionStatefileRequest
            {
                ParentAsRevisionName = RevisionName.FromProjectLocationDeploymentRevision("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[REVISION]"),
            };
            // Make the request
            Statefile response = await configClient.ExportRevisionStatefileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportStatefile</summary>
        public void ImportStatefileRequestObject()
        {
            // Snippet: ImportStatefile(ImportStatefileRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ImportStatefileRequest request = new ImportStatefileRequest
            {
                ParentAsDeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                LockId = 0L,
                SkipDraft = false,
            };
            // Make the request
            Statefile response = configClient.ImportStatefile(request);
            // End snippet
        }

        /// <summary>Snippet for ImportStatefileAsync</summary>
        public async Task ImportStatefileRequestObjectAsync()
        {
            // Snippet: ImportStatefileAsync(ImportStatefileRequest, CallSettings)
            // Additional: ImportStatefileAsync(ImportStatefileRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ImportStatefileRequest request = new ImportStatefileRequest
            {
                ParentAsDeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                LockId = 0L,
                SkipDraft = false,
            };
            // Make the request
            Statefile response = await configClient.ImportStatefileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportStatefile</summary>
        public void ImportStatefile()
        {
            // Snippet: ImportStatefile(string, long, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            long lockId = 0L;
            // Make the request
            Statefile response = configClient.ImportStatefile(parent, lockId);
            // End snippet
        }

        /// <summary>Snippet for ImportStatefileAsync</summary>
        public async Task ImportStatefileAsync()
        {
            // Snippet: ImportStatefileAsync(string, long, CallSettings)
            // Additional: ImportStatefileAsync(string, long, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            long lockId = 0L;
            // Make the request
            Statefile response = await configClient.ImportStatefileAsync(parent, lockId);
            // End snippet
        }

        /// <summary>Snippet for ImportStatefile</summary>
        public void ImportStatefileResourceNames()
        {
            // Snippet: ImportStatefile(DeploymentName, long, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeploymentName parent = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            long lockId = 0L;
            // Make the request
            Statefile response = configClient.ImportStatefile(parent, lockId);
            // End snippet
        }

        /// <summary>Snippet for ImportStatefileAsync</summary>
        public async Task ImportStatefileResourceNamesAsync()
        {
            // Snippet: ImportStatefileAsync(DeploymentName, long, CallSettings)
            // Additional: ImportStatefileAsync(DeploymentName, long, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName parent = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            long lockId = 0L;
            // Make the request
            Statefile response = await configClient.ImportStatefileAsync(parent, lockId);
            // End snippet
        }

        /// <summary>Snippet for DeleteStatefile</summary>
        public void DeleteStatefileRequestObject()
        {
            // Snippet: DeleteStatefile(DeleteStatefileRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeleteStatefileRequest request = new DeleteStatefileRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                LockId = 0L,
            };
            // Make the request
            configClient.DeleteStatefile(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteStatefileAsync</summary>
        public async Task DeleteStatefileRequestObjectAsync()
        {
            // Snippet: DeleteStatefileAsync(DeleteStatefileRequest, CallSettings)
            // Additional: DeleteStatefileAsync(DeleteStatefileRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeleteStatefileRequest request = new DeleteStatefileRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                LockId = 0L,
            };
            // Make the request
            await configClient.DeleteStatefileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteStatefile</summary>
        public void DeleteStatefile()
        {
            // Snippet: DeleteStatefile(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            // Make the request
            configClient.DeleteStatefile(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteStatefileAsync</summary>
        public async Task DeleteStatefileAsync()
        {
            // Snippet: DeleteStatefileAsync(string, CallSettings)
            // Additional: DeleteStatefileAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            // Make the request
            await configClient.DeleteStatefileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteStatefile</summary>
        public void DeleteStatefileResourceNames()
        {
            // Snippet: DeleteStatefile(DeploymentName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            configClient.DeleteStatefile(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteStatefileAsync</summary>
        public async Task DeleteStatefileResourceNamesAsync()
        {
            // Snippet: DeleteStatefileAsync(DeploymentName, CallSettings)
            // Additional: DeleteStatefileAsync(DeploymentName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            await configClient.DeleteStatefileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for LockDeployment</summary>
        public void LockDeploymentRequestObject()
        {
            // Snippet: LockDeployment(LockDeploymentRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            LockDeploymentRequest request = new LockDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            // Make the request
            Operation<Deployment, OperationMetadata> response = configClient.LockDeployment(request);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = configClient.PollOnceLockDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LockDeploymentAsync</summary>
        public async Task LockDeploymentRequestObjectAsync()
        {
            // Snippet: LockDeploymentAsync(LockDeploymentRequest, CallSettings)
            // Additional: LockDeploymentAsync(LockDeploymentRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            LockDeploymentRequest request = new LockDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            // Make the request
            Operation<Deployment, OperationMetadata> response = await configClient.LockDeploymentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = await configClient.PollOnceLockDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LockDeployment</summary>
        public void LockDeployment()
        {
            // Snippet: LockDeployment(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            // Make the request
            Operation<Deployment, OperationMetadata> response = configClient.LockDeployment(name);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = configClient.PollOnceLockDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LockDeploymentAsync</summary>
        public async Task LockDeploymentAsync()
        {
            // Snippet: LockDeploymentAsync(string, CallSettings)
            // Additional: LockDeploymentAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            // Make the request
            Operation<Deployment, OperationMetadata> response = await configClient.LockDeploymentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = await configClient.PollOnceLockDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LockDeployment</summary>
        public void LockDeploymentResourceNames()
        {
            // Snippet: LockDeployment(DeploymentName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            Operation<Deployment, OperationMetadata> response = configClient.LockDeployment(name);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = configClient.PollOnceLockDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LockDeploymentAsync</summary>
        public async Task LockDeploymentResourceNamesAsync()
        {
            // Snippet: LockDeploymentAsync(DeploymentName, CallSettings)
            // Additional: LockDeploymentAsync(DeploymentName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            Operation<Deployment, OperationMetadata> response = await configClient.LockDeploymentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = await configClient.PollOnceLockDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnlockDeployment</summary>
        public void UnlockDeploymentRequestObject()
        {
            // Snippet: UnlockDeployment(UnlockDeploymentRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            UnlockDeploymentRequest request = new UnlockDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                LockId = 0L,
            };
            // Make the request
            Operation<Deployment, OperationMetadata> response = configClient.UnlockDeployment(request);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = configClient.PollOnceUnlockDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnlockDeploymentAsync</summary>
        public async Task UnlockDeploymentRequestObjectAsync()
        {
            // Snippet: UnlockDeploymentAsync(UnlockDeploymentRequest, CallSettings)
            // Additional: UnlockDeploymentAsync(UnlockDeploymentRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            UnlockDeploymentRequest request = new UnlockDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                LockId = 0L,
            };
            // Make the request
            Operation<Deployment, OperationMetadata> response = await configClient.UnlockDeploymentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = await configClient.PollOnceUnlockDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnlockDeployment</summary>
        public void UnlockDeployment()
        {
            // Snippet: UnlockDeployment(string, long, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            long lockId = 0L;
            // Make the request
            Operation<Deployment, OperationMetadata> response = configClient.UnlockDeployment(name, lockId);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = configClient.PollOnceUnlockDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnlockDeploymentAsync</summary>
        public async Task UnlockDeploymentAsync()
        {
            // Snippet: UnlockDeploymentAsync(string, long, CallSettings)
            // Additional: UnlockDeploymentAsync(string, long, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            long lockId = 0L;
            // Make the request
            Operation<Deployment, OperationMetadata> response = await configClient.UnlockDeploymentAsync(name, lockId);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = await configClient.PollOnceUnlockDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnlockDeployment</summary>
        public void UnlockDeploymentResourceNames()
        {
            // Snippet: UnlockDeployment(DeploymentName, long, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            long lockId = 0L;
            // Make the request
            Operation<Deployment, OperationMetadata> response = configClient.UnlockDeployment(name, lockId);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = configClient.PollOnceUnlockDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnlockDeploymentAsync</summary>
        public async Task UnlockDeploymentResourceNamesAsync()
        {
            // Snippet: UnlockDeploymentAsync(DeploymentName, long, CallSettings)
            // Additional: UnlockDeploymentAsync(DeploymentName, long, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            long lockId = 0L;
            // Make the request
            Operation<Deployment, OperationMetadata> response = await configClient.UnlockDeploymentAsync(name, lockId);

            // Poll until the returned long-running operation is complete
            Operation<Deployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Deployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Deployment, OperationMetadata> retrievedResponse = await configClient.PollOnceUnlockDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Deployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportLockInfo</summary>
        public void ExportLockInfoRequestObject()
        {
            // Snippet: ExportLockInfo(ExportLockInfoRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ExportLockInfoRequest request = new ExportLockInfoRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            // Make the request
            LockInfo response = configClient.ExportLockInfo(request);
            // End snippet
        }

        /// <summary>Snippet for ExportLockInfoAsync</summary>
        public async Task ExportLockInfoRequestObjectAsync()
        {
            // Snippet: ExportLockInfoAsync(ExportLockInfoRequest, CallSettings)
            // Additional: ExportLockInfoAsync(ExportLockInfoRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ExportLockInfoRequest request = new ExportLockInfoRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            // Make the request
            LockInfo response = await configClient.ExportLockInfoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ExportLockInfo</summary>
        public void ExportLockInfo()
        {
            // Snippet: ExportLockInfo(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            // Make the request
            LockInfo response = configClient.ExportLockInfo(name);
            // End snippet
        }

        /// <summary>Snippet for ExportLockInfoAsync</summary>
        public async Task ExportLockInfoAsync()
        {
            // Snippet: ExportLockInfoAsync(string, CallSettings)
            // Additional: ExportLockInfoAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployments/[DEPLOYMENT]";
            // Make the request
            LockInfo response = await configClient.ExportLockInfoAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ExportLockInfo</summary>
        public void ExportLockInfoResourceNames()
        {
            // Snippet: ExportLockInfo(DeploymentName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            LockInfo response = configClient.ExportLockInfo(name);
            // End snippet
        }

        /// <summary>Snippet for ExportLockInfoAsync</summary>
        public async Task ExportLockInfoResourceNamesAsync()
        {
            // Snippet: ExportLockInfoAsync(DeploymentName, CallSettings)
            // Additional: ExportLockInfoAsync(DeploymentName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            LockInfo response = await configClient.ExportLockInfoAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreatePreview</summary>
        public void CreatePreviewRequestObject()
        {
            // Snippet: CreatePreview(CreatePreviewRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            CreatePreviewRequest request = new CreatePreviewRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PreviewId = "",
                Preview = new Preview(),
                RequestId = "",
            };
            // Make the request
            Operation<Preview, OperationMetadata> response = configClient.CreatePreview(request);

            // Poll until the returned long-running operation is complete
            Operation<Preview, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Preview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Preview, OperationMetadata> retrievedResponse = configClient.PollOnceCreatePreview(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Preview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePreviewAsync</summary>
        public async Task CreatePreviewRequestObjectAsync()
        {
            // Snippet: CreatePreviewAsync(CreatePreviewRequest, CallSettings)
            // Additional: CreatePreviewAsync(CreatePreviewRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            CreatePreviewRequest request = new CreatePreviewRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PreviewId = "",
                Preview = new Preview(),
                RequestId = "",
            };
            // Make the request
            Operation<Preview, OperationMetadata> response = await configClient.CreatePreviewAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Preview, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Preview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Preview, OperationMetadata> retrievedResponse = await configClient.PollOnceCreatePreviewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Preview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePreview</summary>
        public void CreatePreview()
        {
            // Snippet: CreatePreview(string, Preview, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Preview preview = new Preview();
            // Make the request
            Operation<Preview, OperationMetadata> response = configClient.CreatePreview(parent, preview);

            // Poll until the returned long-running operation is complete
            Operation<Preview, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Preview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Preview, OperationMetadata> retrievedResponse = configClient.PollOnceCreatePreview(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Preview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePreviewAsync</summary>
        public async Task CreatePreviewAsync()
        {
            // Snippet: CreatePreviewAsync(string, Preview, CallSettings)
            // Additional: CreatePreviewAsync(string, Preview, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Preview preview = new Preview();
            // Make the request
            Operation<Preview, OperationMetadata> response = await configClient.CreatePreviewAsync(parent, preview);

            // Poll until the returned long-running operation is complete
            Operation<Preview, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Preview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Preview, OperationMetadata> retrievedResponse = await configClient.PollOnceCreatePreviewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Preview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePreview</summary>
        public void CreatePreviewResourceNames()
        {
            // Snippet: CreatePreview(LocationName, Preview, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Preview preview = new Preview();
            // Make the request
            Operation<Preview, OperationMetadata> response = configClient.CreatePreview(parent, preview);

            // Poll until the returned long-running operation is complete
            Operation<Preview, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Preview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Preview, OperationMetadata> retrievedResponse = configClient.PollOnceCreatePreview(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Preview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePreviewAsync</summary>
        public async Task CreatePreviewResourceNamesAsync()
        {
            // Snippet: CreatePreviewAsync(LocationName, Preview, CallSettings)
            // Additional: CreatePreviewAsync(LocationName, Preview, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Preview preview = new Preview();
            // Make the request
            Operation<Preview, OperationMetadata> response = await configClient.CreatePreviewAsync(parent, preview);

            // Poll until the returned long-running operation is complete
            Operation<Preview, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Preview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Preview, OperationMetadata> retrievedResponse = await configClient.PollOnceCreatePreviewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Preview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetPreview</summary>
        public void GetPreviewRequestObject()
        {
            // Snippet: GetPreview(GetPreviewRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            GetPreviewRequest request = new GetPreviewRequest
            {
                PreviewName = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]"),
            };
            // Make the request
            Preview response = configClient.GetPreview(request);
            // End snippet
        }

        /// <summary>Snippet for GetPreviewAsync</summary>
        public async Task GetPreviewRequestObjectAsync()
        {
            // Snippet: GetPreviewAsync(GetPreviewRequest, CallSettings)
            // Additional: GetPreviewAsync(GetPreviewRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            GetPreviewRequest request = new GetPreviewRequest
            {
                PreviewName = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]"),
            };
            // Make the request
            Preview response = await configClient.GetPreviewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPreview</summary>
        public void GetPreview()
        {
            // Snippet: GetPreview(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/previews/[PREVIEW]";
            // Make the request
            Preview response = configClient.GetPreview(name);
            // End snippet
        }

        /// <summary>Snippet for GetPreviewAsync</summary>
        public async Task GetPreviewAsync()
        {
            // Snippet: GetPreviewAsync(string, CallSettings)
            // Additional: GetPreviewAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/previews/[PREVIEW]";
            // Make the request
            Preview response = await configClient.GetPreviewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPreview</summary>
        public void GetPreviewResourceNames()
        {
            // Snippet: GetPreview(PreviewName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            PreviewName name = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]");
            // Make the request
            Preview response = configClient.GetPreview(name);
            // End snippet
        }

        /// <summary>Snippet for GetPreviewAsync</summary>
        public async Task GetPreviewResourceNamesAsync()
        {
            // Snippet: GetPreviewAsync(PreviewName, CallSettings)
            // Additional: GetPreviewAsync(PreviewName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            PreviewName name = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]");
            // Make the request
            Preview response = await configClient.GetPreviewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPreviews</summary>
        public void ListPreviewsRequestObject()
        {
            // Snippet: ListPreviews(ListPreviewsRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ListPreviewsRequest request = new ListPreviewsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListPreviewsResponse, Preview> response = configClient.ListPreviews(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Preview item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPreviewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Preview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Preview> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Preview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPreviewsAsync</summary>
        public async Task ListPreviewsRequestObjectAsync()
        {
            // Snippet: ListPreviewsAsync(ListPreviewsRequest, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ListPreviewsRequest request = new ListPreviewsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPreviewsResponse, Preview> response = configClient.ListPreviewsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Preview item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPreviewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Preview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Preview> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Preview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPreviews</summary>
        public void ListPreviews()
        {
            // Snippet: ListPreviews(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPreviewsResponse, Preview> response = configClient.ListPreviews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Preview item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPreviewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Preview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Preview> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Preview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPreviewsAsync</summary>
        public async Task ListPreviewsAsync()
        {
            // Snippet: ListPreviewsAsync(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPreviewsResponse, Preview> response = configClient.ListPreviewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Preview item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPreviewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Preview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Preview> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Preview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPreviews</summary>
        public void ListPreviewsResourceNames()
        {
            // Snippet: ListPreviews(LocationName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPreviewsResponse, Preview> response = configClient.ListPreviews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Preview item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPreviewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Preview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Preview> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Preview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPreviewsAsync</summary>
        public async Task ListPreviewsResourceNamesAsync()
        {
            // Snippet: ListPreviewsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPreviewsResponse, Preview> response = configClient.ListPreviewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Preview item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPreviewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Preview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Preview> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Preview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeletePreview</summary>
        public void DeletePreviewRequestObject()
        {
            // Snippet: DeletePreview(DeletePreviewRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeletePreviewRequest request = new DeletePreviewRequest
            {
                PreviewName = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]"),
                RequestId = "",
            };
            // Make the request
            Operation<Preview, OperationMetadata> response = configClient.DeletePreview(request);

            // Poll until the returned long-running operation is complete
            Operation<Preview, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Preview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Preview, OperationMetadata> retrievedResponse = configClient.PollOnceDeletePreview(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Preview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePreviewAsync</summary>
        public async Task DeletePreviewRequestObjectAsync()
        {
            // Snippet: DeletePreviewAsync(DeletePreviewRequest, CallSettings)
            // Additional: DeletePreviewAsync(DeletePreviewRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeletePreviewRequest request = new DeletePreviewRequest
            {
                PreviewName = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]"),
                RequestId = "",
            };
            // Make the request
            Operation<Preview, OperationMetadata> response = await configClient.DeletePreviewAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Preview, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Preview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Preview, OperationMetadata> retrievedResponse = await configClient.PollOnceDeletePreviewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Preview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePreview</summary>
        public void DeletePreview()
        {
            // Snippet: DeletePreview(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/previews/[PREVIEW]";
            // Make the request
            Operation<Preview, OperationMetadata> response = configClient.DeletePreview(name);

            // Poll until the returned long-running operation is complete
            Operation<Preview, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Preview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Preview, OperationMetadata> retrievedResponse = configClient.PollOnceDeletePreview(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Preview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePreviewAsync</summary>
        public async Task DeletePreviewAsync()
        {
            // Snippet: DeletePreviewAsync(string, CallSettings)
            // Additional: DeletePreviewAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/previews/[PREVIEW]";
            // Make the request
            Operation<Preview, OperationMetadata> response = await configClient.DeletePreviewAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Preview, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Preview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Preview, OperationMetadata> retrievedResponse = await configClient.PollOnceDeletePreviewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Preview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePreview</summary>
        public void DeletePreviewResourceNames()
        {
            // Snippet: DeletePreview(PreviewName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            PreviewName name = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]");
            // Make the request
            Operation<Preview, OperationMetadata> response = configClient.DeletePreview(name);

            // Poll until the returned long-running operation is complete
            Operation<Preview, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Preview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Preview, OperationMetadata> retrievedResponse = configClient.PollOnceDeletePreview(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Preview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePreviewAsync</summary>
        public async Task DeletePreviewResourceNamesAsync()
        {
            // Snippet: DeletePreviewAsync(PreviewName, CallSettings)
            // Additional: DeletePreviewAsync(PreviewName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            PreviewName name = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]");
            // Make the request
            Operation<Preview, OperationMetadata> response = await configClient.DeletePreviewAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Preview, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Preview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Preview, OperationMetadata> retrievedResponse = await configClient.PollOnceDeletePreviewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Preview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportPreviewResult</summary>
        public void ExportPreviewResultRequestObject()
        {
            // Snippet: ExportPreviewResult(ExportPreviewResultRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ExportPreviewResultRequest request = new ExportPreviewResultRequest
            {
                ParentAsPreviewName = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]"),
            };
            // Make the request
            ExportPreviewResultResponse response = configClient.ExportPreviewResult(request);
            // End snippet
        }

        /// <summary>Snippet for ExportPreviewResultAsync</summary>
        public async Task ExportPreviewResultRequestObjectAsync()
        {
            // Snippet: ExportPreviewResultAsync(ExportPreviewResultRequest, CallSettings)
            // Additional: ExportPreviewResultAsync(ExportPreviewResultRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ExportPreviewResultRequest request = new ExportPreviewResultRequest
            {
                ParentAsPreviewName = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]"),
            };
            // Make the request
            ExportPreviewResultResponse response = await configClient.ExportPreviewResultAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListTerraformVersions</summary>
        public void ListTerraformVersionsRequestObject()
        {
            // Snippet: ListTerraformVersions(ListTerraformVersionsRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ListTerraformVersionsRequest request = new ListTerraformVersionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListTerraformVersionsResponse, TerraformVersion> response = configClient.ListTerraformVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TerraformVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTerraformVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TerraformVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TerraformVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TerraformVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTerraformVersionsAsync</summary>
        public async Task ListTerraformVersionsRequestObjectAsync()
        {
            // Snippet: ListTerraformVersionsAsync(ListTerraformVersionsRequest, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ListTerraformVersionsRequest request = new ListTerraformVersionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTerraformVersionsResponse, TerraformVersion> response = configClient.ListTerraformVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TerraformVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTerraformVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TerraformVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TerraformVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TerraformVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTerraformVersions</summary>
        public void ListTerraformVersions()
        {
            // Snippet: ListTerraformVersions(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTerraformVersionsResponse, TerraformVersion> response = configClient.ListTerraformVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TerraformVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTerraformVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TerraformVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TerraformVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TerraformVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTerraformVersionsAsync</summary>
        public async Task ListTerraformVersionsAsync()
        {
            // Snippet: ListTerraformVersionsAsync(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTerraformVersionsResponse, TerraformVersion> response = configClient.ListTerraformVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TerraformVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTerraformVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TerraformVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TerraformVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TerraformVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTerraformVersions</summary>
        public void ListTerraformVersionsResourceNames()
        {
            // Snippet: ListTerraformVersions(LocationName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTerraformVersionsResponse, TerraformVersion> response = configClient.ListTerraformVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TerraformVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTerraformVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TerraformVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TerraformVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TerraformVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTerraformVersionsAsync</summary>
        public async Task ListTerraformVersionsResourceNamesAsync()
        {
            // Snippet: ListTerraformVersionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTerraformVersionsResponse, TerraformVersion> response = configClient.ListTerraformVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TerraformVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTerraformVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TerraformVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TerraformVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TerraformVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTerraformVersion</summary>
        public void GetTerraformVersionRequestObject()
        {
            // Snippet: GetTerraformVersion(GetTerraformVersionRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            GetTerraformVersionRequest request = new GetTerraformVersionRequest
            {
                TerraformVersionName = TerraformVersionName.FromProjectLocationTerraformVersion("[PROJECT]", "[LOCATION]", "[TERRAFORM_VERSION]"),
            };
            // Make the request
            TerraformVersion response = configClient.GetTerraformVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetTerraformVersionAsync</summary>
        public async Task GetTerraformVersionRequestObjectAsync()
        {
            // Snippet: GetTerraformVersionAsync(GetTerraformVersionRequest, CallSettings)
            // Additional: GetTerraformVersionAsync(GetTerraformVersionRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            GetTerraformVersionRequest request = new GetTerraformVersionRequest
            {
                TerraformVersionName = TerraformVersionName.FromProjectLocationTerraformVersion("[PROJECT]", "[LOCATION]", "[TERRAFORM_VERSION]"),
            };
            // Make the request
            TerraformVersion response = await configClient.GetTerraformVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTerraformVersion</summary>
        public void GetTerraformVersion()
        {
            // Snippet: GetTerraformVersion(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/terraformVersions/[TERRAFORM_VERSION]";
            // Make the request
            TerraformVersion response = configClient.GetTerraformVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetTerraformVersionAsync</summary>
        public async Task GetTerraformVersionAsync()
        {
            // Snippet: GetTerraformVersionAsync(string, CallSettings)
            // Additional: GetTerraformVersionAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/terraformVersions/[TERRAFORM_VERSION]";
            // Make the request
            TerraformVersion response = await configClient.GetTerraformVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTerraformVersion</summary>
        public void GetTerraformVersionResourceNames()
        {
            // Snippet: GetTerraformVersion(TerraformVersionName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            TerraformVersionName name = TerraformVersionName.FromProjectLocationTerraformVersion("[PROJECT]", "[LOCATION]", "[TERRAFORM_VERSION]");
            // Make the request
            TerraformVersion response = configClient.GetTerraformVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetTerraformVersionAsync</summary>
        public async Task GetTerraformVersionResourceNamesAsync()
        {
            // Snippet: GetTerraformVersionAsync(TerraformVersionName, CallSettings)
            // Additional: GetTerraformVersionAsync(TerraformVersionName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            TerraformVersionName name = TerraformVersionName.FromProjectLocationTerraformVersion("[PROJECT]", "[LOCATION]", "[TERRAFORM_VERSION]");
            // Make the request
            TerraformVersion response = await configClient.GetTerraformVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListResourceChanges</summary>
        public void ListResourceChangesRequestObject()
        {
            // Snippet: ListResourceChanges(ListResourceChangesRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ListResourceChangesRequest request = new ListResourceChangesRequest
            {
                ParentAsPreviewName = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListResourceChangesResponse, ResourceChange> response = configClient.ListResourceChanges(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceChange item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceChangesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceChange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceChange> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceChange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceChangesAsync</summary>
        public async Task ListResourceChangesRequestObjectAsync()
        {
            // Snippet: ListResourceChangesAsync(ListResourceChangesRequest, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ListResourceChangesRequest request = new ListResourceChangesRequest
            {
                ParentAsPreviewName = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListResourceChangesResponse, ResourceChange> response = configClient.ListResourceChangesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ResourceChange item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListResourceChangesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceChange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceChange> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceChange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceChanges</summary>
        public void ListResourceChanges()
        {
            // Snippet: ListResourceChanges(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/previews/[PREVIEW]";
            // Make the request
            PagedEnumerable<ListResourceChangesResponse, ResourceChange> response = configClient.ListResourceChanges(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceChange item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceChangesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceChange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceChange> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceChange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceChangesAsync</summary>
        public async Task ListResourceChangesAsync()
        {
            // Snippet: ListResourceChangesAsync(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/previews/[PREVIEW]";
            // Make the request
            PagedAsyncEnumerable<ListResourceChangesResponse, ResourceChange> response = configClient.ListResourceChangesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ResourceChange item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListResourceChangesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceChange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceChange> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceChange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceChanges</summary>
        public void ListResourceChangesResourceNames()
        {
            // Snippet: ListResourceChanges(PreviewName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            PreviewName parent = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]");
            // Make the request
            PagedEnumerable<ListResourceChangesResponse, ResourceChange> response = configClient.ListResourceChanges(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceChange item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceChangesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceChange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceChange> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceChange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceChangesAsync</summary>
        public async Task ListResourceChangesResourceNamesAsync()
        {
            // Snippet: ListResourceChangesAsync(PreviewName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            PreviewName parent = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]");
            // Make the request
            PagedAsyncEnumerable<ListResourceChangesResponse, ResourceChange> response = configClient.ListResourceChangesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ResourceChange item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListResourceChangesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceChange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceChange> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceChange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetResourceChange</summary>
        public void GetResourceChangeRequestObject()
        {
            // Snippet: GetResourceChange(GetResourceChangeRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            GetResourceChangeRequest request = new GetResourceChangeRequest
            {
                ResourceChangeName = ResourceChangeName.FromProjectLocationPreviewResourceChange("[PROJECT]", "[LOCATION]", "[PREVIEW]", "[RESOURCE_CHANGE]"),
            };
            // Make the request
            ResourceChange response = configClient.GetResourceChange(request);
            // End snippet
        }

        /// <summary>Snippet for GetResourceChangeAsync</summary>
        public async Task GetResourceChangeRequestObjectAsync()
        {
            // Snippet: GetResourceChangeAsync(GetResourceChangeRequest, CallSettings)
            // Additional: GetResourceChangeAsync(GetResourceChangeRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            GetResourceChangeRequest request = new GetResourceChangeRequest
            {
                ResourceChangeName = ResourceChangeName.FromProjectLocationPreviewResourceChange("[PROJECT]", "[LOCATION]", "[PREVIEW]", "[RESOURCE_CHANGE]"),
            };
            // Make the request
            ResourceChange response = await configClient.GetResourceChangeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetResourceChange</summary>
        public void GetResourceChange()
        {
            // Snippet: GetResourceChange(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/previews/[PREVIEW]/resourceChanges/[RESOURCE_CHANGE]";
            // Make the request
            ResourceChange response = configClient.GetResourceChange(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceChangeAsync</summary>
        public async Task GetResourceChangeAsync()
        {
            // Snippet: GetResourceChangeAsync(string, CallSettings)
            // Additional: GetResourceChangeAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/previews/[PREVIEW]/resourceChanges/[RESOURCE_CHANGE]";
            // Make the request
            ResourceChange response = await configClient.GetResourceChangeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceChange</summary>
        public void GetResourceChangeResourceNames()
        {
            // Snippet: GetResourceChange(ResourceChangeName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ResourceChangeName name = ResourceChangeName.FromProjectLocationPreviewResourceChange("[PROJECT]", "[LOCATION]", "[PREVIEW]", "[RESOURCE_CHANGE]");
            // Make the request
            ResourceChange response = configClient.GetResourceChange(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceChangeAsync</summary>
        public async Task GetResourceChangeResourceNamesAsync()
        {
            // Snippet: GetResourceChangeAsync(ResourceChangeName, CallSettings)
            // Additional: GetResourceChangeAsync(ResourceChangeName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ResourceChangeName name = ResourceChangeName.FromProjectLocationPreviewResourceChange("[PROJECT]", "[LOCATION]", "[PREVIEW]", "[RESOURCE_CHANGE]");
            // Make the request
            ResourceChange response = await configClient.GetResourceChangeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListResourceDrifts</summary>
        public void ListResourceDriftsRequestObject()
        {
            // Snippet: ListResourceDrifts(ListResourceDriftsRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ListResourceDriftsRequest request = new ListResourceDriftsRequest
            {
                ParentAsPreviewName = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListResourceDriftsResponse, ResourceDrift> response = configClient.ListResourceDrifts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceDrift item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceDriftsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceDrift item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceDrift> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceDrift item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceDriftsAsync</summary>
        public async Task ListResourceDriftsRequestObjectAsync()
        {
            // Snippet: ListResourceDriftsAsync(ListResourceDriftsRequest, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ListResourceDriftsRequest request = new ListResourceDriftsRequest
            {
                ParentAsPreviewName = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListResourceDriftsResponse, ResourceDrift> response = configClient.ListResourceDriftsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ResourceDrift item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListResourceDriftsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceDrift item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceDrift> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceDrift item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceDrifts</summary>
        public void ListResourceDrifts()
        {
            // Snippet: ListResourceDrifts(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/previews/[PREVIEW]";
            // Make the request
            PagedEnumerable<ListResourceDriftsResponse, ResourceDrift> response = configClient.ListResourceDrifts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceDrift item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceDriftsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceDrift item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceDrift> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceDrift item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceDriftsAsync</summary>
        public async Task ListResourceDriftsAsync()
        {
            // Snippet: ListResourceDriftsAsync(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/previews/[PREVIEW]";
            // Make the request
            PagedAsyncEnumerable<ListResourceDriftsResponse, ResourceDrift> response = configClient.ListResourceDriftsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ResourceDrift item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListResourceDriftsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceDrift item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceDrift> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceDrift item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceDrifts</summary>
        public void ListResourceDriftsResourceNames()
        {
            // Snippet: ListResourceDrifts(PreviewName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            PreviewName parent = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]");
            // Make the request
            PagedEnumerable<ListResourceDriftsResponse, ResourceDrift> response = configClient.ListResourceDrifts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceDrift item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceDriftsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceDrift item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceDrift> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceDrift item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceDriftsAsync</summary>
        public async Task ListResourceDriftsResourceNamesAsync()
        {
            // Snippet: ListResourceDriftsAsync(PreviewName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            PreviewName parent = PreviewName.FromProjectLocationPreview("[PROJECT]", "[LOCATION]", "[PREVIEW]");
            // Make the request
            PagedAsyncEnumerable<ListResourceDriftsResponse, ResourceDrift> response = configClient.ListResourceDriftsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ResourceDrift item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListResourceDriftsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceDrift item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceDrift> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceDrift item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetResourceDrift</summary>
        public void GetResourceDriftRequestObject()
        {
            // Snippet: GetResourceDrift(GetResourceDriftRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            GetResourceDriftRequest request = new GetResourceDriftRequest
            {
                ResourceDriftName = ResourceDriftName.FromProjectLocationPreviewResourceDrift("[PROJECT]", "[LOCATION]", "[PREVIEW]", "[RESOURCE_DRIFT]"),
            };
            // Make the request
            ResourceDrift response = configClient.GetResourceDrift(request);
            // End snippet
        }

        /// <summary>Snippet for GetResourceDriftAsync</summary>
        public async Task GetResourceDriftRequestObjectAsync()
        {
            // Snippet: GetResourceDriftAsync(GetResourceDriftRequest, CallSettings)
            // Additional: GetResourceDriftAsync(GetResourceDriftRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            GetResourceDriftRequest request = new GetResourceDriftRequest
            {
                ResourceDriftName = ResourceDriftName.FromProjectLocationPreviewResourceDrift("[PROJECT]", "[LOCATION]", "[PREVIEW]", "[RESOURCE_DRIFT]"),
            };
            // Make the request
            ResourceDrift response = await configClient.GetResourceDriftAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetResourceDrift</summary>
        public void GetResourceDrift()
        {
            // Snippet: GetResourceDrift(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/previews/[PREVIEW]/resourceDrifts/[RESOURCE_DRIFT]";
            // Make the request
            ResourceDrift response = configClient.GetResourceDrift(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceDriftAsync</summary>
        public async Task GetResourceDriftAsync()
        {
            // Snippet: GetResourceDriftAsync(string, CallSettings)
            // Additional: GetResourceDriftAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/previews/[PREVIEW]/resourceDrifts/[RESOURCE_DRIFT]";
            // Make the request
            ResourceDrift response = await configClient.GetResourceDriftAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceDrift</summary>
        public void GetResourceDriftResourceNames()
        {
            // Snippet: GetResourceDrift(ResourceDriftName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ResourceDriftName name = ResourceDriftName.FromProjectLocationPreviewResourceDrift("[PROJECT]", "[LOCATION]", "[PREVIEW]", "[RESOURCE_DRIFT]");
            // Make the request
            ResourceDrift response = configClient.GetResourceDrift(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceDriftAsync</summary>
        public async Task GetResourceDriftResourceNamesAsync()
        {
            // Snippet: GetResourceDriftAsync(ResourceDriftName, CallSettings)
            // Additional: GetResourceDriftAsync(ResourceDriftName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ResourceDriftName name = ResourceDriftName.FromProjectLocationPreviewResourceDrift("[PROJECT]", "[LOCATION]", "[PREVIEW]", "[RESOURCE_DRIFT]");
            // Make the request
            ResourceDrift response = await configClient.GetResourceDriftAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutoMigrationConfig</summary>
        public void GetAutoMigrationConfigRequestObject()
        {
            // Snippet: GetAutoMigrationConfig(GetAutoMigrationConfigRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            GetAutoMigrationConfigRequest request = new GetAutoMigrationConfigRequest
            {
                AutoMigrationConfigName = AutoMigrationConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            AutoMigrationConfig response = configClient.GetAutoMigrationConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetAutoMigrationConfigAsync</summary>
        public async Task GetAutoMigrationConfigRequestObjectAsync()
        {
            // Snippet: GetAutoMigrationConfigAsync(GetAutoMigrationConfigRequest, CallSettings)
            // Additional: GetAutoMigrationConfigAsync(GetAutoMigrationConfigRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            GetAutoMigrationConfigRequest request = new GetAutoMigrationConfigRequest
            {
                AutoMigrationConfigName = AutoMigrationConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            AutoMigrationConfig response = await configClient.GetAutoMigrationConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAutoMigrationConfig</summary>
        public void GetAutoMigrationConfig()
        {
            // Snippet: GetAutoMigrationConfig(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autoMigrationConfig";
            // Make the request
            AutoMigrationConfig response = configClient.GetAutoMigrationConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutoMigrationConfigAsync</summary>
        public async Task GetAutoMigrationConfigAsync()
        {
            // Snippet: GetAutoMigrationConfigAsync(string, CallSettings)
            // Additional: GetAutoMigrationConfigAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autoMigrationConfig";
            // Make the request
            AutoMigrationConfig response = await configClient.GetAutoMigrationConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutoMigrationConfig</summary>
        public void GetAutoMigrationConfigResourceNames()
        {
            // Snippet: GetAutoMigrationConfig(AutoMigrationConfigName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            AutoMigrationConfigName name = AutoMigrationConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            AutoMigrationConfig response = configClient.GetAutoMigrationConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutoMigrationConfigAsync</summary>
        public async Task GetAutoMigrationConfigResourceNamesAsync()
        {
            // Snippet: GetAutoMigrationConfigAsync(AutoMigrationConfigName, CallSettings)
            // Additional: GetAutoMigrationConfigAsync(AutoMigrationConfigName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            AutoMigrationConfigName name = AutoMigrationConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            AutoMigrationConfig response = await configClient.GetAutoMigrationConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAutoMigrationConfig</summary>
        public void UpdateAutoMigrationConfigRequestObject()
        {
            // Snippet: UpdateAutoMigrationConfig(UpdateAutoMigrationConfigRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            UpdateAutoMigrationConfigRequest request = new UpdateAutoMigrationConfigRequest
            {
                UpdateMask = new FieldMask(),
                AutoMigrationConfig = new AutoMigrationConfig(),
            };
            // Make the request
            Operation<AutoMigrationConfig, OperationMetadata> response = configClient.UpdateAutoMigrationConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<AutoMigrationConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutoMigrationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutoMigrationConfig, OperationMetadata> retrievedResponse = configClient.PollOnceUpdateAutoMigrationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutoMigrationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAutoMigrationConfigAsync</summary>
        public async Task UpdateAutoMigrationConfigRequestObjectAsync()
        {
            // Snippet: UpdateAutoMigrationConfigAsync(UpdateAutoMigrationConfigRequest, CallSettings)
            // Additional: UpdateAutoMigrationConfigAsync(UpdateAutoMigrationConfigRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAutoMigrationConfigRequest request = new UpdateAutoMigrationConfigRequest
            {
                UpdateMask = new FieldMask(),
                AutoMigrationConfig = new AutoMigrationConfig(),
            };
            // Make the request
            Operation<AutoMigrationConfig, OperationMetadata> response = await configClient.UpdateAutoMigrationConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AutoMigrationConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutoMigrationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutoMigrationConfig, OperationMetadata> retrievedResponse = await configClient.PollOnceUpdateAutoMigrationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutoMigrationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAutoMigrationConfig</summary>
        public void UpdateAutoMigrationConfig()
        {
            // Snippet: UpdateAutoMigrationConfig(AutoMigrationConfig, FieldMask, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            AutoMigrationConfig autoMigrationConfig = new AutoMigrationConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AutoMigrationConfig, OperationMetadata> response = configClient.UpdateAutoMigrationConfig(autoMigrationConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AutoMigrationConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutoMigrationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutoMigrationConfig, OperationMetadata> retrievedResponse = configClient.PollOnceUpdateAutoMigrationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutoMigrationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAutoMigrationConfigAsync</summary>
        public async Task UpdateAutoMigrationConfigAsync()
        {
            // Snippet: UpdateAutoMigrationConfigAsync(AutoMigrationConfig, FieldMask, CallSettings)
            // Additional: UpdateAutoMigrationConfigAsync(AutoMigrationConfig, FieldMask, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            AutoMigrationConfig autoMigrationConfig = new AutoMigrationConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AutoMigrationConfig, OperationMetadata> response = await configClient.UpdateAutoMigrationConfigAsync(autoMigrationConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AutoMigrationConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutoMigrationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutoMigrationConfig, OperationMetadata> retrievedResponse = await configClient.PollOnceUpdateAutoMigrationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutoMigrationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentGroup</summary>
        public void GetDeploymentGroupRequestObject()
        {
            // Snippet: GetDeploymentGroup(GetDeploymentGroupRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            GetDeploymentGroupRequest request = new GetDeploymentGroupRequest
            {
                DeploymentGroupName = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]"),
            };
            // Make the request
            DeploymentGroup response = configClient.GetDeploymentGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentGroupAsync</summary>
        public async Task GetDeploymentGroupRequestObjectAsync()
        {
            // Snippet: GetDeploymentGroupAsync(GetDeploymentGroupRequest, CallSettings)
            // Additional: GetDeploymentGroupAsync(GetDeploymentGroupRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            GetDeploymentGroupRequest request = new GetDeploymentGroupRequest
            {
                DeploymentGroupName = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]"),
            };
            // Make the request
            DeploymentGroup response = await configClient.GetDeploymentGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentGroup</summary>
        public void GetDeploymentGroup()
        {
            // Snippet: GetDeploymentGroup(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deploymentGroups/[DEPLOYMENT_GROUP]";
            // Make the request
            DeploymentGroup response = configClient.GetDeploymentGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentGroupAsync</summary>
        public async Task GetDeploymentGroupAsync()
        {
            // Snippet: GetDeploymentGroupAsync(string, CallSettings)
            // Additional: GetDeploymentGroupAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deploymentGroups/[DEPLOYMENT_GROUP]";
            // Make the request
            DeploymentGroup response = await configClient.GetDeploymentGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentGroup</summary>
        public void GetDeploymentGroupResourceNames()
        {
            // Snippet: GetDeploymentGroup(DeploymentGroupName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeploymentGroupName name = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]");
            // Make the request
            DeploymentGroup response = configClient.GetDeploymentGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentGroupAsync</summary>
        public async Task GetDeploymentGroupResourceNamesAsync()
        {
            // Snippet: GetDeploymentGroupAsync(DeploymentGroupName, CallSettings)
            // Additional: GetDeploymentGroupAsync(DeploymentGroupName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentGroupName name = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]");
            // Make the request
            DeploymentGroup response = await configClient.GetDeploymentGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentGroup</summary>
        public void CreateDeploymentGroupRequestObject()
        {
            // Snippet: CreateDeploymentGroup(CreateDeploymentGroupRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            CreateDeploymentGroupRequest request = new CreateDeploymentGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeploymentGroupId = "",
                DeploymentGroup = new DeploymentGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = configClient.CreateDeploymentGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = configClient.PollOnceCreateDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentGroupAsync</summary>
        public async Task CreateDeploymentGroupRequestObjectAsync()
        {
            // Snippet: CreateDeploymentGroupAsync(CreateDeploymentGroupRequest, CallSettings)
            // Additional: CreateDeploymentGroupAsync(CreateDeploymentGroupRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            CreateDeploymentGroupRequest request = new CreateDeploymentGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeploymentGroupId = "",
                DeploymentGroup = new DeploymentGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = await configClient.CreateDeploymentGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = await configClient.PollOnceCreateDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentGroup</summary>
        public void CreateDeploymentGroup()
        {
            // Snippet: CreateDeploymentGroup(string, DeploymentGroup, string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DeploymentGroup deploymentGroup = new DeploymentGroup();
            string deploymentGroupId = "";
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = configClient.CreateDeploymentGroup(parent, deploymentGroup, deploymentGroupId);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = configClient.PollOnceCreateDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentGroupAsync</summary>
        public async Task CreateDeploymentGroupAsync()
        {
            // Snippet: CreateDeploymentGroupAsync(string, DeploymentGroup, string, CallSettings)
            // Additional: CreateDeploymentGroupAsync(string, DeploymentGroup, string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DeploymentGroup deploymentGroup = new DeploymentGroup();
            string deploymentGroupId = "";
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = await configClient.CreateDeploymentGroupAsync(parent, deploymentGroup, deploymentGroupId);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = await configClient.PollOnceCreateDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentGroup</summary>
        public void CreateDeploymentGroupResourceNames()
        {
            // Snippet: CreateDeploymentGroup(LocationName, DeploymentGroup, string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DeploymentGroup deploymentGroup = new DeploymentGroup();
            string deploymentGroupId = "";
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = configClient.CreateDeploymentGroup(parent, deploymentGroup, deploymentGroupId);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = configClient.PollOnceCreateDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentGroupAsync</summary>
        public async Task CreateDeploymentGroupResourceNamesAsync()
        {
            // Snippet: CreateDeploymentGroupAsync(LocationName, DeploymentGroup, string, CallSettings)
            // Additional: CreateDeploymentGroupAsync(LocationName, DeploymentGroup, string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DeploymentGroup deploymentGroup = new DeploymentGroup();
            string deploymentGroupId = "";
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = await configClient.CreateDeploymentGroupAsync(parent, deploymentGroup, deploymentGroupId);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = await configClient.PollOnceCreateDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeploymentGroup</summary>
        public void UpdateDeploymentGroupRequestObject()
        {
            // Snippet: UpdateDeploymentGroup(UpdateDeploymentGroupRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            UpdateDeploymentGroupRequest request = new UpdateDeploymentGroupRequest
            {
                UpdateMask = new FieldMask(),
                DeploymentGroup = new DeploymentGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = configClient.UpdateDeploymentGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = configClient.PollOnceUpdateDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeploymentGroupAsync</summary>
        public async Task UpdateDeploymentGroupRequestObjectAsync()
        {
            // Snippet: UpdateDeploymentGroupAsync(UpdateDeploymentGroupRequest, CallSettings)
            // Additional: UpdateDeploymentGroupAsync(UpdateDeploymentGroupRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDeploymentGroupRequest request = new UpdateDeploymentGroupRequest
            {
                UpdateMask = new FieldMask(),
                DeploymentGroup = new DeploymentGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = await configClient.UpdateDeploymentGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = await configClient.PollOnceUpdateDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeploymentGroup</summary>
        public void UpdateDeploymentGroup()
        {
            // Snippet: UpdateDeploymentGroup(DeploymentGroup, FieldMask, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeploymentGroup deploymentGroup = new DeploymentGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = configClient.UpdateDeploymentGroup(deploymentGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = configClient.PollOnceUpdateDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeploymentGroupAsync</summary>
        public async Task UpdateDeploymentGroupAsync()
        {
            // Snippet: UpdateDeploymentGroupAsync(DeploymentGroup, FieldMask, CallSettings)
            // Additional: UpdateDeploymentGroupAsync(DeploymentGroup, FieldMask, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentGroup deploymentGroup = new DeploymentGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = await configClient.UpdateDeploymentGroupAsync(deploymentGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = await configClient.PollOnceUpdateDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentGroup</summary>
        public void DeleteDeploymentGroupRequestObject()
        {
            // Snippet: DeleteDeploymentGroup(DeleteDeploymentGroupRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeleteDeploymentGroupRequest request = new DeleteDeploymentGroupRequest
            {
                DeploymentGroupName = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]"),
                RequestId = "",
                Force = false,
                DeploymentReferencePolicy = DeleteDeploymentGroupRequest.Types.DeploymentReferencePolicy.Unspecified,
            };
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = configClient.DeleteDeploymentGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = configClient.PollOnceDeleteDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentGroupAsync</summary>
        public async Task DeleteDeploymentGroupRequestObjectAsync()
        {
            // Snippet: DeleteDeploymentGroupAsync(DeleteDeploymentGroupRequest, CallSettings)
            // Additional: DeleteDeploymentGroupAsync(DeleteDeploymentGroupRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDeploymentGroupRequest request = new DeleteDeploymentGroupRequest
            {
                DeploymentGroupName = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]"),
                RequestId = "",
                Force = false,
                DeploymentReferencePolicy = DeleteDeploymentGroupRequest.Types.DeploymentReferencePolicy.Unspecified,
            };
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = await configClient.DeleteDeploymentGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = await configClient.PollOnceDeleteDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentGroup</summary>
        public void DeleteDeploymentGroup()
        {
            // Snippet: DeleteDeploymentGroup(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deploymentGroups/[DEPLOYMENT_GROUP]";
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = configClient.DeleteDeploymentGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = configClient.PollOnceDeleteDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentGroupAsync</summary>
        public async Task DeleteDeploymentGroupAsync()
        {
            // Snippet: DeleteDeploymentGroupAsync(string, CallSettings)
            // Additional: DeleteDeploymentGroupAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deploymentGroups/[DEPLOYMENT_GROUP]";
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = await configClient.DeleteDeploymentGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = await configClient.PollOnceDeleteDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentGroup</summary>
        public void DeleteDeploymentGroupResourceNames()
        {
            // Snippet: DeleteDeploymentGroup(DeploymentGroupName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeploymentGroupName name = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]");
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = configClient.DeleteDeploymentGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = configClient.PollOnceDeleteDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentGroupAsync</summary>
        public async Task DeleteDeploymentGroupResourceNamesAsync()
        {
            // Snippet: DeleteDeploymentGroupAsync(DeploymentGroupName, CallSettings)
            // Additional: DeleteDeploymentGroupAsync(DeploymentGroupName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentGroupName name = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]");
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = await configClient.DeleteDeploymentGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = await configClient.PollOnceDeleteDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentGroups</summary>
        public void ListDeploymentGroupsRequestObject()
        {
            // Snippet: ListDeploymentGroups(ListDeploymentGroupsRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ListDeploymentGroupsRequest request = new ListDeploymentGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDeploymentGroupsResponse, DeploymentGroup> response = configClient.ListDeploymentGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentGroupsAsync</summary>
        public async Task ListDeploymentGroupsRequestObjectAsync()
        {
            // Snippet: ListDeploymentGroupsAsync(ListDeploymentGroupsRequest, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ListDeploymentGroupsRequest request = new ListDeploymentGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDeploymentGroupsResponse, DeploymentGroup> response = configClient.ListDeploymentGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentGroups</summary>
        public void ListDeploymentGroups()
        {
            // Snippet: ListDeploymentGroups(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDeploymentGroupsResponse, DeploymentGroup> response = configClient.ListDeploymentGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentGroupsAsync</summary>
        public async Task ListDeploymentGroupsAsync()
        {
            // Snippet: ListDeploymentGroupsAsync(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDeploymentGroupsResponse, DeploymentGroup> response = configClient.ListDeploymentGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentGroups</summary>
        public void ListDeploymentGroupsResourceNames()
        {
            // Snippet: ListDeploymentGroups(LocationName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDeploymentGroupsResponse, DeploymentGroup> response = configClient.ListDeploymentGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentGroupsAsync</summary>
        public async Task ListDeploymentGroupsResourceNamesAsync()
        {
            // Snippet: ListDeploymentGroupsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDeploymentGroupsResponse, DeploymentGroup> response = configClient.ListDeploymentGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ProvisionDeploymentGroup</summary>
        public void ProvisionDeploymentGroupRequestObject()
        {
            // Snippet: ProvisionDeploymentGroup(ProvisionDeploymentGroupRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ProvisionDeploymentGroupRequest request = new ProvisionDeploymentGroupRequest
            {
                DeploymentGroupName = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]"),
                DeploymentSpecs =
                {
                    {
                        "",
                        new DeploymentSpec()
                    },
                },
            };
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = configClient.ProvisionDeploymentGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = configClient.PollOnceProvisionDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ProvisionDeploymentGroupAsync</summary>
        public async Task ProvisionDeploymentGroupRequestObjectAsync()
        {
            // Snippet: ProvisionDeploymentGroupAsync(ProvisionDeploymentGroupRequest, CallSettings)
            // Additional: ProvisionDeploymentGroupAsync(ProvisionDeploymentGroupRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ProvisionDeploymentGroupRequest request = new ProvisionDeploymentGroupRequest
            {
                DeploymentGroupName = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]"),
                DeploymentSpecs =
                {
                    {
                        "",
                        new DeploymentSpec()
                    },
                },
            };
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = await configClient.ProvisionDeploymentGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = await configClient.PollOnceProvisionDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ProvisionDeploymentGroup</summary>
        public void ProvisionDeploymentGroup()
        {
            // Snippet: ProvisionDeploymentGroup(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deploymentGroups/[DEPLOYMENT_GROUP]";
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = configClient.ProvisionDeploymentGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = configClient.PollOnceProvisionDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ProvisionDeploymentGroupAsync</summary>
        public async Task ProvisionDeploymentGroupAsync()
        {
            // Snippet: ProvisionDeploymentGroupAsync(string, CallSettings)
            // Additional: ProvisionDeploymentGroupAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deploymentGroups/[DEPLOYMENT_GROUP]";
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = await configClient.ProvisionDeploymentGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = await configClient.PollOnceProvisionDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ProvisionDeploymentGroup</summary>
        public void ProvisionDeploymentGroupResourceNames()
        {
            // Snippet: ProvisionDeploymentGroup(DeploymentGroupName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeploymentGroupName name = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]");
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = configClient.ProvisionDeploymentGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = configClient.PollOnceProvisionDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ProvisionDeploymentGroupAsync</summary>
        public async Task ProvisionDeploymentGroupResourceNamesAsync()
        {
            // Snippet: ProvisionDeploymentGroupAsync(DeploymentGroupName, CallSettings)
            // Additional: ProvisionDeploymentGroupAsync(DeploymentGroupName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentGroupName name = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]");
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = await configClient.ProvisionDeploymentGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = await configClient.PollOnceProvisionDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeprovisionDeploymentGroup</summary>
        public void DeprovisionDeploymentGroupRequestObject()
        {
            // Snippet: DeprovisionDeploymentGroup(DeprovisionDeploymentGroupRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeprovisionDeploymentGroupRequest request = new DeprovisionDeploymentGroupRequest
            {
                DeploymentGroupName = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]"),
                Force = false,
                DeletePolicy = DeleteDeploymentRequest.Types.DeletePolicy.Unspecified,
            };
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = configClient.DeprovisionDeploymentGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = configClient.PollOnceDeprovisionDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeprovisionDeploymentGroupAsync</summary>
        public async Task DeprovisionDeploymentGroupRequestObjectAsync()
        {
            // Snippet: DeprovisionDeploymentGroupAsync(DeprovisionDeploymentGroupRequest, CallSettings)
            // Additional: DeprovisionDeploymentGroupAsync(DeprovisionDeploymentGroupRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeprovisionDeploymentGroupRequest request = new DeprovisionDeploymentGroupRequest
            {
                DeploymentGroupName = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]"),
                Force = false,
                DeletePolicy = DeleteDeploymentRequest.Types.DeletePolicy.Unspecified,
            };
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = await configClient.DeprovisionDeploymentGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = await configClient.PollOnceDeprovisionDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeprovisionDeploymentGroup</summary>
        public void DeprovisionDeploymentGroup()
        {
            // Snippet: DeprovisionDeploymentGroup(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deploymentGroups/[DEPLOYMENT_GROUP]";
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = configClient.DeprovisionDeploymentGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = configClient.PollOnceDeprovisionDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeprovisionDeploymentGroupAsync</summary>
        public async Task DeprovisionDeploymentGroupAsync()
        {
            // Snippet: DeprovisionDeploymentGroupAsync(string, CallSettings)
            // Additional: DeprovisionDeploymentGroupAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deploymentGroups/[DEPLOYMENT_GROUP]";
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = await configClient.DeprovisionDeploymentGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = await configClient.PollOnceDeprovisionDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeprovisionDeploymentGroup</summary>
        public void DeprovisionDeploymentGroupResourceNames()
        {
            // Snippet: DeprovisionDeploymentGroup(DeploymentGroupName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeploymentGroupName name = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]");
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = configClient.DeprovisionDeploymentGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = configClient.PollOnceDeprovisionDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeprovisionDeploymentGroupAsync</summary>
        public async Task DeprovisionDeploymentGroupResourceNamesAsync()
        {
            // Snippet: DeprovisionDeploymentGroupAsync(DeploymentGroupName, CallSettings)
            // Additional: DeprovisionDeploymentGroupAsync(DeploymentGroupName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentGroupName name = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]");
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = await configClient.DeprovisionDeploymentGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = await configClient.PollOnceDeprovisionDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentGroupRevision</summary>
        public void GetDeploymentGroupRevisionRequestObject()
        {
            // Snippet: GetDeploymentGroupRevision(GetDeploymentGroupRevisionRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            GetDeploymentGroupRevisionRequest request = new GetDeploymentGroupRevisionRequest
            {
                DeploymentGroupRevisionName = DeploymentGroupRevisionName.FromProjectLocationDeploymentGroupRevision("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]", "[REVISION]"),
            };
            // Make the request
            DeploymentGroupRevision response = configClient.GetDeploymentGroupRevision(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentGroupRevisionAsync</summary>
        public async Task GetDeploymentGroupRevisionRequestObjectAsync()
        {
            // Snippet: GetDeploymentGroupRevisionAsync(GetDeploymentGroupRevisionRequest, CallSettings)
            // Additional: GetDeploymentGroupRevisionAsync(GetDeploymentGroupRevisionRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            GetDeploymentGroupRevisionRequest request = new GetDeploymentGroupRevisionRequest
            {
                DeploymentGroupRevisionName = DeploymentGroupRevisionName.FromProjectLocationDeploymentGroupRevision("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]", "[REVISION]"),
            };
            // Make the request
            DeploymentGroupRevision response = await configClient.GetDeploymentGroupRevisionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentGroupRevision</summary>
        public void GetDeploymentGroupRevision()
        {
            // Snippet: GetDeploymentGroupRevision(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deploymentGroups/[DEPLOYMENT_GROUP]/revisions/[REVISION]";
            // Make the request
            DeploymentGroupRevision response = configClient.GetDeploymentGroupRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentGroupRevisionAsync</summary>
        public async Task GetDeploymentGroupRevisionAsync()
        {
            // Snippet: GetDeploymentGroupRevisionAsync(string, CallSettings)
            // Additional: GetDeploymentGroupRevisionAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deploymentGroups/[DEPLOYMENT_GROUP]/revisions/[REVISION]";
            // Make the request
            DeploymentGroupRevision response = await configClient.GetDeploymentGroupRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentGroupRevision</summary>
        public void GetDeploymentGroupRevisionResourceNames()
        {
            // Snippet: GetDeploymentGroupRevision(DeploymentGroupRevisionName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeploymentGroupRevisionName name = DeploymentGroupRevisionName.FromProjectLocationDeploymentGroupRevision("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]", "[REVISION]");
            // Make the request
            DeploymentGroupRevision response = configClient.GetDeploymentGroupRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentGroupRevisionAsync</summary>
        public async Task GetDeploymentGroupRevisionResourceNamesAsync()
        {
            // Snippet: GetDeploymentGroupRevisionAsync(DeploymentGroupRevisionName, CallSettings)
            // Additional: GetDeploymentGroupRevisionAsync(DeploymentGroupRevisionName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentGroupRevisionName name = DeploymentGroupRevisionName.FromProjectLocationDeploymentGroupRevision("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]", "[REVISION]");
            // Make the request
            DeploymentGroupRevision response = await configClient.GetDeploymentGroupRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentGroupRevisions</summary>
        public void ListDeploymentGroupRevisionsRequestObject()
        {
            // Snippet: ListDeploymentGroupRevisions(ListDeploymentGroupRevisionsRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ListDeploymentGroupRevisionsRequest request = new ListDeploymentGroupRevisionsRequest
            {
                ParentAsDeploymentGroupName = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]"),
            };
            // Make the request
            PagedEnumerable<ListDeploymentGroupRevisionsResponse, DeploymentGroupRevision> response = configClient.ListDeploymentGroupRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeploymentGroupRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentGroupRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentGroupRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentGroupRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentGroupRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentGroupRevisionsAsync</summary>
        public async Task ListDeploymentGroupRevisionsRequestObjectAsync()
        {
            // Snippet: ListDeploymentGroupRevisionsAsync(ListDeploymentGroupRevisionsRequest, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ListDeploymentGroupRevisionsRequest request = new ListDeploymentGroupRevisionsRequest
            {
                ParentAsDeploymentGroupName = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDeploymentGroupRevisionsResponse, DeploymentGroupRevision> response = configClient.ListDeploymentGroupRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DeploymentGroupRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDeploymentGroupRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentGroupRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentGroupRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentGroupRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentGroupRevisions</summary>
        public void ListDeploymentGroupRevisions()
        {
            // Snippet: ListDeploymentGroupRevisions(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deploymentGroups/[DEPLOYMENT_GROUP]";
            // Make the request
            PagedEnumerable<ListDeploymentGroupRevisionsResponse, DeploymentGroupRevision> response = configClient.ListDeploymentGroupRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeploymentGroupRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentGroupRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentGroupRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentGroupRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentGroupRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentGroupRevisionsAsync</summary>
        public async Task ListDeploymentGroupRevisionsAsync()
        {
            // Snippet: ListDeploymentGroupRevisionsAsync(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deploymentGroups/[DEPLOYMENT_GROUP]";
            // Make the request
            PagedAsyncEnumerable<ListDeploymentGroupRevisionsResponse, DeploymentGroupRevision> response = configClient.ListDeploymentGroupRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DeploymentGroupRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDeploymentGroupRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentGroupRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentGroupRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentGroupRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentGroupRevisions</summary>
        public void ListDeploymentGroupRevisionsResourceNames()
        {
            // Snippet: ListDeploymentGroupRevisions(DeploymentGroupName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeploymentGroupName parent = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]");
            // Make the request
            PagedEnumerable<ListDeploymentGroupRevisionsResponse, DeploymentGroupRevision> response = configClient.ListDeploymentGroupRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeploymentGroupRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentGroupRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentGroupRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentGroupRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentGroupRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentGroupRevisionsAsync</summary>
        public async Task ListDeploymentGroupRevisionsResourceNamesAsync()
        {
            // Snippet: ListDeploymentGroupRevisionsAsync(DeploymentGroupName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentGroupName parent = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]");
            // Make the request
            PagedAsyncEnumerable<ListDeploymentGroupRevisionsResponse, DeploymentGroupRevision> response = configClient.ListDeploymentGroupRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DeploymentGroupRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDeploymentGroupRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentGroupRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentGroupRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentGroupRevision item in singlePage)
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
