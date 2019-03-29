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
    public class GeneratedUptimeCheckServiceClientSnippets
    {
        /// <summary>Snippet for ListUptimeCheckConfigsAsync</summary>
        public async Task ListUptimeCheckConfigsAsync()
        {
            // Snippet: ListUptimeCheckConfigsAsync(string,string,int?,CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new ProjectName("[PROJECT]").ToString();
            // Make the request
            PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> response =
                uptimeCheckServiceClient.ListUptimeCheckConfigsAsync(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UptimeCheckConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUptimeCheckConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckConfig item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckConfig item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckConfigs</summary>
        public void ListUptimeCheckConfigs()
        {
            // Snippet: ListUptimeCheckConfigs(string,string,int?,CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            string formattedParent = new ProjectName("[PROJECT]").ToString();
            // Make the request
            PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> response =
                uptimeCheckServiceClient.ListUptimeCheckConfigs(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UptimeCheckConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUptimeCheckConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckConfig item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckConfig item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckConfigsAsync</summary>
        public async Task ListUptimeCheckConfigsAsync_RequestObject()
        {
            // Snippet: ListUptimeCheckConfigsAsync(ListUptimeCheckConfigsRequest,CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListUptimeCheckConfigsRequest request = new ListUptimeCheckConfigsRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
            };
            // Make the request
            PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> response =
                uptimeCheckServiceClient.ListUptimeCheckConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UptimeCheckConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUptimeCheckConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckConfig item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckConfig item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckConfigs</summary>
        public void ListUptimeCheckConfigs_RequestObject()
        {
            // Snippet: ListUptimeCheckConfigs(ListUptimeCheckConfigsRequest,CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            ListUptimeCheckConfigsRequest request = new ListUptimeCheckConfigsRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
            };
            // Make the request
            PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> response =
                uptimeCheckServiceClient.ListUptimeCheckConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UptimeCheckConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUptimeCheckConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckConfig item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckConfig item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetUptimeCheckConfigAsync</summary>
        public async Task GetUptimeCheckConfigAsync()
        {
            // Snippet: GetUptimeCheckConfigAsync(UptimeCheckConfigName,CallSettings)
            // Additional: GetUptimeCheckConfigAsync(UptimeCheckConfigName,CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            UptimeCheckConfigName name = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]");
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.GetUptimeCheckConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUptimeCheckConfig</summary>
        public void GetUptimeCheckConfig()
        {
            // Snippet: GetUptimeCheckConfig(UptimeCheckConfigName,CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            UptimeCheckConfigName name = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]");
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.GetUptimeCheckConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetUptimeCheckConfigAsync</summary>
        public async Task GetUptimeCheckConfigAsync_RequestObject()
        {
            // Snippet: GetUptimeCheckConfigAsync(GetUptimeCheckConfigRequest,CallSettings)
            // Additional: GetUptimeCheckConfigAsync(GetUptimeCheckConfigRequest,CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetUptimeCheckConfigRequest request = new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.GetUptimeCheckConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUptimeCheckConfig</summary>
        public void GetUptimeCheckConfig_RequestObject()
        {
            // Snippet: GetUptimeCheckConfig(GetUptimeCheckConfigRequest,CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            GetUptimeCheckConfigRequest request = new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.GetUptimeCheckConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUptimeCheckConfigAsync</summary>
        public async Task CreateUptimeCheckConfigAsync()
        {
            // Snippet: CreateUptimeCheckConfigAsync(string,UptimeCheckConfig,CallSettings)
            // Additional: CreateUptimeCheckConfigAsync(string,UptimeCheckConfig,CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new ProjectName("[PROJECT]").ToString();
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.CreateUptimeCheckConfigAsync(formattedParent, uptimeCheckConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateUptimeCheckConfig</summary>
        public void CreateUptimeCheckConfig()
        {
            // Snippet: CreateUptimeCheckConfig(string,UptimeCheckConfig,CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            string formattedParent = new ProjectName("[PROJECT]").ToString();
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.CreateUptimeCheckConfig(formattedParent, uptimeCheckConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateUptimeCheckConfigAsync</summary>
        public async Task CreateUptimeCheckConfigAsync_RequestObject()
        {
            // Snippet: CreateUptimeCheckConfigAsync(CreateUptimeCheckConfigRequest,CallSettings)
            // Additional: CreateUptimeCheckConfigAsync(CreateUptimeCheckConfigRequest,CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.CreateUptimeCheckConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUptimeCheckConfig</summary>
        public void CreateUptimeCheckConfig_RequestObject()
        {
            // Snippet: CreateUptimeCheckConfig(CreateUptimeCheckConfigRequest,CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.CreateUptimeCheckConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUptimeCheckConfigAsync</summary>
        public async Task UpdateUptimeCheckConfigAsync()
        {
            // Snippet: UpdateUptimeCheckConfigAsync(UptimeCheckConfig,CallSettings)
            // Additional: UpdateUptimeCheckConfigAsync(UptimeCheckConfig,CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.UpdateUptimeCheckConfigAsync(uptimeCheckConfig);
            // End snippet
        }

        /// <summary>Snippet for UpdateUptimeCheckConfig</summary>
        public void UpdateUptimeCheckConfig()
        {
            // Snippet: UpdateUptimeCheckConfig(UptimeCheckConfig,CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.UpdateUptimeCheckConfig(uptimeCheckConfig);
            // End snippet
        }

        /// <summary>Snippet for UpdateUptimeCheckConfigAsync</summary>
        public async Task UpdateUptimeCheckConfigAsync_RequestObject()
        {
            // Snippet: UpdateUptimeCheckConfigAsync(UpdateUptimeCheckConfigRequest,CallSettings)
            // Additional: UpdateUptimeCheckConfigAsync(UpdateUptimeCheckConfigRequest,CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUptimeCheckConfigRequest request = new UpdateUptimeCheckConfigRequest
            {
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.UpdateUptimeCheckConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUptimeCheckConfig</summary>
        public void UpdateUptimeCheckConfig_RequestObject()
        {
            // Snippet: UpdateUptimeCheckConfig(UpdateUptimeCheckConfigRequest,CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            UpdateUptimeCheckConfigRequest request = new UpdateUptimeCheckConfigRequest
            {
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.UpdateUptimeCheckConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUptimeCheckConfigAsync</summary>
        public async Task DeleteUptimeCheckConfigAsync()
        {
            // Snippet: DeleteUptimeCheckConfigAsync(UptimeCheckConfigName,CallSettings)
            // Additional: DeleteUptimeCheckConfigAsync(UptimeCheckConfigName,CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            UptimeCheckConfigName name = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]");
            // Make the request
            await uptimeCheckServiceClient.DeleteUptimeCheckConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUptimeCheckConfig</summary>
        public void DeleteUptimeCheckConfig()
        {
            // Snippet: DeleteUptimeCheckConfig(UptimeCheckConfigName,CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            UptimeCheckConfigName name = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]");
            // Make the request
            uptimeCheckServiceClient.DeleteUptimeCheckConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUptimeCheckConfigAsync</summary>
        public async Task DeleteUptimeCheckConfigAsync_RequestObject()
        {
            // Snippet: DeleteUptimeCheckConfigAsync(DeleteUptimeCheckConfigRequest,CallSettings)
            // Additional: DeleteUptimeCheckConfigAsync(DeleteUptimeCheckConfigRequest,CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUptimeCheckConfigRequest request = new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            // Make the request
            await uptimeCheckServiceClient.DeleteUptimeCheckConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUptimeCheckConfig</summary>
        public void DeleteUptimeCheckConfig_RequestObject()
        {
            // Snippet: DeleteUptimeCheckConfig(DeleteUptimeCheckConfigRequest,CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            DeleteUptimeCheckConfigRequest request = new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            // Make the request
            uptimeCheckServiceClient.DeleteUptimeCheckConfig(request);
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckIpsAsync</summary>
        public async Task ListUptimeCheckIpsAsync_RequestObject()
        {
            // Snippet: ListUptimeCheckIpsAsync(ListUptimeCheckIpsRequest,CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListUptimeCheckIpsRequest request = new ListUptimeCheckIpsRequest();
            // Make the request
            PagedAsyncEnumerable<ListUptimeCheckIpsResponse, UptimeCheckIp> response =
                uptimeCheckServiceClient.ListUptimeCheckIpsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UptimeCheckIp item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUptimeCheckIpsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckIp item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckIp> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckIp item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckIps</summary>
        public void ListUptimeCheckIps_RequestObject()
        {
            // Snippet: ListUptimeCheckIps(ListUptimeCheckIpsRequest,CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            ListUptimeCheckIpsRequest request = new ListUptimeCheckIpsRequest();
            // Make the request
            PagedEnumerable<ListUptimeCheckIpsResponse, UptimeCheckIp> response =
                uptimeCheckServiceClient.ListUptimeCheckIps(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UptimeCheckIp item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUptimeCheckIpsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckIp item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckIp> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckIp item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

    }
}
