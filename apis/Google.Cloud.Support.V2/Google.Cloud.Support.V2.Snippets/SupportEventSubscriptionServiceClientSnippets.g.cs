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
    using Google.Cloud.Support.V2;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSupportEventSubscriptionServiceClientSnippets
    {
        /// <summary>Snippet for CreateSupportEventSubscription</summary>
        public void CreateSupportEventSubscriptionRequestObject()
        {
            // Snippet: CreateSupportEventSubscription(CreateSupportEventSubscriptionRequest, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = SupportEventSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            CreateSupportEventSubscriptionRequest request = new CreateSupportEventSubscriptionRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                SupportEventSubscription = new SupportEventSubscription(),
            };
            // Make the request
            SupportEventSubscription response = supportEventSubscriptionServiceClient.CreateSupportEventSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSupportEventSubscriptionAsync</summary>
        public async Task CreateSupportEventSubscriptionRequestObjectAsync()
        {
            // Snippet: CreateSupportEventSubscriptionAsync(CreateSupportEventSubscriptionRequest, CallSettings)
            // Additional: CreateSupportEventSubscriptionAsync(CreateSupportEventSubscriptionRequest, CancellationToken)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = await SupportEventSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSupportEventSubscriptionRequest request = new CreateSupportEventSubscriptionRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                SupportEventSubscription = new SupportEventSubscription(),
            };
            // Make the request
            SupportEventSubscription response = await supportEventSubscriptionServiceClient.CreateSupportEventSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSupportEventSubscription</summary>
        public void CreateSupportEventSubscription()
        {
            // Snippet: CreateSupportEventSubscription(string, SupportEventSubscription, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = SupportEventSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            SupportEventSubscription supportEventSubscription = new SupportEventSubscription();
            // Make the request
            SupportEventSubscription response = supportEventSubscriptionServiceClient.CreateSupportEventSubscription(parent, supportEventSubscription);
            // End snippet
        }

        /// <summary>Snippet for CreateSupportEventSubscriptionAsync</summary>
        public async Task CreateSupportEventSubscriptionAsync()
        {
            // Snippet: CreateSupportEventSubscriptionAsync(string, SupportEventSubscription, CallSettings)
            // Additional: CreateSupportEventSubscriptionAsync(string, SupportEventSubscription, CancellationToken)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = await SupportEventSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            SupportEventSubscription supportEventSubscription = new SupportEventSubscription();
            // Make the request
            SupportEventSubscription response = await supportEventSubscriptionServiceClient.CreateSupportEventSubscriptionAsync(parent, supportEventSubscription);
            // End snippet
        }

        /// <summary>Snippet for CreateSupportEventSubscription</summary>
        public void CreateSupportEventSubscriptionResourceNames()
        {
            // Snippet: CreateSupportEventSubscription(OrganizationName, SupportEventSubscription, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = SupportEventSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            SupportEventSubscription supportEventSubscription = new SupportEventSubscription();
            // Make the request
            SupportEventSubscription response = supportEventSubscriptionServiceClient.CreateSupportEventSubscription(parent, supportEventSubscription);
            // End snippet
        }

        /// <summary>Snippet for CreateSupportEventSubscriptionAsync</summary>
        public async Task CreateSupportEventSubscriptionResourceNamesAsync()
        {
            // Snippet: CreateSupportEventSubscriptionAsync(OrganizationName, SupportEventSubscription, CallSettings)
            // Additional: CreateSupportEventSubscriptionAsync(OrganizationName, SupportEventSubscription, CancellationToken)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = await SupportEventSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            SupportEventSubscription supportEventSubscription = new SupportEventSubscription();
            // Make the request
            SupportEventSubscription response = await supportEventSubscriptionServiceClient.CreateSupportEventSubscriptionAsync(parent, supportEventSubscription);
            // End snippet
        }

        /// <summary>Snippet for GetSupportEventSubscription</summary>
        public void GetSupportEventSubscriptionRequestObject()
        {
            // Snippet: GetSupportEventSubscription(GetSupportEventSubscriptionRequest, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = SupportEventSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            GetSupportEventSubscriptionRequest request = new GetSupportEventSubscriptionRequest
            {
                SupportEventSubscriptionName = SupportEventSubscriptionName.FromOrganizationSupportEventSubscription("[ORGANIZATION]", "[SUPPORT_EVENT_SUBSCRIPTION]"),
            };
            // Make the request
            SupportEventSubscription response = supportEventSubscriptionServiceClient.GetSupportEventSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for GetSupportEventSubscriptionAsync</summary>
        public async Task GetSupportEventSubscriptionRequestObjectAsync()
        {
            // Snippet: GetSupportEventSubscriptionAsync(GetSupportEventSubscriptionRequest, CallSettings)
            // Additional: GetSupportEventSubscriptionAsync(GetSupportEventSubscriptionRequest, CancellationToken)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = await SupportEventSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSupportEventSubscriptionRequest request = new GetSupportEventSubscriptionRequest
            {
                SupportEventSubscriptionName = SupportEventSubscriptionName.FromOrganizationSupportEventSubscription("[ORGANIZATION]", "[SUPPORT_EVENT_SUBSCRIPTION]"),
            };
            // Make the request
            SupportEventSubscription response = await supportEventSubscriptionServiceClient.GetSupportEventSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSupportEventSubscription</summary>
        public void GetSupportEventSubscription()
        {
            // Snippet: GetSupportEventSubscription(string, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = SupportEventSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/supportEventSubscriptions/[SUPPORT_EVENT_SUBSCRIPTION]";
            // Make the request
            SupportEventSubscription response = supportEventSubscriptionServiceClient.GetSupportEventSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for GetSupportEventSubscriptionAsync</summary>
        public async Task GetSupportEventSubscriptionAsync()
        {
            // Snippet: GetSupportEventSubscriptionAsync(string, CallSettings)
            // Additional: GetSupportEventSubscriptionAsync(string, CancellationToken)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = await SupportEventSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/supportEventSubscriptions/[SUPPORT_EVENT_SUBSCRIPTION]";
            // Make the request
            SupportEventSubscription response = await supportEventSubscriptionServiceClient.GetSupportEventSubscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSupportEventSubscription</summary>
        public void GetSupportEventSubscriptionResourceNames()
        {
            // Snippet: GetSupportEventSubscription(SupportEventSubscriptionName, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = SupportEventSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            SupportEventSubscriptionName name = SupportEventSubscriptionName.FromOrganizationSupportEventSubscription("[ORGANIZATION]", "[SUPPORT_EVENT_SUBSCRIPTION]");
            // Make the request
            SupportEventSubscription response = supportEventSubscriptionServiceClient.GetSupportEventSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for GetSupportEventSubscriptionAsync</summary>
        public async Task GetSupportEventSubscriptionResourceNamesAsync()
        {
            // Snippet: GetSupportEventSubscriptionAsync(SupportEventSubscriptionName, CallSettings)
            // Additional: GetSupportEventSubscriptionAsync(SupportEventSubscriptionName, CancellationToken)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = await SupportEventSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            SupportEventSubscriptionName name = SupportEventSubscriptionName.FromOrganizationSupportEventSubscription("[ORGANIZATION]", "[SUPPORT_EVENT_SUBSCRIPTION]");
            // Make the request
            SupportEventSubscription response = await supportEventSubscriptionServiceClient.GetSupportEventSubscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSupportEventSubscriptions</summary>
        public void ListSupportEventSubscriptionsRequestObject()
        {
            // Snippet: ListSupportEventSubscriptions(ListSupportEventSubscriptionsRequest, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = SupportEventSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            ListSupportEventSubscriptionsRequest request = new ListSupportEventSubscriptionsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Filter = "",
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListSupportEventSubscriptionsResponse, SupportEventSubscription> response = supportEventSubscriptionServiceClient.ListSupportEventSubscriptions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SupportEventSubscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSupportEventSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SupportEventSubscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SupportEventSubscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SupportEventSubscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSupportEventSubscriptionsAsync</summary>
        public async Task ListSupportEventSubscriptionsRequestObjectAsync()
        {
            // Snippet: ListSupportEventSubscriptionsAsync(ListSupportEventSubscriptionsRequest, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = await SupportEventSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSupportEventSubscriptionsRequest request = new ListSupportEventSubscriptionsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Filter = "",
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListSupportEventSubscriptionsResponse, SupportEventSubscription> response = supportEventSubscriptionServiceClient.ListSupportEventSubscriptionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SupportEventSubscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSupportEventSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SupportEventSubscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SupportEventSubscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SupportEventSubscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSupportEventSubscriptions</summary>
        public void ListSupportEventSubscriptions()
        {
            // Snippet: ListSupportEventSubscriptions(string, string, int?, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = SupportEventSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedEnumerable<ListSupportEventSubscriptionsResponse, SupportEventSubscription> response = supportEventSubscriptionServiceClient.ListSupportEventSubscriptions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SupportEventSubscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSupportEventSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SupportEventSubscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SupportEventSubscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SupportEventSubscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSupportEventSubscriptionsAsync</summary>
        public async Task ListSupportEventSubscriptionsAsync()
        {
            // Snippet: ListSupportEventSubscriptionsAsync(string, string, int?, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = await SupportEventSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedAsyncEnumerable<ListSupportEventSubscriptionsResponse, SupportEventSubscription> response = supportEventSubscriptionServiceClient.ListSupportEventSubscriptionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SupportEventSubscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSupportEventSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SupportEventSubscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SupportEventSubscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SupportEventSubscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSupportEventSubscriptions</summary>
        public void ListSupportEventSubscriptionsResourceNames()
        {
            // Snippet: ListSupportEventSubscriptions(OrganizationName, string, int?, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = SupportEventSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListSupportEventSubscriptionsResponse, SupportEventSubscription> response = supportEventSubscriptionServiceClient.ListSupportEventSubscriptions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SupportEventSubscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSupportEventSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SupportEventSubscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SupportEventSubscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SupportEventSubscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSupportEventSubscriptionsAsync</summary>
        public async Task ListSupportEventSubscriptionsResourceNamesAsync()
        {
            // Snippet: ListSupportEventSubscriptionsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = await SupportEventSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListSupportEventSubscriptionsResponse, SupportEventSubscription> response = supportEventSubscriptionServiceClient.ListSupportEventSubscriptionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SupportEventSubscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSupportEventSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SupportEventSubscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SupportEventSubscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SupportEventSubscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateSupportEventSubscription</summary>
        public void UpdateSupportEventSubscriptionRequestObject()
        {
            // Snippet: UpdateSupportEventSubscription(UpdateSupportEventSubscriptionRequest, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = SupportEventSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            UpdateSupportEventSubscriptionRequest request = new UpdateSupportEventSubscriptionRequest
            {
                SupportEventSubscription = new SupportEventSubscription(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SupportEventSubscription response = supportEventSubscriptionServiceClient.UpdateSupportEventSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSupportEventSubscriptionAsync</summary>
        public async Task UpdateSupportEventSubscriptionRequestObjectAsync()
        {
            // Snippet: UpdateSupportEventSubscriptionAsync(UpdateSupportEventSubscriptionRequest, CallSettings)
            // Additional: UpdateSupportEventSubscriptionAsync(UpdateSupportEventSubscriptionRequest, CancellationToken)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = await SupportEventSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSupportEventSubscriptionRequest request = new UpdateSupportEventSubscriptionRequest
            {
                SupportEventSubscription = new SupportEventSubscription(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SupportEventSubscription response = await supportEventSubscriptionServiceClient.UpdateSupportEventSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSupportEventSubscription</summary>
        public void UpdateSupportEventSubscription()
        {
            // Snippet: UpdateSupportEventSubscription(SupportEventSubscription, FieldMask, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = SupportEventSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            SupportEventSubscription supportEventSubscription = new SupportEventSubscription();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SupportEventSubscription response = supportEventSubscriptionServiceClient.UpdateSupportEventSubscription(supportEventSubscription, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSupportEventSubscriptionAsync</summary>
        public async Task UpdateSupportEventSubscriptionAsync()
        {
            // Snippet: UpdateSupportEventSubscriptionAsync(SupportEventSubscription, FieldMask, CallSettings)
            // Additional: UpdateSupportEventSubscriptionAsync(SupportEventSubscription, FieldMask, CancellationToken)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = await SupportEventSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            SupportEventSubscription supportEventSubscription = new SupportEventSubscription();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SupportEventSubscription response = await supportEventSubscriptionServiceClient.UpdateSupportEventSubscriptionAsync(supportEventSubscription, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSupportEventSubscription</summary>
        public void DeleteSupportEventSubscriptionRequestObject()
        {
            // Snippet: DeleteSupportEventSubscription(DeleteSupportEventSubscriptionRequest, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = SupportEventSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            DeleteSupportEventSubscriptionRequest request = new DeleteSupportEventSubscriptionRequest
            {
                SupportEventSubscriptionName = SupportEventSubscriptionName.FromOrganizationSupportEventSubscription("[ORGANIZATION]", "[SUPPORT_EVENT_SUBSCRIPTION]"),
            };
            // Make the request
            SupportEventSubscription response = supportEventSubscriptionServiceClient.DeleteSupportEventSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSupportEventSubscriptionAsync</summary>
        public async Task DeleteSupportEventSubscriptionRequestObjectAsync()
        {
            // Snippet: DeleteSupportEventSubscriptionAsync(DeleteSupportEventSubscriptionRequest, CallSettings)
            // Additional: DeleteSupportEventSubscriptionAsync(DeleteSupportEventSubscriptionRequest, CancellationToken)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = await SupportEventSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSupportEventSubscriptionRequest request = new DeleteSupportEventSubscriptionRequest
            {
                SupportEventSubscriptionName = SupportEventSubscriptionName.FromOrganizationSupportEventSubscription("[ORGANIZATION]", "[SUPPORT_EVENT_SUBSCRIPTION]"),
            };
            // Make the request
            SupportEventSubscription response = await supportEventSubscriptionServiceClient.DeleteSupportEventSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSupportEventSubscription</summary>
        public void DeleteSupportEventSubscription()
        {
            // Snippet: DeleteSupportEventSubscription(string, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = SupportEventSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/supportEventSubscriptions/[SUPPORT_EVENT_SUBSCRIPTION]";
            // Make the request
            SupportEventSubscription response = supportEventSubscriptionServiceClient.DeleteSupportEventSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSupportEventSubscriptionAsync</summary>
        public async Task DeleteSupportEventSubscriptionAsync()
        {
            // Snippet: DeleteSupportEventSubscriptionAsync(string, CallSettings)
            // Additional: DeleteSupportEventSubscriptionAsync(string, CancellationToken)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = await SupportEventSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/supportEventSubscriptions/[SUPPORT_EVENT_SUBSCRIPTION]";
            // Make the request
            SupportEventSubscription response = await supportEventSubscriptionServiceClient.DeleteSupportEventSubscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSupportEventSubscription</summary>
        public void DeleteSupportEventSubscriptionResourceNames()
        {
            // Snippet: DeleteSupportEventSubscription(SupportEventSubscriptionName, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = SupportEventSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            SupportEventSubscriptionName name = SupportEventSubscriptionName.FromOrganizationSupportEventSubscription("[ORGANIZATION]", "[SUPPORT_EVENT_SUBSCRIPTION]");
            // Make the request
            SupportEventSubscription response = supportEventSubscriptionServiceClient.DeleteSupportEventSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSupportEventSubscriptionAsync</summary>
        public async Task DeleteSupportEventSubscriptionResourceNamesAsync()
        {
            // Snippet: DeleteSupportEventSubscriptionAsync(SupportEventSubscriptionName, CallSettings)
            // Additional: DeleteSupportEventSubscriptionAsync(SupportEventSubscriptionName, CancellationToken)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = await SupportEventSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            SupportEventSubscriptionName name = SupportEventSubscriptionName.FromOrganizationSupportEventSubscription("[ORGANIZATION]", "[SUPPORT_EVENT_SUBSCRIPTION]");
            // Make the request
            SupportEventSubscription response = await supportEventSubscriptionServiceClient.DeleteSupportEventSubscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UndeleteSupportEventSubscription</summary>
        public void UndeleteSupportEventSubscriptionRequestObject()
        {
            // Snippet: UndeleteSupportEventSubscription(UndeleteSupportEventSubscriptionRequest, CallSettings)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = SupportEventSubscriptionServiceClient.Create();
            // Initialize request argument(s)
            UndeleteSupportEventSubscriptionRequest request = new UndeleteSupportEventSubscriptionRequest
            {
                SupportEventSubscriptionName = SupportEventSubscriptionName.FromOrganizationSupportEventSubscription("[ORGANIZATION]", "[SUPPORT_EVENT_SUBSCRIPTION]"),
            };
            // Make the request
            SupportEventSubscription response = supportEventSubscriptionServiceClient.UndeleteSupportEventSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for UndeleteSupportEventSubscriptionAsync</summary>
        public async Task UndeleteSupportEventSubscriptionRequestObjectAsync()
        {
            // Snippet: UndeleteSupportEventSubscriptionAsync(UndeleteSupportEventSubscriptionRequest, CallSettings)
            // Additional: UndeleteSupportEventSubscriptionAsync(UndeleteSupportEventSubscriptionRequest, CancellationToken)
            // Create client
            SupportEventSubscriptionServiceClient supportEventSubscriptionServiceClient = await SupportEventSubscriptionServiceClient.CreateAsync();
            // Initialize request argument(s)
            UndeleteSupportEventSubscriptionRequest request = new UndeleteSupportEventSubscriptionRequest
            {
                SupportEventSubscriptionName = SupportEventSubscriptionName.FromOrganizationSupportEventSubscription("[ORGANIZATION]", "[SUPPORT_EVENT_SUBSCRIPTION]"),
            };
            // Make the request
            SupportEventSubscription response = await supportEventSubscriptionServiceClient.UndeleteSupportEventSubscriptionAsync(request);
            // End snippet
        }
    }
}
