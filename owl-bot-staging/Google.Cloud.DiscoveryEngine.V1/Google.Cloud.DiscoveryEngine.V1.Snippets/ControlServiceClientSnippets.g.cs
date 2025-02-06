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
    using Google.Cloud.DiscoveryEngine.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedControlServiceClientSnippets
    {
        /// <summary>Snippet for CreateControl</summary>
        public void CreateControlRequestObject()
        {
            // Snippet: CreateControl(CreateControlRequest, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = ControlServiceClient.Create();
            // Initialize request argument(s)
            CreateControlRequest request = new CreateControlRequest
            {
                ParentAsEngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
                Control = new Control(),
                ControlId = "",
            };
            // Make the request
            Control response = controlServiceClient.CreateControl(request);
            // End snippet
        }

        /// <summary>Snippet for CreateControlAsync</summary>
        public async Task CreateControlRequestObjectAsync()
        {
            // Snippet: CreateControlAsync(CreateControlRequest, CallSettings)
            // Additional: CreateControlAsync(CreateControlRequest, CancellationToken)
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateControlRequest request = new CreateControlRequest
            {
                ParentAsEngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
                Control = new Control(),
                ControlId = "",
            };
            // Make the request
            Control response = await controlServiceClient.CreateControlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateControl</summary>
        public void CreateControl()
        {
            // Snippet: CreateControl(string, Control, string, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = ControlServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
            Control control = new Control();
            string controlId = "";
            // Make the request
            Control response = controlServiceClient.CreateControl(parent, control, controlId);
            // End snippet
        }

        /// <summary>Snippet for CreateControlAsync</summary>
        public async Task CreateControlAsync()
        {
            // Snippet: CreateControlAsync(string, Control, string, CallSettings)
            // Additional: CreateControlAsync(string, Control, string, CancellationToken)
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
            Control control = new Control();
            string controlId = "";
            // Make the request
            Control response = await controlServiceClient.CreateControlAsync(parent, control, controlId);
            // End snippet
        }

        /// <summary>Snippet for CreateControl</summary>
        public void CreateControlResourceNames1()
        {
            // Snippet: CreateControl(EngineName, Control, string, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = ControlServiceClient.Create();
            // Initialize request argument(s)
            EngineName parent = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
            Control control = new Control();
            string controlId = "";
            // Make the request
            Control response = controlServiceClient.CreateControl(parent, control, controlId);
            // End snippet
        }

        /// <summary>Snippet for CreateControlAsync</summary>
        public async Task CreateControlResourceNames1Async()
        {
            // Snippet: CreateControlAsync(EngineName, Control, string, CallSettings)
            // Additional: CreateControlAsync(EngineName, Control, string, CancellationToken)
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            EngineName parent = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
            Control control = new Control();
            string controlId = "";
            // Make the request
            Control response = await controlServiceClient.CreateControlAsync(parent, control, controlId);
            // End snippet
        }

        /// <summary>Snippet for CreateControl</summary>
        public void CreateControlResourceNames2()
        {
            // Snippet: CreateControl(DataStoreName, Control, string, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = ControlServiceClient.Create();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            Control control = new Control();
            string controlId = "";
            // Make the request
            Control response = controlServiceClient.CreateControl(parent, control, controlId);
            // End snippet
        }

        /// <summary>Snippet for CreateControlAsync</summary>
        public async Task CreateControlResourceNames2Async()
        {
            // Snippet: CreateControlAsync(DataStoreName, Control, string, CallSettings)
            // Additional: CreateControlAsync(DataStoreName, Control, string, CancellationToken)
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            Control control = new Control();
            string controlId = "";
            // Make the request
            Control response = await controlServiceClient.CreateControlAsync(parent, control, controlId);
            // End snippet
        }

        /// <summary>Snippet for DeleteControl</summary>
        public void DeleteControlRequestObject()
        {
            // Snippet: DeleteControl(DeleteControlRequest, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = ControlServiceClient.Create();
            // Initialize request argument(s)
            DeleteControlRequest request = new DeleteControlRequest
            {
                ControlName = ControlName.FromProjectLocationDataStoreControl("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONTROL]"),
            };
            // Make the request
            controlServiceClient.DeleteControl(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteControlAsync</summary>
        public async Task DeleteControlRequestObjectAsync()
        {
            // Snippet: DeleteControlAsync(DeleteControlRequest, CallSettings)
            // Additional: DeleteControlAsync(DeleteControlRequest, CancellationToken)
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteControlRequest request = new DeleteControlRequest
            {
                ControlName = ControlName.FromProjectLocationDataStoreControl("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONTROL]"),
            };
            // Make the request
            await controlServiceClient.DeleteControlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteControl</summary>
        public void DeleteControl()
        {
            // Snippet: DeleteControl(string, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = ControlServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/controls/[CONTROL]";
            // Make the request
            controlServiceClient.DeleteControl(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteControlAsync</summary>
        public async Task DeleteControlAsync()
        {
            // Snippet: DeleteControlAsync(string, CallSettings)
            // Additional: DeleteControlAsync(string, CancellationToken)
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/controls/[CONTROL]";
            // Make the request
            await controlServiceClient.DeleteControlAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteControl</summary>
        public void DeleteControlResourceNames()
        {
            // Snippet: DeleteControl(ControlName, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = ControlServiceClient.Create();
            // Initialize request argument(s)
            ControlName name = ControlName.FromProjectLocationDataStoreControl("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONTROL]");
            // Make the request
            controlServiceClient.DeleteControl(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteControlAsync</summary>
        public async Task DeleteControlResourceNamesAsync()
        {
            // Snippet: DeleteControlAsync(ControlName, CallSettings)
            // Additional: DeleteControlAsync(ControlName, CancellationToken)
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            ControlName name = ControlName.FromProjectLocationDataStoreControl("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONTROL]");
            // Make the request
            await controlServiceClient.DeleteControlAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateControl</summary>
        public void UpdateControlRequestObject()
        {
            // Snippet: UpdateControl(UpdateControlRequest, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = ControlServiceClient.Create();
            // Initialize request argument(s)
            UpdateControlRequest request = new UpdateControlRequest
            {
                Control = new Control(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Control response = controlServiceClient.UpdateControl(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateControlAsync</summary>
        public async Task UpdateControlRequestObjectAsync()
        {
            // Snippet: UpdateControlAsync(UpdateControlRequest, CallSettings)
            // Additional: UpdateControlAsync(UpdateControlRequest, CancellationToken)
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateControlRequest request = new UpdateControlRequest
            {
                Control = new Control(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Control response = await controlServiceClient.UpdateControlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateControl</summary>
        public void UpdateControl()
        {
            // Snippet: UpdateControl(Control, FieldMask, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = ControlServiceClient.Create();
            // Initialize request argument(s)
            Control control = new Control();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Control response = controlServiceClient.UpdateControl(control, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateControlAsync</summary>
        public async Task UpdateControlAsync()
        {
            // Snippet: UpdateControlAsync(Control, FieldMask, CallSettings)
            // Additional: UpdateControlAsync(Control, FieldMask, CancellationToken)
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            Control control = new Control();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Control response = await controlServiceClient.UpdateControlAsync(control, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetControl</summary>
        public void GetControlRequestObject()
        {
            // Snippet: GetControl(GetControlRequest, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = ControlServiceClient.Create();
            // Initialize request argument(s)
            GetControlRequest request = new GetControlRequest
            {
                ControlName = ControlName.FromProjectLocationDataStoreControl("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONTROL]"),
            };
            // Make the request
            Control response = controlServiceClient.GetControl(request);
            // End snippet
        }

        /// <summary>Snippet for GetControlAsync</summary>
        public async Task GetControlRequestObjectAsync()
        {
            // Snippet: GetControlAsync(GetControlRequest, CallSettings)
            // Additional: GetControlAsync(GetControlRequest, CancellationToken)
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetControlRequest request = new GetControlRequest
            {
                ControlName = ControlName.FromProjectLocationDataStoreControl("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONTROL]"),
            };
            // Make the request
            Control response = await controlServiceClient.GetControlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetControl</summary>
        public void GetControl()
        {
            // Snippet: GetControl(string, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = ControlServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/controls/[CONTROL]";
            // Make the request
            Control response = controlServiceClient.GetControl(name);
            // End snippet
        }

        /// <summary>Snippet for GetControlAsync</summary>
        public async Task GetControlAsync()
        {
            // Snippet: GetControlAsync(string, CallSettings)
            // Additional: GetControlAsync(string, CancellationToken)
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/controls/[CONTROL]";
            // Make the request
            Control response = await controlServiceClient.GetControlAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetControl</summary>
        public void GetControlResourceNames()
        {
            // Snippet: GetControl(ControlName, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = ControlServiceClient.Create();
            // Initialize request argument(s)
            ControlName name = ControlName.FromProjectLocationDataStoreControl("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONTROL]");
            // Make the request
            Control response = controlServiceClient.GetControl(name);
            // End snippet
        }

        /// <summary>Snippet for GetControlAsync</summary>
        public async Task GetControlResourceNamesAsync()
        {
            // Snippet: GetControlAsync(ControlName, CallSettings)
            // Additional: GetControlAsync(ControlName, CancellationToken)
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            ControlName name = ControlName.FromProjectLocationDataStoreControl("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONTROL]");
            // Make the request
            Control response = await controlServiceClient.GetControlAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListControls</summary>
        public void ListControlsRequestObject()
        {
            // Snippet: ListControls(ListControlsRequest, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = ControlServiceClient.Create();
            // Initialize request argument(s)
            ListControlsRequest request = new ListControlsRequest
            {
                ParentAsEngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListControlsResponse, Control> response = controlServiceClient.ListControls(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Control item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListControlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Control item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Control> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Control item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControlsAsync</summary>
        public async Task ListControlsRequestObjectAsync()
        {
            // Snippet: ListControlsAsync(ListControlsRequest, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListControlsRequest request = new ListControlsRequest
            {
                ParentAsEngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListControlsResponse, Control> response = controlServiceClient.ListControlsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Control item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListControlsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Control item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Control> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Control item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControls</summary>
        public void ListControls()
        {
            // Snippet: ListControls(string, string, int?, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = ControlServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
            // Make the request
            PagedEnumerable<ListControlsResponse, Control> response = controlServiceClient.ListControls(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Control item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListControlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Control item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Control> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Control item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControlsAsync</summary>
        public async Task ListControlsAsync()
        {
            // Snippet: ListControlsAsync(string, string, int?, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
            // Make the request
            PagedAsyncEnumerable<ListControlsResponse, Control> response = controlServiceClient.ListControlsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Control item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListControlsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Control item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Control> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Control item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControls</summary>
        public void ListControlsResourceNames1()
        {
            // Snippet: ListControls(EngineName, string, int?, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = ControlServiceClient.Create();
            // Initialize request argument(s)
            EngineName parent = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
            // Make the request
            PagedEnumerable<ListControlsResponse, Control> response = controlServiceClient.ListControls(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Control item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListControlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Control item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Control> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Control item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControlsAsync</summary>
        public async Task ListControlsResourceNames1Async()
        {
            // Snippet: ListControlsAsync(EngineName, string, int?, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            EngineName parent = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
            // Make the request
            PagedAsyncEnumerable<ListControlsResponse, Control> response = controlServiceClient.ListControlsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Control item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListControlsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Control item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Control> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Control item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControls</summary>
        public void ListControlsResourceNames2()
        {
            // Snippet: ListControls(DataStoreName, string, int?, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = ControlServiceClient.Create();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            PagedEnumerable<ListControlsResponse, Control> response = controlServiceClient.ListControls(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Control item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListControlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Control item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Control> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Control item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControlsAsync</summary>
        public async Task ListControlsResourceNames2Async()
        {
            // Snippet: ListControlsAsync(DataStoreName, string, int?, CallSettings)
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            PagedAsyncEnumerable<ListControlsResponse, Control> response = controlServiceClient.ListControlsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Control item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListControlsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Control item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Control> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Control item in singlePage)
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
