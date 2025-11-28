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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedContactServiceClientSnippets
    {
        /// <summary>Snippet for GetContact</summary>
        public void GetContactRequestObject()
        {
            // Snippet: GetContact(GetContactRequest, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            GetContactRequest request = new GetContactRequest
            {
                ContactName = ContactName.FromNetworkCodeContact("[NETWORK_CODE]", "[CONTACT]"),
            };
            // Make the request
            Contact response = contactServiceClient.GetContact(request);
            // End snippet
        }

        /// <summary>Snippet for GetContactAsync</summary>
        public async Task GetContactRequestObjectAsync()
        {
            // Snippet: GetContactAsync(GetContactRequest, CallSettings)
            // Additional: GetContactAsync(GetContactRequest, CancellationToken)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetContactRequest request = new GetContactRequest
            {
                ContactName = ContactName.FromNetworkCodeContact("[NETWORK_CODE]", "[CONTACT]"),
            };
            // Make the request
            Contact response = await contactServiceClient.GetContactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetContact</summary>
        public void GetContact()
        {
            // Snippet: GetContact(string, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/contacts/[CONTACT]";
            // Make the request
            Contact response = contactServiceClient.GetContact(name);
            // End snippet
        }

        /// <summary>Snippet for GetContactAsync</summary>
        public async Task GetContactAsync()
        {
            // Snippet: GetContactAsync(string, CallSettings)
            // Additional: GetContactAsync(string, CancellationToken)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/contacts/[CONTACT]";
            // Make the request
            Contact response = await contactServiceClient.GetContactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetContact</summary>
        public void GetContactResourceNames()
        {
            // Snippet: GetContact(ContactName, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            ContactName name = ContactName.FromNetworkCodeContact("[NETWORK_CODE]", "[CONTACT]");
            // Make the request
            Contact response = contactServiceClient.GetContact(name);
            // End snippet
        }

        /// <summary>Snippet for GetContactAsync</summary>
        public async Task GetContactResourceNamesAsync()
        {
            // Snippet: GetContactAsync(ContactName, CallSettings)
            // Additional: GetContactAsync(ContactName, CancellationToken)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            ContactName name = ContactName.FromNetworkCodeContact("[NETWORK_CODE]", "[CONTACT]");
            // Make the request
            Contact response = await contactServiceClient.GetContactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListContacts</summary>
        public void ListContactsRequestObject()
        {
            // Snippet: ListContacts(ListContactsRequest, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            ListContactsRequest request = new ListContactsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListContactsResponse, Contact> response = contactServiceClient.ListContacts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Contact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Contact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Contact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Contact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContactsAsync</summary>
        public async Task ListContactsRequestObjectAsync()
        {
            // Snippet: ListContactsAsync(ListContactsRequest, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListContactsRequest request = new ListContactsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListContactsResponse, Contact> response = contactServiceClient.ListContactsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Contact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Contact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Contact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Contact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContacts</summary>
        public void ListContacts()
        {
            // Snippet: ListContacts(string, string, int?, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListContactsResponse, Contact> response = contactServiceClient.ListContacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Contact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Contact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Contact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Contact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContactsAsync</summary>
        public async Task ListContactsAsync()
        {
            // Snippet: ListContactsAsync(string, string, int?, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListContactsResponse, Contact> response = contactServiceClient.ListContactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Contact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Contact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Contact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Contact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContacts</summary>
        public void ListContactsResourceNames()
        {
            // Snippet: ListContacts(NetworkName, string, int?, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListContactsResponse, Contact> response = contactServiceClient.ListContacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Contact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Contact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Contact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Contact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContactsAsync</summary>
        public async Task ListContactsResourceNamesAsync()
        {
            // Snippet: ListContactsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListContactsResponse, Contact> response = contactServiceClient.ListContactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Contact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Contact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Contact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Contact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateContact</summary>
        public void CreateContactRequestObject()
        {
            // Snippet: CreateContact(CreateContactRequest, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            CreateContactRequest request = new CreateContactRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Contact = new Contact(),
            };
            // Make the request
            Contact response = contactServiceClient.CreateContact(request);
            // End snippet
        }

        /// <summary>Snippet for CreateContactAsync</summary>
        public async Task CreateContactRequestObjectAsync()
        {
            // Snippet: CreateContactAsync(CreateContactRequest, CallSettings)
            // Additional: CreateContactAsync(CreateContactRequest, CancellationToken)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateContactRequest request = new CreateContactRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Contact = new Contact(),
            };
            // Make the request
            Contact response = await contactServiceClient.CreateContactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateContact</summary>
        public void CreateContact()
        {
            // Snippet: CreateContact(string, Contact, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Contact contact = new Contact();
            // Make the request
            Contact response = contactServiceClient.CreateContact(parent, contact);
            // End snippet
        }

        /// <summary>Snippet for CreateContactAsync</summary>
        public async Task CreateContactAsync()
        {
            // Snippet: CreateContactAsync(string, Contact, CallSettings)
            // Additional: CreateContactAsync(string, Contact, CancellationToken)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Contact contact = new Contact();
            // Make the request
            Contact response = await contactServiceClient.CreateContactAsync(parent, contact);
            // End snippet
        }

        /// <summary>Snippet for CreateContact</summary>
        public void CreateContactResourceNames()
        {
            // Snippet: CreateContact(NetworkName, Contact, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Contact contact = new Contact();
            // Make the request
            Contact response = contactServiceClient.CreateContact(parent, contact);
            // End snippet
        }

        /// <summary>Snippet for CreateContactAsync</summary>
        public async Task CreateContactResourceNamesAsync()
        {
            // Snippet: CreateContactAsync(NetworkName, Contact, CallSettings)
            // Additional: CreateContactAsync(NetworkName, Contact, CancellationToken)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Contact contact = new Contact();
            // Make the request
            Contact response = await contactServiceClient.CreateContactAsync(parent, contact);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateContacts</summary>
        public void BatchCreateContactsRequestObject()
        {
            // Snippet: BatchCreateContacts(BatchCreateContactsRequest, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateContactsRequest request = new BatchCreateContactsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateContactRequest(),
                },
            };
            // Make the request
            BatchCreateContactsResponse response = contactServiceClient.BatchCreateContacts(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateContactsAsync</summary>
        public async Task BatchCreateContactsRequestObjectAsync()
        {
            // Snippet: BatchCreateContactsAsync(BatchCreateContactsRequest, CallSettings)
            // Additional: BatchCreateContactsAsync(BatchCreateContactsRequest, CancellationToken)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateContactsRequest request = new BatchCreateContactsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateContactRequest(),
                },
            };
            // Make the request
            BatchCreateContactsResponse response = await contactServiceClient.BatchCreateContactsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateContacts</summary>
        public void BatchCreateContacts()
        {
            // Snippet: BatchCreateContacts(string, IEnumerable<CreateContactRequest>, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateContactRequest> requests = new CreateContactRequest[]
            {
                new CreateContactRequest(),
            };
            // Make the request
            BatchCreateContactsResponse response = contactServiceClient.BatchCreateContacts(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateContactsAsync</summary>
        public async Task BatchCreateContactsAsync()
        {
            // Snippet: BatchCreateContactsAsync(string, IEnumerable<CreateContactRequest>, CallSettings)
            // Additional: BatchCreateContactsAsync(string, IEnumerable<CreateContactRequest>, CancellationToken)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateContactRequest> requests = new CreateContactRequest[]
            {
                new CreateContactRequest(),
            };
            // Make the request
            BatchCreateContactsResponse response = await contactServiceClient.BatchCreateContactsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateContacts</summary>
        public void BatchCreateContactsResourceNames()
        {
            // Snippet: BatchCreateContacts(NetworkName, IEnumerable<CreateContactRequest>, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateContactRequest> requests = new CreateContactRequest[]
            {
                new CreateContactRequest(),
            };
            // Make the request
            BatchCreateContactsResponse response = contactServiceClient.BatchCreateContacts(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateContactsAsync</summary>
        public async Task BatchCreateContactsResourceNamesAsync()
        {
            // Snippet: BatchCreateContactsAsync(NetworkName, IEnumerable<CreateContactRequest>, CallSettings)
            // Additional: BatchCreateContactsAsync(NetworkName, IEnumerable<CreateContactRequest>, CancellationToken)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateContactRequest> requests = new CreateContactRequest[]
            {
                new CreateContactRequest(),
            };
            // Make the request
            BatchCreateContactsResponse response = await contactServiceClient.BatchCreateContactsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateContact</summary>
        public void UpdateContactRequestObject()
        {
            // Snippet: UpdateContact(UpdateContactRequest, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            UpdateContactRequest request = new UpdateContactRequest
            {
                Contact = new Contact(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Contact response = contactServiceClient.UpdateContact(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateContactAsync</summary>
        public async Task UpdateContactRequestObjectAsync()
        {
            // Snippet: UpdateContactAsync(UpdateContactRequest, CallSettings)
            // Additional: UpdateContactAsync(UpdateContactRequest, CancellationToken)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateContactRequest request = new UpdateContactRequest
            {
                Contact = new Contact(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Contact response = await contactServiceClient.UpdateContactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateContact</summary>
        public void UpdateContact()
        {
            // Snippet: UpdateContact(Contact, FieldMask, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            Contact contact = new Contact();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Contact response = contactServiceClient.UpdateContact(contact, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateContactAsync</summary>
        public async Task UpdateContactAsync()
        {
            // Snippet: UpdateContactAsync(Contact, FieldMask, CallSettings)
            // Additional: UpdateContactAsync(Contact, FieldMask, CancellationToken)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            Contact contact = new Contact();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Contact response = await contactServiceClient.UpdateContactAsync(contact, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateContacts</summary>
        public void BatchUpdateContactsRequestObject()
        {
            // Snippet: BatchUpdateContacts(BatchUpdateContactsRequest, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateContactsRequest request = new BatchUpdateContactsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateContactRequest(),
                },
            };
            // Make the request
            BatchUpdateContactsResponse response = contactServiceClient.BatchUpdateContacts(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateContactsAsync</summary>
        public async Task BatchUpdateContactsRequestObjectAsync()
        {
            // Snippet: BatchUpdateContactsAsync(BatchUpdateContactsRequest, CallSettings)
            // Additional: BatchUpdateContactsAsync(BatchUpdateContactsRequest, CancellationToken)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateContactsRequest request = new BatchUpdateContactsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateContactRequest(),
                },
            };
            // Make the request
            BatchUpdateContactsResponse response = await contactServiceClient.BatchUpdateContactsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateContacts</summary>
        public void BatchUpdateContacts()
        {
            // Snippet: BatchUpdateContacts(string, IEnumerable<UpdateContactRequest>, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateContactRequest> requests = new UpdateContactRequest[]
            {
                new UpdateContactRequest(),
            };
            // Make the request
            BatchUpdateContactsResponse response = contactServiceClient.BatchUpdateContacts(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateContactsAsync</summary>
        public async Task BatchUpdateContactsAsync()
        {
            // Snippet: BatchUpdateContactsAsync(string, IEnumerable<UpdateContactRequest>, CallSettings)
            // Additional: BatchUpdateContactsAsync(string, IEnumerable<UpdateContactRequest>, CancellationToken)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateContactRequest> requests = new UpdateContactRequest[]
            {
                new UpdateContactRequest(),
            };
            // Make the request
            BatchUpdateContactsResponse response = await contactServiceClient.BatchUpdateContactsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateContacts</summary>
        public void BatchUpdateContactsResourceNames()
        {
            // Snippet: BatchUpdateContacts(NetworkName, IEnumerable<UpdateContactRequest>, CallSettings)
            // Create client
            ContactServiceClient contactServiceClient = ContactServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateContactRequest> requests = new UpdateContactRequest[]
            {
                new UpdateContactRequest(),
            };
            // Make the request
            BatchUpdateContactsResponse response = contactServiceClient.BatchUpdateContacts(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateContactsAsync</summary>
        public async Task BatchUpdateContactsResourceNamesAsync()
        {
            // Snippet: BatchUpdateContactsAsync(NetworkName, IEnumerable<UpdateContactRequest>, CallSettings)
            // Additional: BatchUpdateContactsAsync(NetworkName, IEnumerable<UpdateContactRequest>, CancellationToken)
            // Create client
            ContactServiceClient contactServiceClient = await ContactServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateContactRequest> requests = new UpdateContactRequest[]
            {
                new UpdateContactRequest(),
            };
            // Make the request
            BatchUpdateContactsResponse response = await contactServiceClient.BatchUpdateContactsAsync(parent, requests);
            // End snippet
        }
    }
}
