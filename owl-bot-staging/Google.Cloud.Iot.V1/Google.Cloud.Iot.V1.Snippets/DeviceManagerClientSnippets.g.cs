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

namespace Google.Cloud.Iot.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDeviceManagerClientSnippets
    {
        /// <summary>Snippet for CreateDeviceRegistry</summary>
        public void CreateDeviceRegistryRequestObject()
        {
            // Snippet: CreateDeviceRegistry(CreateDeviceRegistryRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            CreateDeviceRegistryRequest request = new CreateDeviceRegistryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeviceRegistry = new DeviceRegistry(),
            };
            // Make the request
            DeviceRegistry response = deviceManagerClient.CreateDeviceRegistry(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeviceRegistryAsync</summary>
        public async Task CreateDeviceRegistryRequestObjectAsync()
        {
            // Snippet: CreateDeviceRegistryAsync(CreateDeviceRegistryRequest, CallSettings)
            // Additional: CreateDeviceRegistryAsync(CreateDeviceRegistryRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateDeviceRegistryRequest request = new CreateDeviceRegistryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeviceRegistry = new DeviceRegistry(),
            };
            // Make the request
            DeviceRegistry response = await deviceManagerClient.CreateDeviceRegistryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeviceRegistry</summary>
        public void CreateDeviceRegistry()
        {
            // Snippet: CreateDeviceRegistry(string, DeviceRegistry, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DeviceRegistry deviceRegistry = new DeviceRegistry();
            // Make the request
            DeviceRegistry response = deviceManagerClient.CreateDeviceRegistry(parent, deviceRegistry);
            // End snippet
        }

        /// <summary>Snippet for CreateDeviceRegistryAsync</summary>
        public async Task CreateDeviceRegistryAsync()
        {
            // Snippet: CreateDeviceRegistryAsync(string, DeviceRegistry, CallSettings)
            // Additional: CreateDeviceRegistryAsync(string, DeviceRegistry, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DeviceRegistry deviceRegistry = new DeviceRegistry();
            // Make the request
            DeviceRegistry response = await deviceManagerClient.CreateDeviceRegistryAsync(parent, deviceRegistry);
            // End snippet
        }

        /// <summary>Snippet for CreateDeviceRegistry</summary>
        public void CreateDeviceRegistryResourceNames()
        {
            // Snippet: CreateDeviceRegistry(LocationName, DeviceRegistry, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DeviceRegistry deviceRegistry = new DeviceRegistry();
            // Make the request
            DeviceRegistry response = deviceManagerClient.CreateDeviceRegistry(parent, deviceRegistry);
            // End snippet
        }

        /// <summary>Snippet for CreateDeviceRegistryAsync</summary>
        public async Task CreateDeviceRegistryResourceNamesAsync()
        {
            // Snippet: CreateDeviceRegistryAsync(LocationName, DeviceRegistry, CallSettings)
            // Additional: CreateDeviceRegistryAsync(LocationName, DeviceRegistry, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DeviceRegistry deviceRegistry = new DeviceRegistry();
            // Make the request
            DeviceRegistry response = await deviceManagerClient.CreateDeviceRegistryAsync(parent, deviceRegistry);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceRegistry</summary>
        public void GetDeviceRegistryRequestObject()
        {
            // Snippet: GetDeviceRegistry(GetDeviceRegistryRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            GetDeviceRegistryRequest request = new GetDeviceRegistryRequest
            {
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
            };
            // Make the request
            DeviceRegistry response = deviceManagerClient.GetDeviceRegistry(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceRegistryAsync</summary>
        public async Task GetDeviceRegistryRequestObjectAsync()
        {
            // Snippet: GetDeviceRegistryAsync(GetDeviceRegistryRequest, CallSettings)
            // Additional: GetDeviceRegistryAsync(GetDeviceRegistryRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetDeviceRegistryRequest request = new GetDeviceRegistryRequest
            {
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
            };
            // Make the request
            DeviceRegistry response = await deviceManagerClient.GetDeviceRegistryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceRegistry</summary>
        public void GetDeviceRegistry()
        {
            // Snippet: GetDeviceRegistry(string, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]";
            // Make the request
            DeviceRegistry response = deviceManagerClient.GetDeviceRegistry(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceRegistryAsync</summary>
        public async Task GetDeviceRegistryAsync()
        {
            // Snippet: GetDeviceRegistryAsync(string, CallSettings)
            // Additional: GetDeviceRegistryAsync(string, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]";
            // Make the request
            DeviceRegistry response = await deviceManagerClient.GetDeviceRegistryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceRegistry</summary>
        public void GetDeviceRegistryResourceNames()
        {
            // Snippet: GetDeviceRegistry(RegistryName, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            RegistryName name = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]");
            // Make the request
            DeviceRegistry response = deviceManagerClient.GetDeviceRegistry(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceRegistryAsync</summary>
        public async Task GetDeviceRegistryResourceNamesAsync()
        {
            // Snippet: GetDeviceRegistryAsync(RegistryName, CallSettings)
            // Additional: GetDeviceRegistryAsync(RegistryName, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            RegistryName name = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]");
            // Make the request
            DeviceRegistry response = await deviceManagerClient.GetDeviceRegistryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeviceRegistry</summary>
        public void UpdateDeviceRegistryRequestObject()
        {
            // Snippet: UpdateDeviceRegistry(UpdateDeviceRegistryRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            UpdateDeviceRegistryRequest request = new UpdateDeviceRegistryRequest
            {
                DeviceRegistry = new DeviceRegistry(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DeviceRegistry response = deviceManagerClient.UpdateDeviceRegistry(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeviceRegistryAsync</summary>
        public async Task UpdateDeviceRegistryRequestObjectAsync()
        {
            // Snippet: UpdateDeviceRegistryAsync(UpdateDeviceRegistryRequest, CallSettings)
            // Additional: UpdateDeviceRegistryAsync(UpdateDeviceRegistryRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDeviceRegistryRequest request = new UpdateDeviceRegistryRequest
            {
                DeviceRegistry = new DeviceRegistry(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DeviceRegistry response = await deviceManagerClient.UpdateDeviceRegistryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeviceRegistry</summary>
        public void UpdateDeviceRegistry()
        {
            // Snippet: UpdateDeviceRegistry(DeviceRegistry, FieldMask, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            DeviceRegistry deviceRegistry = new DeviceRegistry();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DeviceRegistry response = deviceManagerClient.UpdateDeviceRegistry(deviceRegistry, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeviceRegistryAsync</summary>
        public async Task UpdateDeviceRegistryAsync()
        {
            // Snippet: UpdateDeviceRegistryAsync(DeviceRegistry, FieldMask, CallSettings)
            // Additional: UpdateDeviceRegistryAsync(DeviceRegistry, FieldMask, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeviceRegistry deviceRegistry = new DeviceRegistry();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DeviceRegistry response = await deviceManagerClient.UpdateDeviceRegistryAsync(deviceRegistry, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeviceRegistry</summary>
        public void DeleteDeviceRegistryRequestObject()
        {
            // Snippet: DeleteDeviceRegistry(DeleteDeviceRegistryRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            DeleteDeviceRegistryRequest request = new DeleteDeviceRegistryRequest
            {
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
            };
            // Make the request
            deviceManagerClient.DeleteDeviceRegistry(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeviceRegistryAsync</summary>
        public async Task DeleteDeviceRegistryRequestObjectAsync()
        {
            // Snippet: DeleteDeviceRegistryAsync(DeleteDeviceRegistryRequest, CallSettings)
            // Additional: DeleteDeviceRegistryAsync(DeleteDeviceRegistryRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDeviceRegistryRequest request = new DeleteDeviceRegistryRequest
            {
                RegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
            };
            // Make the request
            await deviceManagerClient.DeleteDeviceRegistryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeviceRegistry</summary>
        public void DeleteDeviceRegistry()
        {
            // Snippet: DeleteDeviceRegistry(string, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]";
            // Make the request
            deviceManagerClient.DeleteDeviceRegistry(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeviceRegistryAsync</summary>
        public async Task DeleteDeviceRegistryAsync()
        {
            // Snippet: DeleteDeviceRegistryAsync(string, CallSettings)
            // Additional: DeleteDeviceRegistryAsync(string, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]";
            // Make the request
            await deviceManagerClient.DeleteDeviceRegistryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeviceRegistry</summary>
        public void DeleteDeviceRegistryResourceNames()
        {
            // Snippet: DeleteDeviceRegistry(RegistryName, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            RegistryName name = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]");
            // Make the request
            deviceManagerClient.DeleteDeviceRegistry(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeviceRegistryAsync</summary>
        public async Task DeleteDeviceRegistryResourceNamesAsync()
        {
            // Snippet: DeleteDeviceRegistryAsync(RegistryName, CallSettings)
            // Additional: DeleteDeviceRegistryAsync(RegistryName, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            RegistryName name = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]");
            // Make the request
            await deviceManagerClient.DeleteDeviceRegistryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceRegistries</summary>
        public void ListDeviceRegistriesRequestObject()
        {
            // Snippet: ListDeviceRegistries(ListDeviceRegistriesRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            ListDeviceRegistriesRequest request = new ListDeviceRegistriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListDeviceRegistriesResponse, DeviceRegistry> response = deviceManagerClient.ListDeviceRegistries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeviceRegistry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeviceRegistriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceRegistry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceRegistry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceRegistry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceRegistriesAsync</summary>
        public async Task ListDeviceRegistriesRequestObjectAsync()
        {
            // Snippet: ListDeviceRegistriesAsync(ListDeviceRegistriesRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListDeviceRegistriesRequest request = new ListDeviceRegistriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDeviceRegistriesResponse, DeviceRegistry> response = deviceManagerClient.ListDeviceRegistriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeviceRegistry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeviceRegistriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceRegistry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceRegistry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceRegistry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceRegistries</summary>
        public void ListDeviceRegistries()
        {
            // Snippet: ListDeviceRegistries(string, string, int?, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDeviceRegistriesResponse, DeviceRegistry> response = deviceManagerClient.ListDeviceRegistries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeviceRegistry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeviceRegistriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceRegistry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceRegistry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceRegistry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceRegistriesAsync</summary>
        public async Task ListDeviceRegistriesAsync()
        {
            // Snippet: ListDeviceRegistriesAsync(string, string, int?, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDeviceRegistriesResponse, DeviceRegistry> response = deviceManagerClient.ListDeviceRegistriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeviceRegistry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeviceRegistriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceRegistry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceRegistry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceRegistry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceRegistries</summary>
        public void ListDeviceRegistriesResourceNames()
        {
            // Snippet: ListDeviceRegistries(LocationName, string, int?, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDeviceRegistriesResponse, DeviceRegistry> response = deviceManagerClient.ListDeviceRegistries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeviceRegistry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeviceRegistriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceRegistry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceRegistry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceRegistry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceRegistriesAsync</summary>
        public async Task ListDeviceRegistriesResourceNamesAsync()
        {
            // Snippet: ListDeviceRegistriesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDeviceRegistriesResponse, DeviceRegistry> response = deviceManagerClient.ListDeviceRegistriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeviceRegistry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeviceRegistriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceRegistry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceRegistry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceRegistry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateDevice</summary>
        public void CreateDeviceRequestObject()
        {
            // Snippet: CreateDevice(CreateDeviceRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            CreateDeviceRequest request = new CreateDeviceRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                Device = new Device(),
            };
            // Make the request
            Device response = deviceManagerClient.CreateDevice(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeviceAsync</summary>
        public async Task CreateDeviceRequestObjectAsync()
        {
            // Snippet: CreateDeviceAsync(CreateDeviceRequest, CallSettings)
            // Additional: CreateDeviceAsync(CreateDeviceRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateDeviceRequest request = new CreateDeviceRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                Device = new Device(),
            };
            // Make the request
            Device response = await deviceManagerClient.CreateDeviceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDevice</summary>
        public void CreateDevice()
        {
            // Snippet: CreateDevice(string, Device, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]";
            Device device = new Device();
            // Make the request
            Device response = deviceManagerClient.CreateDevice(parent, device);
            // End snippet
        }

        /// <summary>Snippet for CreateDeviceAsync</summary>
        public async Task CreateDeviceAsync()
        {
            // Snippet: CreateDeviceAsync(string, Device, CallSettings)
            // Additional: CreateDeviceAsync(string, Device, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]";
            Device device = new Device();
            // Make the request
            Device response = await deviceManagerClient.CreateDeviceAsync(parent, device);
            // End snippet
        }

        /// <summary>Snippet for CreateDevice</summary>
        public void CreateDeviceResourceNames()
        {
            // Snippet: CreateDevice(RegistryName, Device, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            RegistryName parent = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]");
            Device device = new Device();
            // Make the request
            Device response = deviceManagerClient.CreateDevice(parent, device);
            // End snippet
        }

        /// <summary>Snippet for CreateDeviceAsync</summary>
        public async Task CreateDeviceResourceNamesAsync()
        {
            // Snippet: CreateDeviceAsync(RegistryName, Device, CallSettings)
            // Additional: CreateDeviceAsync(RegistryName, Device, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            RegistryName parent = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]");
            Device device = new Device();
            // Make the request
            Device response = await deviceManagerClient.CreateDeviceAsync(parent, device);
            // End snippet
        }

        /// <summary>Snippet for GetDevice</summary>
        public void GetDeviceRequestObject()
        {
            // Snippet: GetDevice(GetDeviceRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            GetDeviceRequest request = new GetDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                FieldMask = new FieldMask(),
            };
            // Make the request
            Device response = deviceManagerClient.GetDevice(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceAsync</summary>
        public async Task GetDeviceRequestObjectAsync()
        {
            // Snippet: GetDeviceAsync(GetDeviceRequest, CallSettings)
            // Additional: GetDeviceAsync(GetDeviceRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetDeviceRequest request = new GetDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                FieldMask = new FieldMask(),
            };
            // Make the request
            Device response = await deviceManagerClient.GetDeviceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDevice</summary>
        public void GetDevice()
        {
            // Snippet: GetDevice(string, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]/devices/[DEVICE]";
            // Make the request
            Device response = deviceManagerClient.GetDevice(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceAsync</summary>
        public async Task GetDeviceAsync()
        {
            // Snippet: GetDeviceAsync(string, CallSettings)
            // Additional: GetDeviceAsync(string, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]/devices/[DEVICE]";
            // Make the request
            Device response = await deviceManagerClient.GetDeviceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDevice</summary>
        public void GetDeviceResourceNames()
        {
            // Snippet: GetDevice(DeviceName, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            DeviceName name = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]");
            // Make the request
            Device response = deviceManagerClient.GetDevice(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceAsync</summary>
        public async Task GetDeviceResourceNamesAsync()
        {
            // Snippet: GetDeviceAsync(DeviceName, CallSettings)
            // Additional: GetDeviceAsync(DeviceName, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeviceName name = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]");
            // Make the request
            Device response = await deviceManagerClient.GetDeviceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDevice</summary>
        public void UpdateDeviceRequestObject()
        {
            // Snippet: UpdateDevice(UpdateDeviceRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            UpdateDeviceRequest request = new UpdateDeviceRequest
            {
                Device = new Device(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Device response = deviceManagerClient.UpdateDevice(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeviceAsync</summary>
        public async Task UpdateDeviceRequestObjectAsync()
        {
            // Snippet: UpdateDeviceAsync(UpdateDeviceRequest, CallSettings)
            // Additional: UpdateDeviceAsync(UpdateDeviceRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDeviceRequest request = new UpdateDeviceRequest
            {
                Device = new Device(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Device response = await deviceManagerClient.UpdateDeviceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDevice</summary>
        public void UpdateDevice()
        {
            // Snippet: UpdateDevice(Device, FieldMask, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            Device device = new Device();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Device response = deviceManagerClient.UpdateDevice(device, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeviceAsync</summary>
        public async Task UpdateDeviceAsync()
        {
            // Snippet: UpdateDeviceAsync(Device, FieldMask, CallSettings)
            // Additional: UpdateDeviceAsync(Device, FieldMask, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            Device device = new Device();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Device response = await deviceManagerClient.UpdateDeviceAsync(device, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteDevice</summary>
        public void DeleteDeviceRequestObject()
        {
            // Snippet: DeleteDevice(DeleteDeviceRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            DeleteDeviceRequest request = new DeleteDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            // Make the request
            deviceManagerClient.DeleteDevice(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeviceAsync</summary>
        public async Task DeleteDeviceRequestObjectAsync()
        {
            // Snippet: DeleteDeviceAsync(DeleteDeviceRequest, CallSettings)
            // Additional: DeleteDeviceAsync(DeleteDeviceRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDeviceRequest request = new DeleteDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            // Make the request
            await deviceManagerClient.DeleteDeviceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDevice</summary>
        public void DeleteDevice()
        {
            // Snippet: DeleteDevice(string, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]/devices/[DEVICE]";
            // Make the request
            deviceManagerClient.DeleteDevice(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeviceAsync</summary>
        public async Task DeleteDeviceAsync()
        {
            // Snippet: DeleteDeviceAsync(string, CallSettings)
            // Additional: DeleteDeviceAsync(string, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]/devices/[DEVICE]";
            // Make the request
            await deviceManagerClient.DeleteDeviceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDevice</summary>
        public void DeleteDeviceResourceNames()
        {
            // Snippet: DeleteDevice(DeviceName, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            DeviceName name = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]");
            // Make the request
            deviceManagerClient.DeleteDevice(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeviceAsync</summary>
        public async Task DeleteDeviceResourceNamesAsync()
        {
            // Snippet: DeleteDeviceAsync(DeviceName, CallSettings)
            // Additional: DeleteDeviceAsync(DeviceName, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeviceName name = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]");
            // Make the request
            await deviceManagerClient.DeleteDeviceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDevices</summary>
        public void ListDevicesRequestObject()
        {
            // Snippet: ListDevices(ListDevicesRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            ListDevicesRequest request = new ListDevicesRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                DeviceNumIds = { 0UL, },
                DeviceIds = { "", },
                FieldMask = new FieldMask(),
                GatewayListOptions = new GatewayListOptions(),
            };
            // Make the request
            PagedEnumerable<ListDevicesResponse, Device> response = deviceManagerClient.ListDevices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Device item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDevicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Device item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Device> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Device item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDevicesAsync</summary>
        public async Task ListDevicesRequestObjectAsync()
        {
            // Snippet: ListDevicesAsync(ListDevicesRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListDevicesRequest request = new ListDevicesRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                DeviceNumIds = { 0UL, },
                DeviceIds = { "", },
                FieldMask = new FieldMask(),
                GatewayListOptions = new GatewayListOptions(),
            };
            // Make the request
            PagedAsyncEnumerable<ListDevicesResponse, Device> response = deviceManagerClient.ListDevicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Device item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDevicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Device item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Device> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Device item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDevices</summary>
        public void ListDevices()
        {
            // Snippet: ListDevices(string, string, int?, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]";
            // Make the request
            PagedEnumerable<ListDevicesResponse, Device> response = deviceManagerClient.ListDevices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Device item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDevicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Device item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Device> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Device item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDevicesAsync</summary>
        public async Task ListDevicesAsync()
        {
            // Snippet: ListDevicesAsync(string, string, int?, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]";
            // Make the request
            PagedAsyncEnumerable<ListDevicesResponse, Device> response = deviceManagerClient.ListDevicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Device item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDevicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Device item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Device> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Device item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDevices</summary>
        public void ListDevicesResourceNames()
        {
            // Snippet: ListDevices(RegistryName, string, int?, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            RegistryName parent = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]");
            // Make the request
            PagedEnumerable<ListDevicesResponse, Device> response = deviceManagerClient.ListDevices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Device item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDevicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Device item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Device> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Device item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDevicesAsync</summary>
        public async Task ListDevicesResourceNamesAsync()
        {
            // Snippet: ListDevicesAsync(RegistryName, string, int?, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            RegistryName parent = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]");
            // Make the request
            PagedAsyncEnumerable<ListDevicesResponse, Device> response = deviceManagerClient.ListDevicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Device item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDevicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Device item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Device> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Device item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ModifyCloudToDeviceConfig</summary>
        public void ModifyCloudToDeviceConfigRequestObject()
        {
            // Snippet: ModifyCloudToDeviceConfig(ModifyCloudToDeviceConfigRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            ModifyCloudToDeviceConfigRequest request = new ModifyCloudToDeviceConfigRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                VersionToUpdate = 0L,
                BinaryData = ByteString.Empty,
            };
            // Make the request
            DeviceConfig response = deviceManagerClient.ModifyCloudToDeviceConfig(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyCloudToDeviceConfigAsync</summary>
        public async Task ModifyCloudToDeviceConfigRequestObjectAsync()
        {
            // Snippet: ModifyCloudToDeviceConfigAsync(ModifyCloudToDeviceConfigRequest, CallSettings)
            // Additional: ModifyCloudToDeviceConfigAsync(ModifyCloudToDeviceConfigRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ModifyCloudToDeviceConfigRequest request = new ModifyCloudToDeviceConfigRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                VersionToUpdate = 0L,
                BinaryData = ByteString.Empty,
            };
            // Make the request
            DeviceConfig response = await deviceManagerClient.ModifyCloudToDeviceConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyCloudToDeviceConfig</summary>
        public void ModifyCloudToDeviceConfig()
        {
            // Snippet: ModifyCloudToDeviceConfig(string, ByteString, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]/devices/[DEVICE]";
            ByteString binaryData = ByteString.Empty;
            // Make the request
            DeviceConfig response = deviceManagerClient.ModifyCloudToDeviceConfig(name, binaryData);
            // End snippet
        }

        /// <summary>Snippet for ModifyCloudToDeviceConfigAsync</summary>
        public async Task ModifyCloudToDeviceConfigAsync()
        {
            // Snippet: ModifyCloudToDeviceConfigAsync(string, ByteString, CallSettings)
            // Additional: ModifyCloudToDeviceConfigAsync(string, ByteString, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]/devices/[DEVICE]";
            ByteString binaryData = ByteString.Empty;
            // Make the request
            DeviceConfig response = await deviceManagerClient.ModifyCloudToDeviceConfigAsync(name, binaryData);
            // End snippet
        }

        /// <summary>Snippet for ModifyCloudToDeviceConfig</summary>
        public void ModifyCloudToDeviceConfigResourceNames()
        {
            // Snippet: ModifyCloudToDeviceConfig(DeviceName, ByteString, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            DeviceName name = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]");
            ByteString binaryData = ByteString.Empty;
            // Make the request
            DeviceConfig response = deviceManagerClient.ModifyCloudToDeviceConfig(name, binaryData);
            // End snippet
        }

        /// <summary>Snippet for ModifyCloudToDeviceConfigAsync</summary>
        public async Task ModifyCloudToDeviceConfigResourceNamesAsync()
        {
            // Snippet: ModifyCloudToDeviceConfigAsync(DeviceName, ByteString, CallSettings)
            // Additional: ModifyCloudToDeviceConfigAsync(DeviceName, ByteString, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeviceName name = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]");
            ByteString binaryData = ByteString.Empty;
            // Make the request
            DeviceConfig response = await deviceManagerClient.ModifyCloudToDeviceConfigAsync(name, binaryData);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceConfigVersions</summary>
        public void ListDeviceConfigVersionsRequestObject()
        {
            // Snippet: ListDeviceConfigVersions(ListDeviceConfigVersionsRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            ListDeviceConfigVersionsRequest request = new ListDeviceConfigVersionsRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumVersions = 0,
            };
            // Make the request
            ListDeviceConfigVersionsResponse response = deviceManagerClient.ListDeviceConfigVersions(request);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceConfigVersionsAsync</summary>
        public async Task ListDeviceConfigVersionsRequestObjectAsync()
        {
            // Snippet: ListDeviceConfigVersionsAsync(ListDeviceConfigVersionsRequest, CallSettings)
            // Additional: ListDeviceConfigVersionsAsync(ListDeviceConfigVersionsRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListDeviceConfigVersionsRequest request = new ListDeviceConfigVersionsRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumVersions = 0,
            };
            // Make the request
            ListDeviceConfigVersionsResponse response = await deviceManagerClient.ListDeviceConfigVersionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceConfigVersions</summary>
        public void ListDeviceConfigVersions()
        {
            // Snippet: ListDeviceConfigVersions(string, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]/devices/[DEVICE]";
            // Make the request
            ListDeviceConfigVersionsResponse response = deviceManagerClient.ListDeviceConfigVersions(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceConfigVersionsAsync</summary>
        public async Task ListDeviceConfigVersionsAsync()
        {
            // Snippet: ListDeviceConfigVersionsAsync(string, CallSettings)
            // Additional: ListDeviceConfigVersionsAsync(string, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]/devices/[DEVICE]";
            // Make the request
            ListDeviceConfigVersionsResponse response = await deviceManagerClient.ListDeviceConfigVersionsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceConfigVersions</summary>
        public void ListDeviceConfigVersionsResourceNames()
        {
            // Snippet: ListDeviceConfigVersions(DeviceName, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            DeviceName name = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]");
            // Make the request
            ListDeviceConfigVersionsResponse response = deviceManagerClient.ListDeviceConfigVersions(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceConfigVersionsAsync</summary>
        public async Task ListDeviceConfigVersionsResourceNamesAsync()
        {
            // Snippet: ListDeviceConfigVersionsAsync(DeviceName, CallSettings)
            // Additional: ListDeviceConfigVersionsAsync(DeviceName, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeviceName name = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]");
            // Make the request
            ListDeviceConfigVersionsResponse response = await deviceManagerClient.ListDeviceConfigVersionsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceStates</summary>
        public void ListDeviceStatesRequestObject()
        {
            // Snippet: ListDeviceStates(ListDeviceStatesRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            ListDeviceStatesRequest request = new ListDeviceStatesRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumStates = 0,
            };
            // Make the request
            ListDeviceStatesResponse response = deviceManagerClient.ListDeviceStates(request);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceStatesAsync</summary>
        public async Task ListDeviceStatesRequestObjectAsync()
        {
            // Snippet: ListDeviceStatesAsync(ListDeviceStatesRequest, CallSettings)
            // Additional: ListDeviceStatesAsync(ListDeviceStatesRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListDeviceStatesRequest request = new ListDeviceStatesRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                NumStates = 0,
            };
            // Make the request
            ListDeviceStatesResponse response = await deviceManagerClient.ListDeviceStatesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceStates</summary>
        public void ListDeviceStates()
        {
            // Snippet: ListDeviceStates(string, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]/devices/[DEVICE]";
            // Make the request
            ListDeviceStatesResponse response = deviceManagerClient.ListDeviceStates(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceStatesAsync</summary>
        public async Task ListDeviceStatesAsync()
        {
            // Snippet: ListDeviceStatesAsync(string, CallSettings)
            // Additional: ListDeviceStatesAsync(string, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]/devices/[DEVICE]";
            // Make the request
            ListDeviceStatesResponse response = await deviceManagerClient.ListDeviceStatesAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceStates</summary>
        public void ListDeviceStatesResourceNames()
        {
            // Snippet: ListDeviceStates(DeviceName, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            DeviceName name = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]");
            // Make the request
            ListDeviceStatesResponse response = deviceManagerClient.ListDeviceStates(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceStatesAsync</summary>
        public async Task ListDeviceStatesResourceNamesAsync()
        {
            // Snippet: ListDeviceStatesAsync(DeviceName, CallSettings)
            // Additional: ListDeviceStatesAsync(DeviceName, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeviceName name = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]");
            // Make the request
            ListDeviceStatesResponse response = await deviceManagerClient.ListDeviceStatesAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = deviceManagerClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await deviceManagerClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = deviceManagerClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await deviceManagerClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = deviceManagerClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await deviceManagerClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = deviceManagerClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await deviceManagerClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = deviceManagerClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await deviceManagerClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = deviceManagerClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await deviceManagerClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = deviceManagerClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await deviceManagerClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = deviceManagerClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await deviceManagerClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = deviceManagerClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await deviceManagerClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for SendCommandToDevice</summary>
        public void SendCommandToDeviceRequestObject()
        {
            // Snippet: SendCommandToDevice(SendCommandToDeviceRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            SendCommandToDeviceRequest request = new SendCommandToDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                BinaryData = ByteString.Empty,
                Subfolder = "",
            };
            // Make the request
            SendCommandToDeviceResponse response = deviceManagerClient.SendCommandToDevice(request);
            // End snippet
        }

        /// <summary>Snippet for SendCommandToDeviceAsync</summary>
        public async Task SendCommandToDeviceRequestObjectAsync()
        {
            // Snippet: SendCommandToDeviceAsync(SendCommandToDeviceRequest, CallSettings)
            // Additional: SendCommandToDeviceAsync(SendCommandToDeviceRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            SendCommandToDeviceRequest request = new SendCommandToDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
                BinaryData = ByteString.Empty,
                Subfolder = "",
            };
            // Make the request
            SendCommandToDeviceResponse response = await deviceManagerClient.SendCommandToDeviceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SendCommandToDevice</summary>
        public void SendCommandToDevice1()
        {
            // Snippet: SendCommandToDevice(string, ByteString, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]/devices/[DEVICE]";
            ByteString binaryData = ByteString.Empty;
            // Make the request
            SendCommandToDeviceResponse response = deviceManagerClient.SendCommandToDevice(name, binaryData);
            // End snippet
        }

        /// <summary>Snippet for SendCommandToDeviceAsync</summary>
        public async Task SendCommandToDevice1Async()
        {
            // Snippet: SendCommandToDeviceAsync(string, ByteString, CallSettings)
            // Additional: SendCommandToDeviceAsync(string, ByteString, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]/devices/[DEVICE]";
            ByteString binaryData = ByteString.Empty;
            // Make the request
            SendCommandToDeviceResponse response = await deviceManagerClient.SendCommandToDeviceAsync(name, binaryData);
            // End snippet
        }

        /// <summary>Snippet for SendCommandToDevice</summary>
        public void SendCommandToDevice1ResourceNames()
        {
            // Snippet: SendCommandToDevice(DeviceName, ByteString, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            DeviceName name = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]");
            ByteString binaryData = ByteString.Empty;
            // Make the request
            SendCommandToDeviceResponse response = deviceManagerClient.SendCommandToDevice(name, binaryData);
            // End snippet
        }

        /// <summary>Snippet for SendCommandToDeviceAsync</summary>
        public async Task SendCommandToDevice1ResourceNamesAsync()
        {
            // Snippet: SendCommandToDeviceAsync(DeviceName, ByteString, CallSettings)
            // Additional: SendCommandToDeviceAsync(DeviceName, ByteString, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeviceName name = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]");
            ByteString binaryData = ByteString.Empty;
            // Make the request
            SendCommandToDeviceResponse response = await deviceManagerClient.SendCommandToDeviceAsync(name, binaryData);
            // End snippet
        }

        /// <summary>Snippet for SendCommandToDevice</summary>
        public void SendCommandToDevice2()
        {
            // Snippet: SendCommandToDevice(string, ByteString, string, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]/devices/[DEVICE]";
            ByteString binaryData = ByteString.Empty;
            string subfolder = "";
            // Make the request
            SendCommandToDeviceResponse response = deviceManagerClient.SendCommandToDevice(name, binaryData, subfolder);
            // End snippet
        }

        /// <summary>Snippet for SendCommandToDeviceAsync</summary>
        public async Task SendCommandToDevice2Async()
        {
            // Snippet: SendCommandToDeviceAsync(string, ByteString, string, CallSettings)
            // Additional: SendCommandToDeviceAsync(string, ByteString, string, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]/devices/[DEVICE]";
            ByteString binaryData = ByteString.Empty;
            string subfolder = "";
            // Make the request
            SendCommandToDeviceResponse response = await deviceManagerClient.SendCommandToDeviceAsync(name, binaryData, subfolder);
            // End snippet
        }

        /// <summary>Snippet for SendCommandToDevice</summary>
        public void SendCommandToDevice2ResourceNames()
        {
            // Snippet: SendCommandToDevice(DeviceName, ByteString, string, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            DeviceName name = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]");
            ByteString binaryData = ByteString.Empty;
            string subfolder = "";
            // Make the request
            SendCommandToDeviceResponse response = deviceManagerClient.SendCommandToDevice(name, binaryData, subfolder);
            // End snippet
        }

        /// <summary>Snippet for SendCommandToDeviceAsync</summary>
        public async Task SendCommandToDevice2ResourceNamesAsync()
        {
            // Snippet: SendCommandToDeviceAsync(DeviceName, ByteString, string, CallSettings)
            // Additional: SendCommandToDeviceAsync(DeviceName, ByteString, string, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeviceName name = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]");
            ByteString binaryData = ByteString.Empty;
            string subfolder = "";
            // Make the request
            SendCommandToDeviceResponse response = await deviceManagerClient.SendCommandToDeviceAsync(name, binaryData, subfolder);
            // End snippet
        }

        /// <summary>Snippet for BindDeviceToGateway</summary>
        public void BindDeviceToGatewayRequestObject()
        {
            // Snippet: BindDeviceToGateway(BindDeviceToGatewayRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            BindDeviceToGatewayRequest request = new BindDeviceToGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "",
                DeviceId = "",
            };
            // Make the request
            BindDeviceToGatewayResponse response = deviceManagerClient.BindDeviceToGateway(request);
            // End snippet
        }

        /// <summary>Snippet for BindDeviceToGatewayAsync</summary>
        public async Task BindDeviceToGatewayRequestObjectAsync()
        {
            // Snippet: BindDeviceToGatewayAsync(BindDeviceToGatewayRequest, CallSettings)
            // Additional: BindDeviceToGatewayAsync(BindDeviceToGatewayRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            BindDeviceToGatewayRequest request = new BindDeviceToGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "",
                DeviceId = "",
            };
            // Make the request
            BindDeviceToGatewayResponse response = await deviceManagerClient.BindDeviceToGatewayAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BindDeviceToGateway</summary>
        public void BindDeviceToGateway()
        {
            // Snippet: BindDeviceToGateway(string, string, string, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]";
            string gatewayId = "";
            string deviceId = "";
            // Make the request
            BindDeviceToGatewayResponse response = deviceManagerClient.BindDeviceToGateway(parent, gatewayId, deviceId);
            // End snippet
        }

        /// <summary>Snippet for BindDeviceToGatewayAsync</summary>
        public async Task BindDeviceToGatewayAsync()
        {
            // Snippet: BindDeviceToGatewayAsync(string, string, string, CallSettings)
            // Additional: BindDeviceToGatewayAsync(string, string, string, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]";
            string gatewayId = "";
            string deviceId = "";
            // Make the request
            BindDeviceToGatewayResponse response = await deviceManagerClient.BindDeviceToGatewayAsync(parent, gatewayId, deviceId);
            // End snippet
        }

        /// <summary>Snippet for BindDeviceToGateway</summary>
        public void BindDeviceToGatewayResourceNames()
        {
            // Snippet: BindDeviceToGateway(RegistryName, string, string, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            RegistryName parent = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]");
            string gatewayId = "";
            string deviceId = "";
            // Make the request
            BindDeviceToGatewayResponse response = deviceManagerClient.BindDeviceToGateway(parent, gatewayId, deviceId);
            // End snippet
        }

        /// <summary>Snippet for BindDeviceToGatewayAsync</summary>
        public async Task BindDeviceToGatewayResourceNamesAsync()
        {
            // Snippet: BindDeviceToGatewayAsync(RegistryName, string, string, CallSettings)
            // Additional: BindDeviceToGatewayAsync(RegistryName, string, string, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            RegistryName parent = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]");
            string gatewayId = "";
            string deviceId = "";
            // Make the request
            BindDeviceToGatewayResponse response = await deviceManagerClient.BindDeviceToGatewayAsync(parent, gatewayId, deviceId);
            // End snippet
        }

        /// <summary>Snippet for UnbindDeviceFromGateway</summary>
        public void UnbindDeviceFromGatewayRequestObject()
        {
            // Snippet: UnbindDeviceFromGateway(UnbindDeviceFromGatewayRequest, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            UnbindDeviceFromGatewayRequest request = new UnbindDeviceFromGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "",
                DeviceId = "",
            };
            // Make the request
            UnbindDeviceFromGatewayResponse response = deviceManagerClient.UnbindDeviceFromGateway(request);
            // End snippet
        }

        /// <summary>Snippet for UnbindDeviceFromGatewayAsync</summary>
        public async Task UnbindDeviceFromGatewayRequestObjectAsync()
        {
            // Snippet: UnbindDeviceFromGatewayAsync(UnbindDeviceFromGatewayRequest, CallSettings)
            // Additional: UnbindDeviceFromGatewayAsync(UnbindDeviceFromGatewayRequest, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            UnbindDeviceFromGatewayRequest request = new UnbindDeviceFromGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "",
                DeviceId = "",
            };
            // Make the request
            UnbindDeviceFromGatewayResponse response = await deviceManagerClient.UnbindDeviceFromGatewayAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UnbindDeviceFromGateway</summary>
        public void UnbindDeviceFromGateway()
        {
            // Snippet: UnbindDeviceFromGateway(string, string, string, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]";
            string gatewayId = "";
            string deviceId = "";
            // Make the request
            UnbindDeviceFromGatewayResponse response = deviceManagerClient.UnbindDeviceFromGateway(parent, gatewayId, deviceId);
            // End snippet
        }

        /// <summary>Snippet for UnbindDeviceFromGatewayAsync</summary>
        public async Task UnbindDeviceFromGatewayAsync()
        {
            // Snippet: UnbindDeviceFromGatewayAsync(string, string, string, CallSettings)
            // Additional: UnbindDeviceFromGatewayAsync(string, string, string, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/registries/[REGISTRY]";
            string gatewayId = "";
            string deviceId = "";
            // Make the request
            UnbindDeviceFromGatewayResponse response = await deviceManagerClient.UnbindDeviceFromGatewayAsync(parent, gatewayId, deviceId);
            // End snippet
        }

        /// <summary>Snippet for UnbindDeviceFromGateway</summary>
        public void UnbindDeviceFromGatewayResourceNames()
        {
            // Snippet: UnbindDeviceFromGateway(RegistryName, string, string, CallSettings)
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            RegistryName parent = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]");
            string gatewayId = "";
            string deviceId = "";
            // Make the request
            UnbindDeviceFromGatewayResponse response = deviceManagerClient.UnbindDeviceFromGateway(parent, gatewayId, deviceId);
            // End snippet
        }

        /// <summary>Snippet for UnbindDeviceFromGatewayAsync</summary>
        public async Task UnbindDeviceFromGatewayResourceNamesAsync()
        {
            // Snippet: UnbindDeviceFromGatewayAsync(RegistryName, string, string, CallSettings)
            // Additional: UnbindDeviceFromGatewayAsync(RegistryName, string, string, CancellationToken)
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            RegistryName parent = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]");
            string gatewayId = "";
            string deviceId = "";
            // Make the request
            UnbindDeviceFromGatewayResponse response = await deviceManagerClient.UnbindDeviceFromGatewayAsync(parent, gatewayId, deviceId);
            // End snippet
        }
    }
}
