// Copyright 2019 Google LLC
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

namespace Google.Cloud.Monitoring.V3.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Monitoring.V3;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedAlertPolicyServiceClientSnippets
    {
        /// <summary>Snippet for ListAlertPoliciesAsync</summary>
        public async Task ListAlertPoliciesAsync()
        {
            // Snippet: ListAlertPoliciesAsync(ProjectName,string,int?,CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> response =
                alertPolicyServiceClient.ListAlertPoliciesAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AlertPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAlertPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AlertPolicy item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AlertPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AlertPolicy item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAlertPolicies</summary>
        public void ListAlertPolicies()
        {
            // Snippet: ListAlertPolicies(ProjectName,string,int?,CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> response =
                alertPolicyServiceClient.ListAlertPolicies(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AlertPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAlertPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AlertPolicy item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AlertPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AlertPolicy item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAlertPoliciesAsync</summary>
        public async Task ListAlertPoliciesAsync_RequestObject()
        {
            // Snippet: ListAlertPoliciesAsync(ListAlertPoliciesRequest,CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAlertPoliciesRequest request = new ListAlertPoliciesRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> response =
                alertPolicyServiceClient.ListAlertPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AlertPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAlertPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AlertPolicy item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AlertPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AlertPolicy item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAlertPolicies</summary>
        public void ListAlertPolicies_RequestObject()
        {
            // Snippet: ListAlertPolicies(ListAlertPoliciesRequest,CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            ListAlertPoliciesRequest request = new ListAlertPoliciesRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> response =
                alertPolicyServiceClient.ListAlertPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AlertPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAlertPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AlertPolicy item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AlertPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AlertPolicy item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAlertPolicyAsync</summary>
        public async Task GetAlertPolicyAsync()
        {
            // Snippet: GetAlertPolicyAsync(AlertPolicyName,CallSettings)
            // Additional: GetAlertPolicyAsync(AlertPolicyName,CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            AlertPolicyName name = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]");
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.GetAlertPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAlertPolicy</summary>
        public void GetAlertPolicy()
        {
            // Snippet: GetAlertPolicy(AlertPolicyName,CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            AlertPolicyName name = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]");
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.GetAlertPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetAlertPolicyAsync</summary>
        public async Task GetAlertPolicyAsync_RequestObject()
        {
            // Snippet: GetAlertPolicyAsync(GetAlertPolicyRequest,CallSettings)
            // Additional: GetAlertPolicyAsync(GetAlertPolicyRequest,CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAlertPolicyRequest request = new GetAlertPolicyRequest
            {
                AlertPolicyName = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]"),
            };
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.GetAlertPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAlertPolicy</summary>
        public void GetAlertPolicy_RequestObject()
        {
            // Snippet: GetAlertPolicy(GetAlertPolicyRequest,CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            GetAlertPolicyRequest request = new GetAlertPolicyRequest
            {
                AlertPolicyName = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]"),
            };
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.GetAlertPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAlertPolicyAsync</summary>
        public async Task CreateAlertPolicyAsync()
        {
            // Snippet: CreateAlertPolicyAsync(ProjectName,AlertPolicy,CallSettings)
            // Additional: CreateAlertPolicyAsync(ProjectName,AlertPolicy,CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = new ProjectName("[PROJECT]");
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.CreateAlertPolicyAsync(name, alertPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateAlertPolicy</summary>
        public void CreateAlertPolicy()
        {
            // Snippet: CreateAlertPolicy(ProjectName,AlertPolicy,CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = new ProjectName("[PROJECT]");
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.CreateAlertPolicy(name, alertPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateAlertPolicyAsync</summary>
        public async Task CreateAlertPolicyAsync_RequestObject()
        {
            // Snippet: CreateAlertPolicyAsync(CreateAlertPolicyRequest,CallSettings)
            // Additional: CreateAlertPolicyAsync(CreateAlertPolicyRequest,CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                AlertPolicy = new AlertPolicy(),
            };
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.CreateAlertPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAlertPolicy</summary>
        public void CreateAlertPolicy_RequestObject()
        {
            // Snippet: CreateAlertPolicy(CreateAlertPolicyRequest,CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                AlertPolicy = new AlertPolicy(),
            };
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.CreateAlertPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAlertPolicyAsync</summary>
        public async Task DeleteAlertPolicyAsync()
        {
            // Snippet: DeleteAlertPolicyAsync(AlertPolicyName,CallSettings)
            // Additional: DeleteAlertPolicyAsync(AlertPolicyName,CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            AlertPolicyName name = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]");
            // Make the request
            await alertPolicyServiceClient.DeleteAlertPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAlertPolicy</summary>
        public void DeleteAlertPolicy()
        {
            // Snippet: DeleteAlertPolicy(AlertPolicyName,CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            AlertPolicyName name = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]");
            // Make the request
            alertPolicyServiceClient.DeleteAlertPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAlertPolicyAsync</summary>
        public async Task DeleteAlertPolicyAsync_RequestObject()
        {
            // Snippet: DeleteAlertPolicyAsync(DeleteAlertPolicyRequest,CallSettings)
            // Additional: DeleteAlertPolicyAsync(DeleteAlertPolicyRequest,CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAlertPolicyRequest request = new DeleteAlertPolicyRequest
            {
                AlertPolicyName = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]"),
            };
            // Make the request
            await alertPolicyServiceClient.DeleteAlertPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAlertPolicy</summary>
        public void DeleteAlertPolicy_RequestObject()
        {
            // Snippet: DeleteAlertPolicy(DeleteAlertPolicyRequest,CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            DeleteAlertPolicyRequest request = new DeleteAlertPolicyRequest
            {
                AlertPolicyName = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]"),
            };
            // Make the request
            alertPolicyServiceClient.DeleteAlertPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAlertPolicyAsync</summary>
        public async Task UpdateAlertPolicyAsync()
        {
            // Snippet: UpdateAlertPolicyAsync(FieldMask,AlertPolicy,CallSettings)
            // Additional: UpdateAlertPolicyAsync(FieldMask,AlertPolicy,CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            FieldMask updateMask = new FieldMask();
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.UpdateAlertPolicyAsync(updateMask, alertPolicy);
            // End snippet
        }

        /// <summary>Snippet for UpdateAlertPolicy</summary>
        public void UpdateAlertPolicy()
        {
            // Snippet: UpdateAlertPolicy(FieldMask,AlertPolicy,CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            FieldMask updateMask = new FieldMask();
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.UpdateAlertPolicy(updateMask, alertPolicy);
            // End snippet
        }

        /// <summary>Snippet for UpdateAlertPolicyAsync</summary>
        public async Task UpdateAlertPolicyAsync_RequestObject()
        {
            // Snippet: UpdateAlertPolicyAsync(UpdateAlertPolicyRequest,CallSettings)
            // Additional: UpdateAlertPolicyAsync(UpdateAlertPolicyRequest,CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAlertPolicyRequest request = new UpdateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
            };
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.UpdateAlertPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAlertPolicy</summary>
        public void UpdateAlertPolicy_RequestObject()
        {
            // Snippet: UpdateAlertPolicy(UpdateAlertPolicyRequest,CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            UpdateAlertPolicyRequest request = new UpdateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
            };
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.UpdateAlertPolicy(request);
            // End snippet
        }

    }
}
