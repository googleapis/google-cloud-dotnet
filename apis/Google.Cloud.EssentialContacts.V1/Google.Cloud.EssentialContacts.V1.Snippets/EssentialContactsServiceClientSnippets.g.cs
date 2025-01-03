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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.EssentialContacts.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEssentialContactsServiceClientSnippets
    {
        /// <summary>Snippet for CreateContact</summary>
        public void CreateContactRequestObject()
        {
            // Snippet: CreateContact(CreateContactRequest, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            CreateContactRequest request = new CreateContactRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Contact = new Contact(),
            };
            // Make the request
            Contact response = essentialContactsServiceClient.CreateContact(request);
            // End snippet
        }

        /// <summary>Snippet for CreateContactAsync</summary>
        public async Task CreateContactRequestObjectAsync()
        {
            // Snippet: CreateContactAsync(CreateContactRequest, CallSettings)
            // Additional: CreateContactAsync(CreateContactRequest, CancellationToken)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateContactRequest request = new CreateContactRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Contact = new Contact(),
            };
            // Make the request
            Contact response = await essentialContactsServiceClient.CreateContactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateContact</summary>
        public void CreateContact()
        {
            // Snippet: CreateContact(string, Contact, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Contact contact = new Contact();
            // Make the request
            Contact response = essentialContactsServiceClient.CreateContact(parent, contact);
            // End snippet
        }

        /// <summary>Snippet for CreateContactAsync</summary>
        public async Task CreateContactAsync()
        {
            // Snippet: CreateContactAsync(string, Contact, CallSettings)
            // Additional: CreateContactAsync(string, Contact, CancellationToken)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Contact contact = new Contact();
            // Make the request
            Contact response = await essentialContactsServiceClient.CreateContactAsync(parent, contact);
            // End snippet
        }

        /// <summary>Snippet for CreateContact</summary>
        public void CreateContactResourceNames1()
        {
            // Snippet: CreateContact(ProjectName, Contact, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Contact contact = new Contact();
            // Make the request
            Contact response = essentialContactsServiceClient.CreateContact(parent, contact);
            // End snippet
        }

        /// <summary>Snippet for CreateContactAsync</summary>
        public async Task CreateContactResourceNames1Async()
        {
            // Snippet: CreateContactAsync(ProjectName, Contact, CallSettings)
            // Additional: CreateContactAsync(ProjectName, Contact, CancellationToken)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Contact contact = new Contact();
            // Make the request
            Contact response = await essentialContactsServiceClient.CreateContactAsync(parent, contact);
            // End snippet
        }

        /// <summary>Snippet for CreateContact</summary>
        public void CreateContactResourceNames2()
        {
            // Snippet: CreateContact(FolderName, Contact, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            Contact contact = new Contact();
            // Make the request
            Contact response = essentialContactsServiceClient.CreateContact(parent, contact);
            // End snippet
        }

        /// <summary>Snippet for CreateContactAsync</summary>
        public async Task CreateContactResourceNames2Async()
        {
            // Snippet: CreateContactAsync(FolderName, Contact, CallSettings)
            // Additional: CreateContactAsync(FolderName, Contact, CancellationToken)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            Contact contact = new Contact();
            // Make the request
            Contact response = await essentialContactsServiceClient.CreateContactAsync(parent, contact);
            // End snippet
        }

        /// <summary>Snippet for CreateContact</summary>
        public void CreateContactResourceNames3()
        {
            // Snippet: CreateContact(OrganizationName, Contact, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            Contact contact = new Contact();
            // Make the request
            Contact response = essentialContactsServiceClient.CreateContact(parent, contact);
            // End snippet
        }

        /// <summary>Snippet for CreateContactAsync</summary>
        public async Task CreateContactResourceNames3Async()
        {
            // Snippet: CreateContactAsync(OrganizationName, Contact, CallSettings)
            // Additional: CreateContactAsync(OrganizationName, Contact, CancellationToken)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            Contact contact = new Contact();
            // Make the request
            Contact response = await essentialContactsServiceClient.CreateContactAsync(parent, contact);
            // End snippet
        }

        /// <summary>Snippet for UpdateContact</summary>
        public void UpdateContactRequestObject()
        {
            // Snippet: UpdateContact(UpdateContactRequest, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            UpdateContactRequest request = new UpdateContactRequest
            {
                Contact = new Contact(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Contact response = essentialContactsServiceClient.UpdateContact(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateContactAsync</summary>
        public async Task UpdateContactRequestObjectAsync()
        {
            // Snippet: UpdateContactAsync(UpdateContactRequest, CallSettings)
            // Additional: UpdateContactAsync(UpdateContactRequest, CancellationToken)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateContactRequest request = new UpdateContactRequest
            {
                Contact = new Contact(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Contact response = await essentialContactsServiceClient.UpdateContactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateContact</summary>
        public void UpdateContact()
        {
            // Snippet: UpdateContact(Contact, FieldMask, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            Contact contact = new Contact();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Contact response = essentialContactsServiceClient.UpdateContact(contact, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateContactAsync</summary>
        public async Task UpdateContactAsync()
        {
            // Snippet: UpdateContactAsync(Contact, FieldMask, CallSettings)
            // Additional: UpdateContactAsync(Contact, FieldMask, CancellationToken)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            Contact contact = new Contact();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Contact response = await essentialContactsServiceClient.UpdateContactAsync(contact, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListContacts</summary>
        public void ListContactsRequestObject()
        {
            // Snippet: ListContacts(ListContactsRequest, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            ListContactsRequest request = new ListContactsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListContactsResponse, Contact> response = essentialContactsServiceClient.ListContacts(request);

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
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListContactsRequest request = new ListContactsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListContactsResponse, Contact> response = essentialContactsServiceClient.ListContactsAsync(request);

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
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListContactsResponse, Contact> response = essentialContactsServiceClient.ListContacts(parent);

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
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListContactsResponse, Contact> response = essentialContactsServiceClient.ListContactsAsync(parent);

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
        public void ListContactsResourceNames1()
        {
            // Snippet: ListContacts(ProjectName, string, int?, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListContactsResponse, Contact> response = essentialContactsServiceClient.ListContacts(parent);

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
        public async Task ListContactsResourceNames1Async()
        {
            // Snippet: ListContactsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListContactsResponse, Contact> response = essentialContactsServiceClient.ListContactsAsync(parent);

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
        public void ListContactsResourceNames2()
        {
            // Snippet: ListContacts(FolderName, string, int?, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListContactsResponse, Contact> response = essentialContactsServiceClient.ListContacts(parent);

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
        public async Task ListContactsResourceNames2Async()
        {
            // Snippet: ListContactsAsync(FolderName, string, int?, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListContactsResponse, Contact> response = essentialContactsServiceClient.ListContactsAsync(parent);

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
        public void ListContactsResourceNames3()
        {
            // Snippet: ListContacts(OrganizationName, string, int?, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListContactsResponse, Contact> response = essentialContactsServiceClient.ListContacts(parent);

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
        public async Task ListContactsResourceNames3Async()
        {
            // Snippet: ListContactsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListContactsResponse, Contact> response = essentialContactsServiceClient.ListContactsAsync(parent);

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

        /// <summary>Snippet for GetContact</summary>
        public void GetContactRequestObject()
        {
            // Snippet: GetContact(GetContactRequest, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            GetContactRequest request = new GetContactRequest
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
            };
            // Make the request
            Contact response = essentialContactsServiceClient.GetContact(request);
            // End snippet
        }

        /// <summary>Snippet for GetContactAsync</summary>
        public async Task GetContactRequestObjectAsync()
        {
            // Snippet: GetContactAsync(GetContactRequest, CallSettings)
            // Additional: GetContactAsync(GetContactRequest, CancellationToken)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetContactRequest request = new GetContactRequest
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
            };
            // Make the request
            Contact response = await essentialContactsServiceClient.GetContactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetContact</summary>
        public void GetContact()
        {
            // Snippet: GetContact(string, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/contacts/[CONTACT]";
            // Make the request
            Contact response = essentialContactsServiceClient.GetContact(name);
            // End snippet
        }

        /// <summary>Snippet for GetContactAsync</summary>
        public async Task GetContactAsync()
        {
            // Snippet: GetContactAsync(string, CallSettings)
            // Additional: GetContactAsync(string, CancellationToken)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/contacts/[CONTACT]";
            // Make the request
            Contact response = await essentialContactsServiceClient.GetContactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetContact</summary>
        public void GetContactResourceNames()
        {
            // Snippet: GetContact(ContactName, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            ContactName name = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]");
            // Make the request
            Contact response = essentialContactsServiceClient.GetContact(name);
            // End snippet
        }

        /// <summary>Snippet for GetContactAsync</summary>
        public async Task GetContactResourceNamesAsync()
        {
            // Snippet: GetContactAsync(ContactName, CallSettings)
            // Additional: GetContactAsync(ContactName, CancellationToken)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ContactName name = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]");
            // Make the request
            Contact response = await essentialContactsServiceClient.GetContactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteContact</summary>
        public void DeleteContactRequestObject()
        {
            // Snippet: DeleteContact(DeleteContactRequest, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            DeleteContactRequest request = new DeleteContactRequest
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
            };
            // Make the request
            essentialContactsServiceClient.DeleteContact(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteContactAsync</summary>
        public async Task DeleteContactRequestObjectAsync()
        {
            // Snippet: DeleteContactAsync(DeleteContactRequest, CallSettings)
            // Additional: DeleteContactAsync(DeleteContactRequest, CancellationToken)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteContactRequest request = new DeleteContactRequest
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
            };
            // Make the request
            await essentialContactsServiceClient.DeleteContactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteContact</summary>
        public void DeleteContact()
        {
            // Snippet: DeleteContact(string, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/contacts/[CONTACT]";
            // Make the request
            essentialContactsServiceClient.DeleteContact(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteContactAsync</summary>
        public async Task DeleteContactAsync()
        {
            // Snippet: DeleteContactAsync(string, CallSettings)
            // Additional: DeleteContactAsync(string, CancellationToken)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/contacts/[CONTACT]";
            // Make the request
            await essentialContactsServiceClient.DeleteContactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteContact</summary>
        public void DeleteContactResourceNames()
        {
            // Snippet: DeleteContact(ContactName, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            ContactName name = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]");
            // Make the request
            essentialContactsServiceClient.DeleteContact(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteContactAsync</summary>
        public async Task DeleteContactResourceNamesAsync()
        {
            // Snippet: DeleteContactAsync(ContactName, CallSettings)
            // Additional: DeleteContactAsync(ContactName, CancellationToken)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ContactName name = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]");
            // Make the request
            await essentialContactsServiceClient.DeleteContactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ComputeContacts</summary>
        public void ComputeContactsRequestObject()
        {
            // Snippet: ComputeContacts(ComputeContactsRequest, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            ComputeContactsRequest request = new ComputeContactsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                NotificationCategories =
                {
                    NotificationCategory.Unspecified,
                },
            };
            // Make the request
            PagedEnumerable<ComputeContactsResponse, Contact> response = essentialContactsServiceClient.ComputeContacts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Contact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ComputeContactsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ComputeContactsAsync</summary>
        public async Task ComputeContactsRequestObjectAsync()
        {
            // Snippet: ComputeContactsAsync(ComputeContactsRequest, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ComputeContactsRequest request = new ComputeContactsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                NotificationCategories =
                {
                    NotificationCategory.Unspecified,
                },
            };
            // Make the request
            PagedAsyncEnumerable<ComputeContactsResponse, Contact> response = essentialContactsServiceClient.ComputeContactsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Contact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ComputeContactsResponse page) =>
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

        /// <summary>Snippet for SendTestMessage</summary>
        public void SendTestMessageRequestObject()
        {
            // Snippet: SendTestMessage(SendTestMessageRequest, CallSettings)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            SendTestMessageRequest request = new SendTestMessageRequest
            {
                ContactsAsContactNames =
                {
                    ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                },
                ResourceAsProjectName = ProjectName.FromProject("[PROJECT]"),
                NotificationCategory = NotificationCategory.Unspecified,
            };
            // Make the request
            essentialContactsServiceClient.SendTestMessage(request);
            // End snippet
        }

        /// <summary>Snippet for SendTestMessageAsync</summary>
        public async Task SendTestMessageRequestObjectAsync()
        {
            // Snippet: SendTestMessageAsync(SendTestMessageRequest, CallSettings)
            // Additional: SendTestMessageAsync(SendTestMessageRequest, CancellationToken)
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = await EssentialContactsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SendTestMessageRequest request = new SendTestMessageRequest
            {
                ContactsAsContactNames =
                {
                    ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                },
                ResourceAsProjectName = ProjectName.FromProject("[PROJECT]"),
                NotificationCategory = NotificationCategory.Unspecified,
            };
            // Make the request
            await essentialContactsServiceClient.SendTestMessageAsync(request);
            // End snippet
        }
    }
}
