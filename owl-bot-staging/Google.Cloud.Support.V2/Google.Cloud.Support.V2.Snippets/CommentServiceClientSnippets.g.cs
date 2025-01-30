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
    using Google.Cloud.Support.V2;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCommentServiceClientSnippets
    {
        /// <summary>Snippet for ListComments</summary>
        public void ListCommentsRequestObject()
        {
            // Snippet: ListComments(ListCommentsRequest, CallSettings)
            // Create client
            CommentServiceClient commentServiceClient = CommentServiceClient.Create();
            // Initialize request argument(s)
            ListCommentsRequest request = new ListCommentsRequest
            {
                ParentAsCaseName = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]"),
            };
            // Make the request
            PagedEnumerable<ListCommentsResponse, Comment> response = commentServiceClient.ListComments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Comment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Comment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Comment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Comment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCommentsAsync</summary>
        public async Task ListCommentsRequestObjectAsync()
        {
            // Snippet: ListCommentsAsync(ListCommentsRequest, CallSettings)
            // Create client
            CommentServiceClient commentServiceClient = await CommentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCommentsRequest request = new ListCommentsRequest
            {
                ParentAsCaseName = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCommentsResponse, Comment> response = commentServiceClient.ListCommentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Comment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCommentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Comment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Comment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Comment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListComments</summary>
        public void ListComments()
        {
            // Snippet: ListComments(string, string, int?, CallSettings)
            // Create client
            CommentServiceClient commentServiceClient = CommentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/cases/[CASE]";
            // Make the request
            PagedEnumerable<ListCommentsResponse, Comment> response = commentServiceClient.ListComments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Comment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Comment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Comment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Comment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCommentsAsync</summary>
        public async Task ListCommentsAsync()
        {
            // Snippet: ListCommentsAsync(string, string, int?, CallSettings)
            // Create client
            CommentServiceClient commentServiceClient = await CommentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/cases/[CASE]";
            // Make the request
            PagedAsyncEnumerable<ListCommentsResponse, Comment> response = commentServiceClient.ListCommentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Comment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCommentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Comment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Comment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Comment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListComments</summary>
        public void ListCommentsResourceNames()
        {
            // Snippet: ListComments(CaseName, string, int?, CallSettings)
            // Create client
            CommentServiceClient commentServiceClient = CommentServiceClient.Create();
            // Initialize request argument(s)
            CaseName parent = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]");
            // Make the request
            PagedEnumerable<ListCommentsResponse, Comment> response = commentServiceClient.ListComments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Comment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Comment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Comment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Comment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCommentsAsync</summary>
        public async Task ListCommentsResourceNamesAsync()
        {
            // Snippet: ListCommentsAsync(CaseName, string, int?, CallSettings)
            // Create client
            CommentServiceClient commentServiceClient = await CommentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CaseName parent = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]");
            // Make the request
            PagedAsyncEnumerable<ListCommentsResponse, Comment> response = commentServiceClient.ListCommentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Comment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCommentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Comment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Comment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Comment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateComment</summary>
        public void CreateCommentRequestObject()
        {
            // Snippet: CreateComment(CreateCommentRequest, CallSettings)
            // Create client
            CommentServiceClient commentServiceClient = CommentServiceClient.Create();
            // Initialize request argument(s)
            CreateCommentRequest request = new CreateCommentRequest
            {
                ParentAsCaseName = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]"),
                Comment = new Comment(),
            };
            // Make the request
            Comment response = commentServiceClient.CreateComment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCommentAsync</summary>
        public async Task CreateCommentRequestObjectAsync()
        {
            // Snippet: CreateCommentAsync(CreateCommentRequest, CallSettings)
            // Additional: CreateCommentAsync(CreateCommentRequest, CancellationToken)
            // Create client
            CommentServiceClient commentServiceClient = await CommentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCommentRequest request = new CreateCommentRequest
            {
                ParentAsCaseName = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]"),
                Comment = new Comment(),
            };
            // Make the request
            Comment response = await commentServiceClient.CreateCommentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateComment</summary>
        public void CreateComment()
        {
            // Snippet: CreateComment(string, Comment, CallSettings)
            // Create client
            CommentServiceClient commentServiceClient = CommentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/cases/[CASE]";
            Comment comment = new Comment();
            // Make the request
            Comment response = commentServiceClient.CreateComment(parent, comment);
            // End snippet
        }

        /// <summary>Snippet for CreateCommentAsync</summary>
        public async Task CreateCommentAsync()
        {
            // Snippet: CreateCommentAsync(string, Comment, CallSettings)
            // Additional: CreateCommentAsync(string, Comment, CancellationToken)
            // Create client
            CommentServiceClient commentServiceClient = await CommentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/cases/[CASE]";
            Comment comment = new Comment();
            // Make the request
            Comment response = await commentServiceClient.CreateCommentAsync(parent, comment);
            // End snippet
        }

        /// <summary>Snippet for CreateComment</summary>
        public void CreateCommentResourceNames()
        {
            // Snippet: CreateComment(CaseName, Comment, CallSettings)
            // Create client
            CommentServiceClient commentServiceClient = CommentServiceClient.Create();
            // Initialize request argument(s)
            CaseName parent = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]");
            Comment comment = new Comment();
            // Make the request
            Comment response = commentServiceClient.CreateComment(parent, comment);
            // End snippet
        }

        /// <summary>Snippet for CreateCommentAsync</summary>
        public async Task CreateCommentResourceNamesAsync()
        {
            // Snippet: CreateCommentAsync(CaseName, Comment, CallSettings)
            // Additional: CreateCommentAsync(CaseName, Comment, CancellationToken)
            // Create client
            CommentServiceClient commentServiceClient = await CommentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CaseName parent = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]");
            Comment comment = new Comment();
            // Make the request
            Comment response = await commentServiceClient.CreateCommentAsync(parent, comment);
            // End snippet
        }
    }
}
