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
    using Google.Cloud.Iap.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedIdentityAwareProxyOAuthServiceClientSnippets
    {
        /// <summary>Snippet for ListBrands</summary>
        public void ListBrandsRequestObject()
        {
            // Snippet: ListBrands(ListBrandsRequest, CallSettings)
            // Create client
            IdentityAwareProxyOAuthServiceClient identityAwareProxyOAuthServiceClient = IdentityAwareProxyOAuthServiceClient.Create();
            // Initialize request argument(s)
            ListBrandsRequest request = new ListBrandsRequest { Parent = "", };
            // Make the request
            ListBrandsResponse response = identityAwareProxyOAuthServiceClient.ListBrands(request);
            // End snippet
        }

        /// <summary>Snippet for ListBrandsAsync</summary>
        public async Task ListBrandsRequestObjectAsync()
        {
            // Snippet: ListBrandsAsync(ListBrandsRequest, CallSettings)
            // Additional: ListBrandsAsync(ListBrandsRequest, CancellationToken)
            // Create client
            IdentityAwareProxyOAuthServiceClient identityAwareProxyOAuthServiceClient = await IdentityAwareProxyOAuthServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListBrandsRequest request = new ListBrandsRequest { Parent = "", };
            // Make the request
            ListBrandsResponse response = await identityAwareProxyOAuthServiceClient.ListBrandsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBrand</summary>
        public void CreateBrandRequestObject()
        {
            // Snippet: CreateBrand(CreateBrandRequest, CallSettings)
            // Create client
            IdentityAwareProxyOAuthServiceClient identityAwareProxyOAuthServiceClient = IdentityAwareProxyOAuthServiceClient.Create();
            // Initialize request argument(s)
            CreateBrandRequest request = new CreateBrandRequest
            {
                Parent = "",
                Brand = new Brand(),
            };
            // Make the request
            Brand response = identityAwareProxyOAuthServiceClient.CreateBrand(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBrandAsync</summary>
        public async Task CreateBrandRequestObjectAsync()
        {
            // Snippet: CreateBrandAsync(CreateBrandRequest, CallSettings)
            // Additional: CreateBrandAsync(CreateBrandRequest, CancellationToken)
            // Create client
            IdentityAwareProxyOAuthServiceClient identityAwareProxyOAuthServiceClient = await IdentityAwareProxyOAuthServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateBrandRequest request = new CreateBrandRequest
            {
                Parent = "",
                Brand = new Brand(),
            };
            // Make the request
            Brand response = await identityAwareProxyOAuthServiceClient.CreateBrandAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBrand</summary>
        public void GetBrandRequestObject()
        {
            // Snippet: GetBrand(GetBrandRequest, CallSettings)
            // Create client
            IdentityAwareProxyOAuthServiceClient identityAwareProxyOAuthServiceClient = IdentityAwareProxyOAuthServiceClient.Create();
            // Initialize request argument(s)
            GetBrandRequest request = new GetBrandRequest { Name = "", };
            // Make the request
            Brand response = identityAwareProxyOAuthServiceClient.GetBrand(request);
            // End snippet
        }

        /// <summary>Snippet for GetBrandAsync</summary>
        public async Task GetBrandRequestObjectAsync()
        {
            // Snippet: GetBrandAsync(GetBrandRequest, CallSettings)
            // Additional: GetBrandAsync(GetBrandRequest, CancellationToken)
            // Create client
            IdentityAwareProxyOAuthServiceClient identityAwareProxyOAuthServiceClient = await IdentityAwareProxyOAuthServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBrandRequest request = new GetBrandRequest { Name = "", };
            // Make the request
            Brand response = await identityAwareProxyOAuthServiceClient.GetBrandAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateIdentityAwareProxyClient</summary>
        public void CreateIdentityAwareProxyClientRequestObject()
        {
            // Snippet: CreateIdentityAwareProxyClient(CreateIdentityAwareProxyClientRequest, CallSettings)
            // Create client
            IdentityAwareProxyOAuthServiceClient identityAwareProxyOAuthServiceClient = IdentityAwareProxyOAuthServiceClient.Create();
            // Initialize request argument(s)
            CreateIdentityAwareProxyClientRequest request = new CreateIdentityAwareProxyClientRequest
            {
                Parent = "",
                IdentityAwareProxyClient = new IdentityAwareProxyClient(),
            };
            // Make the request
            IdentityAwareProxyClient response = identityAwareProxyOAuthServiceClient.CreateIdentityAwareProxyClient(request);
            // End snippet
        }

        /// <summary>Snippet for CreateIdentityAwareProxyClientAsync</summary>
        public async Task CreateIdentityAwareProxyClientRequestObjectAsync()
        {
            // Snippet: CreateIdentityAwareProxyClientAsync(CreateIdentityAwareProxyClientRequest, CallSettings)
            // Additional: CreateIdentityAwareProxyClientAsync(CreateIdentityAwareProxyClientRequest, CancellationToken)
            // Create client
            IdentityAwareProxyOAuthServiceClient identityAwareProxyOAuthServiceClient = await IdentityAwareProxyOAuthServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateIdentityAwareProxyClientRequest request = new CreateIdentityAwareProxyClientRequest
            {
                Parent = "",
                IdentityAwareProxyClient = new IdentityAwareProxyClient(),
            };
            // Make the request
            IdentityAwareProxyClient response = await identityAwareProxyOAuthServiceClient.CreateIdentityAwareProxyClientAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListIdentityAwareProxyClients</summary>
        public void ListIdentityAwareProxyClientsRequestObject()
        {
            // Snippet: ListIdentityAwareProxyClients(ListIdentityAwareProxyClientsRequest, CallSettings)
            // Create client
            IdentityAwareProxyOAuthServiceClient identityAwareProxyOAuthServiceClient = IdentityAwareProxyOAuthServiceClient.Create();
            // Initialize request argument(s)
            ListIdentityAwareProxyClientsRequest request = new ListIdentityAwareProxyClientsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListIdentityAwareProxyClientsResponse, IdentityAwareProxyClient> response = identityAwareProxyOAuthServiceClient.ListIdentityAwareProxyClients(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IdentityAwareProxyClient item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIdentityAwareProxyClientsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IdentityAwareProxyClient item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IdentityAwareProxyClient> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IdentityAwareProxyClient item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIdentityAwareProxyClientsAsync</summary>
        public async Task ListIdentityAwareProxyClientsRequestObjectAsync()
        {
            // Snippet: ListIdentityAwareProxyClientsAsync(ListIdentityAwareProxyClientsRequest, CallSettings)
            // Create client
            IdentityAwareProxyOAuthServiceClient identityAwareProxyOAuthServiceClient = await IdentityAwareProxyOAuthServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListIdentityAwareProxyClientsRequest request = new ListIdentityAwareProxyClientsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListIdentityAwareProxyClientsResponse, IdentityAwareProxyClient> response = identityAwareProxyOAuthServiceClient.ListIdentityAwareProxyClientsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IdentityAwareProxyClient item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIdentityAwareProxyClientsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IdentityAwareProxyClient item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IdentityAwareProxyClient> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IdentityAwareProxyClient item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetIdentityAwareProxyClient</summary>
        public void GetIdentityAwareProxyClientRequestObject()
        {
            // Snippet: GetIdentityAwareProxyClient(GetIdentityAwareProxyClientRequest, CallSettings)
            // Create client
            IdentityAwareProxyOAuthServiceClient identityAwareProxyOAuthServiceClient = IdentityAwareProxyOAuthServiceClient.Create();
            // Initialize request argument(s)
            GetIdentityAwareProxyClientRequest request = new GetIdentityAwareProxyClientRequest { Name = "", };
            // Make the request
            IdentityAwareProxyClient response = identityAwareProxyOAuthServiceClient.GetIdentityAwareProxyClient(request);
            // End snippet
        }

        /// <summary>Snippet for GetIdentityAwareProxyClientAsync</summary>
        public async Task GetIdentityAwareProxyClientRequestObjectAsync()
        {
            // Snippet: GetIdentityAwareProxyClientAsync(GetIdentityAwareProxyClientRequest, CallSettings)
            // Additional: GetIdentityAwareProxyClientAsync(GetIdentityAwareProxyClientRequest, CancellationToken)
            // Create client
            IdentityAwareProxyOAuthServiceClient identityAwareProxyOAuthServiceClient = await IdentityAwareProxyOAuthServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIdentityAwareProxyClientRequest request = new GetIdentityAwareProxyClientRequest { Name = "", };
            // Make the request
            IdentityAwareProxyClient response = await identityAwareProxyOAuthServiceClient.GetIdentityAwareProxyClientAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResetIdentityAwareProxyClientSecret</summary>
        public void ResetIdentityAwareProxyClientSecretRequestObject()
        {
            // Snippet: ResetIdentityAwareProxyClientSecret(ResetIdentityAwareProxyClientSecretRequest, CallSettings)
            // Create client
            IdentityAwareProxyOAuthServiceClient identityAwareProxyOAuthServiceClient = IdentityAwareProxyOAuthServiceClient.Create();
            // Initialize request argument(s)
            ResetIdentityAwareProxyClientSecretRequest request = new ResetIdentityAwareProxyClientSecretRequest { Name = "", };
            // Make the request
            IdentityAwareProxyClient response = identityAwareProxyOAuthServiceClient.ResetIdentityAwareProxyClientSecret(request);
            // End snippet
        }

        /// <summary>Snippet for ResetIdentityAwareProxyClientSecretAsync</summary>
        public async Task ResetIdentityAwareProxyClientSecretRequestObjectAsync()
        {
            // Snippet: ResetIdentityAwareProxyClientSecretAsync(ResetIdentityAwareProxyClientSecretRequest, CallSettings)
            // Additional: ResetIdentityAwareProxyClientSecretAsync(ResetIdentityAwareProxyClientSecretRequest, CancellationToken)
            // Create client
            IdentityAwareProxyOAuthServiceClient identityAwareProxyOAuthServiceClient = await IdentityAwareProxyOAuthServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResetIdentityAwareProxyClientSecretRequest request = new ResetIdentityAwareProxyClientSecretRequest { Name = "", };
            // Make the request
            IdentityAwareProxyClient response = await identityAwareProxyOAuthServiceClient.ResetIdentityAwareProxyClientSecretAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIdentityAwareProxyClient</summary>
        public void DeleteIdentityAwareProxyClientRequestObject()
        {
            // Snippet: DeleteIdentityAwareProxyClient(DeleteIdentityAwareProxyClientRequest, CallSettings)
            // Create client
            IdentityAwareProxyOAuthServiceClient identityAwareProxyOAuthServiceClient = IdentityAwareProxyOAuthServiceClient.Create();
            // Initialize request argument(s)
            DeleteIdentityAwareProxyClientRequest request = new DeleteIdentityAwareProxyClientRequest { Name = "", };
            // Make the request
            identityAwareProxyOAuthServiceClient.DeleteIdentityAwareProxyClient(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIdentityAwareProxyClientAsync</summary>
        public async Task DeleteIdentityAwareProxyClientRequestObjectAsync()
        {
            // Snippet: DeleteIdentityAwareProxyClientAsync(DeleteIdentityAwareProxyClientRequest, CallSettings)
            // Additional: DeleteIdentityAwareProxyClientAsync(DeleteIdentityAwareProxyClientRequest, CancellationToken)
            // Create client
            IdentityAwareProxyOAuthServiceClient identityAwareProxyOAuthServiceClient = await IdentityAwareProxyOAuthServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteIdentityAwareProxyClientRequest request = new DeleteIdentityAwareProxyClientRequest { Name = "", };
            // Make the request
            await identityAwareProxyOAuthServiceClient.DeleteIdentityAwareProxyClientAsync(request);
            // End snippet
        }
    }
}
