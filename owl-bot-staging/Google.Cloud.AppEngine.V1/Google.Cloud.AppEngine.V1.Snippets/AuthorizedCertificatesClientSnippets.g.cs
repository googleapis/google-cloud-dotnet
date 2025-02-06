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
    using Google.Cloud.AppEngine.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAuthorizedCertificatesClientSnippets
    {
        /// <summary>Snippet for ListAuthorizedCertificates</summary>
        public void ListAuthorizedCertificatesRequestObject()
        {
            // Snippet: ListAuthorizedCertificates(ListAuthorizedCertificatesRequest, CallSettings)
            // Create client
            AuthorizedCertificatesClient authorizedCertificatesClient = AuthorizedCertificatesClient.Create();
            // Initialize request argument(s)
            ListAuthorizedCertificatesRequest request = new ListAuthorizedCertificatesRequest
            {
                Parent = "",
                View = AuthorizedCertificateView.BasicCertificate,
            };
            // Make the request
            PagedEnumerable<ListAuthorizedCertificatesResponse, AuthorizedCertificate> response = authorizedCertificatesClient.ListAuthorizedCertificates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AuthorizedCertificate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAuthorizedCertificatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthorizedCertificate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthorizedCertificate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthorizedCertificate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthorizedCertificatesAsync</summary>
        public async Task ListAuthorizedCertificatesRequestObjectAsync()
        {
            // Snippet: ListAuthorizedCertificatesAsync(ListAuthorizedCertificatesRequest, CallSettings)
            // Create client
            AuthorizedCertificatesClient authorizedCertificatesClient = await AuthorizedCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            ListAuthorizedCertificatesRequest request = new ListAuthorizedCertificatesRequest
            {
                Parent = "",
                View = AuthorizedCertificateView.BasicCertificate,
            };
            // Make the request
            PagedAsyncEnumerable<ListAuthorizedCertificatesResponse, AuthorizedCertificate> response = authorizedCertificatesClient.ListAuthorizedCertificatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AuthorizedCertificate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAuthorizedCertificatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthorizedCertificate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthorizedCertificate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthorizedCertificate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizedCertificate</summary>
        public void GetAuthorizedCertificateRequestObject()
        {
            // Snippet: GetAuthorizedCertificate(GetAuthorizedCertificateRequest, CallSettings)
            // Create client
            AuthorizedCertificatesClient authorizedCertificatesClient = AuthorizedCertificatesClient.Create();
            // Initialize request argument(s)
            GetAuthorizedCertificateRequest request = new GetAuthorizedCertificateRequest
            {
                Name = "",
                View = AuthorizedCertificateView.BasicCertificate,
            };
            // Make the request
            AuthorizedCertificate response = authorizedCertificatesClient.GetAuthorizedCertificate(request);
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizedCertificateAsync</summary>
        public async Task GetAuthorizedCertificateRequestObjectAsync()
        {
            // Snippet: GetAuthorizedCertificateAsync(GetAuthorizedCertificateRequest, CallSettings)
            // Additional: GetAuthorizedCertificateAsync(GetAuthorizedCertificateRequest, CancellationToken)
            // Create client
            AuthorizedCertificatesClient authorizedCertificatesClient = await AuthorizedCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            GetAuthorizedCertificateRequest request = new GetAuthorizedCertificateRequest
            {
                Name = "",
                View = AuthorizedCertificateView.BasicCertificate,
            };
            // Make the request
            AuthorizedCertificate response = await authorizedCertificatesClient.GetAuthorizedCertificateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAuthorizedCertificate</summary>
        public void CreateAuthorizedCertificateRequestObject()
        {
            // Snippet: CreateAuthorizedCertificate(CreateAuthorizedCertificateRequest, CallSettings)
            // Create client
            AuthorizedCertificatesClient authorizedCertificatesClient = AuthorizedCertificatesClient.Create();
            // Initialize request argument(s)
            CreateAuthorizedCertificateRequest request = new CreateAuthorizedCertificateRequest
            {
                Parent = "",
                Certificate = new AuthorizedCertificate(),
            };
            // Make the request
            AuthorizedCertificate response = authorizedCertificatesClient.CreateAuthorizedCertificate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAuthorizedCertificateAsync</summary>
        public async Task CreateAuthorizedCertificateRequestObjectAsync()
        {
            // Snippet: CreateAuthorizedCertificateAsync(CreateAuthorizedCertificateRequest, CallSettings)
            // Additional: CreateAuthorizedCertificateAsync(CreateAuthorizedCertificateRequest, CancellationToken)
            // Create client
            AuthorizedCertificatesClient authorizedCertificatesClient = await AuthorizedCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            CreateAuthorizedCertificateRequest request = new CreateAuthorizedCertificateRequest
            {
                Parent = "",
                Certificate = new AuthorizedCertificate(),
            };
            // Make the request
            AuthorizedCertificate response = await authorizedCertificatesClient.CreateAuthorizedCertificateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAuthorizedCertificate</summary>
        public void UpdateAuthorizedCertificateRequestObject()
        {
            // Snippet: UpdateAuthorizedCertificate(UpdateAuthorizedCertificateRequest, CallSettings)
            // Create client
            AuthorizedCertificatesClient authorizedCertificatesClient = AuthorizedCertificatesClient.Create();
            // Initialize request argument(s)
            UpdateAuthorizedCertificateRequest request = new UpdateAuthorizedCertificateRequest
            {
                Name = "",
                Certificate = new AuthorizedCertificate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AuthorizedCertificate response = authorizedCertificatesClient.UpdateAuthorizedCertificate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAuthorizedCertificateAsync</summary>
        public async Task UpdateAuthorizedCertificateRequestObjectAsync()
        {
            // Snippet: UpdateAuthorizedCertificateAsync(UpdateAuthorizedCertificateRequest, CallSettings)
            // Additional: UpdateAuthorizedCertificateAsync(UpdateAuthorizedCertificateRequest, CancellationToken)
            // Create client
            AuthorizedCertificatesClient authorizedCertificatesClient = await AuthorizedCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAuthorizedCertificateRequest request = new UpdateAuthorizedCertificateRequest
            {
                Name = "",
                Certificate = new AuthorizedCertificate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AuthorizedCertificate response = await authorizedCertificatesClient.UpdateAuthorizedCertificateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthorizedCertificate</summary>
        public void DeleteAuthorizedCertificateRequestObject()
        {
            // Snippet: DeleteAuthorizedCertificate(DeleteAuthorizedCertificateRequest, CallSettings)
            // Create client
            AuthorizedCertificatesClient authorizedCertificatesClient = AuthorizedCertificatesClient.Create();
            // Initialize request argument(s)
            DeleteAuthorizedCertificateRequest request = new DeleteAuthorizedCertificateRequest { Name = "", };
            // Make the request
            authorizedCertificatesClient.DeleteAuthorizedCertificate(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthorizedCertificateAsync</summary>
        public async Task DeleteAuthorizedCertificateRequestObjectAsync()
        {
            // Snippet: DeleteAuthorizedCertificateAsync(DeleteAuthorizedCertificateRequest, CallSettings)
            // Additional: DeleteAuthorizedCertificateAsync(DeleteAuthorizedCertificateRequest, CancellationToken)
            // Create client
            AuthorizedCertificatesClient authorizedCertificatesClient = await AuthorizedCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAuthorizedCertificateRequest request = new DeleteAuthorizedCertificateRequest { Name = "", };
            // Make the request
            await authorizedCertificatesClient.DeleteAuthorizedCertificateAsync(request);
            // End snippet
        }
    }
}
