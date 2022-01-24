// Copyright 2022 Google LLC
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

namespace Google.Cloud.Video.LiveStream.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedLivestreamServiceClientSnippets
    {
        /// <summary>Snippet for CreateChannel</summary>
        public void CreateChannelRequestObject()
        {
            // Snippet: CreateChannel(CreateChannelRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            CreateChannelRequest request = new CreateChannelRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Channel = new Channel(),
                ChannelId = "",
                RequestId = "",
            };
            // Make the request
            Operation<Channel, OperationMetadata> response = livestreamServiceClient.CreateChannel(request);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceCreateChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateChannelAsync</summary>
        public async Task CreateChannelRequestObjectAsync()
        {
            // Snippet: CreateChannelAsync(CreateChannelRequest, CallSettings)
            // Additional: CreateChannelAsync(CreateChannelRequest, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateChannelRequest request = new CreateChannelRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Channel = new Channel(),
                ChannelId = "",
                RequestId = "",
            };
            // Make the request
            Operation<Channel, OperationMetadata> response = await livestreamServiceClient.CreateChannelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceCreateChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateChannel</summary>
        public void CreateChannel()
        {
            // Snippet: CreateChannel(string, Channel, string, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Channel channel = new Channel();
            string channelId = "";
            // Make the request
            Operation<Channel, OperationMetadata> response = livestreamServiceClient.CreateChannel(parent, channel, channelId);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceCreateChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateChannelAsync</summary>
        public async Task CreateChannelAsync()
        {
            // Snippet: CreateChannelAsync(string, Channel, string, CallSettings)
            // Additional: CreateChannelAsync(string, Channel, string, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Channel channel = new Channel();
            string channelId = "";
            // Make the request
            Operation<Channel, OperationMetadata> response = await livestreamServiceClient.CreateChannelAsync(parent, channel, channelId);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceCreateChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateChannel</summary>
        public void CreateChannelResourceNames()
        {
            // Snippet: CreateChannel(LocationName, Channel, string, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Channel channel = new Channel();
            string channelId = "";
            // Make the request
            Operation<Channel, OperationMetadata> response = livestreamServiceClient.CreateChannel(parent, channel, channelId);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceCreateChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateChannelAsync</summary>
        public async Task CreateChannelResourceNamesAsync()
        {
            // Snippet: CreateChannelAsync(LocationName, Channel, string, CallSettings)
            // Additional: CreateChannelAsync(LocationName, Channel, string, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Channel channel = new Channel();
            string channelId = "";
            // Make the request
            Operation<Channel, OperationMetadata> response = await livestreamServiceClient.CreateChannelAsync(parent, channel, channelId);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceCreateChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListChannels</summary>
        public void ListChannelsRequestObject()
        {
            // Snippet: ListChannels(ListChannelsRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            ListChannelsRequest request = new ListChannelsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListChannelsResponse, Channel> response = livestreamServiceClient.ListChannels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Channel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChannelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Channel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Channel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Channel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelsAsync</summary>
        public async Task ListChannelsRequestObjectAsync()
        {
            // Snippet: ListChannelsAsync(ListChannelsRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListChannelsRequest request = new ListChannelsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListChannelsResponse, Channel> response = livestreamServiceClient.ListChannelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Channel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChannelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Channel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Channel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Channel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannels</summary>
        public void ListChannels()
        {
            // Snippet: ListChannels(string, string, int?, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListChannelsResponse, Channel> response = livestreamServiceClient.ListChannels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Channel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChannelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Channel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Channel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Channel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelsAsync</summary>
        public async Task ListChannelsAsync()
        {
            // Snippet: ListChannelsAsync(string, string, int?, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListChannelsResponse, Channel> response = livestreamServiceClient.ListChannelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Channel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChannelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Channel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Channel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Channel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannels</summary>
        public void ListChannelsResourceNames()
        {
            // Snippet: ListChannels(LocationName, string, int?, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListChannelsResponse, Channel> response = livestreamServiceClient.ListChannels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Channel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChannelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Channel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Channel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Channel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelsAsync</summary>
        public async Task ListChannelsResourceNamesAsync()
        {
            // Snippet: ListChannelsAsync(LocationName, string, int?, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListChannelsResponse, Channel> response = livestreamServiceClient.ListChannelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Channel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChannelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Channel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Channel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Channel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetChannel</summary>
        public void GetChannelRequestObject()
        {
            // Snippet: GetChannel(GetChannelRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            GetChannelRequest request = new GetChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
            };
            // Make the request
            Channel response = livestreamServiceClient.GetChannel(request);
            // End snippet
        }

        /// <summary>Snippet for GetChannelAsync</summary>
        public async Task GetChannelRequestObjectAsync()
        {
            // Snippet: GetChannelAsync(GetChannelRequest, CallSettings)
            // Additional: GetChannelAsync(GetChannelRequest, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetChannelRequest request = new GetChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
            };
            // Make the request
            Channel response = await livestreamServiceClient.GetChannelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetChannel</summary>
        public void GetChannel()
        {
            // Snippet: GetChannel(string, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]";
            // Make the request
            Channel response = livestreamServiceClient.GetChannel(name);
            // End snippet
        }

        /// <summary>Snippet for GetChannelAsync</summary>
        public async Task GetChannelAsync()
        {
            // Snippet: GetChannelAsync(string, CallSettings)
            // Additional: GetChannelAsync(string, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]";
            // Make the request
            Channel response = await livestreamServiceClient.GetChannelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetChannel</summary>
        public void GetChannelResourceNames()
        {
            // Snippet: GetChannel(ChannelName, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            ChannelName name = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            // Make the request
            Channel response = livestreamServiceClient.GetChannel(name);
            // End snippet
        }

        /// <summary>Snippet for GetChannelAsync</summary>
        public async Task GetChannelResourceNamesAsync()
        {
            // Snippet: GetChannelAsync(ChannelName, CallSettings)
            // Additional: GetChannelAsync(ChannelName, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChannelName name = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            // Make the request
            Channel response = await livestreamServiceClient.GetChannelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteChannel</summary>
        public void DeleteChannelRequestObject()
        {
            // Snippet: DeleteChannel(DeleteChannelRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            DeleteChannelRequest request = new DeleteChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = livestreamServiceClient.DeleteChannel(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceDeleteChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelAsync</summary>
        public async Task DeleteChannelRequestObjectAsync()
        {
            // Snippet: DeleteChannelAsync(DeleteChannelRequest, CallSettings)
            // Additional: DeleteChannelAsync(DeleteChannelRequest, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteChannelRequest request = new DeleteChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await livestreamServiceClient.DeleteChannelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceDeleteChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannel</summary>
        public void DeleteChannel()
        {
            // Snippet: DeleteChannel(string, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]";
            // Make the request
            Operation<Empty, OperationMetadata> response = livestreamServiceClient.DeleteChannel(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceDeleteChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelAsync</summary>
        public async Task DeleteChannelAsync()
        {
            // Snippet: DeleteChannelAsync(string, CallSettings)
            // Additional: DeleteChannelAsync(string, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await livestreamServiceClient.DeleteChannelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceDeleteChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannel</summary>
        public void DeleteChannelResourceNames()
        {
            // Snippet: DeleteChannel(ChannelName, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            ChannelName name = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            // Make the request
            Operation<Empty, OperationMetadata> response = livestreamServiceClient.DeleteChannel(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceDeleteChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelAsync</summary>
        public async Task DeleteChannelResourceNamesAsync()
        {
            // Snippet: DeleteChannelAsync(ChannelName, CallSettings)
            // Additional: DeleteChannelAsync(ChannelName, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChannelName name = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await livestreamServiceClient.DeleteChannelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceDeleteChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateChannel</summary>
        public void UpdateChannelRequestObject()
        {
            // Snippet: UpdateChannel(UpdateChannelRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            UpdateChannelRequest request = new UpdateChannelRequest
            {
                UpdateMask = new FieldMask(),
                Channel = new Channel(),
                RequestId = "",
            };
            // Make the request
            Operation<Channel, OperationMetadata> response = livestreamServiceClient.UpdateChannel(request);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceUpdateChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateChannelAsync</summary>
        public async Task UpdateChannelRequestObjectAsync()
        {
            // Snippet: UpdateChannelAsync(UpdateChannelRequest, CallSettings)
            // Additional: UpdateChannelAsync(UpdateChannelRequest, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateChannelRequest request = new UpdateChannelRequest
            {
                UpdateMask = new FieldMask(),
                Channel = new Channel(),
                RequestId = "",
            };
            // Make the request
            Operation<Channel, OperationMetadata> response = await livestreamServiceClient.UpdateChannelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceUpdateChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateChannel</summary>
        public void UpdateChannel()
        {
            // Snippet: UpdateChannel(Channel, FieldMask, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            Channel channel = new Channel();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Channel, OperationMetadata> response = livestreamServiceClient.UpdateChannel(channel, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceUpdateChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateChannelAsync</summary>
        public async Task UpdateChannelAsync()
        {
            // Snippet: UpdateChannelAsync(Channel, FieldMask, CallSettings)
            // Additional: UpdateChannelAsync(Channel, FieldMask, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            Channel channel = new Channel();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Channel, OperationMetadata> response = await livestreamServiceClient.UpdateChannelAsync(channel, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceUpdateChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartChannel</summary>
        public void StartChannelRequestObject()
        {
            // Snippet: StartChannel(StartChannelRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            StartChannelRequest request = new StartChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                RequestId = "",
            };
            // Make the request
            Operation<ChannelOperationResponse, OperationMetadata> response = livestreamServiceClient.StartChannel(request);

            // Poll until the returned long-running operation is complete
            Operation<ChannelOperationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ChannelOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelOperationResponse, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceStartChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartChannelAsync</summary>
        public async Task StartChannelRequestObjectAsync()
        {
            // Snippet: StartChannelAsync(StartChannelRequest, CallSettings)
            // Additional: StartChannelAsync(StartChannelRequest, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            StartChannelRequest request = new StartChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                RequestId = "",
            };
            // Make the request
            Operation<ChannelOperationResponse, OperationMetadata> response = await livestreamServiceClient.StartChannelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ChannelOperationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ChannelOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelOperationResponse, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceStartChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartChannel</summary>
        public void StartChannel()
        {
            // Snippet: StartChannel(string, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]";
            // Make the request
            Operation<ChannelOperationResponse, OperationMetadata> response = livestreamServiceClient.StartChannel(name);

            // Poll until the returned long-running operation is complete
            Operation<ChannelOperationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ChannelOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelOperationResponse, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceStartChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartChannelAsync</summary>
        public async Task StartChannelAsync()
        {
            // Snippet: StartChannelAsync(string, CallSettings)
            // Additional: StartChannelAsync(string, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]";
            // Make the request
            Operation<ChannelOperationResponse, OperationMetadata> response = await livestreamServiceClient.StartChannelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ChannelOperationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ChannelOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelOperationResponse, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceStartChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartChannel</summary>
        public void StartChannelResourceNames()
        {
            // Snippet: StartChannel(ChannelName, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            ChannelName name = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            // Make the request
            Operation<ChannelOperationResponse, OperationMetadata> response = livestreamServiceClient.StartChannel(name);

            // Poll until the returned long-running operation is complete
            Operation<ChannelOperationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ChannelOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelOperationResponse, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceStartChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartChannelAsync</summary>
        public async Task StartChannelResourceNamesAsync()
        {
            // Snippet: StartChannelAsync(ChannelName, CallSettings)
            // Additional: StartChannelAsync(ChannelName, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChannelName name = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            // Make the request
            Operation<ChannelOperationResponse, OperationMetadata> response = await livestreamServiceClient.StartChannelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ChannelOperationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ChannelOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelOperationResponse, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceStartChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopChannel</summary>
        public void StopChannelRequestObject()
        {
            // Snippet: StopChannel(StopChannelRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            StopChannelRequest request = new StopChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                RequestId = "",
            };
            // Make the request
            Operation<ChannelOperationResponse, OperationMetadata> response = livestreamServiceClient.StopChannel(request);

            // Poll until the returned long-running operation is complete
            Operation<ChannelOperationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ChannelOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelOperationResponse, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceStopChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopChannelAsync</summary>
        public async Task StopChannelRequestObjectAsync()
        {
            // Snippet: StopChannelAsync(StopChannelRequest, CallSettings)
            // Additional: StopChannelAsync(StopChannelRequest, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            StopChannelRequest request = new StopChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                RequestId = "",
            };
            // Make the request
            Operation<ChannelOperationResponse, OperationMetadata> response = await livestreamServiceClient.StopChannelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ChannelOperationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ChannelOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelOperationResponse, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceStopChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopChannel</summary>
        public void StopChannel()
        {
            // Snippet: StopChannel(string, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]";
            // Make the request
            Operation<ChannelOperationResponse, OperationMetadata> response = livestreamServiceClient.StopChannel(name);

            // Poll until the returned long-running operation is complete
            Operation<ChannelOperationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ChannelOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelOperationResponse, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceStopChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopChannelAsync</summary>
        public async Task StopChannelAsync()
        {
            // Snippet: StopChannelAsync(string, CallSettings)
            // Additional: StopChannelAsync(string, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]";
            // Make the request
            Operation<ChannelOperationResponse, OperationMetadata> response = await livestreamServiceClient.StopChannelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ChannelOperationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ChannelOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelOperationResponse, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceStopChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopChannel</summary>
        public void StopChannelResourceNames()
        {
            // Snippet: StopChannel(ChannelName, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            ChannelName name = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            // Make the request
            Operation<ChannelOperationResponse, OperationMetadata> response = livestreamServiceClient.StopChannel(name);

            // Poll until the returned long-running operation is complete
            Operation<ChannelOperationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ChannelOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelOperationResponse, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceStopChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopChannelAsync</summary>
        public async Task StopChannelResourceNamesAsync()
        {
            // Snippet: StopChannelAsync(ChannelName, CallSettings)
            // Additional: StopChannelAsync(ChannelName, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChannelName name = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            // Make the request
            Operation<ChannelOperationResponse, OperationMetadata> response = await livestreamServiceClient.StopChannelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ChannelOperationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ChannelOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelOperationResponse, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceStopChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInput</summary>
        public void CreateInputRequestObject()
        {
            // Snippet: CreateInput(CreateInputRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            CreateInputRequest request = new CreateInputRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Input = new Input(),
                InputId = "",
                RequestId = "",
            };
            // Make the request
            Operation<Input, OperationMetadata> response = livestreamServiceClient.CreateInput(request);

            // Poll until the returned long-running operation is complete
            Operation<Input, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Input result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Input, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceCreateInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Input retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInputAsync</summary>
        public async Task CreateInputRequestObjectAsync()
        {
            // Snippet: CreateInputAsync(CreateInputRequest, CallSettings)
            // Additional: CreateInputAsync(CreateInputRequest, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateInputRequest request = new CreateInputRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Input = new Input(),
                InputId = "",
                RequestId = "",
            };
            // Make the request
            Operation<Input, OperationMetadata> response = await livestreamServiceClient.CreateInputAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Input, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Input result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Input, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceCreateInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Input retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInput</summary>
        public void CreateInput()
        {
            // Snippet: CreateInput(string, Input, string, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Input input = new Input();
            string inputId = "";
            // Make the request
            Operation<Input, OperationMetadata> response = livestreamServiceClient.CreateInput(parent, input, inputId);

            // Poll until the returned long-running operation is complete
            Operation<Input, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Input result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Input, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceCreateInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Input retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInputAsync</summary>
        public async Task CreateInputAsync()
        {
            // Snippet: CreateInputAsync(string, Input, string, CallSettings)
            // Additional: CreateInputAsync(string, Input, string, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Input input = new Input();
            string inputId = "";
            // Make the request
            Operation<Input, OperationMetadata> response = await livestreamServiceClient.CreateInputAsync(parent, input, inputId);

            // Poll until the returned long-running operation is complete
            Operation<Input, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Input result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Input, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceCreateInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Input retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInput</summary>
        public void CreateInputResourceNames()
        {
            // Snippet: CreateInput(LocationName, Input, string, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Input input = new Input();
            string inputId = "";
            // Make the request
            Operation<Input, OperationMetadata> response = livestreamServiceClient.CreateInput(parent, input, inputId);

            // Poll until the returned long-running operation is complete
            Operation<Input, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Input result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Input, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceCreateInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Input retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInputAsync</summary>
        public async Task CreateInputResourceNamesAsync()
        {
            // Snippet: CreateInputAsync(LocationName, Input, string, CallSettings)
            // Additional: CreateInputAsync(LocationName, Input, string, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Input input = new Input();
            string inputId = "";
            // Make the request
            Operation<Input, OperationMetadata> response = await livestreamServiceClient.CreateInputAsync(parent, input, inputId);

            // Poll until the returned long-running operation is complete
            Operation<Input, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Input result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Input, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceCreateInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Input retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListInputs</summary>
        public void ListInputsRequestObject()
        {
            // Snippet: ListInputs(ListInputsRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            ListInputsRequest request = new ListInputsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListInputsResponse, Input> response = livestreamServiceClient.ListInputs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Input item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInputsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Input item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Input> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Input item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInputsAsync</summary>
        public async Task ListInputsRequestObjectAsync()
        {
            // Snippet: ListInputsAsync(ListInputsRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListInputsRequest request = new ListInputsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInputsResponse, Input> response = livestreamServiceClient.ListInputsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Input item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInputsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Input item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Input> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Input item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInputs</summary>
        public void ListInputs()
        {
            // Snippet: ListInputs(string, string, int?, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListInputsResponse, Input> response = livestreamServiceClient.ListInputs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Input item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInputsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Input item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Input> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Input item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInputsAsync</summary>
        public async Task ListInputsAsync()
        {
            // Snippet: ListInputsAsync(string, string, int?, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListInputsResponse, Input> response = livestreamServiceClient.ListInputsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Input item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInputsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Input item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Input> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Input item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInputs</summary>
        public void ListInputsResourceNames()
        {
            // Snippet: ListInputs(LocationName, string, int?, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInputsResponse, Input> response = livestreamServiceClient.ListInputs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Input item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInputsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Input item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Input> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Input item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInputsAsync</summary>
        public async Task ListInputsResourceNamesAsync()
        {
            // Snippet: ListInputsAsync(LocationName, string, int?, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInputsResponse, Input> response = livestreamServiceClient.ListInputsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Input item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInputsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Input item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Input> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Input item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetInput</summary>
        public void GetInputRequestObject()
        {
            // Snippet: GetInput(GetInputRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            GetInputRequest request = new GetInputRequest
            {
                InputName = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]"),
            };
            // Make the request
            Input response = livestreamServiceClient.GetInput(request);
            // End snippet
        }

        /// <summary>Snippet for GetInputAsync</summary>
        public async Task GetInputRequestObjectAsync()
        {
            // Snippet: GetInputAsync(GetInputRequest, CallSettings)
            // Additional: GetInputAsync(GetInputRequest, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetInputRequest request = new GetInputRequest
            {
                InputName = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]"),
            };
            // Make the request
            Input response = await livestreamServiceClient.GetInputAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInput</summary>
        public void GetInput()
        {
            // Snippet: GetInput(string, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/inputs/[INPUT]";
            // Make the request
            Input response = livestreamServiceClient.GetInput(name);
            // End snippet
        }

        /// <summary>Snippet for GetInputAsync</summary>
        public async Task GetInputAsync()
        {
            // Snippet: GetInputAsync(string, CallSettings)
            // Additional: GetInputAsync(string, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/inputs/[INPUT]";
            // Make the request
            Input response = await livestreamServiceClient.GetInputAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInput</summary>
        public void GetInputResourceNames()
        {
            // Snippet: GetInput(InputName, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            InputName name = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]");
            // Make the request
            Input response = livestreamServiceClient.GetInput(name);
            // End snippet
        }

        /// <summary>Snippet for GetInputAsync</summary>
        public async Task GetInputResourceNamesAsync()
        {
            // Snippet: GetInputAsync(InputName, CallSettings)
            // Additional: GetInputAsync(InputName, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            InputName name = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]");
            // Make the request
            Input response = await livestreamServiceClient.GetInputAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInput</summary>
        public void DeleteInputRequestObject()
        {
            // Snippet: DeleteInput(DeleteInputRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            DeleteInputRequest request = new DeleteInputRequest
            {
                InputName = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = livestreamServiceClient.DeleteInput(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceDeleteInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInputAsync</summary>
        public async Task DeleteInputRequestObjectAsync()
        {
            // Snippet: DeleteInputAsync(DeleteInputRequest, CallSettings)
            // Additional: DeleteInputAsync(DeleteInputRequest, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInputRequest request = new DeleteInputRequest
            {
                InputName = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await livestreamServiceClient.DeleteInputAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceDeleteInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInput</summary>
        public void DeleteInput()
        {
            // Snippet: DeleteInput(string, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/inputs/[INPUT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = livestreamServiceClient.DeleteInput(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceDeleteInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInputAsync</summary>
        public async Task DeleteInputAsync()
        {
            // Snippet: DeleteInputAsync(string, CallSettings)
            // Additional: DeleteInputAsync(string, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/inputs/[INPUT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await livestreamServiceClient.DeleteInputAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceDeleteInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInput</summary>
        public void DeleteInputResourceNames()
        {
            // Snippet: DeleteInput(InputName, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            InputName name = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = livestreamServiceClient.DeleteInput(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceDeleteInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInputAsync</summary>
        public async Task DeleteInputResourceNamesAsync()
        {
            // Snippet: DeleteInputAsync(InputName, CallSettings)
            // Additional: DeleteInputAsync(InputName, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            InputName name = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await livestreamServiceClient.DeleteInputAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceDeleteInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInput</summary>
        public void UpdateInputRequestObject()
        {
            // Snippet: UpdateInput(UpdateInputRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            UpdateInputRequest request = new UpdateInputRequest
            {
                UpdateMask = new FieldMask(),
                Input = new Input(),
                RequestId = "",
            };
            // Make the request
            Operation<Input, OperationMetadata> response = livestreamServiceClient.UpdateInput(request);

            // Poll until the returned long-running operation is complete
            Operation<Input, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Input result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Input, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceUpdateInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Input retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInputAsync</summary>
        public async Task UpdateInputRequestObjectAsync()
        {
            // Snippet: UpdateInputAsync(UpdateInputRequest, CallSettings)
            // Additional: UpdateInputAsync(UpdateInputRequest, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInputRequest request = new UpdateInputRequest
            {
                UpdateMask = new FieldMask(),
                Input = new Input(),
                RequestId = "",
            };
            // Make the request
            Operation<Input, OperationMetadata> response = await livestreamServiceClient.UpdateInputAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Input, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Input result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Input, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceUpdateInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Input retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInput</summary>
        public void UpdateInput()
        {
            // Snippet: UpdateInput(Input, FieldMask, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            Input input = new Input();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Input, OperationMetadata> response = livestreamServiceClient.UpdateInput(input, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Input, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Input result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Input, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceUpdateInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Input retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInputAsync</summary>
        public async Task UpdateInputAsync()
        {
            // Snippet: UpdateInputAsync(Input, FieldMask, CallSettings)
            // Additional: UpdateInputAsync(Input, FieldMask, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            Input input = new Input();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Input, OperationMetadata> response = await livestreamServiceClient.UpdateInputAsync(input, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Input, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Input result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Input, OperationMetadata> retrievedResponse = await livestreamServiceClient.PollOnceUpdateInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Input retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEvent</summary>
        public void CreateEventRequestObject()
        {
            // Snippet: CreateEvent(CreateEventRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            CreateEventRequest request = new CreateEventRequest
            {
                ParentAsChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                Event = new Event(),
                EventId = "",
                RequestId = "",
            };
            // Make the request
            Event response = livestreamServiceClient.CreateEvent(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEventAsync</summary>
        public async Task CreateEventRequestObjectAsync()
        {
            // Snippet: CreateEventAsync(CreateEventRequest, CallSettings)
            // Additional: CreateEventAsync(CreateEventRequest, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEventRequest request = new CreateEventRequest
            {
                ParentAsChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                Event = new Event(),
                EventId = "",
                RequestId = "",
            };
            // Make the request
            Event response = await livestreamServiceClient.CreateEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEvent</summary>
        public void CreateEvent()
        {
            // Snippet: CreateEvent(string, Event, string, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]";
            Event @event = new Event();
            string eventId = "";
            // Make the request
            Event response = livestreamServiceClient.CreateEvent(parent, @event, eventId);
            // End snippet
        }

        /// <summary>Snippet for CreateEventAsync</summary>
        public async Task CreateEventAsync()
        {
            // Snippet: CreateEventAsync(string, Event, string, CallSettings)
            // Additional: CreateEventAsync(string, Event, string, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]";
            Event @event = new Event();
            string eventId = "";
            // Make the request
            Event response = await livestreamServiceClient.CreateEventAsync(parent, @event, eventId);
            // End snippet
        }

        /// <summary>Snippet for CreateEvent</summary>
        public void CreateEventResourceNames()
        {
            // Snippet: CreateEvent(ChannelName, Event, string, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            ChannelName parent = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            Event @event = new Event();
            string eventId = "";
            // Make the request
            Event response = livestreamServiceClient.CreateEvent(parent, @event, eventId);
            // End snippet
        }

        /// <summary>Snippet for CreateEventAsync</summary>
        public async Task CreateEventResourceNamesAsync()
        {
            // Snippet: CreateEventAsync(ChannelName, Event, string, CallSettings)
            // Additional: CreateEventAsync(ChannelName, Event, string, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChannelName parent = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            Event @event = new Event();
            string eventId = "";
            // Make the request
            Event response = await livestreamServiceClient.CreateEventAsync(parent, @event, eventId);
            // End snippet
        }

        /// <summary>Snippet for ListEvents</summary>
        public void ListEventsRequestObject()
        {
            // Snippet: ListEvents(ListEventsRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            ListEventsRequest request = new ListEventsRequest
            {
                ParentAsChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListEventsResponse, Event> response = livestreamServiceClient.ListEvents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Event item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventsAsync</summary>
        public async Task ListEventsRequestObjectAsync()
        {
            // Snippet: ListEventsAsync(ListEventsRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEventsRequest request = new ListEventsRequest
            {
                ParentAsChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse, Event> response = livestreamServiceClient.ListEventsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Event item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvents</summary>
        public void ListEvents()
        {
            // Snippet: ListEvents(string, string, int?, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]";
            // Make the request
            PagedEnumerable<ListEventsResponse, Event> response = livestreamServiceClient.ListEvents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Event item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventsAsync</summary>
        public async Task ListEventsAsync()
        {
            // Snippet: ListEventsAsync(string, string, int?, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]";
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse, Event> response = livestreamServiceClient.ListEventsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Event item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvents</summary>
        public void ListEventsResourceNames()
        {
            // Snippet: ListEvents(ChannelName, string, int?, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            ChannelName parent = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            // Make the request
            PagedEnumerable<ListEventsResponse, Event> response = livestreamServiceClient.ListEvents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Event item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventsAsync</summary>
        public async Task ListEventsResourceNamesAsync()
        {
            // Snippet: ListEventsAsync(ChannelName, string, int?, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChannelName parent = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse, Event> response = livestreamServiceClient.ListEventsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Event item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEvent</summary>
        public void GetEventRequestObject()
        {
            // Snippet: GetEvent(GetEventRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            GetEventRequest request = new GetEventRequest
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
            };
            // Make the request
            Event response = livestreamServiceClient.GetEvent(request);
            // End snippet
        }

        /// <summary>Snippet for GetEventAsync</summary>
        public async Task GetEventRequestObjectAsync()
        {
            // Snippet: GetEventAsync(GetEventRequest, CallSettings)
            // Additional: GetEventAsync(GetEventRequest, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEventRequest request = new GetEventRequest
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
            };
            // Make the request
            Event response = await livestreamServiceClient.GetEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvent</summary>
        public void GetEvent()
        {
            // Snippet: GetEvent(string, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]/events/[EVENT]";
            // Make the request
            Event response = livestreamServiceClient.GetEvent(name);
            // End snippet
        }

        /// <summary>Snippet for GetEventAsync</summary>
        public async Task GetEventAsync()
        {
            // Snippet: GetEventAsync(string, CallSettings)
            // Additional: GetEventAsync(string, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]/events/[EVENT]";
            // Make the request
            Event response = await livestreamServiceClient.GetEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvent</summary>
        public void GetEventResourceNames()
        {
            // Snippet: GetEvent(EventName, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            EventName name = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]");
            // Make the request
            Event response = livestreamServiceClient.GetEvent(name);
            // End snippet
        }

        /// <summary>Snippet for GetEventAsync</summary>
        public async Task GetEventResourceNamesAsync()
        {
            // Snippet: GetEventAsync(EventName, CallSettings)
            // Additional: GetEventAsync(EventName, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            EventName name = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]");
            // Make the request
            Event response = await livestreamServiceClient.GetEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvent</summary>
        public void DeleteEventRequestObject()
        {
            // Snippet: DeleteEvent(DeleteEventRequest, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            DeleteEventRequest request = new DeleteEventRequest
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
                RequestId = "",
            };
            // Make the request
            livestreamServiceClient.DeleteEvent(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventAsync</summary>
        public async Task DeleteEventRequestObjectAsync()
        {
            // Snippet: DeleteEventAsync(DeleteEventRequest, CallSettings)
            // Additional: DeleteEventAsync(DeleteEventRequest, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEventRequest request = new DeleteEventRequest
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
                RequestId = "",
            };
            // Make the request
            await livestreamServiceClient.DeleteEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvent</summary>
        public void DeleteEvent()
        {
            // Snippet: DeleteEvent(string, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]/events/[EVENT]";
            // Make the request
            livestreamServiceClient.DeleteEvent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventAsync</summary>
        public async Task DeleteEventAsync()
        {
            // Snippet: DeleteEventAsync(string, CallSettings)
            // Additional: DeleteEventAsync(string, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/channels/[CHANNEL]/events/[EVENT]";
            // Make the request
            await livestreamServiceClient.DeleteEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvent</summary>
        public void DeleteEventResourceNames()
        {
            // Snippet: DeleteEvent(EventName, CallSettings)
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            EventName name = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]");
            // Make the request
            livestreamServiceClient.DeleteEvent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventAsync</summary>
        public async Task DeleteEventResourceNamesAsync()
        {
            // Snippet: DeleteEventAsync(EventName, CallSettings)
            // Additional: DeleteEventAsync(EventName, CancellationToken)
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            EventName name = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]");
            // Make the request
            await livestreamServiceClient.DeleteEventAsync(name);
            // End snippet
        }
    }
}
