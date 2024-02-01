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
    using Google.Cloud.Monitoring.V3;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedNotificationChannelServiceClientSnippets
    {
        /// <summary>Snippet for ListNotificationChannelDescriptors</summary>
        public void ListNotificationChannelDescriptorsRequestObject()
        {
            // Snippet: ListNotificationChannelDescriptors(ListNotificationChannelDescriptorsRequest, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            ListNotificationChannelDescriptorsRequest request = new ListNotificationChannelDescriptorsRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> response = notificationChannelServiceClient.ListNotificationChannelDescriptors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationChannelDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationChannelDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannelDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannelDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannelDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelDescriptorsAsync</summary>
        public async Task ListNotificationChannelDescriptorsRequestObjectAsync()
        {
            // Snippet: ListNotificationChannelDescriptorsAsync(ListNotificationChannelDescriptorsRequest, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNotificationChannelDescriptorsRequest request = new ListNotificationChannelDescriptorsRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> response = notificationChannelServiceClient.ListNotificationChannelDescriptorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationChannelDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationChannelDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannelDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannelDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannelDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelDescriptors</summary>
        public void ListNotificationChannelDescriptors()
        {
            // Snippet: ListNotificationChannelDescriptors(string, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> response = notificationChannelServiceClient.ListNotificationChannelDescriptors(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationChannelDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationChannelDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannelDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannelDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannelDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelDescriptorsAsync</summary>
        public async Task ListNotificationChannelDescriptorsAsync()
        {
            // Snippet: ListNotificationChannelDescriptorsAsync(string, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> response = notificationChannelServiceClient.ListNotificationChannelDescriptorsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationChannelDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationChannelDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannelDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannelDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannelDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelDescriptors</summary>
        public void ListNotificationChannelDescriptorsResourceNames1()
        {
            // Snippet: ListNotificationChannelDescriptors(ProjectName, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> response = notificationChannelServiceClient.ListNotificationChannelDescriptors(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationChannelDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationChannelDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannelDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannelDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannelDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelDescriptorsAsync</summary>
        public async Task ListNotificationChannelDescriptorsResourceNames1Async()
        {
            // Snippet: ListNotificationChannelDescriptorsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> response = notificationChannelServiceClient.ListNotificationChannelDescriptorsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationChannelDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationChannelDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannelDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannelDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannelDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelDescriptors</summary>
        public void ListNotificationChannelDescriptorsResourceNames2()
        {
            // Snippet: ListNotificationChannelDescriptors(OrganizationName, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> response = notificationChannelServiceClient.ListNotificationChannelDescriptors(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationChannelDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationChannelDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannelDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannelDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannelDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelDescriptorsAsync</summary>
        public async Task ListNotificationChannelDescriptorsResourceNames2Async()
        {
            // Snippet: ListNotificationChannelDescriptorsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> response = notificationChannelServiceClient.ListNotificationChannelDescriptorsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationChannelDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationChannelDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannelDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannelDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannelDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelDescriptors</summary>
        public void ListNotificationChannelDescriptorsResourceNames3()
        {
            // Snippet: ListNotificationChannelDescriptors(FolderName, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> response = notificationChannelServiceClient.ListNotificationChannelDescriptors(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationChannelDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationChannelDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannelDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannelDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannelDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelDescriptorsAsync</summary>
        public async Task ListNotificationChannelDescriptorsResourceNames3Async()
        {
            // Snippet: ListNotificationChannelDescriptorsAsync(FolderName, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> response = notificationChannelServiceClient.ListNotificationChannelDescriptorsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationChannelDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationChannelDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannelDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannelDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannelDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelDescriptors</summary>
        public void ListNotificationChannelDescriptorsResourceNames4()
        {
            // Snippet: ListNotificationChannelDescriptors(IResourceName, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> response = notificationChannelServiceClient.ListNotificationChannelDescriptors(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationChannelDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationChannelDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannelDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannelDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannelDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelDescriptorsAsync</summary>
        public async Task ListNotificationChannelDescriptorsResourceNames4Async()
        {
            // Snippet: ListNotificationChannelDescriptorsAsync(IResourceName, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> response = notificationChannelServiceClient.ListNotificationChannelDescriptorsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationChannelDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationChannelDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannelDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannelDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannelDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelDescriptor</summary>
        public void GetNotificationChannelDescriptorRequestObject()
        {
            // Snippet: GetNotificationChannelDescriptor(GetNotificationChannelDescriptorRequest, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            GetNotificationChannelDescriptorRequest request = new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
            };
            // Make the request
            NotificationChannelDescriptor response = notificationChannelServiceClient.GetNotificationChannelDescriptor(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelDescriptorAsync</summary>
        public async Task GetNotificationChannelDescriptorRequestObjectAsync()
        {
            // Snippet: GetNotificationChannelDescriptorAsync(GetNotificationChannelDescriptorRequest, CallSettings)
            // Additional: GetNotificationChannelDescriptorAsync(GetNotificationChannelDescriptorRequest, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNotificationChannelDescriptorRequest request = new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
            };
            // Make the request
            NotificationChannelDescriptor response = await notificationChannelServiceClient.GetNotificationChannelDescriptorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelDescriptor</summary>
        public void GetNotificationChannelDescriptor()
        {
            // Snippet: GetNotificationChannelDescriptor(string, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notificationChannelDescriptors/[CHANNEL_DESCRIPTOR]";
            // Make the request
            NotificationChannelDescriptor response = notificationChannelServiceClient.GetNotificationChannelDescriptor(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelDescriptorAsync</summary>
        public async Task GetNotificationChannelDescriptorAsync()
        {
            // Snippet: GetNotificationChannelDescriptorAsync(string, CallSettings)
            // Additional: GetNotificationChannelDescriptorAsync(string, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notificationChannelDescriptors/[CHANNEL_DESCRIPTOR]";
            // Make the request
            NotificationChannelDescriptor response = await notificationChannelServiceClient.GetNotificationChannelDescriptorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelDescriptor</summary>
        public void GetNotificationChannelDescriptorResourceNames1()
        {
            // Snippet: GetNotificationChannelDescriptor(NotificationChannelDescriptorName, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            NotificationChannelDescriptorName name = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]");
            // Make the request
            NotificationChannelDescriptor response = notificationChannelServiceClient.GetNotificationChannelDescriptor(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelDescriptorAsync</summary>
        public async Task GetNotificationChannelDescriptorResourceNames1Async()
        {
            // Snippet: GetNotificationChannelDescriptorAsync(NotificationChannelDescriptorName, CallSettings)
            // Additional: GetNotificationChannelDescriptorAsync(NotificationChannelDescriptorName, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotificationChannelDescriptorName name = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]");
            // Make the request
            NotificationChannelDescriptor response = await notificationChannelServiceClient.GetNotificationChannelDescriptorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelDescriptor</summary>
        public void GetNotificationChannelDescriptorResourceNames2()
        {
            // Snippet: GetNotificationChannelDescriptor(IResourceName, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            NotificationChannelDescriptor response = notificationChannelServiceClient.GetNotificationChannelDescriptor(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelDescriptorAsync</summary>
        public async Task GetNotificationChannelDescriptorResourceNames2Async()
        {
            // Snippet: GetNotificationChannelDescriptorAsync(IResourceName, CallSettings)
            // Additional: GetNotificationChannelDescriptorAsync(IResourceName, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            NotificationChannelDescriptor response = await notificationChannelServiceClient.GetNotificationChannelDescriptorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannels</summary>
        public void ListNotificationChannelsRequestObject()
        {
            // Snippet: ListNotificationChannels(ListNotificationChannelsRequest, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            ListNotificationChannelsRequest request = new ListNotificationChannelsRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> response = notificationChannelServiceClient.ListNotificationChannels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationChannel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationChannelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelsAsync</summary>
        public async Task ListNotificationChannelsRequestObjectAsync()
        {
            // Snippet: ListNotificationChannelsAsync(ListNotificationChannelsRequest, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNotificationChannelsRequest request = new ListNotificationChannelsRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> response = notificationChannelServiceClient.ListNotificationChannelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationChannel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationChannelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannels</summary>
        public void ListNotificationChannels()
        {
            // Snippet: ListNotificationChannels(string, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> response = notificationChannelServiceClient.ListNotificationChannels(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationChannel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationChannelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelsAsync</summary>
        public async Task ListNotificationChannelsAsync()
        {
            // Snippet: ListNotificationChannelsAsync(string, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> response = notificationChannelServiceClient.ListNotificationChannelsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationChannel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationChannelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannels</summary>
        public void ListNotificationChannelsResourceNames1()
        {
            // Snippet: ListNotificationChannels(ProjectName, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> response = notificationChannelServiceClient.ListNotificationChannels(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationChannel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationChannelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelsAsync</summary>
        public async Task ListNotificationChannelsResourceNames1Async()
        {
            // Snippet: ListNotificationChannelsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> response = notificationChannelServiceClient.ListNotificationChannelsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationChannel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationChannelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannels</summary>
        public void ListNotificationChannelsResourceNames2()
        {
            // Snippet: ListNotificationChannels(OrganizationName, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> response = notificationChannelServiceClient.ListNotificationChannels(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationChannel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationChannelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelsAsync</summary>
        public async Task ListNotificationChannelsResourceNames2Async()
        {
            // Snippet: ListNotificationChannelsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> response = notificationChannelServiceClient.ListNotificationChannelsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationChannel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationChannelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannels</summary>
        public void ListNotificationChannelsResourceNames3()
        {
            // Snippet: ListNotificationChannels(FolderName, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> response = notificationChannelServiceClient.ListNotificationChannels(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationChannel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationChannelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelsAsync</summary>
        public async Task ListNotificationChannelsResourceNames3Async()
        {
            // Snippet: ListNotificationChannelsAsync(FolderName, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> response = notificationChannelServiceClient.ListNotificationChannelsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationChannel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationChannelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannels</summary>
        public void ListNotificationChannelsResourceNames4()
        {
            // Snippet: ListNotificationChannels(IResourceName, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> response = notificationChannelServiceClient.ListNotificationChannels(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationChannel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationChannelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelsAsync</summary>
        public async Task ListNotificationChannelsResourceNames4Async()
        {
            // Snippet: ListNotificationChannelsAsync(IResourceName, string, int?, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> response = notificationChannelServiceClient.ListNotificationChannelsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationChannel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationChannelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannel</summary>
        public void GetNotificationChannelRequestObject()
        {
            // Snippet: GetNotificationChannel(GetNotificationChannelRequest, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            GetNotificationChannelRequest request = new GetNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.GetNotificationChannel(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelAsync</summary>
        public async Task GetNotificationChannelRequestObjectAsync()
        {
            // Snippet: GetNotificationChannelAsync(GetNotificationChannelRequest, CallSettings)
            // Additional: GetNotificationChannelAsync(GetNotificationChannelRequest, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNotificationChannelRequest request = new GetNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.GetNotificationChannelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannel</summary>
        public void GetNotificationChannel()
        {
            // Snippet: GetNotificationChannel(string, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notificationChannels/[NOTIFICATION_CHANNEL]";
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.GetNotificationChannel(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelAsync</summary>
        public async Task GetNotificationChannelAsync()
        {
            // Snippet: GetNotificationChannelAsync(string, CallSettings)
            // Additional: GetNotificationChannelAsync(string, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notificationChannels/[NOTIFICATION_CHANNEL]";
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.GetNotificationChannelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannel</summary>
        public void GetNotificationChannelResourceNames1()
        {
            // Snippet: GetNotificationChannel(NotificationChannelName, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            NotificationChannelName name = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.GetNotificationChannel(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelAsync</summary>
        public async Task GetNotificationChannelResourceNames1Async()
        {
            // Snippet: GetNotificationChannelAsync(NotificationChannelName, CallSettings)
            // Additional: GetNotificationChannelAsync(NotificationChannelName, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotificationChannelName name = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.GetNotificationChannelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannel</summary>
        public void GetNotificationChannelResourceNames2()
        {
            // Snippet: GetNotificationChannel(IResourceName, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.GetNotificationChannel(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelAsync</summary>
        public async Task GetNotificationChannelResourceNames2Async()
        {
            // Snippet: GetNotificationChannelAsync(IResourceName, CallSettings)
            // Additional: GetNotificationChannelAsync(IResourceName, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.GetNotificationChannelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationChannel</summary>
        public void CreateNotificationChannelRequestObject()
        {
            // Snippet: CreateNotificationChannel(CreateNotificationChannelRequest, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.CreateNotificationChannel(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationChannelAsync</summary>
        public async Task CreateNotificationChannelRequestObjectAsync()
        {
            // Snippet: CreateNotificationChannelAsync(CreateNotificationChannelRequest, CallSettings)
            // Additional: CreateNotificationChannelAsync(CreateNotificationChannelRequest, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.CreateNotificationChannelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationChannel</summary>
        public void CreateNotificationChannel()
        {
            // Snippet: CreateNotificationChannel(string, NotificationChannel, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            NotificationChannel notificationChannel = new NotificationChannel();
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.CreateNotificationChannel(name, notificationChannel);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationChannelAsync</summary>
        public async Task CreateNotificationChannelAsync()
        {
            // Snippet: CreateNotificationChannelAsync(string, NotificationChannel, CallSettings)
            // Additional: CreateNotificationChannelAsync(string, NotificationChannel, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            NotificationChannel notificationChannel = new NotificationChannel();
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.CreateNotificationChannelAsync(name, notificationChannel);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationChannel</summary>
        public void CreateNotificationChannelResourceNames1()
        {
            // Snippet: CreateNotificationChannel(ProjectName, NotificationChannel, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            NotificationChannel notificationChannel = new NotificationChannel();
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.CreateNotificationChannel(name, notificationChannel);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationChannelAsync</summary>
        public async Task CreateNotificationChannelResourceNames1Async()
        {
            // Snippet: CreateNotificationChannelAsync(ProjectName, NotificationChannel, CallSettings)
            // Additional: CreateNotificationChannelAsync(ProjectName, NotificationChannel, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            NotificationChannel notificationChannel = new NotificationChannel();
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.CreateNotificationChannelAsync(name, notificationChannel);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationChannel</summary>
        public void CreateNotificationChannelResourceNames2()
        {
            // Snippet: CreateNotificationChannel(OrganizationName, NotificationChannel, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            NotificationChannel notificationChannel = new NotificationChannel();
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.CreateNotificationChannel(name, notificationChannel);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationChannelAsync</summary>
        public async Task CreateNotificationChannelResourceNames2Async()
        {
            // Snippet: CreateNotificationChannelAsync(OrganizationName, NotificationChannel, CallSettings)
            // Additional: CreateNotificationChannelAsync(OrganizationName, NotificationChannel, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            NotificationChannel notificationChannel = new NotificationChannel();
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.CreateNotificationChannelAsync(name, notificationChannel);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationChannel</summary>
        public void CreateNotificationChannelResourceNames3()
        {
            // Snippet: CreateNotificationChannel(FolderName, NotificationChannel, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            NotificationChannel notificationChannel = new NotificationChannel();
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.CreateNotificationChannel(name, notificationChannel);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationChannelAsync</summary>
        public async Task CreateNotificationChannelResourceNames3Async()
        {
            // Snippet: CreateNotificationChannelAsync(FolderName, NotificationChannel, CallSettings)
            // Additional: CreateNotificationChannelAsync(FolderName, NotificationChannel, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            NotificationChannel notificationChannel = new NotificationChannel();
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.CreateNotificationChannelAsync(name, notificationChannel);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationChannel</summary>
        public void CreateNotificationChannelResourceNames4()
        {
            // Snippet: CreateNotificationChannel(IResourceName, NotificationChannel, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            NotificationChannel notificationChannel = new NotificationChannel();
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.CreateNotificationChannel(name, notificationChannel);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationChannelAsync</summary>
        public async Task CreateNotificationChannelResourceNames4Async()
        {
            // Snippet: CreateNotificationChannelAsync(IResourceName, NotificationChannel, CallSettings)
            // Additional: CreateNotificationChannelAsync(IResourceName, NotificationChannel, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            NotificationChannel notificationChannel = new NotificationChannel();
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.CreateNotificationChannelAsync(name, notificationChannel);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotificationChannel</summary>
        public void UpdateNotificationChannelRequestObject()
        {
            // Snippet: UpdateNotificationChannel(UpdateNotificationChannelRequest, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            UpdateNotificationChannelRequest request = new UpdateNotificationChannelRequest
            {
                UpdateMask = new FieldMask(),
                NotificationChannel = new NotificationChannel(),
            };
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.UpdateNotificationChannel(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotificationChannelAsync</summary>
        public async Task UpdateNotificationChannelRequestObjectAsync()
        {
            // Snippet: UpdateNotificationChannelAsync(UpdateNotificationChannelRequest, CallSettings)
            // Additional: UpdateNotificationChannelAsync(UpdateNotificationChannelRequest, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateNotificationChannelRequest request = new UpdateNotificationChannelRequest
            {
                UpdateMask = new FieldMask(),
                NotificationChannel = new NotificationChannel(),
            };
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.UpdateNotificationChannelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotificationChannel</summary>
        public void UpdateNotificationChannel()
        {
            // Snippet: UpdateNotificationChannel(FieldMask, NotificationChannel, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            FieldMask updateMask = new FieldMask();
            NotificationChannel notificationChannel = new NotificationChannel();
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.UpdateNotificationChannel(updateMask, notificationChannel);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotificationChannelAsync</summary>
        public async Task UpdateNotificationChannelAsync()
        {
            // Snippet: UpdateNotificationChannelAsync(FieldMask, NotificationChannel, CallSettings)
            // Additional: UpdateNotificationChannelAsync(FieldMask, NotificationChannel, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            FieldMask updateMask = new FieldMask();
            NotificationChannel notificationChannel = new NotificationChannel();
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.UpdateNotificationChannelAsync(updateMask, notificationChannel);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationChannel</summary>
        public void DeleteNotificationChannelRequestObject()
        {
            // Snippet: DeleteNotificationChannel(DeleteNotificationChannelRequest, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            DeleteNotificationChannelRequest request = new DeleteNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Force = false,
            };
            // Make the request
            notificationChannelServiceClient.DeleteNotificationChannel(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationChannelAsync</summary>
        public async Task DeleteNotificationChannelRequestObjectAsync()
        {
            // Snippet: DeleteNotificationChannelAsync(DeleteNotificationChannelRequest, CallSettings)
            // Additional: DeleteNotificationChannelAsync(DeleteNotificationChannelRequest, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNotificationChannelRequest request = new DeleteNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Force = false,
            };
            // Make the request
            await notificationChannelServiceClient.DeleteNotificationChannelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationChannel</summary>
        public void DeleteNotificationChannel()
        {
            // Snippet: DeleteNotificationChannel(string, bool, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notificationChannels/[NOTIFICATION_CHANNEL]";
            bool force = false;
            // Make the request
            notificationChannelServiceClient.DeleteNotificationChannel(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationChannelAsync</summary>
        public async Task DeleteNotificationChannelAsync()
        {
            // Snippet: DeleteNotificationChannelAsync(string, bool, CallSettings)
            // Additional: DeleteNotificationChannelAsync(string, bool, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notificationChannels/[NOTIFICATION_CHANNEL]";
            bool force = false;
            // Make the request
            await notificationChannelServiceClient.DeleteNotificationChannelAsync(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationChannel</summary>
        public void DeleteNotificationChannelResourceNames1()
        {
            // Snippet: DeleteNotificationChannel(NotificationChannelName, bool, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            NotificationChannelName name = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            bool force = false;
            // Make the request
            notificationChannelServiceClient.DeleteNotificationChannel(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationChannelAsync</summary>
        public async Task DeleteNotificationChannelResourceNames1Async()
        {
            // Snippet: DeleteNotificationChannelAsync(NotificationChannelName, bool, CallSettings)
            // Additional: DeleteNotificationChannelAsync(NotificationChannelName, bool, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotificationChannelName name = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            bool force = false;
            // Make the request
            await notificationChannelServiceClient.DeleteNotificationChannelAsync(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationChannel</summary>
        public void DeleteNotificationChannelResourceNames2()
        {
            // Snippet: DeleteNotificationChannel(IResourceName, bool, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            bool force = false;
            // Make the request
            notificationChannelServiceClient.DeleteNotificationChannel(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationChannelAsync</summary>
        public async Task DeleteNotificationChannelResourceNames2Async()
        {
            // Snippet: DeleteNotificationChannelAsync(IResourceName, bool, CallSettings)
            // Additional: DeleteNotificationChannelAsync(IResourceName, bool, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            bool force = false;
            // Make the request
            await notificationChannelServiceClient.DeleteNotificationChannelAsync(name, force);
            // End snippet
        }

        /// <summary>Snippet for SendNotificationChannelVerificationCode</summary>
        public void SendNotificationChannelVerificationCodeRequestObject()
        {
            // Snippet: SendNotificationChannelVerificationCode(SendNotificationChannelVerificationCodeRequest, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            SendNotificationChannelVerificationCodeRequest request = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            // Make the request
            notificationChannelServiceClient.SendNotificationChannelVerificationCode(request);
            // End snippet
        }

        /// <summary>Snippet for SendNotificationChannelVerificationCodeAsync</summary>
        public async Task SendNotificationChannelVerificationCodeRequestObjectAsync()
        {
            // Snippet: SendNotificationChannelVerificationCodeAsync(SendNotificationChannelVerificationCodeRequest, CallSettings)
            // Additional: SendNotificationChannelVerificationCodeAsync(SendNotificationChannelVerificationCodeRequest, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            SendNotificationChannelVerificationCodeRequest request = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            // Make the request
            await notificationChannelServiceClient.SendNotificationChannelVerificationCodeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SendNotificationChannelVerificationCode</summary>
        public void SendNotificationChannelVerificationCode()
        {
            // Snippet: SendNotificationChannelVerificationCode(string, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notificationChannels/[NOTIFICATION_CHANNEL]";
            // Make the request
            notificationChannelServiceClient.SendNotificationChannelVerificationCode(name);
            // End snippet
        }

        /// <summary>Snippet for SendNotificationChannelVerificationCodeAsync</summary>
        public async Task SendNotificationChannelVerificationCodeAsync()
        {
            // Snippet: SendNotificationChannelVerificationCodeAsync(string, CallSettings)
            // Additional: SendNotificationChannelVerificationCodeAsync(string, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notificationChannels/[NOTIFICATION_CHANNEL]";
            // Make the request
            await notificationChannelServiceClient.SendNotificationChannelVerificationCodeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SendNotificationChannelVerificationCode</summary>
        public void SendNotificationChannelVerificationCodeResourceNames1()
        {
            // Snippet: SendNotificationChannelVerificationCode(NotificationChannelName, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            NotificationChannelName name = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            // Make the request
            notificationChannelServiceClient.SendNotificationChannelVerificationCode(name);
            // End snippet
        }

        /// <summary>Snippet for SendNotificationChannelVerificationCodeAsync</summary>
        public async Task SendNotificationChannelVerificationCodeResourceNames1Async()
        {
            // Snippet: SendNotificationChannelVerificationCodeAsync(NotificationChannelName, CallSettings)
            // Additional: SendNotificationChannelVerificationCodeAsync(NotificationChannelName, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotificationChannelName name = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            // Make the request
            await notificationChannelServiceClient.SendNotificationChannelVerificationCodeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SendNotificationChannelVerificationCode</summary>
        public void SendNotificationChannelVerificationCodeResourceNames2()
        {
            // Snippet: SendNotificationChannelVerificationCode(IResourceName, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            notificationChannelServiceClient.SendNotificationChannelVerificationCode(name);
            // End snippet
        }

        /// <summary>Snippet for SendNotificationChannelVerificationCodeAsync</summary>
        public async Task SendNotificationChannelVerificationCodeResourceNames2Async()
        {
            // Snippet: SendNotificationChannelVerificationCodeAsync(IResourceName, CallSettings)
            // Additional: SendNotificationChannelVerificationCodeAsync(IResourceName, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            await notificationChannelServiceClient.SendNotificationChannelVerificationCodeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelVerificationCode</summary>
        public void GetNotificationChannelVerificationCodeRequestObject()
        {
            // Snippet: GetNotificationChannelVerificationCode(GetNotificationChannelVerificationCodeRequest, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            GetNotificationChannelVerificationCodeRequest request = new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                ExpireTime = new Timestamp(),
            };
            // Make the request
            GetNotificationChannelVerificationCodeResponse response = notificationChannelServiceClient.GetNotificationChannelVerificationCode(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelVerificationCodeAsync</summary>
        public async Task GetNotificationChannelVerificationCodeRequestObjectAsync()
        {
            // Snippet: GetNotificationChannelVerificationCodeAsync(GetNotificationChannelVerificationCodeRequest, CallSettings)
            // Additional: GetNotificationChannelVerificationCodeAsync(GetNotificationChannelVerificationCodeRequest, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNotificationChannelVerificationCodeRequest request = new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                ExpireTime = new Timestamp(),
            };
            // Make the request
            GetNotificationChannelVerificationCodeResponse response = await notificationChannelServiceClient.GetNotificationChannelVerificationCodeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelVerificationCode</summary>
        public void GetNotificationChannelVerificationCode()
        {
            // Snippet: GetNotificationChannelVerificationCode(string, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notificationChannels/[NOTIFICATION_CHANNEL]";
            // Make the request
            GetNotificationChannelVerificationCodeResponse response = notificationChannelServiceClient.GetNotificationChannelVerificationCode(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelVerificationCodeAsync</summary>
        public async Task GetNotificationChannelVerificationCodeAsync()
        {
            // Snippet: GetNotificationChannelVerificationCodeAsync(string, CallSettings)
            // Additional: GetNotificationChannelVerificationCodeAsync(string, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notificationChannels/[NOTIFICATION_CHANNEL]";
            // Make the request
            GetNotificationChannelVerificationCodeResponse response = await notificationChannelServiceClient.GetNotificationChannelVerificationCodeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelVerificationCode</summary>
        public void GetNotificationChannelVerificationCodeResourceNames1()
        {
            // Snippet: GetNotificationChannelVerificationCode(NotificationChannelName, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            NotificationChannelName name = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            // Make the request
            GetNotificationChannelVerificationCodeResponse response = notificationChannelServiceClient.GetNotificationChannelVerificationCode(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelVerificationCodeAsync</summary>
        public async Task GetNotificationChannelVerificationCodeResourceNames1Async()
        {
            // Snippet: GetNotificationChannelVerificationCodeAsync(NotificationChannelName, CallSettings)
            // Additional: GetNotificationChannelVerificationCodeAsync(NotificationChannelName, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotificationChannelName name = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            // Make the request
            GetNotificationChannelVerificationCodeResponse response = await notificationChannelServiceClient.GetNotificationChannelVerificationCodeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelVerificationCode</summary>
        public void GetNotificationChannelVerificationCodeResourceNames2()
        {
            // Snippet: GetNotificationChannelVerificationCode(IResourceName, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            GetNotificationChannelVerificationCodeResponse response = notificationChannelServiceClient.GetNotificationChannelVerificationCode(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelVerificationCodeAsync</summary>
        public async Task GetNotificationChannelVerificationCodeResourceNames2Async()
        {
            // Snippet: GetNotificationChannelVerificationCodeAsync(IResourceName, CallSettings)
            // Additional: GetNotificationChannelVerificationCodeAsync(IResourceName, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            GetNotificationChannelVerificationCodeResponse response = await notificationChannelServiceClient.GetNotificationChannelVerificationCodeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for VerifyNotificationChannel</summary>
        public void VerifyNotificationChannelRequestObject()
        {
            // Snippet: VerifyNotificationChannel(VerifyNotificationChannelRequest, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            VerifyNotificationChannelRequest request = new VerifyNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Code = "",
            };
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.VerifyNotificationChannel(request);
            // End snippet
        }

        /// <summary>Snippet for VerifyNotificationChannelAsync</summary>
        public async Task VerifyNotificationChannelRequestObjectAsync()
        {
            // Snippet: VerifyNotificationChannelAsync(VerifyNotificationChannelRequest, CallSettings)
            // Additional: VerifyNotificationChannelAsync(VerifyNotificationChannelRequest, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            VerifyNotificationChannelRequest request = new VerifyNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Code = "",
            };
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.VerifyNotificationChannelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for VerifyNotificationChannel</summary>
        public void VerifyNotificationChannel()
        {
            // Snippet: VerifyNotificationChannel(string, string, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notificationChannels/[NOTIFICATION_CHANNEL]";
            string code = "";
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.VerifyNotificationChannel(name, code);
            // End snippet
        }

        /// <summary>Snippet for VerifyNotificationChannelAsync</summary>
        public async Task VerifyNotificationChannelAsync()
        {
            // Snippet: VerifyNotificationChannelAsync(string, string, CallSettings)
            // Additional: VerifyNotificationChannelAsync(string, string, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notificationChannels/[NOTIFICATION_CHANNEL]";
            string code = "";
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.VerifyNotificationChannelAsync(name, code);
            // End snippet
        }

        /// <summary>Snippet for VerifyNotificationChannel</summary>
        public void VerifyNotificationChannelResourceNames1()
        {
            // Snippet: VerifyNotificationChannel(NotificationChannelName, string, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            NotificationChannelName name = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            string code = "";
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.VerifyNotificationChannel(name, code);
            // End snippet
        }

        /// <summary>Snippet for VerifyNotificationChannelAsync</summary>
        public async Task VerifyNotificationChannelResourceNames1Async()
        {
            // Snippet: VerifyNotificationChannelAsync(NotificationChannelName, string, CallSettings)
            // Additional: VerifyNotificationChannelAsync(NotificationChannelName, string, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotificationChannelName name = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            string code = "";
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.VerifyNotificationChannelAsync(name, code);
            // End snippet
        }

        /// <summary>Snippet for VerifyNotificationChannel</summary>
        public void VerifyNotificationChannelResourceNames2()
        {
            // Snippet: VerifyNotificationChannel(IResourceName, string, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            string code = "";
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.VerifyNotificationChannel(name, code);
            // End snippet
        }

        /// <summary>Snippet for VerifyNotificationChannelAsync</summary>
        public async Task VerifyNotificationChannelResourceNames2Async()
        {
            // Snippet: VerifyNotificationChannelAsync(IResourceName, string, CallSettings)
            // Additional: VerifyNotificationChannelAsync(IResourceName, string, CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            string code = "";
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.VerifyNotificationChannelAsync(name, code);
            // End snippet
        }
    }
}
