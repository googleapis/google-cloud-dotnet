// Copyright 2024 Google LLC
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
    using Google.Ads.AdManager.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedUserServiceClientSnippets
    {
        /// <summary>Snippet for GetUser</summary>
        public void GetUserRequestObject()
        {
            // Snippet: GetUser(GetUserRequest, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            GetUserRequest request = new GetUserRequest
            {
                UserName = UserName.FromNetworkCodeUser("[NETWORK_CODE]", "[USER]"),
            };
            // Make the request
            User response = userServiceClient.GetUser(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserAsync</summary>
        public async Task GetUserRequestObjectAsync()
        {
            // Snippet: GetUserAsync(GetUserRequest, CallSettings)
            // Additional: GetUserAsync(GetUserRequest, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetUserRequest request = new GetUserRequest
            {
                UserName = UserName.FromNetworkCodeUser("[NETWORK_CODE]", "[USER]"),
            };
            // Make the request
            User response = await userServiceClient.GetUserAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUser</summary>
        public void GetUser()
        {
            // Snippet: GetUser(string, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/users/[USER]";
            // Make the request
            User response = userServiceClient.GetUser(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserAsync</summary>
        public async Task GetUserAsync()
        {
            // Snippet: GetUserAsync(string, CallSettings)
            // Additional: GetUserAsync(string, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/users/[USER]";
            // Make the request
            User response = await userServiceClient.GetUserAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUser</summary>
        public void GetUserResourceNames()
        {
            // Snippet: GetUser(UserName, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            UserName name = UserName.FromNetworkCodeUser("[NETWORK_CODE]", "[USER]");
            // Make the request
            User response = userServiceClient.GetUser(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserAsync</summary>
        public async Task GetUserResourceNamesAsync()
        {
            // Snippet: GetUserAsync(UserName, CallSettings)
            // Additional: GetUserAsync(UserName, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserName name = UserName.FromNetworkCodeUser("[NETWORK_CODE]", "[USER]");
            // Make the request
            User response = await userServiceClient.GetUserAsync(name);
            // End snippet
        }
    }
}
