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
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.DeviceStreaming.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDirectAccessServiceClientSnippets
    {
        /// <summary>Snippet for CreateDeviceSession</summary>
        public void CreateDeviceSessionRequestObject()
        {
            // Snippet: CreateDeviceSession(CreateDeviceSessionRequest, CallSettings)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = DirectAccessServiceClient.Create();
            // Initialize request argument(s)
            CreateDeviceSessionRequest request = new CreateDeviceSessionRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                DeviceSession = new DeviceSession(),
                DeviceSessionId = "",
            };
            // Make the request
            DeviceSession response = directAccessServiceClient.CreateDeviceSession(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeviceSessionAsync</summary>
        public async Task CreateDeviceSessionRequestObjectAsync()
        {
            // Snippet: CreateDeviceSessionAsync(CreateDeviceSessionRequest, CallSettings)
            // Additional: CreateDeviceSessionAsync(CreateDeviceSessionRequest, CancellationToken)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = await DirectAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDeviceSessionRequest request = new CreateDeviceSessionRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                DeviceSession = new DeviceSession(),
                DeviceSessionId = "",
            };
            // Make the request
            DeviceSession response = await directAccessServiceClient.CreateDeviceSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeviceSession</summary>
        public void CreateDeviceSession()
        {
            // Snippet: CreateDeviceSession(string, DeviceSession, string, CallSettings)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = DirectAccessServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            DeviceSession deviceSession = new DeviceSession();
            string deviceSessionId = "";
            // Make the request
            DeviceSession response = directAccessServiceClient.CreateDeviceSession(parent, deviceSession, deviceSessionId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeviceSessionAsync</summary>
        public async Task CreateDeviceSessionAsync()
        {
            // Snippet: CreateDeviceSessionAsync(string, DeviceSession, string, CallSettings)
            // Additional: CreateDeviceSessionAsync(string, DeviceSession, string, CancellationToken)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = await DirectAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            DeviceSession deviceSession = new DeviceSession();
            string deviceSessionId = "";
            // Make the request
            DeviceSession response = await directAccessServiceClient.CreateDeviceSessionAsync(parent, deviceSession, deviceSessionId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeviceSession</summary>
        public void CreateDeviceSessionResourceNames()
        {
            // Snippet: CreateDeviceSession(ProjectName, DeviceSession, string, CallSettings)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = DirectAccessServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            DeviceSession deviceSession = new DeviceSession();
            string deviceSessionId = "";
            // Make the request
            DeviceSession response = directAccessServiceClient.CreateDeviceSession(parent, deviceSession, deviceSessionId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeviceSessionAsync</summary>
        public async Task CreateDeviceSessionResourceNamesAsync()
        {
            // Snippet: CreateDeviceSessionAsync(ProjectName, DeviceSession, string, CallSettings)
            // Additional: CreateDeviceSessionAsync(ProjectName, DeviceSession, string, CancellationToken)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = await DirectAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            DeviceSession deviceSession = new DeviceSession();
            string deviceSessionId = "";
            // Make the request
            DeviceSession response = await directAccessServiceClient.CreateDeviceSessionAsync(parent, deviceSession, deviceSessionId);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceSessions</summary>
        public void ListDeviceSessionsRequestObject()
        {
            // Snippet: ListDeviceSessions(ListDeviceSessionsRequest, CallSettings)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = DirectAccessServiceClient.Create();
            // Initialize request argument(s)
            ListDeviceSessionsRequest request = new ListDeviceSessionsRequest
            {
                Filter = "",
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListDeviceSessionsResponse, DeviceSession> response = directAccessServiceClient.ListDeviceSessions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeviceSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeviceSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceSession> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceSessionsAsync</summary>
        public async Task ListDeviceSessionsRequestObjectAsync()
        {
            // Snippet: ListDeviceSessionsAsync(ListDeviceSessionsRequest, CallSettings)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = await DirectAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDeviceSessionsRequest request = new ListDeviceSessionsRequest
            {
                Filter = "",
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDeviceSessionsResponse, DeviceSession> response = directAccessServiceClient.ListDeviceSessionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeviceSession item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeviceSessionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceSession> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceSessions</summary>
        public void ListDeviceSessions()
        {
            // Snippet: ListDeviceSessions(string, string, int?, CallSettings)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = DirectAccessServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListDeviceSessionsResponse, DeviceSession> response = directAccessServiceClient.ListDeviceSessions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeviceSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeviceSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceSession> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceSessionsAsync</summary>
        public async Task ListDeviceSessionsAsync()
        {
            // Snippet: ListDeviceSessionsAsync(string, string, int?, CallSettings)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = await DirectAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListDeviceSessionsResponse, DeviceSession> response = directAccessServiceClient.ListDeviceSessionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeviceSession item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeviceSessionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceSession> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceSessions</summary>
        public void ListDeviceSessionsResourceNames()
        {
            // Snippet: ListDeviceSessions(ProjectName, string, int?, CallSettings)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = DirectAccessServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListDeviceSessionsResponse, DeviceSession> response = directAccessServiceClient.ListDeviceSessions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeviceSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeviceSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceSession> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceSessionsAsync</summary>
        public async Task ListDeviceSessionsResourceNamesAsync()
        {
            // Snippet: ListDeviceSessionsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = await DirectAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListDeviceSessionsResponse, DeviceSession> response = directAccessServiceClient.ListDeviceSessionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeviceSession item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeviceSessionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceSession> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDeviceSession</summary>
        public void GetDeviceSessionRequestObject()
        {
            // Snippet: GetDeviceSession(GetDeviceSessionRequest, CallSettings)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = DirectAccessServiceClient.Create();
            // Initialize request argument(s)
            GetDeviceSessionRequest request = new GetDeviceSessionRequest
            {
                DeviceSessionName = DeviceSessionName.FromProjectDeviceSession("[PROJECT]", "[DEVICE_SESSION]"),
            };
            // Make the request
            DeviceSession response = directAccessServiceClient.GetDeviceSession(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceSessionAsync</summary>
        public async Task GetDeviceSessionRequestObjectAsync()
        {
            // Snippet: GetDeviceSessionAsync(GetDeviceSessionRequest, CallSettings)
            // Additional: GetDeviceSessionAsync(GetDeviceSessionRequest, CancellationToken)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = await DirectAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDeviceSessionRequest request = new GetDeviceSessionRequest
            {
                DeviceSessionName = DeviceSessionName.FromProjectDeviceSession("[PROJECT]", "[DEVICE_SESSION]"),
            };
            // Make the request
            DeviceSession response = await directAccessServiceClient.GetDeviceSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceSession</summary>
        public void GetDeviceSession()
        {
            // Snippet: GetDeviceSession(string, CallSettings)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = DirectAccessServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/deviceSessions/[DEVICE_SESSION]";
            // Make the request
            DeviceSession response = directAccessServiceClient.GetDeviceSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceSessionAsync</summary>
        public async Task GetDeviceSessionAsync()
        {
            // Snippet: GetDeviceSessionAsync(string, CallSettings)
            // Additional: GetDeviceSessionAsync(string, CancellationToken)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = await DirectAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/deviceSessions/[DEVICE_SESSION]";
            // Make the request
            DeviceSession response = await directAccessServiceClient.GetDeviceSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceSession</summary>
        public void GetDeviceSessionResourceNames()
        {
            // Snippet: GetDeviceSession(DeviceSessionName, CallSettings)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = DirectAccessServiceClient.Create();
            // Initialize request argument(s)
            DeviceSessionName name = DeviceSessionName.FromProjectDeviceSession("[PROJECT]", "[DEVICE_SESSION]");
            // Make the request
            DeviceSession response = directAccessServiceClient.GetDeviceSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceSessionAsync</summary>
        public async Task GetDeviceSessionResourceNamesAsync()
        {
            // Snippet: GetDeviceSessionAsync(DeviceSessionName, CallSettings)
            // Additional: GetDeviceSessionAsync(DeviceSessionName, CancellationToken)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = await DirectAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeviceSessionName name = DeviceSessionName.FromProjectDeviceSession("[PROJECT]", "[DEVICE_SESSION]");
            // Make the request
            DeviceSession response = await directAccessServiceClient.GetDeviceSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelDeviceSession</summary>
        public void CancelDeviceSessionRequestObject()
        {
            // Snippet: CancelDeviceSession(CancelDeviceSessionRequest, CallSettings)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = DirectAccessServiceClient.Create();
            // Initialize request argument(s)
            CancelDeviceSessionRequest request = new CancelDeviceSessionRequest
            {
                DeviceSessionName = DeviceSessionName.FromProjectDeviceSession("[PROJECT]", "[DEVICE_SESSION]"),
            };
            // Make the request
            directAccessServiceClient.CancelDeviceSession(request);
            // End snippet
        }

        /// <summary>Snippet for CancelDeviceSessionAsync</summary>
        public async Task CancelDeviceSessionRequestObjectAsync()
        {
            // Snippet: CancelDeviceSessionAsync(CancelDeviceSessionRequest, CallSettings)
            // Additional: CancelDeviceSessionAsync(CancelDeviceSessionRequest, CancellationToken)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = await DirectAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelDeviceSessionRequest request = new CancelDeviceSessionRequest
            {
                DeviceSessionName = DeviceSessionName.FromProjectDeviceSession("[PROJECT]", "[DEVICE_SESSION]"),
            };
            // Make the request
            await directAccessServiceClient.CancelDeviceSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeviceSession</summary>
        public void UpdateDeviceSessionRequestObject()
        {
            // Snippet: UpdateDeviceSession(UpdateDeviceSessionRequest, CallSettings)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = DirectAccessServiceClient.Create();
            // Initialize request argument(s)
            UpdateDeviceSessionRequest request = new UpdateDeviceSessionRequest
            {
                DeviceSession = new DeviceSession(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DeviceSession response = directAccessServiceClient.UpdateDeviceSession(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeviceSessionAsync</summary>
        public async Task UpdateDeviceSessionRequestObjectAsync()
        {
            // Snippet: UpdateDeviceSessionAsync(UpdateDeviceSessionRequest, CallSettings)
            // Additional: UpdateDeviceSessionAsync(UpdateDeviceSessionRequest, CancellationToken)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = await DirectAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDeviceSessionRequest request = new UpdateDeviceSessionRequest
            {
                DeviceSession = new DeviceSession(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DeviceSession response = await directAccessServiceClient.UpdateDeviceSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeviceSession</summary>
        public void UpdateDeviceSession()
        {
            // Snippet: UpdateDeviceSession(DeviceSession, FieldMask, CallSettings)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = DirectAccessServiceClient.Create();
            // Initialize request argument(s)
            DeviceSession deviceSession = new DeviceSession();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DeviceSession response = directAccessServiceClient.UpdateDeviceSession(deviceSession, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeviceSessionAsync</summary>
        public async Task UpdateDeviceSessionAsync()
        {
            // Snippet: UpdateDeviceSessionAsync(DeviceSession, FieldMask, CallSettings)
            // Additional: UpdateDeviceSessionAsync(DeviceSession, FieldMask, CancellationToken)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = await DirectAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeviceSession deviceSession = new DeviceSession();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DeviceSession response = await directAccessServiceClient.UpdateDeviceSessionAsync(deviceSession, updateMask);
            // End snippet
        }

        /// <summary>Snippet for AdbConnect</summary>
        public async Task AdbConnect()
        {
            // Snippet: AdbConnect(CallSettings, BidirectionalStreamingSettings)
            // Create client
            DirectAccessServiceClient directAccessServiceClient = DirectAccessServiceClient.Create();
            // Initialize streaming call, retrieving the stream object
            using DirectAccessServiceClient.AdbConnectStream response = directAccessServiceClient.AdbConnect();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<DeviceMessage> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    DeviceMessage responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                AdbMessage request = new AdbMessage { Open = new Open(), };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }
    }
}
