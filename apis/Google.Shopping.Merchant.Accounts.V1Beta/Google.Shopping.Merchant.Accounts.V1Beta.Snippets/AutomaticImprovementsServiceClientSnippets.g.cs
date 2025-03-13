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
    public sealed class AllGeneratedAutomaticImprovementsServiceClientSnippets
    {
        /// <summary>Snippet for GetAutomaticImprovements</summary>
        public void GetAutomaticImprovementsRequestObject()
        {
            // Snippet: GetAutomaticImprovements(GetAutomaticImprovementsRequest, CallSettings)
            // Create client
            AutomaticImprovementsServiceClient automaticImprovementsServiceClient = AutomaticImprovementsServiceClient.Create();
            // Initialize request argument(s)
            GetAutomaticImprovementsRequest request = new GetAutomaticImprovementsRequest
            {
                AutomaticImprovementsName = AutomaticImprovementsName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            AutomaticImprovements response = automaticImprovementsServiceClient.GetAutomaticImprovements(request);
            // End snippet
        }

        /// <summary>Snippet for GetAutomaticImprovementsAsync</summary>
        public async Task GetAutomaticImprovementsRequestObjectAsync()
        {
            // Snippet: GetAutomaticImprovementsAsync(GetAutomaticImprovementsRequest, CallSettings)
            // Additional: GetAutomaticImprovementsAsync(GetAutomaticImprovementsRequest, CancellationToken)
            // Create client
            AutomaticImprovementsServiceClient automaticImprovementsServiceClient = await AutomaticImprovementsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAutomaticImprovementsRequest request = new GetAutomaticImprovementsRequest
            {
                AutomaticImprovementsName = AutomaticImprovementsName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            AutomaticImprovements response = await automaticImprovementsServiceClient.GetAutomaticImprovementsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAutomaticImprovements</summary>
        public void GetAutomaticImprovements()
        {
            // Snippet: GetAutomaticImprovements(string, CallSettings)
            // Create client
            AutomaticImprovementsServiceClient automaticImprovementsServiceClient = AutomaticImprovementsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/automaticImprovements";
            // Make the request
            AutomaticImprovements response = automaticImprovementsServiceClient.GetAutomaticImprovements(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutomaticImprovementsAsync</summary>
        public async Task GetAutomaticImprovementsAsync()
        {
            // Snippet: GetAutomaticImprovementsAsync(string, CallSettings)
            // Additional: GetAutomaticImprovementsAsync(string, CancellationToken)
            // Create client
            AutomaticImprovementsServiceClient automaticImprovementsServiceClient = await AutomaticImprovementsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/automaticImprovements";
            // Make the request
            AutomaticImprovements response = await automaticImprovementsServiceClient.GetAutomaticImprovementsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutomaticImprovements</summary>
        public void GetAutomaticImprovementsResourceNames()
        {
            // Snippet: GetAutomaticImprovements(AutomaticImprovementsName, CallSettings)
            // Create client
            AutomaticImprovementsServiceClient automaticImprovementsServiceClient = AutomaticImprovementsServiceClient.Create();
            // Initialize request argument(s)
            AutomaticImprovementsName name = AutomaticImprovementsName.FromAccount("[ACCOUNT]");
            // Make the request
            AutomaticImprovements response = automaticImprovementsServiceClient.GetAutomaticImprovements(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutomaticImprovementsAsync</summary>
        public async Task GetAutomaticImprovementsResourceNamesAsync()
        {
            // Snippet: GetAutomaticImprovementsAsync(AutomaticImprovementsName, CallSettings)
            // Additional: GetAutomaticImprovementsAsync(AutomaticImprovementsName, CancellationToken)
            // Create client
            AutomaticImprovementsServiceClient automaticImprovementsServiceClient = await AutomaticImprovementsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AutomaticImprovementsName name = AutomaticImprovementsName.FromAccount("[ACCOUNT]");
            // Make the request
            AutomaticImprovements response = await automaticImprovementsServiceClient.GetAutomaticImprovementsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAutomaticImprovements</summary>
        public void UpdateAutomaticImprovementsRequestObject()
        {
            // Snippet: UpdateAutomaticImprovements(UpdateAutomaticImprovementsRequest, CallSettings)
            // Create client
            AutomaticImprovementsServiceClient automaticImprovementsServiceClient = AutomaticImprovementsServiceClient.Create();
            // Initialize request argument(s)
            UpdateAutomaticImprovementsRequest request = new UpdateAutomaticImprovementsRequest
            {
                AutomaticImprovements = new AutomaticImprovements(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AutomaticImprovements response = automaticImprovementsServiceClient.UpdateAutomaticImprovements(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAutomaticImprovementsAsync</summary>
        public async Task UpdateAutomaticImprovementsRequestObjectAsync()
        {
            // Snippet: UpdateAutomaticImprovementsAsync(UpdateAutomaticImprovementsRequest, CallSettings)
            // Additional: UpdateAutomaticImprovementsAsync(UpdateAutomaticImprovementsRequest, CancellationToken)
            // Create client
            AutomaticImprovementsServiceClient automaticImprovementsServiceClient = await AutomaticImprovementsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAutomaticImprovementsRequest request = new UpdateAutomaticImprovementsRequest
            {
                AutomaticImprovements = new AutomaticImprovements(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AutomaticImprovements response = await automaticImprovementsServiceClient.UpdateAutomaticImprovementsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAutomaticImprovements</summary>
        public void UpdateAutomaticImprovements()
        {
            // Snippet: UpdateAutomaticImprovements(AutomaticImprovements, FieldMask, CallSettings)
            // Create client
            AutomaticImprovementsServiceClient automaticImprovementsServiceClient = AutomaticImprovementsServiceClient.Create();
            // Initialize request argument(s)
            AutomaticImprovements automaticImprovements = new AutomaticImprovements();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AutomaticImprovements response = automaticImprovementsServiceClient.UpdateAutomaticImprovements(automaticImprovements, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAutomaticImprovementsAsync</summary>
        public async Task UpdateAutomaticImprovementsAsync()
        {
            // Snippet: UpdateAutomaticImprovementsAsync(AutomaticImprovements, FieldMask, CallSettings)
            // Additional: UpdateAutomaticImprovementsAsync(AutomaticImprovements, FieldMask, CancellationToken)
            // Create client
            AutomaticImprovementsServiceClient automaticImprovementsServiceClient = await AutomaticImprovementsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AutomaticImprovements automaticImprovements = new AutomaticImprovements();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AutomaticImprovements response = await automaticImprovementsServiceClient.UpdateAutomaticImprovementsAsync(automaticImprovements, updateMask);
            // End snippet
        }
    }
}
