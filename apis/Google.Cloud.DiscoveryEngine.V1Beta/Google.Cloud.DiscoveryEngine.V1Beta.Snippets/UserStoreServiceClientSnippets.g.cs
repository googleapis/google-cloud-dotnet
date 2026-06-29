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
    using Google.Cloud.DiscoveryEngine.V1Beta;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedUserStoreServiceClientSnippets
    {
        /// <summary>Snippet for GetUserStore</summary>
        public void GetUserStoreRequestObject()
        {
            // Snippet: GetUserStore(GetUserStoreRequest, CallSettings)
            // Create client
            UserStoreServiceClient userStoreServiceClient = UserStoreServiceClient.Create();
            // Initialize request argument(s)
            GetUserStoreRequest request = new GetUserStoreRequest
            {
                UserStoreName = UserStoreName.FromProjectLocationUserStore("[PROJECT]", "[LOCATION]", "[USER_STORE]"),
            };
            // Make the request
            UserStore response = userStoreServiceClient.GetUserStore(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserStoreAsync</summary>
        public async Task GetUserStoreRequestObjectAsync()
        {
            // Snippet: GetUserStoreAsync(GetUserStoreRequest, CallSettings)
            // Additional: GetUserStoreAsync(GetUserStoreRequest, CancellationToken)
            // Create client
            UserStoreServiceClient userStoreServiceClient = await UserStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetUserStoreRequest request = new GetUserStoreRequest
            {
                UserStoreName = UserStoreName.FromProjectLocationUserStore("[PROJECT]", "[LOCATION]", "[USER_STORE]"),
            };
            // Make the request
            UserStore response = await userStoreServiceClient.GetUserStoreAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserStore</summary>
        public void GetUserStore()
        {
            // Snippet: GetUserStore(string, CallSettings)
            // Create client
            UserStoreServiceClient userStoreServiceClient = UserStoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/userStores/[USER_STORE]";
            // Make the request
            UserStore response = userStoreServiceClient.GetUserStore(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserStoreAsync</summary>
        public async Task GetUserStoreAsync()
        {
            // Snippet: GetUserStoreAsync(string, CallSettings)
            // Additional: GetUserStoreAsync(string, CancellationToken)
            // Create client
            UserStoreServiceClient userStoreServiceClient = await UserStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/userStores/[USER_STORE]";
            // Make the request
            UserStore response = await userStoreServiceClient.GetUserStoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserStore</summary>
        public void GetUserStoreResourceNames()
        {
            // Snippet: GetUserStore(UserStoreName, CallSettings)
            // Create client
            UserStoreServiceClient userStoreServiceClient = UserStoreServiceClient.Create();
            // Initialize request argument(s)
            UserStoreName name = UserStoreName.FromProjectLocationUserStore("[PROJECT]", "[LOCATION]", "[USER_STORE]");
            // Make the request
            UserStore response = userStoreServiceClient.GetUserStore(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserStoreAsync</summary>
        public async Task GetUserStoreResourceNamesAsync()
        {
            // Snippet: GetUserStoreAsync(UserStoreName, CallSettings)
            // Additional: GetUserStoreAsync(UserStoreName, CancellationToken)
            // Create client
            UserStoreServiceClient userStoreServiceClient = await UserStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserStoreName name = UserStoreName.FromProjectLocationUserStore("[PROJECT]", "[LOCATION]", "[USER_STORE]");
            // Make the request
            UserStore response = await userStoreServiceClient.GetUserStoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserStore</summary>
        public void UpdateUserStoreRequestObject()
        {
            // Snippet: UpdateUserStore(UpdateUserStoreRequest, CallSettings)
            // Create client
            UserStoreServiceClient userStoreServiceClient = UserStoreServiceClient.Create();
            // Initialize request argument(s)
            UpdateUserStoreRequest request = new UpdateUserStoreRequest
            {
                UserStore = new UserStore(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UserStore response = userStoreServiceClient.UpdateUserStore(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserStoreAsync</summary>
        public async Task UpdateUserStoreRequestObjectAsync()
        {
            // Snippet: UpdateUserStoreAsync(UpdateUserStoreRequest, CallSettings)
            // Additional: UpdateUserStoreAsync(UpdateUserStoreRequest, CancellationToken)
            // Create client
            UserStoreServiceClient userStoreServiceClient = await UserStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUserStoreRequest request = new UpdateUserStoreRequest
            {
                UserStore = new UserStore(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UserStore response = await userStoreServiceClient.UpdateUserStoreAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserStore</summary>
        public void UpdateUserStore()
        {
            // Snippet: UpdateUserStore(UserStore, FieldMask, CallSettings)
            // Create client
            UserStoreServiceClient userStoreServiceClient = UserStoreServiceClient.Create();
            // Initialize request argument(s)
            UserStore userStore = new UserStore();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UserStore response = userStoreServiceClient.UpdateUserStore(userStore, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserStoreAsync</summary>
        public async Task UpdateUserStoreAsync()
        {
            // Snippet: UpdateUserStoreAsync(UserStore, FieldMask, CallSettings)
            // Additional: UpdateUserStoreAsync(UserStore, FieldMask, CancellationToken)
            // Create client
            UserStoreServiceClient userStoreServiceClient = await UserStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserStore userStore = new UserStore();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UserStore response = await userStoreServiceClient.UpdateUserStoreAsync(userStore, updateMask);
            // End snippet
        }
    }
}
