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
    using Google.Api.Gax;
    using Google.DevicesAndServices.Health.V4;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedHealthProfileServiceClientSnippets
    {
        /// <summary>Snippet for GetProfile</summary>
        public void GetProfileRequestObject()
        {
            // Snippet: GetProfile(GetProfileRequest, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            GetProfileRequest request = new GetProfileRequest
            {
                ProfileName = ProfileName.FromUser("[USER]"),
            };
            // Make the request
            Profile response = healthProfileServiceClient.GetProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetProfileAsync</summary>
        public async Task GetProfileRequestObjectAsync()
        {
            // Snippet: GetProfileAsync(GetProfileRequest, CallSettings)
            // Additional: GetProfileAsync(GetProfileRequest, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProfileRequest request = new GetProfileRequest
            {
                ProfileName = ProfileName.FromUser("[USER]"),
            };
            // Make the request
            Profile response = await healthProfileServiceClient.GetProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProfile</summary>
        public void GetProfile()
        {
            // Snippet: GetProfile(string, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            string name = "users/[USER]/profile";
            // Make the request
            Profile response = healthProfileServiceClient.GetProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetProfileAsync</summary>
        public async Task GetProfileAsync()
        {
            // Snippet: GetProfileAsync(string, CallSettings)
            // Additional: GetProfileAsync(string, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "users/[USER]/profile";
            // Make the request
            Profile response = await healthProfileServiceClient.GetProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProfile</summary>
        public void GetProfileResourceNames()
        {
            // Snippet: GetProfile(ProfileName, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            ProfileName name = ProfileName.FromUser("[USER]");
            // Make the request
            Profile response = healthProfileServiceClient.GetProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetProfileAsync</summary>
        public async Task GetProfileResourceNamesAsync()
        {
            // Snippet: GetProfileAsync(ProfileName, CallSettings)
            // Additional: GetProfileAsync(ProfileName, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProfileName name = ProfileName.FromUser("[USER]");
            // Make the request
            Profile response = await healthProfileServiceClient.GetProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateProfile</summary>
        public void UpdateProfileRequestObject()
        {
            // Snippet: UpdateProfile(UpdateProfileRequest, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            UpdateProfileRequest request = new UpdateProfileRequest
            {
                Profile = new Profile(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Profile response = healthProfileServiceClient.UpdateProfile(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProfileAsync</summary>
        public async Task UpdateProfileRequestObjectAsync()
        {
            // Snippet: UpdateProfileAsync(UpdateProfileRequest, CallSettings)
            // Additional: UpdateProfileAsync(UpdateProfileRequest, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProfileRequest request = new UpdateProfileRequest
            {
                Profile = new Profile(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Profile response = await healthProfileServiceClient.UpdateProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProfile</summary>
        public void UpdateProfile()
        {
            // Snippet: UpdateProfile(Profile, FieldMask, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            Profile profile = new Profile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Profile response = healthProfileServiceClient.UpdateProfile(profile, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateProfileAsync</summary>
        public async Task UpdateProfileAsync()
        {
            // Snippet: UpdateProfileAsync(Profile, FieldMask, CallSettings)
            // Additional: UpdateProfileAsync(Profile, FieldMask, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            Profile profile = new Profile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Profile response = await healthProfileServiceClient.UpdateProfileAsync(profile, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettingsRequestObject()
        {
            // Snippet: GetSettings(GetSettingsRequest, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromUser("[USER]"),
            };
            // Make the request
            Settings response = healthProfileServiceClient.GetSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsRequestObjectAsync()
        {
            // Snippet: GetSettingsAsync(GetSettingsRequest, CallSettings)
            // Additional: GetSettingsAsync(GetSettingsRequest, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromUser("[USER]"),
            };
            // Make the request
            Settings response = await healthProfileServiceClient.GetSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettings()
        {
            // Snippet: GetSettings(string, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            string name = "users/[USER]/settings";
            // Make the request
            Settings response = healthProfileServiceClient.GetSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsAsync()
        {
            // Snippet: GetSettingsAsync(string, CallSettings)
            // Additional: GetSettingsAsync(string, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "users/[USER]/settings";
            // Make the request
            Settings response = await healthProfileServiceClient.GetSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettingsResourceNames()
        {
            // Snippet: GetSettings(SettingsName, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            SettingsName name = SettingsName.FromUser("[USER]");
            // Make the request
            Settings response = healthProfileServiceClient.GetSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsResourceNamesAsync()
        {
            // Snippet: GetSettingsAsync(SettingsName, CallSettings)
            // Additional: GetSettingsAsync(SettingsName, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            SettingsName name = SettingsName.FromUser("[USER]");
            // Make the request
            Settings response = await healthProfileServiceClient.GetSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettings</summary>
        public void UpdateSettingsRequestObject()
        {
            // Snippet: UpdateSettings(UpdateSettingsRequest, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Settings response = healthProfileServiceClient.UpdateSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettingsAsync</summary>
        public async Task UpdateSettingsRequestObjectAsync()
        {
            // Snippet: UpdateSettingsAsync(UpdateSettingsRequest, CallSettings)
            // Additional: UpdateSettingsAsync(UpdateSettingsRequest, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Settings response = await healthProfileServiceClient.UpdateSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettings</summary>
        public void UpdateSettings()
        {
            // Snippet: UpdateSettings(Settings, FieldMask, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            Settings settings = new Settings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Settings response = healthProfileServiceClient.UpdateSettings(settings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettingsAsync</summary>
        public async Task UpdateSettingsAsync()
        {
            // Snippet: UpdateSettingsAsync(Settings, FieldMask, CallSettings)
            // Additional: UpdateSettingsAsync(Settings, FieldMask, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            Settings settings = new Settings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Settings response = await healthProfileServiceClient.UpdateSettingsAsync(settings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetIdentity</summary>
        public void GetIdentityRequestObject()
        {
            // Snippet: GetIdentity(GetIdentityRequest, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            GetIdentityRequest request = new GetIdentityRequest
            {
                IdentityName = IdentityName.FromUser("[USER]"),
            };
            // Make the request
            Identity response = healthProfileServiceClient.GetIdentity(request);
            // End snippet
        }

        /// <summary>Snippet for GetIdentityAsync</summary>
        public async Task GetIdentityRequestObjectAsync()
        {
            // Snippet: GetIdentityAsync(GetIdentityRequest, CallSettings)
            // Additional: GetIdentityAsync(GetIdentityRequest, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIdentityRequest request = new GetIdentityRequest
            {
                IdentityName = IdentityName.FromUser("[USER]"),
            };
            // Make the request
            Identity response = await healthProfileServiceClient.GetIdentityAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIdentity</summary>
        public void GetIdentity()
        {
            // Snippet: GetIdentity(string, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            string name = "users/[USER]/identity";
            // Make the request
            Identity response = healthProfileServiceClient.GetIdentity(name);
            // End snippet
        }

        /// <summary>Snippet for GetIdentityAsync</summary>
        public async Task GetIdentityAsync()
        {
            // Snippet: GetIdentityAsync(string, CallSettings)
            // Additional: GetIdentityAsync(string, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "users/[USER]/identity";
            // Make the request
            Identity response = await healthProfileServiceClient.GetIdentityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIdentity</summary>
        public void GetIdentityResourceNames()
        {
            // Snippet: GetIdentity(IdentityName, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            IdentityName name = IdentityName.FromUser("[USER]");
            // Make the request
            Identity response = healthProfileServiceClient.GetIdentity(name);
            // End snippet
        }

        /// <summary>Snippet for GetIdentityAsync</summary>
        public async Task GetIdentityResourceNamesAsync()
        {
            // Snippet: GetIdentityAsync(IdentityName, CallSettings)
            // Additional: GetIdentityAsync(IdentityName, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            IdentityName name = IdentityName.FromUser("[USER]");
            // Make the request
            Identity response = await healthProfileServiceClient.GetIdentityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIrnProfile</summary>
        public void GetIrnProfileRequestObject()
        {
            // Snippet: GetIrnProfile(GetIrnProfileRequest, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            GetIrnProfileRequest request = new GetIrnProfileRequest
            {
                IrnProfileName = IrnProfileName.FromUser("[USER]"),
            };
            // Make the request
            IrnProfile response = healthProfileServiceClient.GetIrnProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetIrnProfileAsync</summary>
        public async Task GetIrnProfileRequestObjectAsync()
        {
            // Snippet: GetIrnProfileAsync(GetIrnProfileRequest, CallSettings)
            // Additional: GetIrnProfileAsync(GetIrnProfileRequest, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIrnProfileRequest request = new GetIrnProfileRequest
            {
                IrnProfileName = IrnProfileName.FromUser("[USER]"),
            };
            // Make the request
            IrnProfile response = await healthProfileServiceClient.GetIrnProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIrnProfile</summary>
        public void GetIrnProfile()
        {
            // Snippet: GetIrnProfile(string, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            string name = "users/[USER]/irnProfile";
            // Make the request
            IrnProfile response = healthProfileServiceClient.GetIrnProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetIrnProfileAsync</summary>
        public async Task GetIrnProfileAsync()
        {
            // Snippet: GetIrnProfileAsync(string, CallSettings)
            // Additional: GetIrnProfileAsync(string, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "users/[USER]/irnProfile";
            // Make the request
            IrnProfile response = await healthProfileServiceClient.GetIrnProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIrnProfile</summary>
        public void GetIrnProfileResourceNames()
        {
            // Snippet: GetIrnProfile(IrnProfileName, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            IrnProfileName name = IrnProfileName.FromUser("[USER]");
            // Make the request
            IrnProfile response = healthProfileServiceClient.GetIrnProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetIrnProfileAsync</summary>
        public async Task GetIrnProfileResourceNamesAsync()
        {
            // Snippet: GetIrnProfileAsync(IrnProfileName, CallSettings)
            // Additional: GetIrnProfileAsync(IrnProfileName, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            IrnProfileName name = IrnProfileName.FromUser("[USER]");
            // Make the request
            IrnProfile response = await healthProfileServiceClient.GetIrnProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPairedDevice</summary>
        public void GetPairedDeviceRequestObject()
        {
            // Snippet: GetPairedDevice(GetPairedDeviceRequest, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            GetPairedDeviceRequest request = new GetPairedDeviceRequest
            {
                PairedDeviceName = PairedDeviceName.FromUserPairedDevice("[USER]", "[PAIRED_DEVICE]"),
            };
            // Make the request
            PairedDevice response = healthProfileServiceClient.GetPairedDevice(request);
            // End snippet
        }

        /// <summary>Snippet for GetPairedDeviceAsync</summary>
        public async Task GetPairedDeviceRequestObjectAsync()
        {
            // Snippet: GetPairedDeviceAsync(GetPairedDeviceRequest, CallSettings)
            // Additional: GetPairedDeviceAsync(GetPairedDeviceRequest, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPairedDeviceRequest request = new GetPairedDeviceRequest
            {
                PairedDeviceName = PairedDeviceName.FromUserPairedDevice("[USER]", "[PAIRED_DEVICE]"),
            };
            // Make the request
            PairedDevice response = await healthProfileServiceClient.GetPairedDeviceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPairedDevice</summary>
        public void GetPairedDevice()
        {
            // Snippet: GetPairedDevice(string, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            string name = "users/[USER]/pairedDevices/[PAIRED_DEVICE]";
            // Make the request
            PairedDevice response = healthProfileServiceClient.GetPairedDevice(name);
            // End snippet
        }

        /// <summary>Snippet for GetPairedDeviceAsync</summary>
        public async Task GetPairedDeviceAsync()
        {
            // Snippet: GetPairedDeviceAsync(string, CallSettings)
            // Additional: GetPairedDeviceAsync(string, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "users/[USER]/pairedDevices/[PAIRED_DEVICE]";
            // Make the request
            PairedDevice response = await healthProfileServiceClient.GetPairedDeviceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPairedDevice</summary>
        public void GetPairedDeviceResourceNames()
        {
            // Snippet: GetPairedDevice(PairedDeviceName, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            PairedDeviceName name = PairedDeviceName.FromUserPairedDevice("[USER]", "[PAIRED_DEVICE]");
            // Make the request
            PairedDevice response = healthProfileServiceClient.GetPairedDevice(name);
            // End snippet
        }

        /// <summary>Snippet for GetPairedDeviceAsync</summary>
        public async Task GetPairedDeviceResourceNamesAsync()
        {
            // Snippet: GetPairedDeviceAsync(PairedDeviceName, CallSettings)
            // Additional: GetPairedDeviceAsync(PairedDeviceName, CancellationToken)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            PairedDeviceName name = PairedDeviceName.FromUserPairedDevice("[USER]", "[PAIRED_DEVICE]");
            // Make the request
            PairedDevice response = await healthProfileServiceClient.GetPairedDeviceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPairedDevices</summary>
        public void ListPairedDevicesRequestObject()
        {
            // Snippet: ListPairedDevices(ListPairedDevicesRequest, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            ListPairedDevicesRequest request = new ListPairedDevicesRequest
            {
                ParentAsUserName = UserName.FromUser("[USER]"),
            };
            // Make the request
            PagedEnumerable<ListPairedDevicesResponse, PairedDevice> response = healthProfileServiceClient.ListPairedDevices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PairedDevice item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPairedDevicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PairedDevice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PairedDevice> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PairedDevice item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPairedDevicesAsync</summary>
        public async Task ListPairedDevicesRequestObjectAsync()
        {
            // Snippet: ListPairedDevicesAsync(ListPairedDevicesRequest, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPairedDevicesRequest request = new ListPairedDevicesRequest
            {
                ParentAsUserName = UserName.FromUser("[USER]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPairedDevicesResponse, PairedDevice> response = healthProfileServiceClient.ListPairedDevicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PairedDevice item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPairedDevicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PairedDevice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PairedDevice> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PairedDevice item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPairedDevices</summary>
        public void ListPairedDevices()
        {
            // Snippet: ListPairedDevices(string, string, int?, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            string parent = "users/[USER]";
            // Make the request
            PagedEnumerable<ListPairedDevicesResponse, PairedDevice> response = healthProfileServiceClient.ListPairedDevices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PairedDevice item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPairedDevicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PairedDevice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PairedDevice> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PairedDevice item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPairedDevicesAsync</summary>
        public async Task ListPairedDevicesAsync()
        {
            // Snippet: ListPairedDevicesAsync(string, string, int?, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "users/[USER]";
            // Make the request
            PagedAsyncEnumerable<ListPairedDevicesResponse, PairedDevice> response = healthProfileServiceClient.ListPairedDevicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PairedDevice item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPairedDevicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PairedDevice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PairedDevice> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PairedDevice item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPairedDevices</summary>
        public void ListPairedDevicesResourceNames()
        {
            // Snippet: ListPairedDevices(UserName, string, int?, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = HealthProfileServiceClient.Create();
            // Initialize request argument(s)
            UserName parent = UserName.FromUser("[USER]");
            // Make the request
            PagedEnumerable<ListPairedDevicesResponse, PairedDevice> response = healthProfileServiceClient.ListPairedDevices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PairedDevice item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPairedDevicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PairedDevice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PairedDevice> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PairedDevice item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPairedDevicesAsync</summary>
        public async Task ListPairedDevicesResourceNamesAsync()
        {
            // Snippet: ListPairedDevicesAsync(UserName, string, int?, CallSettings)
            // Create client
            HealthProfileServiceClient healthProfileServiceClient = await HealthProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserName parent = UserName.FromUser("[USER]");
            // Make the request
            PagedAsyncEnumerable<ListPairedDevicesResponse, PairedDevice> response = healthProfileServiceClient.ListPairedDevicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PairedDevice item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPairedDevicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PairedDevice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PairedDevice> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PairedDevice item in singlePage)
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
