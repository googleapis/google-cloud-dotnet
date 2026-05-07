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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLabelServiceClientSnippets
    {
        /// <summary>Snippet for GetLabel</summary>
        public void GetLabelRequestObject()
        {
            // Snippet: GetLabel(GetLabelRequest, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            GetLabelRequest request = new GetLabelRequest
            {
                LabelName = LabelName.FromNetworkCodeLabel("[NETWORK_CODE]", "[LABEL]"),
            };
            // Make the request
            Label response = labelServiceClient.GetLabel(request);
            // End snippet
        }

        /// <summary>Snippet for GetLabelAsync</summary>
        public async Task GetLabelRequestObjectAsync()
        {
            // Snippet: GetLabelAsync(GetLabelRequest, CallSettings)
            // Additional: GetLabelAsync(GetLabelRequest, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLabelRequest request = new GetLabelRequest
            {
                LabelName = LabelName.FromNetworkCodeLabel("[NETWORK_CODE]", "[LABEL]"),
            };
            // Make the request
            Label response = await labelServiceClient.GetLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLabel</summary>
        public void GetLabel()
        {
            // Snippet: GetLabel(string, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/labels/[LABEL]";
            // Make the request
            Label response = labelServiceClient.GetLabel(name);
            // End snippet
        }

        /// <summary>Snippet for GetLabelAsync</summary>
        public async Task GetLabelAsync()
        {
            // Snippet: GetLabelAsync(string, CallSettings)
            // Additional: GetLabelAsync(string, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/labels/[LABEL]";
            // Make the request
            Label response = await labelServiceClient.GetLabelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLabel</summary>
        public void GetLabelResourceNames()
        {
            // Snippet: GetLabel(LabelName, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            LabelName name = LabelName.FromNetworkCodeLabel("[NETWORK_CODE]", "[LABEL]");
            // Make the request
            Label response = labelServiceClient.GetLabel(name);
            // End snippet
        }

        /// <summary>Snippet for GetLabelAsync</summary>
        public async Task GetLabelResourceNamesAsync()
        {
            // Snippet: GetLabelAsync(LabelName, CallSettings)
            // Additional: GetLabelAsync(LabelName, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            LabelName name = LabelName.FromNetworkCodeLabel("[NETWORK_CODE]", "[LABEL]");
            // Make the request
            Label response = await labelServiceClient.GetLabelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLabels</summary>
        public void ListLabelsRequestObject()
        {
            // Snippet: ListLabels(ListLabelsRequest, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            ListLabelsRequest request = new ListLabelsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListLabelsResponse, Label> response = labelServiceClient.ListLabels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Label item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLabelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Label item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Label> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Label item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLabelsAsync</summary>
        public async Task ListLabelsRequestObjectAsync()
        {
            // Snippet: ListLabelsAsync(ListLabelsRequest, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLabelsRequest request = new ListLabelsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListLabelsResponse, Label> response = labelServiceClient.ListLabelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Label item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLabelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Label item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Label> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Label item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLabels</summary>
        public void ListLabels()
        {
            // Snippet: ListLabels(string, string, int?, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListLabelsResponse, Label> response = labelServiceClient.ListLabels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Label item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLabelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Label item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Label> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Label item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLabelsAsync</summary>
        public async Task ListLabelsAsync()
        {
            // Snippet: ListLabelsAsync(string, string, int?, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListLabelsResponse, Label> response = labelServiceClient.ListLabelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Label item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLabelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Label item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Label> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Label item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLabels</summary>
        public void ListLabelsResourceNames()
        {
            // Snippet: ListLabels(NetworkName, string, int?, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListLabelsResponse, Label> response = labelServiceClient.ListLabels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Label item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLabelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Label item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Label> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Label item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLabelsAsync</summary>
        public async Task ListLabelsResourceNamesAsync()
        {
            // Snippet: ListLabelsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListLabelsResponse, Label> response = labelServiceClient.ListLabelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Label item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLabelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Label item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Label> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Label item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateLabel</summary>
        public void CreateLabelRequestObject()
        {
            // Snippet: CreateLabel(CreateLabelRequest, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            CreateLabelRequest request = new CreateLabelRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Label = new Label(),
            };
            // Make the request
            Label response = labelServiceClient.CreateLabel(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLabelAsync</summary>
        public async Task CreateLabelRequestObjectAsync()
        {
            // Snippet: CreateLabelAsync(CreateLabelRequest, CallSettings)
            // Additional: CreateLabelAsync(CreateLabelRequest, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateLabelRequest request = new CreateLabelRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Label = new Label(),
            };
            // Make the request
            Label response = await labelServiceClient.CreateLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLabel</summary>
        public void CreateLabel()
        {
            // Snippet: CreateLabel(string, Label, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Label label = new Label();
            // Make the request
            Label response = labelServiceClient.CreateLabel(parent, label);
            // End snippet
        }

        /// <summary>Snippet for CreateLabelAsync</summary>
        public async Task CreateLabelAsync()
        {
            // Snippet: CreateLabelAsync(string, Label, CallSettings)
            // Additional: CreateLabelAsync(string, Label, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Label label = new Label();
            // Make the request
            Label response = await labelServiceClient.CreateLabelAsync(parent, label);
            // End snippet
        }

        /// <summary>Snippet for CreateLabel</summary>
        public void CreateLabelResourceNames()
        {
            // Snippet: CreateLabel(NetworkName, Label, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Label label = new Label();
            // Make the request
            Label response = labelServiceClient.CreateLabel(parent, label);
            // End snippet
        }

        /// <summary>Snippet for CreateLabelAsync</summary>
        public async Task CreateLabelResourceNamesAsync()
        {
            // Snippet: CreateLabelAsync(NetworkName, Label, CallSettings)
            // Additional: CreateLabelAsync(NetworkName, Label, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Label label = new Label();
            // Make the request
            Label response = await labelServiceClient.CreateLabelAsync(parent, label);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLabels</summary>
        public void BatchCreateLabelsRequestObject()
        {
            // Snippet: BatchCreateLabels(BatchCreateLabelsRequest, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateLabelsRequest request = new BatchCreateLabelsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateLabelRequest(),
                },
            };
            // Make the request
            BatchCreateLabelsResponse response = labelServiceClient.BatchCreateLabels(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLabelsAsync</summary>
        public async Task BatchCreateLabelsRequestObjectAsync()
        {
            // Snippet: BatchCreateLabelsAsync(BatchCreateLabelsRequest, CallSettings)
            // Additional: BatchCreateLabelsAsync(BatchCreateLabelsRequest, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateLabelsRequest request = new BatchCreateLabelsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateLabelRequest(),
                },
            };
            // Make the request
            BatchCreateLabelsResponse response = await labelServiceClient.BatchCreateLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLabels</summary>
        public void BatchCreateLabels()
        {
            // Snippet: BatchCreateLabels(string, IEnumerable<CreateLabelRequest>, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateLabelRequest> requests = new CreateLabelRequest[]
            {
                new CreateLabelRequest(),
            };
            // Make the request
            BatchCreateLabelsResponse response = labelServiceClient.BatchCreateLabels(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLabelsAsync</summary>
        public async Task BatchCreateLabelsAsync()
        {
            // Snippet: BatchCreateLabelsAsync(string, IEnumerable<CreateLabelRequest>, CallSettings)
            // Additional: BatchCreateLabelsAsync(string, IEnumerable<CreateLabelRequest>, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateLabelRequest> requests = new CreateLabelRequest[]
            {
                new CreateLabelRequest(),
            };
            // Make the request
            BatchCreateLabelsResponse response = await labelServiceClient.BatchCreateLabelsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLabels</summary>
        public void BatchCreateLabelsResourceNames()
        {
            // Snippet: BatchCreateLabels(NetworkName, IEnumerable<CreateLabelRequest>, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateLabelRequest> requests = new CreateLabelRequest[]
            {
                new CreateLabelRequest(),
            };
            // Make the request
            BatchCreateLabelsResponse response = labelServiceClient.BatchCreateLabels(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLabelsAsync</summary>
        public async Task BatchCreateLabelsResourceNamesAsync()
        {
            // Snippet: BatchCreateLabelsAsync(NetworkName, IEnumerable<CreateLabelRequest>, CallSettings)
            // Additional: BatchCreateLabelsAsync(NetworkName, IEnumerable<CreateLabelRequest>, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateLabelRequest> requests = new CreateLabelRequest[]
            {
                new CreateLabelRequest(),
            };
            // Make the request
            BatchCreateLabelsResponse response = await labelServiceClient.BatchCreateLabelsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateLabel</summary>
        public void UpdateLabelRequestObject()
        {
            // Snippet: UpdateLabel(UpdateLabelRequest, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            UpdateLabelRequest request = new UpdateLabelRequest
            {
                Label = new Label(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Label response = labelServiceClient.UpdateLabel(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLabelAsync</summary>
        public async Task UpdateLabelRequestObjectAsync()
        {
            // Snippet: UpdateLabelAsync(UpdateLabelRequest, CallSettings)
            // Additional: UpdateLabelAsync(UpdateLabelRequest, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateLabelRequest request = new UpdateLabelRequest
            {
                Label = new Label(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Label response = await labelServiceClient.UpdateLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLabel</summary>
        public void UpdateLabel()
        {
            // Snippet: UpdateLabel(Label, FieldMask, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            Label label = new Label();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Label response = labelServiceClient.UpdateLabel(label, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateLabelAsync</summary>
        public async Task UpdateLabelAsync()
        {
            // Snippet: UpdateLabelAsync(Label, FieldMask, CallSettings)
            // Additional: UpdateLabelAsync(Label, FieldMask, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            Label label = new Label();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Label response = await labelServiceClient.UpdateLabelAsync(label, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLabels</summary>
        public void BatchUpdateLabelsRequestObject()
        {
            // Snippet: BatchUpdateLabels(BatchUpdateLabelsRequest, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateLabelsRequest request = new BatchUpdateLabelsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateLabelRequest(),
                },
            };
            // Make the request
            BatchUpdateLabelsResponse response = labelServiceClient.BatchUpdateLabels(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLabelsAsync</summary>
        public async Task BatchUpdateLabelsRequestObjectAsync()
        {
            // Snippet: BatchUpdateLabelsAsync(BatchUpdateLabelsRequest, CallSettings)
            // Additional: BatchUpdateLabelsAsync(BatchUpdateLabelsRequest, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateLabelsRequest request = new BatchUpdateLabelsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateLabelRequest(),
                },
            };
            // Make the request
            BatchUpdateLabelsResponse response = await labelServiceClient.BatchUpdateLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLabels</summary>
        public void BatchUpdateLabels()
        {
            // Snippet: BatchUpdateLabels(string, IEnumerable<UpdateLabelRequest>, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateLabelRequest> requests = new UpdateLabelRequest[]
            {
                new UpdateLabelRequest(),
            };
            // Make the request
            BatchUpdateLabelsResponse response = labelServiceClient.BatchUpdateLabels(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLabelsAsync</summary>
        public async Task BatchUpdateLabelsAsync()
        {
            // Snippet: BatchUpdateLabelsAsync(string, IEnumerable<UpdateLabelRequest>, CallSettings)
            // Additional: BatchUpdateLabelsAsync(string, IEnumerable<UpdateLabelRequest>, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateLabelRequest> requests = new UpdateLabelRequest[]
            {
                new UpdateLabelRequest(),
            };
            // Make the request
            BatchUpdateLabelsResponse response = await labelServiceClient.BatchUpdateLabelsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLabels</summary>
        public void BatchUpdateLabelsResourceNames()
        {
            // Snippet: BatchUpdateLabels(NetworkName, IEnumerable<UpdateLabelRequest>, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateLabelRequest> requests = new UpdateLabelRequest[]
            {
                new UpdateLabelRequest(),
            };
            // Make the request
            BatchUpdateLabelsResponse response = labelServiceClient.BatchUpdateLabels(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLabelsAsync</summary>
        public async Task BatchUpdateLabelsResourceNamesAsync()
        {
            // Snippet: BatchUpdateLabelsAsync(NetworkName, IEnumerable<UpdateLabelRequest>, CallSettings)
            // Additional: BatchUpdateLabelsAsync(NetworkName, IEnumerable<UpdateLabelRequest>, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateLabelRequest> requests = new UpdateLabelRequest[]
            {
                new UpdateLabelRequest(),
            };
            // Make the request
            BatchUpdateLabelsResponse response = await labelServiceClient.BatchUpdateLabelsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLabels</summary>
        public void BatchActivateLabelsRequestObject()
        {
            // Snippet: BatchActivateLabels(BatchActivateLabelsRequest, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateLabelsRequest request = new BatchActivateLabelsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LabelNames =
                {
                    LabelName.FromNetworkCodeLabel("[NETWORK_CODE]", "[LABEL]"),
                },
            };
            // Make the request
            BatchActivateLabelsResponse response = labelServiceClient.BatchActivateLabels(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLabelsAsync</summary>
        public async Task BatchActivateLabelsRequestObjectAsync()
        {
            // Snippet: BatchActivateLabelsAsync(BatchActivateLabelsRequest, CallSettings)
            // Additional: BatchActivateLabelsAsync(BatchActivateLabelsRequest, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateLabelsRequest request = new BatchActivateLabelsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LabelNames =
                {
                    LabelName.FromNetworkCodeLabel("[NETWORK_CODE]", "[LABEL]"),
                },
            };
            // Make the request
            BatchActivateLabelsResponse response = await labelServiceClient.BatchActivateLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLabels</summary>
        public void BatchActivateLabels()
        {
            // Snippet: BatchActivateLabels(string, IEnumerable<string>, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/labels/[LABEL]",
            };
            // Make the request
            BatchActivateLabelsResponse response = labelServiceClient.BatchActivateLabels(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLabelsAsync</summary>
        public async Task BatchActivateLabelsAsync()
        {
            // Snippet: BatchActivateLabelsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateLabelsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/labels/[LABEL]",
            };
            // Make the request
            BatchActivateLabelsResponse response = await labelServiceClient.BatchActivateLabelsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLabels</summary>
        public void BatchActivateLabelsResourceNames()
        {
            // Snippet: BatchActivateLabels(NetworkName, IEnumerable<LabelName>, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LabelName> names = new LabelName[]
            {
                LabelName.FromNetworkCodeLabel("[NETWORK_CODE]", "[LABEL]"),
            };
            // Make the request
            BatchActivateLabelsResponse response = labelServiceClient.BatchActivateLabels(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLabelsAsync</summary>
        public async Task BatchActivateLabelsResourceNamesAsync()
        {
            // Snippet: BatchActivateLabelsAsync(NetworkName, IEnumerable<LabelName>, CallSettings)
            // Additional: BatchActivateLabelsAsync(NetworkName, IEnumerable<LabelName>, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LabelName> names = new LabelName[]
            {
                LabelName.FromNetworkCodeLabel("[NETWORK_CODE]", "[LABEL]"),
            };
            // Make the request
            BatchActivateLabelsResponse response = await labelServiceClient.BatchActivateLabelsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateLabels</summary>
        public void BatchDeactivateLabelsRequestObject()
        {
            // Snippet: BatchDeactivateLabels(BatchDeactivateLabelsRequest, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateLabelsRequest request = new BatchDeactivateLabelsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LabelNames =
                {
                    LabelName.FromNetworkCodeLabel("[NETWORK_CODE]", "[LABEL]"),
                },
            };
            // Make the request
            BatchDeactivateLabelsResponse response = labelServiceClient.BatchDeactivateLabels(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateLabelsAsync</summary>
        public async Task BatchDeactivateLabelsRequestObjectAsync()
        {
            // Snippet: BatchDeactivateLabelsAsync(BatchDeactivateLabelsRequest, CallSettings)
            // Additional: BatchDeactivateLabelsAsync(BatchDeactivateLabelsRequest, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateLabelsRequest request = new BatchDeactivateLabelsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LabelNames =
                {
                    LabelName.FromNetworkCodeLabel("[NETWORK_CODE]", "[LABEL]"),
                },
            };
            // Make the request
            BatchDeactivateLabelsResponse response = await labelServiceClient.BatchDeactivateLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateLabels</summary>
        public void BatchDeactivateLabels()
        {
            // Snippet: BatchDeactivateLabels(string, IEnumerable<string>, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/labels/[LABEL]",
            };
            // Make the request
            BatchDeactivateLabelsResponse response = labelServiceClient.BatchDeactivateLabels(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateLabelsAsync</summary>
        public async Task BatchDeactivateLabelsAsync()
        {
            // Snippet: BatchDeactivateLabelsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateLabelsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/labels/[LABEL]",
            };
            // Make the request
            BatchDeactivateLabelsResponse response = await labelServiceClient.BatchDeactivateLabelsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateLabels</summary>
        public void BatchDeactivateLabelsResourceNames()
        {
            // Snippet: BatchDeactivateLabels(NetworkName, IEnumerable<LabelName>, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LabelName> names = new LabelName[]
            {
                LabelName.FromNetworkCodeLabel("[NETWORK_CODE]", "[LABEL]"),
            };
            // Make the request
            BatchDeactivateLabelsResponse response = labelServiceClient.BatchDeactivateLabels(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateLabelsAsync</summary>
        public async Task BatchDeactivateLabelsResourceNamesAsync()
        {
            // Snippet: BatchDeactivateLabelsAsync(NetworkName, IEnumerable<LabelName>, CallSettings)
            // Additional: BatchDeactivateLabelsAsync(NetworkName, IEnumerable<LabelName>, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LabelName> names = new LabelName[]
            {
                LabelName.FromNetworkCodeLabel("[NETWORK_CODE]", "[LABEL]"),
            };
            // Make the request
            BatchDeactivateLabelsResponse response = await labelServiceClient.BatchDeactivateLabelsAsync(parent, names);
            // End snippet
        }
    }
}
