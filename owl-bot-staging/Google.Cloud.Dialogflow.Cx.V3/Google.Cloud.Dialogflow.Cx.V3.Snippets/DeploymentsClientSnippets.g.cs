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
    using Google.Cloud.Dialogflow.Cx.V3;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDeploymentsClientSnippets
    {
        /// <summary>Snippet for ListDeployments</summary>
        public void ListDeploymentsRequestObject()
        {
            // Snippet: ListDeployments(ListDeploymentsRequest, CallSettings)
            // Create client
            DeploymentsClient deploymentsClient = DeploymentsClient.Create();
            // Initialize request argument(s)
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            PagedEnumerable<ListDeploymentsResponse, Deployment> response = deploymentsClient.ListDeployments(request);

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
            DeploymentsClient deploymentsClient = await DeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> response = deploymentsClient.ListDeploymentsAsync(request);

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
            DeploymentsClient deploymentsClient = DeploymentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]";
            // Make the request
            PagedEnumerable<ListDeploymentsResponse, Deployment> response = deploymentsClient.ListDeployments(parent);

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
            DeploymentsClient deploymentsClient = await DeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]";
            // Make the request
            PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> response = deploymentsClient.ListDeploymentsAsync(parent);

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
            // Snippet: ListDeployments(EnvironmentName, string, int?, CallSettings)
            // Create client
            DeploymentsClient deploymentsClient = DeploymentsClient.Create();
            // Initialize request argument(s)
            EnvironmentName parent = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]");
            // Make the request
            PagedEnumerable<ListDeploymentsResponse, Deployment> response = deploymentsClient.ListDeployments(parent);

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
            // Snippet: ListDeploymentsAsync(EnvironmentName, string, int?, CallSettings)
            // Create client
            DeploymentsClient deploymentsClient = await DeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            EnvironmentName parent = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]");
            // Make the request
            PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> response = deploymentsClient.ListDeploymentsAsync(parent);

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

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeploymentRequestObject()
        {
            // Snippet: GetDeployment(GetDeploymentRequest, CallSettings)
            // Create client
            DeploymentsClient deploymentsClient = DeploymentsClient.Create();
            // Initialize request argument(s)
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationAgentEnvironmentDeployment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[DEPLOYMENT]"),
            };
            // Make the request
            Deployment response = deploymentsClient.GetDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentRequestObjectAsync()
        {
            // Snippet: GetDeploymentAsync(GetDeploymentRequest, CallSettings)
            // Additional: GetDeploymentAsync(GetDeploymentRequest, CancellationToken)
            // Create client
            DeploymentsClient deploymentsClient = await DeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationAgentEnvironmentDeployment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[DEPLOYMENT]"),
            };
            // Make the request
            Deployment response = await deploymentsClient.GetDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeployment()
        {
            // Snippet: GetDeployment(string, CallSettings)
            // Create client
            DeploymentsClient deploymentsClient = DeploymentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]/deployments/[DEPLOYMENT]";
            // Make the request
            Deployment response = deploymentsClient.GetDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentAsync()
        {
            // Snippet: GetDeploymentAsync(string, CallSettings)
            // Additional: GetDeploymentAsync(string, CancellationToken)
            // Create client
            DeploymentsClient deploymentsClient = await DeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]/deployments/[DEPLOYMENT]";
            // Make the request
            Deployment response = await deploymentsClient.GetDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeploymentResourceNames()
        {
            // Snippet: GetDeployment(DeploymentName, CallSettings)
            // Create client
            DeploymentsClient deploymentsClient = DeploymentsClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationAgentEnvironmentDeployment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[DEPLOYMENT]");
            // Make the request
            Deployment response = deploymentsClient.GetDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentResourceNamesAsync()
        {
            // Snippet: GetDeploymentAsync(DeploymentName, CallSettings)
            // Additional: GetDeploymentAsync(DeploymentName, CancellationToken)
            // Create client
            DeploymentsClient deploymentsClient = await DeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationAgentEnvironmentDeployment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[DEPLOYMENT]");
            // Make the request
            Deployment response = await deploymentsClient.GetDeploymentAsync(name);
            // End snippet
        }
    }
}
