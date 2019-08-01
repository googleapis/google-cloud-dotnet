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
    public class GeneratedNotificationChannelServiceClientSnippets
    {
        /// <summary>Snippet for ListNotificationChannelDescriptorsAsync</summary>
        public async Task ListNotificationChannelDescriptorsAsync()
        {
            // Snippet: ListNotificationChannelDescriptorsAsync(ProjectName,string,int?,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> response =
                notificationChannelServiceClient.ListNotificationChannelDescriptorsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationChannelDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationChannelDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannelDescriptor item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannelDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannelDescriptor item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelDescriptors</summary>
        public void ListNotificationChannelDescriptors()
        {
            // Snippet: ListNotificationChannelDescriptors(ProjectName,string,int?,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> response =
                notificationChannelServiceClient.ListNotificationChannelDescriptors(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationChannelDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationChannelDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannelDescriptor item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannelDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannelDescriptor item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelDescriptorsAsync</summary>
        public async Task ListNotificationChannelDescriptorsAsync_RequestObject()
        {
            // Snippet: ListNotificationChannelDescriptorsAsync(ListNotificationChannelDescriptorsRequest,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNotificationChannelDescriptorsRequest request = new ListNotificationChannelDescriptorsRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> response =
                notificationChannelServiceClient.ListNotificationChannelDescriptorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationChannelDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationChannelDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannelDescriptor item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannelDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannelDescriptor item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelDescriptors</summary>
        public void ListNotificationChannelDescriptors_RequestObject()
        {
            // Snippet: ListNotificationChannelDescriptors(ListNotificationChannelDescriptorsRequest,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            ListNotificationChannelDescriptorsRequest request = new ListNotificationChannelDescriptorsRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> response =
                notificationChannelServiceClient.ListNotificationChannelDescriptors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationChannelDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationChannelDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannelDescriptor item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannelDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannelDescriptor item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelDescriptorAsync</summary>
        public async Task GetNotificationChannelDescriptorAsync()
        {
            // Snippet: GetNotificationChannelDescriptorAsync(NotificationChannelDescriptorName,CallSettings)
            // Additional: GetNotificationChannelDescriptorAsync(NotificationChannelDescriptorName,CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotificationChannelDescriptorName name = new NotificationChannelDescriptorName("[PROJECT]", "[CHANNEL_DESCRIPTOR]");
            // Make the request
            NotificationChannelDescriptor response = await notificationChannelServiceClient.GetNotificationChannelDescriptorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelDescriptor</summary>
        public void GetNotificationChannelDescriptor()
        {
            // Snippet: GetNotificationChannelDescriptor(NotificationChannelDescriptorName,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            NotificationChannelDescriptorName name = new NotificationChannelDescriptorName("[PROJECT]", "[CHANNEL_DESCRIPTOR]");
            // Make the request
            NotificationChannelDescriptor response = notificationChannelServiceClient.GetNotificationChannelDescriptor(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelDescriptorAsync</summary>
        public async Task GetNotificationChannelDescriptorAsync_RequestObject()
        {
            // Snippet: GetNotificationChannelDescriptorAsync(GetNotificationChannelDescriptorRequest,CallSettings)
            // Additional: GetNotificationChannelDescriptorAsync(GetNotificationChannelDescriptorRequest,CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNotificationChannelDescriptorRequest request = new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = new NotificationChannelDescriptorName("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
            };
            // Make the request
            NotificationChannelDescriptor response = await notificationChannelServiceClient.GetNotificationChannelDescriptorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelDescriptor</summary>
        public void GetNotificationChannelDescriptor_RequestObject()
        {
            // Snippet: GetNotificationChannelDescriptor(GetNotificationChannelDescriptorRequest,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            GetNotificationChannelDescriptorRequest request = new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = new NotificationChannelDescriptorName("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
            };
            // Make the request
            NotificationChannelDescriptor response = notificationChannelServiceClient.GetNotificationChannelDescriptor(request);
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelsAsync</summary>
        public async Task ListNotificationChannelsAsync()
        {
            // Snippet: ListNotificationChannelsAsync(ProjectName,string,int?,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> response =
                notificationChannelServiceClient.ListNotificationChannelsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationChannel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationChannelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannel item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannel item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannels</summary>
        public void ListNotificationChannels()
        {
            // Snippet: ListNotificationChannels(ProjectName,string,int?,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> response =
                notificationChannelServiceClient.ListNotificationChannels(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationChannel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationChannelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannel item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannel item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannelsAsync</summary>
        public async Task ListNotificationChannelsAsync_RequestObject()
        {
            // Snippet: ListNotificationChannelsAsync(ListNotificationChannelsRequest,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNotificationChannelsRequest request = new ListNotificationChannelsRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> response =
                notificationChannelServiceClient.ListNotificationChannelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationChannel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationChannelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannel item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannel item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationChannels</summary>
        public void ListNotificationChannels_RequestObject()
        {
            // Snippet: ListNotificationChannels(ListNotificationChannelsRequest,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            ListNotificationChannelsRequest request = new ListNotificationChannelsRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> response =
                notificationChannelServiceClient.ListNotificationChannels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationChannel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationChannelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationChannel item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationChannel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationChannel item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelAsync</summary>
        public async Task GetNotificationChannelAsync()
        {
            // Snippet: GetNotificationChannelAsync(NotificationChannelName,CallSettings)
            // Additional: GetNotificationChannelAsync(NotificationChannelName,CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.GetNotificationChannelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannel</summary>
        public void GetNotificationChannel()
        {
            // Snippet: GetNotificationChannel(NotificationChannelName,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.GetNotificationChannel(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelAsync</summary>
        public async Task GetNotificationChannelAsync_RequestObject()
        {
            // Snippet: GetNotificationChannelAsync(GetNotificationChannelRequest,CallSettings)
            // Additional: GetNotificationChannelAsync(GetNotificationChannelRequest,CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNotificationChannelRequest request = new GetNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.GetNotificationChannelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannel</summary>
        public void GetNotificationChannel_RequestObject()
        {
            // Snippet: GetNotificationChannel(GetNotificationChannelRequest,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            GetNotificationChannelRequest request = new GetNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.GetNotificationChannel(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationChannelAsync</summary>
        public async Task CreateNotificationChannelAsync()
        {
            // Snippet: CreateNotificationChannelAsync(ProjectName,NotificationChannel,CallSettings)
            // Additional: CreateNotificationChannelAsync(ProjectName,NotificationChannel,CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = new ProjectName("[PROJECT]");
            NotificationChannel notificationChannel = new NotificationChannel();
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.CreateNotificationChannelAsync(name, notificationChannel);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationChannel</summary>
        public void CreateNotificationChannel()
        {
            // Snippet: CreateNotificationChannel(ProjectName,NotificationChannel,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = new ProjectName("[PROJECT]");
            NotificationChannel notificationChannel = new NotificationChannel();
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.CreateNotificationChannel(name, notificationChannel);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationChannelAsync</summary>
        public async Task CreateNotificationChannelAsync_RequestObject()
        {
            // Snippet: CreateNotificationChannelAsync(CreateNotificationChannelRequest,CallSettings)
            // Additional: CreateNotificationChannelAsync(CreateNotificationChannelRequest,CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                NotificationChannel = new NotificationChannel(),
            };
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.CreateNotificationChannelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationChannel</summary>
        public void CreateNotificationChannel_RequestObject()
        {
            // Snippet: CreateNotificationChannel(CreateNotificationChannelRequest,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                NotificationChannel = new NotificationChannel(),
            };
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.CreateNotificationChannel(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotificationChannelAsync</summary>
        public async Task UpdateNotificationChannelAsync()
        {
            // Snippet: UpdateNotificationChannelAsync(FieldMask,NotificationChannel,CallSettings)
            // Additional: UpdateNotificationChannelAsync(FieldMask,NotificationChannel,CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            FieldMask updateMask = new FieldMask();
            NotificationChannel notificationChannel = new NotificationChannel();
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.UpdateNotificationChannelAsync(updateMask, notificationChannel);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotificationChannel</summary>
        public void UpdateNotificationChannel()
        {
            // Snippet: UpdateNotificationChannel(FieldMask,NotificationChannel,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            FieldMask updateMask = new FieldMask();
            NotificationChannel notificationChannel = new NotificationChannel();
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.UpdateNotificationChannel(updateMask, notificationChannel);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotificationChannelAsync</summary>
        public async Task UpdateNotificationChannelAsync_RequestObject()
        {
            // Snippet: UpdateNotificationChannelAsync(UpdateNotificationChannelRequest,CallSettings)
            // Additional: UpdateNotificationChannelAsync(UpdateNotificationChannelRequest,CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateNotificationChannelRequest request = new UpdateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
            };
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.UpdateNotificationChannelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNotificationChannel</summary>
        public void UpdateNotificationChannel_RequestObject()
        {
            // Snippet: UpdateNotificationChannel(UpdateNotificationChannelRequest,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            UpdateNotificationChannelRequest request = new UpdateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
            };
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.UpdateNotificationChannel(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationChannelAsync</summary>
        public async Task DeleteNotificationChannelAsync()
        {
            // Snippet: DeleteNotificationChannelAsync(NotificationChannelName,bool?,CallSettings)
            // Additional: DeleteNotificationChannelAsync(NotificationChannelName,bool?,CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            bool force = false;
            // Make the request
            await notificationChannelServiceClient.DeleteNotificationChannelAsync(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationChannel</summary>
        public void DeleteNotificationChannel()
        {
            // Snippet: DeleteNotificationChannel(NotificationChannelName,bool?,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            bool force = false;
            // Make the request
            notificationChannelServiceClient.DeleteNotificationChannel(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationChannelAsync</summary>
        public async Task DeleteNotificationChannelAsync_RequestObject()
        {
            // Snippet: DeleteNotificationChannelAsync(DeleteNotificationChannelRequest,CallSettings)
            // Additional: DeleteNotificationChannelAsync(DeleteNotificationChannelRequest,CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNotificationChannelRequest request = new DeleteNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            // Make the request
            await notificationChannelServiceClient.DeleteNotificationChannelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationChannel</summary>
        public void DeleteNotificationChannel_RequestObject()
        {
            // Snippet: DeleteNotificationChannel(DeleteNotificationChannelRequest,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            DeleteNotificationChannelRequest request = new DeleteNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            // Make the request
            notificationChannelServiceClient.DeleteNotificationChannel(request);
            // End snippet
        }

        /// <summary>Snippet for SendNotificationChannelVerificationCodeAsync</summary>
        public async Task SendNotificationChannelVerificationCodeAsync()
        {
            // Snippet: SendNotificationChannelVerificationCodeAsync(NotificationChannelName,CallSettings)
            // Additional: SendNotificationChannelVerificationCodeAsync(NotificationChannelName,CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            // Make the request
            await notificationChannelServiceClient.SendNotificationChannelVerificationCodeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SendNotificationChannelVerificationCode</summary>
        public void SendNotificationChannelVerificationCode()
        {
            // Snippet: SendNotificationChannelVerificationCode(NotificationChannelName,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            // Make the request
            notificationChannelServiceClient.SendNotificationChannelVerificationCode(name);
            // End snippet
        }

        /// <summary>Snippet for SendNotificationChannelVerificationCodeAsync</summary>
        public async Task SendNotificationChannelVerificationCodeAsync_RequestObject()
        {
            // Snippet: SendNotificationChannelVerificationCodeAsync(SendNotificationChannelVerificationCodeRequest,CallSettings)
            // Additional: SendNotificationChannelVerificationCodeAsync(SendNotificationChannelVerificationCodeRequest,CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            SendNotificationChannelVerificationCodeRequest request = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            // Make the request
            await notificationChannelServiceClient.SendNotificationChannelVerificationCodeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SendNotificationChannelVerificationCode</summary>
        public void SendNotificationChannelVerificationCode_RequestObject()
        {
            // Snippet: SendNotificationChannelVerificationCode(SendNotificationChannelVerificationCodeRequest,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            SendNotificationChannelVerificationCodeRequest request = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            // Make the request
            notificationChannelServiceClient.SendNotificationChannelVerificationCode(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelVerificationCodeAsync</summary>
        public async Task GetNotificationChannelVerificationCodeAsync()
        {
            // Snippet: GetNotificationChannelVerificationCodeAsync(NotificationChannelName,CallSettings)
            // Additional: GetNotificationChannelVerificationCodeAsync(NotificationChannelName,CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            // Make the request
            GetNotificationChannelVerificationCodeResponse response = await notificationChannelServiceClient.GetNotificationChannelVerificationCodeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelVerificationCode</summary>
        public void GetNotificationChannelVerificationCode()
        {
            // Snippet: GetNotificationChannelVerificationCode(NotificationChannelName,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            // Make the request
            GetNotificationChannelVerificationCodeResponse response = notificationChannelServiceClient.GetNotificationChannelVerificationCode(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelVerificationCodeAsync</summary>
        public async Task GetNotificationChannelVerificationCodeAsync_RequestObject()
        {
            // Snippet: GetNotificationChannelVerificationCodeAsync(GetNotificationChannelVerificationCodeRequest,CallSettings)
            // Additional: GetNotificationChannelVerificationCodeAsync(GetNotificationChannelVerificationCodeRequest,CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNotificationChannelVerificationCodeRequest request = new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            // Make the request
            GetNotificationChannelVerificationCodeResponse response = await notificationChannelServiceClient.GetNotificationChannelVerificationCodeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationChannelVerificationCode</summary>
        public void GetNotificationChannelVerificationCode_RequestObject()
        {
            // Snippet: GetNotificationChannelVerificationCode(GetNotificationChannelVerificationCodeRequest,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            GetNotificationChannelVerificationCodeRequest request = new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            // Make the request
            GetNotificationChannelVerificationCodeResponse response = notificationChannelServiceClient.GetNotificationChannelVerificationCode(request);
            // End snippet
        }

        /// <summary>Snippet for VerifyNotificationChannelAsync</summary>
        public async Task VerifyNotificationChannelAsync()
        {
            // Snippet: VerifyNotificationChannelAsync(NotificationChannelName,string,CallSettings)
            // Additional: VerifyNotificationChannelAsync(NotificationChannelName,string,CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            string code = "";
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.VerifyNotificationChannelAsync(name, code);
            // End snippet
        }

        /// <summary>Snippet for VerifyNotificationChannel</summary>
        public void VerifyNotificationChannel()
        {
            // Snippet: VerifyNotificationChannel(NotificationChannelName,string,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            string code = "";
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.VerifyNotificationChannel(name, code);
            // End snippet
        }

        /// <summary>Snippet for VerifyNotificationChannelAsync</summary>
        public async Task VerifyNotificationChannelAsync_RequestObject()
        {
            // Snippet: VerifyNotificationChannelAsync(VerifyNotificationChannelRequest,CallSettings)
            // Additional: VerifyNotificationChannelAsync(VerifyNotificationChannelRequest,CancellationToken)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            VerifyNotificationChannelRequest request = new VerifyNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Code = "",
            };
            // Make the request
            NotificationChannel response = await notificationChannelServiceClient.VerifyNotificationChannelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for VerifyNotificationChannel</summary>
        public void VerifyNotificationChannel_RequestObject()
        {
            // Snippet: VerifyNotificationChannel(VerifyNotificationChannelRequest,CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            VerifyNotificationChannelRequest request = new VerifyNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Code = "",
            };
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.VerifyNotificationChannel(request);
            // End snippet
        }

    }
}
