// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Logging.V2;
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

namespace Google.Cloud.Logging.V2.Snippets
{
    public class GeneratedConfigServiceV2ClientSnippets
    {
        public async Task ListSinksAsync()
        {
            // Snippet: ListSinksAsync(ParentNameOneof,string,int?,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            // Make the request
            PagedAsyncEnumerable<ListSinksResponse, LogSink> response =
                configServiceV2Client.ListSinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogSink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListSinks()
        {
            // Snippet: ListSinks(ParentNameOneof,string,int?,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            // Make the request
            PagedEnumerable<ListSinksResponse, LogSink> response =
                configServiceV2Client.ListSinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogSink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task ListSinksAsync_RequestObject()
        {
            // Snippet: ListSinksAsync(ListSinksRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ListSinksRequest request = new ListSinksRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
            };
            // Make the request
            PagedAsyncEnumerable<ListSinksResponse, LogSink> response =
                configServiceV2Client.ListSinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogSink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListSinks_RequestObject()
        {
            // Snippet: ListSinks(ListSinksRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ListSinksRequest request = new ListSinksRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
            };
            // Make the request
            PagedEnumerable<ListSinksResponse, LogSink> response =
                configServiceV2Client.ListSinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogSink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task GetSinkAsync()
        {
            // Snippet: GetSinkAsync(SinkNameOneof,CallSettings)
            // Additional: GetSinkAsync(SinkNameOneof,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            // Make the request
            LogSink response = await configServiceV2Client.GetSinkAsync(sinkName);
            // End snippet
        }

        public void GetSink()
        {
            // Snippet: GetSink(SinkNameOneof,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            // Make the request
            LogSink response = configServiceV2Client.GetSink(sinkName);
            // End snippet
        }

        public async Task GetSinkAsync_RequestObject()
        {
            // Snippet: GetSinkAsync(GetSinkRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
            };
            // Make the request
            LogSink response = await configServiceV2Client.GetSinkAsync(request);
            // End snippet
        }

        public void GetSink_RequestObject()
        {
            // Snippet: GetSink(GetSinkRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
            };
            // Make the request
            LogSink response = configServiceV2Client.GetSink(request);
            // End snippet
        }

        public async Task CreateSinkAsync()
        {
            // Snippet: CreateSinkAsync(ParentNameOneof,LogSink,CallSettings)
            // Additional: CreateSinkAsync(ParentNameOneof,LogSink,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = await configServiceV2Client.CreateSinkAsync(parent, sink);
            // End snippet
        }

        public void CreateSink()
        {
            // Snippet: CreateSink(ParentNameOneof,LogSink,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = configServiceV2Client.CreateSink(parent, sink);
            // End snippet
        }

        public async Task CreateSinkAsync_RequestObject()
        {
            // Snippet: CreateSinkAsync(CreateSinkRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                Sink = new LogSink(),
            };
            // Make the request
            LogSink response = await configServiceV2Client.CreateSinkAsync(request);
            // End snippet
        }

        public void CreateSink_RequestObject()
        {
            // Snippet: CreateSink(CreateSinkRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                Sink = new LogSink(),
            };
            // Make the request
            LogSink response = configServiceV2Client.CreateSink(request);
            // End snippet
        }

        public async Task UpdateSinkAsync()
        {
            // Snippet: UpdateSinkAsync(SinkNameOneof,LogSink,CallSettings)
            // Additional: UpdateSinkAsync(SinkNameOneof,LogSink,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = await configServiceV2Client.UpdateSinkAsync(sinkName, sink);
            // End snippet
        }

        public void UpdateSink()
        {
            // Snippet: UpdateSink(SinkNameOneof,LogSink,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = configServiceV2Client.UpdateSink(sinkName, sink);
            // End snippet
        }

        public async Task UpdateSinkAsync_RequestObject()
        {
            // Snippet: UpdateSinkAsync(UpdateSinkRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
                Sink = new LogSink(),
            };
            // Make the request
            LogSink response = await configServiceV2Client.UpdateSinkAsync(request);
            // End snippet
        }

        public void UpdateSink_RequestObject()
        {
            // Snippet: UpdateSink(UpdateSinkRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
                Sink = new LogSink(),
            };
            // Make the request
            LogSink response = configServiceV2Client.UpdateSink(request);
            // End snippet
        }

        public async Task DeleteSinkAsync()
        {
            // Snippet: DeleteSinkAsync(SinkNameOneof,CallSettings)
            // Additional: DeleteSinkAsync(SinkNameOneof,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            // Make the request
            await configServiceV2Client.DeleteSinkAsync(sinkName);
            // End snippet
        }

        public void DeleteSink()
        {
            // Snippet: DeleteSink(SinkNameOneof,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            // Make the request
            configServiceV2Client.DeleteSink(sinkName);
            // End snippet
        }

        public async Task DeleteSinkAsync_RequestObject()
        {
            // Snippet: DeleteSinkAsync(DeleteSinkRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
            };
            // Make the request
            await configServiceV2Client.DeleteSinkAsync(request);
            // End snippet
        }

        public void DeleteSink_RequestObject()
        {
            // Snippet: DeleteSink(DeleteSinkRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
            };
            // Make the request
            configServiceV2Client.DeleteSink(request);
            // End snippet
        }

    }
}
