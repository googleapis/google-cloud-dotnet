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
    using Google.Cloud.GSuiteAddOns.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGSuiteAddOnsClientSnippets
    {
        /// <summary>Snippet for GetAuthorization</summary>
        public void GetAuthorizationRequestObject()
        {
            // Snippet: GetAuthorization(GetAuthorizationRequest, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            GetAuthorizationRequest request = new GetAuthorizationRequest
            {
                AuthorizationName = AuthorizationName.FromProject("[PROJECT]"),
            };
            // Make the request
            Authorization response = gSuiteAddOnsClient.GetAuthorization(request);
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizationAsync</summary>
        public async Task GetAuthorizationRequestObjectAsync()
        {
            // Snippet: GetAuthorizationAsync(GetAuthorizationRequest, CallSettings)
            // Additional: GetAuthorizationAsync(GetAuthorizationRequest, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            GetAuthorizationRequest request = new GetAuthorizationRequest
            {
                AuthorizationName = AuthorizationName.FromProject("[PROJECT]"),
            };
            // Make the request
            Authorization response = await gSuiteAddOnsClient.GetAuthorizationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAuthorization</summary>
        public void GetAuthorization()
        {
            // Snippet: GetAuthorization(string, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/authorization";
            // Make the request
            Authorization response = gSuiteAddOnsClient.GetAuthorization(name);
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizationAsync</summary>
        public async Task GetAuthorizationAsync()
        {
            // Snippet: GetAuthorizationAsync(string, CallSettings)
            // Additional: GetAuthorizationAsync(string, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/authorization";
            // Make the request
            Authorization response = await gSuiteAddOnsClient.GetAuthorizationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAuthorization</summary>
        public void GetAuthorizationResourceNames()
        {
            // Snippet: GetAuthorization(AuthorizationName, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            AuthorizationName name = AuthorizationName.FromProject("[PROJECT]");
            // Make the request
            Authorization response = gSuiteAddOnsClient.GetAuthorization(name);
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizationAsync</summary>
        public async Task GetAuthorizationResourceNamesAsync()
        {
            // Snippet: GetAuthorizationAsync(AuthorizationName, CallSettings)
            // Additional: GetAuthorizationAsync(AuthorizationName, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            AuthorizationName name = AuthorizationName.FromProject("[PROJECT]");
            // Make the request
            Authorization response = await gSuiteAddOnsClient.GetAuthorizationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeploymentRequestObject()
        {
            // Snippet: CreateDeployment(CreateDeploymentRequest, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            CreateDeploymentRequest request = new CreateDeploymentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                DeploymentId = "",
                Deployment = new Deployment(),
            };
            // Make the request
            Deployment response = gSuiteAddOnsClient.CreateDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeploymentRequestObjectAsync()
        {
            // Snippet: CreateDeploymentAsync(CreateDeploymentRequest, CallSettings)
            // Additional: CreateDeploymentAsync(CreateDeploymentRequest, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            CreateDeploymentRequest request = new CreateDeploymentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                DeploymentId = "",
                Deployment = new Deployment(),
            };
            // Make the request
            Deployment response = await gSuiteAddOnsClient.CreateDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeployment()
        {
            // Snippet: CreateDeployment(string, Deployment, string, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Deployment deployment = new Deployment();
            string deploymentId = "";
            // Make the request
            Deployment response = gSuiteAddOnsClient.CreateDeployment(parent, deployment, deploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeploymentAsync()
        {
            // Snippet: CreateDeploymentAsync(string, Deployment, string, CallSettings)
            // Additional: CreateDeploymentAsync(string, Deployment, string, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Deployment deployment = new Deployment();
            string deploymentId = "";
            // Make the request
            Deployment response = await gSuiteAddOnsClient.CreateDeploymentAsync(parent, deployment, deploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeploymentResourceNames()
        {
            // Snippet: CreateDeployment(ProjectName, Deployment, string, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Deployment deployment = new Deployment();
            string deploymentId = "";
            // Make the request
            Deployment response = gSuiteAddOnsClient.CreateDeployment(parent, deployment, deploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeploymentResourceNamesAsync()
        {
            // Snippet: CreateDeploymentAsync(ProjectName, Deployment, string, CallSettings)
            // Additional: CreateDeploymentAsync(ProjectName, Deployment, string, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Deployment deployment = new Deployment();
            string deploymentId = "";
            // Make the request
            Deployment response = await gSuiteAddOnsClient.CreateDeploymentAsync(parent, deployment, deploymentId);
            // End snippet
        }

        /// <summary>Snippet for ReplaceDeployment</summary>
        public void ReplaceDeploymentRequestObject()
        {
            // Snippet: ReplaceDeployment(ReplaceDeploymentRequest, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            ReplaceDeploymentRequest request = new ReplaceDeploymentRequest
            {
                Deployment = new Deployment(),
            };
            // Make the request
            Deployment response = gSuiteAddOnsClient.ReplaceDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for ReplaceDeploymentAsync</summary>
        public async Task ReplaceDeploymentRequestObjectAsync()
        {
            // Snippet: ReplaceDeploymentAsync(ReplaceDeploymentRequest, CallSettings)
            // Additional: ReplaceDeploymentAsync(ReplaceDeploymentRequest, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            ReplaceDeploymentRequest request = new ReplaceDeploymentRequest
            {
                Deployment = new Deployment(),
            };
            // Make the request
            Deployment response = await gSuiteAddOnsClient.ReplaceDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReplaceDeployment</summary>
        public void ReplaceDeployment()
        {
            // Snippet: ReplaceDeployment(Deployment, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            Deployment deployment = new Deployment();
            // Make the request
            Deployment response = gSuiteAddOnsClient.ReplaceDeployment(deployment);
            // End snippet
        }

        /// <summary>Snippet for ReplaceDeploymentAsync</summary>
        public async Task ReplaceDeploymentAsync()
        {
            // Snippet: ReplaceDeploymentAsync(Deployment, CallSettings)
            // Additional: ReplaceDeploymentAsync(Deployment, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            Deployment deployment = new Deployment();
            // Make the request
            Deployment response = await gSuiteAddOnsClient.ReplaceDeploymentAsync(deployment);
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeploymentRequestObject()
        {
            // Snippet: GetDeployment(GetDeploymentRequest, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            // Make the request
            Deployment response = gSuiteAddOnsClient.GetDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentRequestObjectAsync()
        {
            // Snippet: GetDeploymentAsync(GetDeploymentRequest, CallSettings)
            // Additional: GetDeploymentAsync(GetDeploymentRequest, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            // Make the request
            Deployment response = await gSuiteAddOnsClient.GetDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeployment()
        {
            // Snippet: GetDeployment(string, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/deployments/[DEPLOYMENT]";
            // Make the request
            Deployment response = gSuiteAddOnsClient.GetDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentAsync()
        {
            // Snippet: GetDeploymentAsync(string, CallSettings)
            // Additional: GetDeploymentAsync(string, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/deployments/[DEPLOYMENT]";
            // Make the request
            Deployment response = await gSuiteAddOnsClient.GetDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeploymentResourceNames()
        {
            // Snippet: GetDeployment(DeploymentName, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]");
            // Make the request
            Deployment response = gSuiteAddOnsClient.GetDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentResourceNamesAsync()
        {
            // Snippet: GetDeploymentAsync(DeploymentName, CallSettings)
            // Additional: GetDeploymentAsync(DeploymentName, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]");
            // Make the request
            Deployment response = await gSuiteAddOnsClient.GetDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeployments</summary>
        public void ListDeploymentsRequestObject()
        {
            // Snippet: ListDeployments(ListDeploymentsRequest, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListDeploymentsResponse, Deployment> response = gSuiteAddOnsClient.ListDeployments(request);

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
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> response = gSuiteAddOnsClient.ListDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Deployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListDeploymentsResponse, Deployment> response = gSuiteAddOnsClient.ListDeployments(parent);

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
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> response = gSuiteAddOnsClient.ListDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Deployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            // Snippet: ListDeployments(ProjectName, string, int?, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListDeploymentsResponse, Deployment> response = gSuiteAddOnsClient.ListDeployments(parent);

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
            // Snippet: ListDeploymentsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> response = gSuiteAddOnsClient.ListDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Deployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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

        /// <summary>Snippet for DeleteDeployment</summary>
        public void DeleteDeploymentRequestObject()
        {
            // Snippet: DeleteDeployment(DeleteDeploymentRequest, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            DeleteDeploymentRequest request = new DeleteDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                Etag = "",
            };
            // Make the request
            gSuiteAddOnsClient.DeleteDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentAsync</summary>
        public async Task DeleteDeploymentRequestObjectAsync()
        {
            // Snippet: DeleteDeploymentAsync(DeleteDeploymentRequest, CallSettings)
            // Additional: DeleteDeploymentAsync(DeleteDeploymentRequest, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDeploymentRequest request = new DeleteDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                Etag = "",
            };
            // Make the request
            await gSuiteAddOnsClient.DeleteDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployment</summary>
        public void DeleteDeployment()
        {
            // Snippet: DeleteDeployment(string, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/deployments/[DEPLOYMENT]";
            // Make the request
            gSuiteAddOnsClient.DeleteDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentAsync</summary>
        public async Task DeleteDeploymentAsync()
        {
            // Snippet: DeleteDeploymentAsync(string, CallSettings)
            // Additional: DeleteDeploymentAsync(string, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/deployments/[DEPLOYMENT]";
            // Make the request
            await gSuiteAddOnsClient.DeleteDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployment</summary>
        public void DeleteDeploymentResourceNames()
        {
            // Snippet: DeleteDeployment(DeploymentName, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]");
            // Make the request
            gSuiteAddOnsClient.DeleteDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentAsync</summary>
        public async Task DeleteDeploymentResourceNamesAsync()
        {
            // Snippet: DeleteDeploymentAsync(DeploymentName, CallSettings)
            // Additional: DeleteDeploymentAsync(DeploymentName, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]");
            // Make the request
            await gSuiteAddOnsClient.DeleteDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for InstallDeployment</summary>
        public void InstallDeploymentRequestObject()
        {
            // Snippet: InstallDeployment(InstallDeploymentRequest, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            InstallDeploymentRequest request = new InstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            // Make the request
            gSuiteAddOnsClient.InstallDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for InstallDeploymentAsync</summary>
        public async Task InstallDeploymentRequestObjectAsync()
        {
            // Snippet: InstallDeploymentAsync(InstallDeploymentRequest, CallSettings)
            // Additional: InstallDeploymentAsync(InstallDeploymentRequest, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            InstallDeploymentRequest request = new InstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            // Make the request
            await gSuiteAddOnsClient.InstallDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for InstallDeployment</summary>
        public void InstallDeployment()
        {
            // Snippet: InstallDeployment(string, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/deployments/[DEPLOYMENT]";
            // Make the request
            gSuiteAddOnsClient.InstallDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for InstallDeploymentAsync</summary>
        public async Task InstallDeploymentAsync()
        {
            // Snippet: InstallDeploymentAsync(string, CallSettings)
            // Additional: InstallDeploymentAsync(string, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/deployments/[DEPLOYMENT]";
            // Make the request
            await gSuiteAddOnsClient.InstallDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for InstallDeployment</summary>
        public void InstallDeploymentResourceNames()
        {
            // Snippet: InstallDeployment(DeploymentName, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]");
            // Make the request
            gSuiteAddOnsClient.InstallDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for InstallDeploymentAsync</summary>
        public async Task InstallDeploymentResourceNamesAsync()
        {
            // Snippet: InstallDeploymentAsync(DeploymentName, CallSettings)
            // Additional: InstallDeploymentAsync(DeploymentName, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]");
            // Make the request
            await gSuiteAddOnsClient.InstallDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UninstallDeployment</summary>
        public void UninstallDeploymentRequestObject()
        {
            // Snippet: UninstallDeployment(UninstallDeploymentRequest, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            UninstallDeploymentRequest request = new UninstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            // Make the request
            gSuiteAddOnsClient.UninstallDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for UninstallDeploymentAsync</summary>
        public async Task UninstallDeploymentRequestObjectAsync()
        {
            // Snippet: UninstallDeploymentAsync(UninstallDeploymentRequest, CallSettings)
            // Additional: UninstallDeploymentAsync(UninstallDeploymentRequest, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            UninstallDeploymentRequest request = new UninstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            // Make the request
            await gSuiteAddOnsClient.UninstallDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UninstallDeployment</summary>
        public void UninstallDeployment()
        {
            // Snippet: UninstallDeployment(string, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/deployments/[DEPLOYMENT]";
            // Make the request
            gSuiteAddOnsClient.UninstallDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for UninstallDeploymentAsync</summary>
        public async Task UninstallDeploymentAsync()
        {
            // Snippet: UninstallDeploymentAsync(string, CallSettings)
            // Additional: UninstallDeploymentAsync(string, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/deployments/[DEPLOYMENT]";
            // Make the request
            await gSuiteAddOnsClient.UninstallDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UninstallDeployment</summary>
        public void UninstallDeploymentResourceNames()
        {
            // Snippet: UninstallDeployment(DeploymentName, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]");
            // Make the request
            gSuiteAddOnsClient.UninstallDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for UninstallDeploymentAsync</summary>
        public async Task UninstallDeploymentResourceNamesAsync()
        {
            // Snippet: UninstallDeploymentAsync(DeploymentName, CallSettings)
            // Additional: UninstallDeploymentAsync(DeploymentName, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]");
            // Make the request
            await gSuiteAddOnsClient.UninstallDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstallStatus</summary>
        public void GetInstallStatusRequestObject()
        {
            // Snippet: GetInstallStatus(GetInstallStatusRequest, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            GetInstallStatusRequest request = new GetInstallStatusRequest
            {
                InstallStatusName = InstallStatusName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            // Make the request
            InstallStatus response = gSuiteAddOnsClient.GetInstallStatus(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstallStatusAsync</summary>
        public async Task GetInstallStatusRequestObjectAsync()
        {
            // Snippet: GetInstallStatusAsync(GetInstallStatusRequest, CallSettings)
            // Additional: GetInstallStatusAsync(GetInstallStatusRequest, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            GetInstallStatusRequest request = new GetInstallStatusRequest
            {
                InstallStatusName = InstallStatusName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            // Make the request
            InstallStatus response = await gSuiteAddOnsClient.GetInstallStatusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstallStatus</summary>
        public void GetInstallStatus()
        {
            // Snippet: GetInstallStatus(string, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/deployments/[DEPLOYMENT]/installStatus";
            // Make the request
            InstallStatus response = gSuiteAddOnsClient.GetInstallStatus(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstallStatusAsync</summary>
        public async Task GetInstallStatusAsync()
        {
            // Snippet: GetInstallStatusAsync(string, CallSettings)
            // Additional: GetInstallStatusAsync(string, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/deployments/[DEPLOYMENT]/installStatus";
            // Make the request
            InstallStatus response = await gSuiteAddOnsClient.GetInstallStatusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstallStatus</summary>
        public void GetInstallStatusResourceNames()
        {
            // Snippet: GetInstallStatus(InstallStatusName, CallSettings)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            InstallStatusName name = InstallStatusName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]");
            // Make the request
            InstallStatus response = gSuiteAddOnsClient.GetInstallStatus(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstallStatusAsync</summary>
        public async Task GetInstallStatusResourceNamesAsync()
        {
            // Snippet: GetInstallStatusAsync(InstallStatusName, CallSettings)
            // Additional: GetInstallStatusAsync(InstallStatusName, CancellationToken)
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = await GSuiteAddOnsClient.CreateAsync();
            // Initialize request argument(s)
            InstallStatusName name = InstallStatusName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]");
            // Make the request
            InstallStatus response = await gSuiteAddOnsClient.GetInstallStatusAsync(name);
            // End snippet
        }
    }
}
