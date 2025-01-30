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
    using Google.Protobuf.WellKnownTypes;
    using Google.Shopping.Merchant.Accounts.V1Beta;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedHomepageServiceClientSnippets
    {
        /// <summary>Snippet for GetHomepage</summary>
        public void GetHomepageRequestObject()
        {
            // Snippet: GetHomepage(GetHomepageRequest, CallSettings)
            // Create client
            HomepageServiceClient homepageServiceClient = HomepageServiceClient.Create();
            // Initialize request argument(s)
            GetHomepageRequest request = new GetHomepageRequest
            {
                HomepageName = HomepageName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            Homepage response = homepageServiceClient.GetHomepage(request);
            // End snippet
        }

        /// <summary>Snippet for GetHomepageAsync</summary>
        public async Task GetHomepageRequestObjectAsync()
        {
            // Snippet: GetHomepageAsync(GetHomepageRequest, CallSettings)
            // Additional: GetHomepageAsync(GetHomepageRequest, CancellationToken)
            // Create client
            HomepageServiceClient homepageServiceClient = await HomepageServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetHomepageRequest request = new GetHomepageRequest
            {
                HomepageName = HomepageName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            Homepage response = await homepageServiceClient.GetHomepageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHomepage</summary>
        public void GetHomepage()
        {
            // Snippet: GetHomepage(string, CallSettings)
            // Create client
            HomepageServiceClient homepageServiceClient = HomepageServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/homepage";
            // Make the request
            Homepage response = homepageServiceClient.GetHomepage(name);
            // End snippet
        }

        /// <summary>Snippet for GetHomepageAsync</summary>
        public async Task GetHomepageAsync()
        {
            // Snippet: GetHomepageAsync(string, CallSettings)
            // Additional: GetHomepageAsync(string, CancellationToken)
            // Create client
            HomepageServiceClient homepageServiceClient = await HomepageServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/homepage";
            // Make the request
            Homepage response = await homepageServiceClient.GetHomepageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetHomepage</summary>
        public void GetHomepageResourceNames()
        {
            // Snippet: GetHomepage(HomepageName, CallSettings)
            // Create client
            HomepageServiceClient homepageServiceClient = HomepageServiceClient.Create();
            // Initialize request argument(s)
            HomepageName name = HomepageName.FromAccount("[ACCOUNT]");
            // Make the request
            Homepage response = homepageServiceClient.GetHomepage(name);
            // End snippet
        }

        /// <summary>Snippet for GetHomepageAsync</summary>
        public async Task GetHomepageResourceNamesAsync()
        {
            // Snippet: GetHomepageAsync(HomepageName, CallSettings)
            // Additional: GetHomepageAsync(HomepageName, CancellationToken)
            // Create client
            HomepageServiceClient homepageServiceClient = await HomepageServiceClient.CreateAsync();
            // Initialize request argument(s)
            HomepageName name = HomepageName.FromAccount("[ACCOUNT]");
            // Make the request
            Homepage response = await homepageServiceClient.GetHomepageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateHomepage</summary>
        public void UpdateHomepageRequestObject()
        {
            // Snippet: UpdateHomepage(UpdateHomepageRequest, CallSettings)
            // Create client
            HomepageServiceClient homepageServiceClient = HomepageServiceClient.Create();
            // Initialize request argument(s)
            UpdateHomepageRequest request = new UpdateHomepageRequest
            {
                Homepage = new Homepage(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Homepage response = homepageServiceClient.UpdateHomepage(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateHomepageAsync</summary>
        public async Task UpdateHomepageRequestObjectAsync()
        {
            // Snippet: UpdateHomepageAsync(UpdateHomepageRequest, CallSettings)
            // Additional: UpdateHomepageAsync(UpdateHomepageRequest, CancellationToken)
            // Create client
            HomepageServiceClient homepageServiceClient = await HomepageServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateHomepageRequest request = new UpdateHomepageRequest
            {
                Homepage = new Homepage(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Homepage response = await homepageServiceClient.UpdateHomepageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateHomepage</summary>
        public void UpdateHomepage()
        {
            // Snippet: UpdateHomepage(Homepage, FieldMask, CallSettings)
            // Create client
            HomepageServiceClient homepageServiceClient = HomepageServiceClient.Create();
            // Initialize request argument(s)
            Homepage homepage = new Homepage();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Homepage response = homepageServiceClient.UpdateHomepage(homepage, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateHomepageAsync</summary>
        public async Task UpdateHomepageAsync()
        {
            // Snippet: UpdateHomepageAsync(Homepage, FieldMask, CallSettings)
            // Additional: UpdateHomepageAsync(Homepage, FieldMask, CancellationToken)
            // Create client
            HomepageServiceClient homepageServiceClient = await HomepageServiceClient.CreateAsync();
            // Initialize request argument(s)
            Homepage homepage = new Homepage();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Homepage response = await homepageServiceClient.UpdateHomepageAsync(homepage, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ClaimHomepage</summary>
        public void ClaimHomepageRequestObject()
        {
            // Snippet: ClaimHomepage(ClaimHomepageRequest, CallSettings)
            // Create client
            HomepageServiceClient homepageServiceClient = HomepageServiceClient.Create();
            // Initialize request argument(s)
            ClaimHomepageRequest request = new ClaimHomepageRequest
            {
                HomepageName = HomepageName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            Homepage response = homepageServiceClient.ClaimHomepage(request);
            // End snippet
        }

        /// <summary>Snippet for ClaimHomepageAsync</summary>
        public async Task ClaimHomepageRequestObjectAsync()
        {
            // Snippet: ClaimHomepageAsync(ClaimHomepageRequest, CallSettings)
            // Additional: ClaimHomepageAsync(ClaimHomepageRequest, CancellationToken)
            // Create client
            HomepageServiceClient homepageServiceClient = await HomepageServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClaimHomepageRequest request = new ClaimHomepageRequest
            {
                HomepageName = HomepageName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            Homepage response = await homepageServiceClient.ClaimHomepageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UnclaimHomepage</summary>
        public void UnclaimHomepageRequestObject()
        {
            // Snippet: UnclaimHomepage(UnclaimHomepageRequest, CallSettings)
            // Create client
            HomepageServiceClient homepageServiceClient = HomepageServiceClient.Create();
            // Initialize request argument(s)
            UnclaimHomepageRequest request = new UnclaimHomepageRequest
            {
                HomepageName = HomepageName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            Homepage response = homepageServiceClient.UnclaimHomepage(request);
            // End snippet
        }

        /// <summary>Snippet for UnclaimHomepageAsync</summary>
        public async Task UnclaimHomepageRequestObjectAsync()
        {
            // Snippet: UnclaimHomepageAsync(UnclaimHomepageRequest, CallSettings)
            // Additional: UnclaimHomepageAsync(UnclaimHomepageRequest, CancellationToken)
            // Create client
            HomepageServiceClient homepageServiceClient = await HomepageServiceClient.CreateAsync();
            // Initialize request argument(s)
            UnclaimHomepageRequest request = new UnclaimHomepageRequest
            {
                HomepageName = HomepageName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            Homepage response = await homepageServiceClient.UnclaimHomepageAsync(request);
            // End snippet
        }
    }
}
