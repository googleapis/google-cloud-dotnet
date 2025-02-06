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
    using Google.Cloud.Iam.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataplex.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedContentServiceClientSnippets
    {
        /// <summary>Snippet for CreateContent</summary>
        public void CreateContentRequestObject()
        {
            // Snippet: CreateContent(CreateContentRequest, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateContentRequest request = new gcdv::CreateContentRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Content = new gcdv::Content(),
                ValidateOnly = false,
            };
            // Make the request
            gcdv::Content response = contentServiceClient.CreateContent(request);
            // End snippet
        }

        /// <summary>Snippet for CreateContentAsync</summary>
        public async Task CreateContentRequestObjectAsync()
        {
            // Snippet: CreateContentAsync(CreateContentRequest, CallSettings)
            // Additional: CreateContentAsync(CreateContentRequest, CancellationToken)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateContentRequest request = new gcdv::CreateContentRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Content = new gcdv::Content(),
                ValidateOnly = false,
            };
            // Make the request
            gcdv::Content response = await contentServiceClient.CreateContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateContent</summary>
        public void CreateContent()
        {
            // Snippet: CreateContent(string, Content, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            gcdv::Content content = new gcdv::Content();
            // Make the request
            gcdv::Content response = contentServiceClient.CreateContent(parent, content);
            // End snippet
        }

        /// <summary>Snippet for CreateContentAsync</summary>
        public async Task CreateContentAsync()
        {
            // Snippet: CreateContentAsync(string, Content, CallSettings)
            // Additional: CreateContentAsync(string, Content, CancellationToken)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            gcdv::Content content = new gcdv::Content();
            // Make the request
            gcdv::Content response = await contentServiceClient.CreateContentAsync(parent, content);
            // End snippet
        }

        /// <summary>Snippet for CreateContent</summary>
        public void CreateContentResourceNames()
        {
            // Snippet: CreateContent(LakeName, Content, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            gcdv::Content content = new gcdv::Content();
            // Make the request
            gcdv::Content response = contentServiceClient.CreateContent(parent, content);
            // End snippet
        }

        /// <summary>Snippet for CreateContentAsync</summary>
        public async Task CreateContentResourceNamesAsync()
        {
            // Snippet: CreateContentAsync(LakeName, Content, CallSettings)
            // Additional: CreateContentAsync(LakeName, Content, CancellationToken)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            gcdv::Content content = new gcdv::Content();
            // Make the request
            gcdv::Content response = await contentServiceClient.CreateContentAsync(parent, content);
            // End snippet
        }

        /// <summary>Snippet for UpdateContent</summary>
        public void UpdateContentRequestObject()
        {
            // Snippet: UpdateContent(UpdateContentRequest, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateContentRequest request = new gcdv::UpdateContentRequest
            {
                UpdateMask = new FieldMask(),
                Content = new gcdv::Content(),
                ValidateOnly = false,
            };
            // Make the request
            gcdv::Content response = contentServiceClient.UpdateContent(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateContentAsync</summary>
        public async Task UpdateContentRequestObjectAsync()
        {
            // Snippet: UpdateContentAsync(UpdateContentRequest, CallSettings)
            // Additional: UpdateContentAsync(UpdateContentRequest, CancellationToken)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateContentRequest request = new gcdv::UpdateContentRequest
            {
                UpdateMask = new FieldMask(),
                Content = new gcdv::Content(),
                ValidateOnly = false,
            };
            // Make the request
            gcdv::Content response = await contentServiceClient.UpdateContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateContent</summary>
        public void UpdateContent()
        {
            // Snippet: UpdateContent(Content, FieldMask, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            gcdv::Content content = new gcdv::Content();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::Content response = contentServiceClient.UpdateContent(content, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateContentAsync</summary>
        public async Task UpdateContentAsync()
        {
            // Snippet: UpdateContentAsync(Content, FieldMask, CallSettings)
            // Additional: UpdateContentAsync(Content, FieldMask, CancellationToken)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::Content content = new gcdv::Content();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::Content response = await contentServiceClient.UpdateContentAsync(content, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteContent</summary>
        public void DeleteContentRequestObject()
        {
            // Snippet: DeleteContent(DeleteContentRequest, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteContentRequest request = new gcdv::DeleteContentRequest
            {
                ContentName = gcdv::ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
            };
            // Make the request
            contentServiceClient.DeleteContent(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteContentAsync</summary>
        public async Task DeleteContentRequestObjectAsync()
        {
            // Snippet: DeleteContentAsync(DeleteContentRequest, CallSettings)
            // Additional: DeleteContentAsync(DeleteContentRequest, CancellationToken)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteContentRequest request = new gcdv::DeleteContentRequest
            {
                ContentName = gcdv::ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
            };
            // Make the request
            await contentServiceClient.DeleteContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteContent</summary>
        public void DeleteContent()
        {
            // Snippet: DeleteContent(string, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/content/[CONTENT]";
            // Make the request
            contentServiceClient.DeleteContent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteContentAsync</summary>
        public async Task DeleteContentAsync()
        {
            // Snippet: DeleteContentAsync(string, CallSettings)
            // Additional: DeleteContentAsync(string, CancellationToken)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/content/[CONTENT]";
            // Make the request
            await contentServiceClient.DeleteContentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteContent</summary>
        public void DeleteContentResourceNames()
        {
            // Snippet: DeleteContent(ContentName, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ContentName name = gcdv::ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]");
            // Make the request
            contentServiceClient.DeleteContent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteContentAsync</summary>
        public async Task DeleteContentResourceNamesAsync()
        {
            // Snippet: DeleteContentAsync(ContentName, CallSettings)
            // Additional: DeleteContentAsync(ContentName, CancellationToken)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ContentName name = gcdv::ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]");
            // Make the request
            await contentServiceClient.DeleteContentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetContent</summary>
        public void GetContentRequestObject()
        {
            // Snippet: GetContent(GetContentRequest, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetContentRequest request = new gcdv::GetContentRequest
            {
                ContentName = gcdv::ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                View = gcdv::GetContentRequest.Types.ContentView.Unspecified,
            };
            // Make the request
            gcdv::Content response = contentServiceClient.GetContent(request);
            // End snippet
        }

        /// <summary>Snippet for GetContentAsync</summary>
        public async Task GetContentRequestObjectAsync()
        {
            // Snippet: GetContentAsync(GetContentRequest, CallSettings)
            // Additional: GetContentAsync(GetContentRequest, CancellationToken)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetContentRequest request = new gcdv::GetContentRequest
            {
                ContentName = gcdv::ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                View = gcdv::GetContentRequest.Types.ContentView.Unspecified,
            };
            // Make the request
            gcdv::Content response = await contentServiceClient.GetContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetContent</summary>
        public void GetContent()
        {
            // Snippet: GetContent(string, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/content/[CONTENT]";
            // Make the request
            gcdv::Content response = contentServiceClient.GetContent(name);
            // End snippet
        }

        /// <summary>Snippet for GetContentAsync</summary>
        public async Task GetContentAsync()
        {
            // Snippet: GetContentAsync(string, CallSettings)
            // Additional: GetContentAsync(string, CancellationToken)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/content/[CONTENT]";
            // Make the request
            gcdv::Content response = await contentServiceClient.GetContentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetContent</summary>
        public void GetContentResourceNames()
        {
            // Snippet: GetContent(ContentName, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ContentName name = gcdv::ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]");
            // Make the request
            gcdv::Content response = contentServiceClient.GetContent(name);
            // End snippet
        }

        /// <summary>Snippet for GetContentAsync</summary>
        public async Task GetContentResourceNamesAsync()
        {
            // Snippet: GetContentAsync(ContentName, CallSettings)
            // Additional: GetContentAsync(ContentName, CancellationToken)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ContentName name = gcdv::ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]");
            // Make the request
            gcdv::Content response = await contentServiceClient.GetContentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = contentServiceClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await contentServiceClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = contentServiceClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await contentServiceClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = contentServiceClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await contentServiceClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = contentServiceClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await contentServiceClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = contentServiceClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await contentServiceClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListContent</summary>
        public void ListContentRequestObject()
        {
            // Snippet: ListContent(ListContentRequest, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListContentRequest request = new gcdv::ListContentRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListContentResponse, gcdv::Content> response = contentServiceClient.ListContent(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Content item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListContentResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Content item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Content> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Content item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContentAsync</summary>
        public async Task ListContentRequestObjectAsync()
        {
            // Snippet: ListContentAsync(ListContentRequest, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListContentRequest request = new gcdv::ListContentRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListContentResponse, gcdv::Content> response = contentServiceClient.ListContentAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Content item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListContentResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Content item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Content> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Content item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContent</summary>
        public void ListContent()
        {
            // Snippet: ListContent(string, string, int?, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            PagedEnumerable<gcdv::ListContentResponse, gcdv::Content> response = contentServiceClient.ListContent(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Content item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListContentResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Content item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Content> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Content item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContentAsync</summary>
        public async Task ListContentAsync()
        {
            // Snippet: ListContentAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListContentResponse, gcdv::Content> response = contentServiceClient.ListContentAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Content item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListContentResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Content item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Content> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Content item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContent</summary>
        public void ListContentResourceNames()
        {
            // Snippet: ListContent(LakeName, string, int?, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = gcdv::ContentServiceClient.Create();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            PagedEnumerable<gcdv::ListContentResponse, gcdv::Content> response = contentServiceClient.ListContent(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Content item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListContentResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Content item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Content> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Content item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContentAsync</summary>
        public async Task ListContentResourceNamesAsync()
        {
            // Snippet: ListContentAsync(LakeName, string, int?, CallSettings)
            // Create client
            gcdv::ContentServiceClient contentServiceClient = await gcdv::ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListContentResponse, gcdv::Content> response = contentServiceClient.ListContentAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Content item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListContentResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Content item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Content> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Content item in singlePage)
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
