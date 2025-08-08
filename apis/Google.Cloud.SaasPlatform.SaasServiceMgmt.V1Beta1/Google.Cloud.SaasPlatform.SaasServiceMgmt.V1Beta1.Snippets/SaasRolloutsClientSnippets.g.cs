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
    using Google.Cloud.SaasPlatform.SaasServiceMgmt.V1Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSaasRolloutsClientSnippets
    {
        /// <summary>Snippet for ListRollouts</summary>
        public void ListRolloutsRequestObject()
        {
            // Snippet: ListRollouts(ListRolloutsRequest, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            ListRolloutsRequest request = new ListRolloutsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListRolloutsResponse, Rollout> response = saasRolloutsClient.ListRollouts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rollout item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRolloutsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolloutsAsync</summary>
        public async Task ListRolloutsRequestObjectAsync()
        {
            // Snippet: ListRolloutsAsync(ListRolloutsRequest, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            ListRolloutsRequest request = new ListRolloutsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRolloutsResponse, Rollout> response = saasRolloutsClient.ListRolloutsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rollout item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRolloutsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRollouts</summary>
        public void ListRollouts()
        {
            // Snippet: ListRollouts(string, string, int?, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListRolloutsResponse, Rollout> response = saasRolloutsClient.ListRollouts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rollout item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRolloutsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolloutsAsync</summary>
        public async Task ListRolloutsAsync()
        {
            // Snippet: ListRolloutsAsync(string, string, int?, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListRolloutsResponse, Rollout> response = saasRolloutsClient.ListRolloutsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rollout item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRolloutsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRollouts</summary>
        public void ListRolloutsResourceNames()
        {
            // Snippet: ListRollouts(LocationName, string, int?, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListRolloutsResponse, Rollout> response = saasRolloutsClient.ListRollouts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rollout item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRolloutsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolloutsAsync</summary>
        public async Task ListRolloutsResourceNamesAsync()
        {
            // Snippet: ListRolloutsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListRolloutsResponse, Rollout> response = saasRolloutsClient.ListRolloutsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rollout item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRolloutsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRollout</summary>
        public void GetRolloutRequestObject()
        {
            // Snippet: GetRollout(GetRolloutRequest, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            GetRolloutRequest request = new GetRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationRollout("[PROJECT]", "[LOCATION]", "[ROLLOUT_ID]"),
            };
            // Make the request
            Rollout response = saasRolloutsClient.GetRollout(request);
            // End snippet
        }

        /// <summary>Snippet for GetRolloutAsync</summary>
        public async Task GetRolloutRequestObjectAsync()
        {
            // Snippet: GetRolloutAsync(GetRolloutRequest, CallSettings)
            // Additional: GetRolloutAsync(GetRolloutRequest, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            GetRolloutRequest request = new GetRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationRollout("[PROJECT]", "[LOCATION]", "[ROLLOUT_ID]"),
            };
            // Make the request
            Rollout response = await saasRolloutsClient.GetRolloutAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRollout</summary>
        public void GetRollout()
        {
            // Snippet: GetRollout(string, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/rollouts/[ROLLOUT_ID]";
            // Make the request
            Rollout response = saasRolloutsClient.GetRollout(name);
            // End snippet
        }

        /// <summary>Snippet for GetRolloutAsync</summary>
        public async Task GetRolloutAsync()
        {
            // Snippet: GetRolloutAsync(string, CallSettings)
            // Additional: GetRolloutAsync(string, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/rollouts/[ROLLOUT_ID]";
            // Make the request
            Rollout response = await saasRolloutsClient.GetRolloutAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRollout</summary>
        public void GetRolloutResourceNames()
        {
            // Snippet: GetRollout(RolloutName, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationRollout("[PROJECT]", "[LOCATION]", "[ROLLOUT_ID]");
            // Make the request
            Rollout response = saasRolloutsClient.GetRollout(name);
            // End snippet
        }

        /// <summary>Snippet for GetRolloutAsync</summary>
        public async Task GetRolloutResourceNamesAsync()
        {
            // Snippet: GetRolloutAsync(RolloutName, CallSettings)
            // Additional: GetRolloutAsync(RolloutName, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationRollout("[PROJECT]", "[LOCATION]", "[ROLLOUT_ID]");
            // Make the request
            Rollout response = await saasRolloutsClient.GetRolloutAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRollout</summary>
        public void CreateRolloutRequestObject()
        {
            // Snippet: CreateRollout(CreateRolloutRequest, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            CreateRolloutRequest request = new CreateRolloutRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                RequestId = "",
                RolloutId = "",
                Rollout = new Rollout(),
            };
            // Make the request
            Rollout response = saasRolloutsClient.CreateRollout(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRolloutAsync</summary>
        public async Task CreateRolloutRequestObjectAsync()
        {
            // Snippet: CreateRolloutAsync(CreateRolloutRequest, CallSettings)
            // Additional: CreateRolloutAsync(CreateRolloutRequest, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            CreateRolloutRequest request = new CreateRolloutRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                RequestId = "",
                RolloutId = "",
                Rollout = new Rollout(),
            };
            // Make the request
            Rollout response = await saasRolloutsClient.CreateRolloutAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRollout</summary>
        public void CreateRollout()
        {
            // Snippet: CreateRollout(string, Rollout, string, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Rollout rollout = new Rollout();
            string rolloutId = "";
            // Make the request
            Rollout response = saasRolloutsClient.CreateRollout(parent, rollout, rolloutId);
            // End snippet
        }

        /// <summary>Snippet for CreateRolloutAsync</summary>
        public async Task CreateRolloutAsync()
        {
            // Snippet: CreateRolloutAsync(string, Rollout, string, CallSettings)
            // Additional: CreateRolloutAsync(string, Rollout, string, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Rollout rollout = new Rollout();
            string rolloutId = "";
            // Make the request
            Rollout response = await saasRolloutsClient.CreateRolloutAsync(parent, rollout, rolloutId);
            // End snippet
        }

        /// <summary>Snippet for CreateRollout</summary>
        public void CreateRolloutResourceNames()
        {
            // Snippet: CreateRollout(LocationName, Rollout, string, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Rollout rollout = new Rollout();
            string rolloutId = "";
            // Make the request
            Rollout response = saasRolloutsClient.CreateRollout(parent, rollout, rolloutId);
            // End snippet
        }

        /// <summary>Snippet for CreateRolloutAsync</summary>
        public async Task CreateRolloutResourceNamesAsync()
        {
            // Snippet: CreateRolloutAsync(LocationName, Rollout, string, CallSettings)
            // Additional: CreateRolloutAsync(LocationName, Rollout, string, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Rollout rollout = new Rollout();
            string rolloutId = "";
            // Make the request
            Rollout response = await saasRolloutsClient.CreateRolloutAsync(parent, rollout, rolloutId);
            // End snippet
        }

        /// <summary>Snippet for UpdateRollout</summary>
        public void UpdateRolloutRequestObject()
        {
            // Snippet: UpdateRollout(UpdateRolloutRequest, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            UpdateRolloutRequest request = new UpdateRolloutRequest
            {
                ValidateOnly = false,
                RequestId = "",
                Rollout = new Rollout(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Rollout response = saasRolloutsClient.UpdateRollout(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRolloutAsync</summary>
        public async Task UpdateRolloutRequestObjectAsync()
        {
            // Snippet: UpdateRolloutAsync(UpdateRolloutRequest, CallSettings)
            // Additional: UpdateRolloutAsync(UpdateRolloutRequest, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRolloutRequest request = new UpdateRolloutRequest
            {
                ValidateOnly = false,
                RequestId = "",
                Rollout = new Rollout(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Rollout response = await saasRolloutsClient.UpdateRolloutAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRollout</summary>
        public void UpdateRollout()
        {
            // Snippet: UpdateRollout(Rollout, FieldMask, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            Rollout rollout = new Rollout();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Rollout response = saasRolloutsClient.UpdateRollout(rollout, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateRolloutAsync</summary>
        public async Task UpdateRolloutAsync()
        {
            // Snippet: UpdateRolloutAsync(Rollout, FieldMask, CallSettings)
            // Additional: UpdateRolloutAsync(Rollout, FieldMask, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            Rollout rollout = new Rollout();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Rollout response = await saasRolloutsClient.UpdateRolloutAsync(rollout, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteRollout</summary>
        public void DeleteRolloutRequestObject()
        {
            // Snippet: DeleteRollout(DeleteRolloutRequest, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            DeleteRolloutRequest request = new DeleteRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationRollout("[PROJECT]", "[LOCATION]", "[ROLLOUT_ID]"),
                Etag = "",
                ValidateOnly = false,
                RequestId = "",
            };
            // Make the request
            saasRolloutsClient.DeleteRollout(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRolloutAsync</summary>
        public async Task DeleteRolloutRequestObjectAsync()
        {
            // Snippet: DeleteRolloutAsync(DeleteRolloutRequest, CallSettings)
            // Additional: DeleteRolloutAsync(DeleteRolloutRequest, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRolloutRequest request = new DeleteRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationRollout("[PROJECT]", "[LOCATION]", "[ROLLOUT_ID]"),
                Etag = "",
                ValidateOnly = false,
                RequestId = "",
            };
            // Make the request
            await saasRolloutsClient.DeleteRolloutAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRollout</summary>
        public void DeleteRollout()
        {
            // Snippet: DeleteRollout(string, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/rollouts/[ROLLOUT_ID]";
            // Make the request
            saasRolloutsClient.DeleteRollout(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRolloutAsync</summary>
        public async Task DeleteRolloutAsync()
        {
            // Snippet: DeleteRolloutAsync(string, CallSettings)
            // Additional: DeleteRolloutAsync(string, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/rollouts/[ROLLOUT_ID]";
            // Make the request
            await saasRolloutsClient.DeleteRolloutAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRollout</summary>
        public void DeleteRolloutResourceNames()
        {
            // Snippet: DeleteRollout(RolloutName, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationRollout("[PROJECT]", "[LOCATION]", "[ROLLOUT_ID]");
            // Make the request
            saasRolloutsClient.DeleteRollout(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRolloutAsync</summary>
        public async Task DeleteRolloutResourceNamesAsync()
        {
            // Snippet: DeleteRolloutAsync(RolloutName, CallSettings)
            // Additional: DeleteRolloutAsync(RolloutName, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationRollout("[PROJECT]", "[LOCATION]", "[ROLLOUT_ID]");
            // Make the request
            await saasRolloutsClient.DeleteRolloutAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRolloutKinds</summary>
        public void ListRolloutKindsRequestObject()
        {
            // Snippet: ListRolloutKinds(ListRolloutKindsRequest, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            ListRolloutKindsRequest request = new ListRolloutKindsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListRolloutKindsResponse, RolloutKind> response = saasRolloutsClient.ListRolloutKinds(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RolloutKind item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRolloutKindsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RolloutKind item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RolloutKind> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RolloutKind item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolloutKindsAsync</summary>
        public async Task ListRolloutKindsRequestObjectAsync()
        {
            // Snippet: ListRolloutKindsAsync(ListRolloutKindsRequest, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            ListRolloutKindsRequest request = new ListRolloutKindsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRolloutKindsResponse, RolloutKind> response = saasRolloutsClient.ListRolloutKindsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RolloutKind item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRolloutKindsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RolloutKind item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RolloutKind> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RolloutKind item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolloutKinds</summary>
        public void ListRolloutKinds()
        {
            // Snippet: ListRolloutKinds(string, string, int?, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListRolloutKindsResponse, RolloutKind> response = saasRolloutsClient.ListRolloutKinds(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RolloutKind item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRolloutKindsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RolloutKind item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RolloutKind> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RolloutKind item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolloutKindsAsync</summary>
        public async Task ListRolloutKindsAsync()
        {
            // Snippet: ListRolloutKindsAsync(string, string, int?, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListRolloutKindsResponse, RolloutKind> response = saasRolloutsClient.ListRolloutKindsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RolloutKind item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRolloutKindsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RolloutKind item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RolloutKind> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RolloutKind item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolloutKinds</summary>
        public void ListRolloutKindsResourceNames()
        {
            // Snippet: ListRolloutKinds(LocationName, string, int?, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListRolloutKindsResponse, RolloutKind> response = saasRolloutsClient.ListRolloutKinds(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RolloutKind item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRolloutKindsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RolloutKind item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RolloutKind> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RolloutKind item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolloutKindsAsync</summary>
        public async Task ListRolloutKindsResourceNamesAsync()
        {
            // Snippet: ListRolloutKindsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListRolloutKindsResponse, RolloutKind> response = saasRolloutsClient.ListRolloutKindsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RolloutKind item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRolloutKindsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RolloutKind item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RolloutKind> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RolloutKind item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRolloutKind</summary>
        public void GetRolloutKindRequestObject()
        {
            // Snippet: GetRolloutKind(GetRolloutKindRequest, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            GetRolloutKindRequest request = new GetRolloutKindRequest
            {
                RolloutKindName = RolloutKindName.FromProjectLocationRolloutKind("[PROJECT]", "[LOCATION]", "[ROLLOUT_KIND_ID]"),
            };
            // Make the request
            RolloutKind response = saasRolloutsClient.GetRolloutKind(request);
            // End snippet
        }

        /// <summary>Snippet for GetRolloutKindAsync</summary>
        public async Task GetRolloutKindRequestObjectAsync()
        {
            // Snippet: GetRolloutKindAsync(GetRolloutKindRequest, CallSettings)
            // Additional: GetRolloutKindAsync(GetRolloutKindRequest, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            GetRolloutKindRequest request = new GetRolloutKindRequest
            {
                RolloutKindName = RolloutKindName.FromProjectLocationRolloutKind("[PROJECT]", "[LOCATION]", "[ROLLOUT_KIND_ID]"),
            };
            // Make the request
            RolloutKind response = await saasRolloutsClient.GetRolloutKindAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRolloutKind</summary>
        public void GetRolloutKind()
        {
            // Snippet: GetRolloutKind(string, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/rolloutKinds/[ROLLOUT_KIND_ID]";
            // Make the request
            RolloutKind response = saasRolloutsClient.GetRolloutKind(name);
            // End snippet
        }

        /// <summary>Snippet for GetRolloutKindAsync</summary>
        public async Task GetRolloutKindAsync()
        {
            // Snippet: GetRolloutKindAsync(string, CallSettings)
            // Additional: GetRolloutKindAsync(string, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/rolloutKinds/[ROLLOUT_KIND_ID]";
            // Make the request
            RolloutKind response = await saasRolloutsClient.GetRolloutKindAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRolloutKind</summary>
        public void GetRolloutKindResourceNames()
        {
            // Snippet: GetRolloutKind(RolloutKindName, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            RolloutKindName name = RolloutKindName.FromProjectLocationRolloutKind("[PROJECT]", "[LOCATION]", "[ROLLOUT_KIND_ID]");
            // Make the request
            RolloutKind response = saasRolloutsClient.GetRolloutKind(name);
            // End snippet
        }

        /// <summary>Snippet for GetRolloutKindAsync</summary>
        public async Task GetRolloutKindResourceNamesAsync()
        {
            // Snippet: GetRolloutKindAsync(RolloutKindName, CallSettings)
            // Additional: GetRolloutKindAsync(RolloutKindName, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            RolloutKindName name = RolloutKindName.FromProjectLocationRolloutKind("[PROJECT]", "[LOCATION]", "[ROLLOUT_KIND_ID]");
            // Make the request
            RolloutKind response = await saasRolloutsClient.GetRolloutKindAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRolloutKind</summary>
        public void CreateRolloutKindRequestObject()
        {
            // Snippet: CreateRolloutKind(CreateRolloutKindRequest, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            CreateRolloutKindRequest request = new CreateRolloutKindRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                RequestId = "",
                RolloutKindId = "",
                RolloutKind = new RolloutKind(),
            };
            // Make the request
            RolloutKind response = saasRolloutsClient.CreateRolloutKind(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRolloutKindAsync</summary>
        public async Task CreateRolloutKindRequestObjectAsync()
        {
            // Snippet: CreateRolloutKindAsync(CreateRolloutKindRequest, CallSettings)
            // Additional: CreateRolloutKindAsync(CreateRolloutKindRequest, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            CreateRolloutKindRequest request = new CreateRolloutKindRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                RequestId = "",
                RolloutKindId = "",
                RolloutKind = new RolloutKind(),
            };
            // Make the request
            RolloutKind response = await saasRolloutsClient.CreateRolloutKindAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRolloutKind</summary>
        public void CreateRolloutKind()
        {
            // Snippet: CreateRolloutKind(string, RolloutKind, string, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            RolloutKind rolloutKind = new RolloutKind();
            string rolloutKindId = "";
            // Make the request
            RolloutKind response = saasRolloutsClient.CreateRolloutKind(parent, rolloutKind, rolloutKindId);
            // End snippet
        }

        /// <summary>Snippet for CreateRolloutKindAsync</summary>
        public async Task CreateRolloutKindAsync()
        {
            // Snippet: CreateRolloutKindAsync(string, RolloutKind, string, CallSettings)
            // Additional: CreateRolloutKindAsync(string, RolloutKind, string, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            RolloutKind rolloutKind = new RolloutKind();
            string rolloutKindId = "";
            // Make the request
            RolloutKind response = await saasRolloutsClient.CreateRolloutKindAsync(parent, rolloutKind, rolloutKindId);
            // End snippet
        }

        /// <summary>Snippet for CreateRolloutKind</summary>
        public void CreateRolloutKindResourceNames()
        {
            // Snippet: CreateRolloutKind(LocationName, RolloutKind, string, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RolloutKind rolloutKind = new RolloutKind();
            string rolloutKindId = "";
            // Make the request
            RolloutKind response = saasRolloutsClient.CreateRolloutKind(parent, rolloutKind, rolloutKindId);
            // End snippet
        }

        /// <summary>Snippet for CreateRolloutKindAsync</summary>
        public async Task CreateRolloutKindResourceNamesAsync()
        {
            // Snippet: CreateRolloutKindAsync(LocationName, RolloutKind, string, CallSettings)
            // Additional: CreateRolloutKindAsync(LocationName, RolloutKind, string, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RolloutKind rolloutKind = new RolloutKind();
            string rolloutKindId = "";
            // Make the request
            RolloutKind response = await saasRolloutsClient.CreateRolloutKindAsync(parent, rolloutKind, rolloutKindId);
            // End snippet
        }

        /// <summary>Snippet for UpdateRolloutKind</summary>
        public void UpdateRolloutKindRequestObject()
        {
            // Snippet: UpdateRolloutKind(UpdateRolloutKindRequest, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            UpdateRolloutKindRequest request = new UpdateRolloutKindRequest
            {
                ValidateOnly = false,
                RequestId = "",
                RolloutKind = new RolloutKind(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            RolloutKind response = saasRolloutsClient.UpdateRolloutKind(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRolloutKindAsync</summary>
        public async Task UpdateRolloutKindRequestObjectAsync()
        {
            // Snippet: UpdateRolloutKindAsync(UpdateRolloutKindRequest, CallSettings)
            // Additional: UpdateRolloutKindAsync(UpdateRolloutKindRequest, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRolloutKindRequest request = new UpdateRolloutKindRequest
            {
                ValidateOnly = false,
                RequestId = "",
                RolloutKind = new RolloutKind(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            RolloutKind response = await saasRolloutsClient.UpdateRolloutKindAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRolloutKind</summary>
        public void UpdateRolloutKind()
        {
            // Snippet: UpdateRolloutKind(RolloutKind, FieldMask, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            RolloutKind rolloutKind = new RolloutKind();
            FieldMask updateMask = new FieldMask();
            // Make the request
            RolloutKind response = saasRolloutsClient.UpdateRolloutKind(rolloutKind, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateRolloutKindAsync</summary>
        public async Task UpdateRolloutKindAsync()
        {
            // Snippet: UpdateRolloutKindAsync(RolloutKind, FieldMask, CallSettings)
            // Additional: UpdateRolloutKindAsync(RolloutKind, FieldMask, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            RolloutKind rolloutKind = new RolloutKind();
            FieldMask updateMask = new FieldMask();
            // Make the request
            RolloutKind response = await saasRolloutsClient.UpdateRolloutKindAsync(rolloutKind, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteRolloutKind</summary>
        public void DeleteRolloutKindRequestObject()
        {
            // Snippet: DeleteRolloutKind(DeleteRolloutKindRequest, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            DeleteRolloutKindRequest request = new DeleteRolloutKindRequest
            {
                RolloutKindName = RolloutKindName.FromProjectLocationRolloutKind("[PROJECT]", "[LOCATION]", "[ROLLOUT_KIND_ID]"),
                Etag = "",
                ValidateOnly = false,
                RequestId = "",
            };
            // Make the request
            saasRolloutsClient.DeleteRolloutKind(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRolloutKindAsync</summary>
        public async Task DeleteRolloutKindRequestObjectAsync()
        {
            // Snippet: DeleteRolloutKindAsync(DeleteRolloutKindRequest, CallSettings)
            // Additional: DeleteRolloutKindAsync(DeleteRolloutKindRequest, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRolloutKindRequest request = new DeleteRolloutKindRequest
            {
                RolloutKindName = RolloutKindName.FromProjectLocationRolloutKind("[PROJECT]", "[LOCATION]", "[ROLLOUT_KIND_ID]"),
                Etag = "",
                ValidateOnly = false,
                RequestId = "",
            };
            // Make the request
            await saasRolloutsClient.DeleteRolloutKindAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRolloutKind</summary>
        public void DeleteRolloutKind()
        {
            // Snippet: DeleteRolloutKind(string, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/rolloutKinds/[ROLLOUT_KIND_ID]";
            // Make the request
            saasRolloutsClient.DeleteRolloutKind(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRolloutKindAsync</summary>
        public async Task DeleteRolloutKindAsync()
        {
            // Snippet: DeleteRolloutKindAsync(string, CallSettings)
            // Additional: DeleteRolloutKindAsync(string, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/rolloutKinds/[ROLLOUT_KIND_ID]";
            // Make the request
            await saasRolloutsClient.DeleteRolloutKindAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRolloutKind</summary>
        public void DeleteRolloutKindResourceNames()
        {
            // Snippet: DeleteRolloutKind(RolloutKindName, CallSettings)
            // Create client
            SaasRolloutsClient saasRolloutsClient = SaasRolloutsClient.Create();
            // Initialize request argument(s)
            RolloutKindName name = RolloutKindName.FromProjectLocationRolloutKind("[PROJECT]", "[LOCATION]", "[ROLLOUT_KIND_ID]");
            // Make the request
            saasRolloutsClient.DeleteRolloutKind(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRolloutKindAsync</summary>
        public async Task DeleteRolloutKindResourceNamesAsync()
        {
            // Snippet: DeleteRolloutKindAsync(RolloutKindName, CallSettings)
            // Additional: DeleteRolloutKindAsync(RolloutKindName, CancellationToken)
            // Create client
            SaasRolloutsClient saasRolloutsClient = await SaasRolloutsClient.CreateAsync();
            // Initialize request argument(s)
            RolloutKindName name = RolloutKindName.FromProjectLocationRolloutKind("[PROJECT]", "[LOCATION]", "[ROLLOUT_KIND_ID]");
            // Make the request
            await saasRolloutsClient.DeleteRolloutKindAsync(name);
            // End snippet
        }
    }
}
