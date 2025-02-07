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
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPhoneNumbersClientSnippets
    {
        /// <summary>Snippet for ListPhoneNumbers</summary>
        public void ListPhoneNumbersRequestObject()
        {
            // Snippet: ListPhoneNumbers(ListPhoneNumbersRequest, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            ListPhoneNumbersRequest request = new ListPhoneNumbersRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListPhoneNumbersResponse, PhoneNumber> response = phoneNumbersClient.ListPhoneNumbers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PhoneNumber item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhoneNumbersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhoneNumber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhoneNumber> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhoneNumber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhoneNumbersAsync</summary>
        public async Task ListPhoneNumbersRequestObjectAsync()
        {
            // Snippet: ListPhoneNumbersAsync(ListPhoneNumbersRequest, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            ListPhoneNumbersRequest request = new ListPhoneNumbersRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListPhoneNumbersResponse, PhoneNumber> response = phoneNumbersClient.ListPhoneNumbersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PhoneNumber item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhoneNumbersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhoneNumber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhoneNumber> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhoneNumber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhoneNumbers</summary>
        public void ListPhoneNumbers()
        {
            // Snippet: ListPhoneNumbers(string, string, int?, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListPhoneNumbersResponse, PhoneNumber> response = phoneNumbersClient.ListPhoneNumbers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PhoneNumber item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhoneNumbersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhoneNumber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhoneNumber> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhoneNumber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhoneNumbersAsync</summary>
        public async Task ListPhoneNumbersAsync()
        {
            // Snippet: ListPhoneNumbersAsync(string, string, int?, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListPhoneNumbersResponse, PhoneNumber> response = phoneNumbersClient.ListPhoneNumbersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PhoneNumber item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhoneNumbersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhoneNumber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhoneNumber> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhoneNumber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhoneNumbers</summary>
        public void ListPhoneNumbersResourceNames1()
        {
            // Snippet: ListPhoneNumbers(ProjectName, string, int?, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListPhoneNumbersResponse, PhoneNumber> response = phoneNumbersClient.ListPhoneNumbers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PhoneNumber item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhoneNumbersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhoneNumber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhoneNumber> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhoneNumber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhoneNumbersAsync</summary>
        public async Task ListPhoneNumbersResourceNames1Async()
        {
            // Snippet: ListPhoneNumbersAsync(ProjectName, string, int?, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListPhoneNumbersResponse, PhoneNumber> response = phoneNumbersClient.ListPhoneNumbersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PhoneNumber item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhoneNumbersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhoneNumber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhoneNumber> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhoneNumber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhoneNumbers</summary>
        public void ListPhoneNumbersResourceNames2()
        {
            // Snippet: ListPhoneNumbers(LocationName, string, int?, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPhoneNumbersResponse, PhoneNumber> response = phoneNumbersClient.ListPhoneNumbers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PhoneNumber item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhoneNumbersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhoneNumber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhoneNumber> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhoneNumber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhoneNumbersAsync</summary>
        public async Task ListPhoneNumbersResourceNames2Async()
        {
            // Snippet: ListPhoneNumbersAsync(LocationName, string, int?, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPhoneNumbersResponse, PhoneNumber> response = phoneNumbersClient.ListPhoneNumbersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PhoneNumber item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhoneNumbersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhoneNumber item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhoneNumber> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhoneNumber item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdatePhoneNumber</summary>
        public void UpdatePhoneNumberRequestObject()
        {
            // Snippet: UpdatePhoneNumber(UpdatePhoneNumberRequest, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            UpdatePhoneNumberRequest request = new UpdatePhoneNumberRequest
            {
                PhoneNumber = new PhoneNumber(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PhoneNumber response = phoneNumbersClient.UpdatePhoneNumber(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhoneNumberAsync</summary>
        public async Task UpdatePhoneNumberRequestObjectAsync()
        {
            // Snippet: UpdatePhoneNumberAsync(UpdatePhoneNumberRequest, CallSettings)
            // Additional: UpdatePhoneNumberAsync(UpdatePhoneNumberRequest, CancellationToken)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePhoneNumberRequest request = new UpdatePhoneNumberRequest
            {
                PhoneNumber = new PhoneNumber(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PhoneNumber response = await phoneNumbersClient.UpdatePhoneNumberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhoneNumber</summary>
        public void UpdatePhoneNumber()
        {
            // Snippet: UpdatePhoneNumber(PhoneNumber, FieldMask, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            PhoneNumber phoneNumber = new PhoneNumber();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PhoneNumber response = phoneNumbersClient.UpdatePhoneNumber(phoneNumber, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhoneNumberAsync</summary>
        public async Task UpdatePhoneNumberAsync()
        {
            // Snippet: UpdatePhoneNumberAsync(PhoneNumber, FieldMask, CallSettings)
            // Additional: UpdatePhoneNumberAsync(PhoneNumber, FieldMask, CancellationToken)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            PhoneNumber phoneNumber = new PhoneNumber();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PhoneNumber response = await phoneNumbersClient.UpdatePhoneNumberAsync(phoneNumber, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoneNumber</summary>
        public void DeletePhoneNumberRequestObject()
        {
            // Snippet: DeletePhoneNumber(DeletePhoneNumberRequest, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            DeletePhoneNumberRequest request = new DeletePhoneNumberRequest
            {
                PhoneNumberName = PhoneNumberName.FromProjectPhoneNumber("[PROJECT]", "[PHONE_NUMBER]"),
            };
            // Make the request
            PhoneNumber response = phoneNumbersClient.DeletePhoneNumber(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoneNumberAsync</summary>
        public async Task DeletePhoneNumberRequestObjectAsync()
        {
            // Snippet: DeletePhoneNumberAsync(DeletePhoneNumberRequest, CallSettings)
            // Additional: DeletePhoneNumberAsync(DeletePhoneNumberRequest, CancellationToken)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            DeletePhoneNumberRequest request = new DeletePhoneNumberRequest
            {
                PhoneNumberName = PhoneNumberName.FromProjectPhoneNumber("[PROJECT]", "[PHONE_NUMBER]"),
            };
            // Make the request
            PhoneNumber response = await phoneNumbersClient.DeletePhoneNumberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoneNumber</summary>
        public void DeletePhoneNumber()
        {
            // Snippet: DeletePhoneNumber(string, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/phoneNumbers/[PHONE_NUMBER]";
            // Make the request
            PhoneNumber response = phoneNumbersClient.DeletePhoneNumber(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoneNumberAsync</summary>
        public async Task DeletePhoneNumberAsync()
        {
            // Snippet: DeletePhoneNumberAsync(string, CallSettings)
            // Additional: DeletePhoneNumberAsync(string, CancellationToken)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/phoneNumbers/[PHONE_NUMBER]";
            // Make the request
            PhoneNumber response = await phoneNumbersClient.DeletePhoneNumberAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoneNumber</summary>
        public void DeletePhoneNumberResourceNames()
        {
            // Snippet: DeletePhoneNumber(PhoneNumberName, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            PhoneNumberName name = PhoneNumberName.FromProjectPhoneNumber("[PROJECT]", "[PHONE_NUMBER]");
            // Make the request
            PhoneNumber response = phoneNumbersClient.DeletePhoneNumber(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePhoneNumberAsync</summary>
        public async Task DeletePhoneNumberResourceNamesAsync()
        {
            // Snippet: DeletePhoneNumberAsync(PhoneNumberName, CallSettings)
            // Additional: DeletePhoneNumberAsync(PhoneNumberName, CancellationToken)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            PhoneNumberName name = PhoneNumberName.FromProjectPhoneNumber("[PROJECT]", "[PHONE_NUMBER]");
            // Make the request
            PhoneNumber response = await phoneNumbersClient.DeletePhoneNumberAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UndeletePhoneNumber</summary>
        public void UndeletePhoneNumberRequestObject()
        {
            // Snippet: UndeletePhoneNumber(UndeletePhoneNumberRequest, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            UndeletePhoneNumberRequest request = new UndeletePhoneNumberRequest
            {
                PhoneNumberName = PhoneNumberName.FromProjectPhoneNumber("[PROJECT]", "[PHONE_NUMBER]"),
            };
            // Make the request
            PhoneNumber response = phoneNumbersClient.UndeletePhoneNumber(request);
            // End snippet
        }

        /// <summary>Snippet for UndeletePhoneNumberAsync</summary>
        public async Task UndeletePhoneNumberRequestObjectAsync()
        {
            // Snippet: UndeletePhoneNumberAsync(UndeletePhoneNumberRequest, CallSettings)
            // Additional: UndeletePhoneNumberAsync(UndeletePhoneNumberRequest, CancellationToken)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            UndeletePhoneNumberRequest request = new UndeletePhoneNumberRequest
            {
                PhoneNumberName = PhoneNumberName.FromProjectPhoneNumber("[PROJECT]", "[PHONE_NUMBER]"),
            };
            // Make the request
            PhoneNumber response = await phoneNumbersClient.UndeletePhoneNumberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UndeletePhoneNumber</summary>
        public void UndeletePhoneNumber()
        {
            // Snippet: UndeletePhoneNumber(string, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/phoneNumbers/[PHONE_NUMBER]";
            // Make the request
            PhoneNumber response = phoneNumbersClient.UndeletePhoneNumber(name);
            // End snippet
        }

        /// <summary>Snippet for UndeletePhoneNumberAsync</summary>
        public async Task UndeletePhoneNumberAsync()
        {
            // Snippet: UndeletePhoneNumberAsync(string, CallSettings)
            // Additional: UndeletePhoneNumberAsync(string, CancellationToken)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/phoneNumbers/[PHONE_NUMBER]";
            // Make the request
            PhoneNumber response = await phoneNumbersClient.UndeletePhoneNumberAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UndeletePhoneNumber</summary>
        public void UndeletePhoneNumberResourceNames()
        {
            // Snippet: UndeletePhoneNumber(PhoneNumberName, CallSettings)
            // Create client
            PhoneNumbersClient phoneNumbersClient = PhoneNumbersClient.Create();
            // Initialize request argument(s)
            PhoneNumberName name = PhoneNumberName.FromProjectPhoneNumber("[PROJECT]", "[PHONE_NUMBER]");
            // Make the request
            PhoneNumber response = phoneNumbersClient.UndeletePhoneNumber(name);
            // End snippet
        }

        /// <summary>Snippet for UndeletePhoneNumberAsync</summary>
        public async Task UndeletePhoneNumberResourceNamesAsync()
        {
            // Snippet: UndeletePhoneNumberAsync(PhoneNumberName, CallSettings)
            // Additional: UndeletePhoneNumberAsync(PhoneNumberName, CancellationToken)
            // Create client
            PhoneNumbersClient phoneNumbersClient = await PhoneNumbersClient.CreateAsync();
            // Initialize request argument(s)
            PhoneNumberName name = PhoneNumberName.FromProjectPhoneNumber("[PROJECT]", "[PHONE_NUMBER]");
            // Make the request
            PhoneNumber response = await phoneNumbersClient.UndeletePhoneNumberAsync(name);
            // End snippet
        }
    }
}
