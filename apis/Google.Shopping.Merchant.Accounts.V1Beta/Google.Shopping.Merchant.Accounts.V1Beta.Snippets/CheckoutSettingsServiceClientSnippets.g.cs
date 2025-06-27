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
    public sealed class AllGeneratedCheckoutSettingsServiceClientSnippets
    {
        /// <summary>Snippet for GetCheckoutSettings</summary>
        public void GetCheckoutSettingsRequestObject()
        {
            // Snippet: GetCheckoutSettings(GetCheckoutSettingsRequest, CallSettings)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = CheckoutSettingsServiceClient.Create();
            // Initialize request argument(s)
            GetCheckoutSettingsRequest request = new GetCheckoutSettingsRequest
            {
                CheckoutSettingsName = CheckoutSettingsName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]"),
            };
            // Make the request
            CheckoutSettings response = checkoutSettingsServiceClient.GetCheckoutSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetCheckoutSettingsAsync</summary>
        public async Task GetCheckoutSettingsRequestObjectAsync()
        {
            // Snippet: GetCheckoutSettingsAsync(GetCheckoutSettingsRequest, CallSettings)
            // Additional: GetCheckoutSettingsAsync(GetCheckoutSettingsRequest, CancellationToken)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = await CheckoutSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCheckoutSettingsRequest request = new GetCheckoutSettingsRequest
            {
                CheckoutSettingsName = CheckoutSettingsName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]"),
            };
            // Make the request
            CheckoutSettings response = await checkoutSettingsServiceClient.GetCheckoutSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCheckoutSettings</summary>
        public void GetCheckoutSettings()
        {
            // Snippet: GetCheckoutSettings(string, CallSettings)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = CheckoutSettingsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/programs/[PROGRAM]/checkoutSettings";
            // Make the request
            CheckoutSettings response = checkoutSettingsServiceClient.GetCheckoutSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetCheckoutSettingsAsync</summary>
        public async Task GetCheckoutSettingsAsync()
        {
            // Snippet: GetCheckoutSettingsAsync(string, CallSettings)
            // Additional: GetCheckoutSettingsAsync(string, CancellationToken)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = await CheckoutSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/programs/[PROGRAM]/checkoutSettings";
            // Make the request
            CheckoutSettings response = await checkoutSettingsServiceClient.GetCheckoutSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCheckoutSettings</summary>
        public void GetCheckoutSettingsResourceNames()
        {
            // Snippet: GetCheckoutSettings(CheckoutSettingsName, CallSettings)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = CheckoutSettingsServiceClient.Create();
            // Initialize request argument(s)
            CheckoutSettingsName name = CheckoutSettingsName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]");
            // Make the request
            CheckoutSettings response = checkoutSettingsServiceClient.GetCheckoutSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetCheckoutSettingsAsync</summary>
        public async Task GetCheckoutSettingsResourceNamesAsync()
        {
            // Snippet: GetCheckoutSettingsAsync(CheckoutSettingsName, CallSettings)
            // Additional: GetCheckoutSettingsAsync(CheckoutSettingsName, CancellationToken)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = await CheckoutSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CheckoutSettingsName name = CheckoutSettingsName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]");
            // Make the request
            CheckoutSettings response = await checkoutSettingsServiceClient.GetCheckoutSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCheckoutSettings</summary>
        public void CreateCheckoutSettingsRequestObject()
        {
            // Snippet: CreateCheckoutSettings(CreateCheckoutSettingsRequest, CallSettings)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = CheckoutSettingsServiceClient.Create();
            // Initialize request argument(s)
            CreateCheckoutSettingsRequest request = new CreateCheckoutSettingsRequest
            {
                ParentAsProgramName = ProgramName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]"),
                CheckoutSettings = new CheckoutSettings(),
            };
            // Make the request
            CheckoutSettings response = checkoutSettingsServiceClient.CreateCheckoutSettings(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCheckoutSettingsAsync</summary>
        public async Task CreateCheckoutSettingsRequestObjectAsync()
        {
            // Snippet: CreateCheckoutSettingsAsync(CreateCheckoutSettingsRequest, CallSettings)
            // Additional: CreateCheckoutSettingsAsync(CreateCheckoutSettingsRequest, CancellationToken)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = await CheckoutSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCheckoutSettingsRequest request = new CreateCheckoutSettingsRequest
            {
                ParentAsProgramName = ProgramName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]"),
                CheckoutSettings = new CheckoutSettings(),
            };
            // Make the request
            CheckoutSettings response = await checkoutSettingsServiceClient.CreateCheckoutSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCheckoutSettings</summary>
        public void CreateCheckoutSettings()
        {
            // Snippet: CreateCheckoutSettings(string, CheckoutSettings, CallSettings)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = CheckoutSettingsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]/programs/[PROGRAM]";
            CheckoutSettings checkoutSettings = new CheckoutSettings();
            // Make the request
            CheckoutSettings response = checkoutSettingsServiceClient.CreateCheckoutSettings(parent, checkoutSettings);
            // End snippet
        }

        /// <summary>Snippet for CreateCheckoutSettingsAsync</summary>
        public async Task CreateCheckoutSettingsAsync()
        {
            // Snippet: CreateCheckoutSettingsAsync(string, CheckoutSettings, CallSettings)
            // Additional: CreateCheckoutSettingsAsync(string, CheckoutSettings, CancellationToken)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = await CheckoutSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]/programs/[PROGRAM]";
            CheckoutSettings checkoutSettings = new CheckoutSettings();
            // Make the request
            CheckoutSettings response = await checkoutSettingsServiceClient.CreateCheckoutSettingsAsync(parent, checkoutSettings);
            // End snippet
        }

        /// <summary>Snippet for CreateCheckoutSettings</summary>
        public void CreateCheckoutSettingsResourceNames()
        {
            // Snippet: CreateCheckoutSettings(ProgramName, CheckoutSettings, CallSettings)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = CheckoutSettingsServiceClient.Create();
            // Initialize request argument(s)
            ProgramName parent = ProgramName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]");
            CheckoutSettings checkoutSettings = new CheckoutSettings();
            // Make the request
            CheckoutSettings response = checkoutSettingsServiceClient.CreateCheckoutSettings(parent, checkoutSettings);
            // End snippet
        }

        /// <summary>Snippet for CreateCheckoutSettingsAsync</summary>
        public async Task CreateCheckoutSettingsResourceNamesAsync()
        {
            // Snippet: CreateCheckoutSettingsAsync(ProgramName, CheckoutSettings, CallSettings)
            // Additional: CreateCheckoutSettingsAsync(ProgramName, CheckoutSettings, CancellationToken)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = await CheckoutSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProgramName parent = ProgramName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]");
            CheckoutSettings checkoutSettings = new CheckoutSettings();
            // Make the request
            CheckoutSettings response = await checkoutSettingsServiceClient.CreateCheckoutSettingsAsync(parent, checkoutSettings);
            // End snippet
        }

        /// <summary>Snippet for UpdateCheckoutSettings</summary>
        public void UpdateCheckoutSettingsRequestObject()
        {
            // Snippet: UpdateCheckoutSettings(UpdateCheckoutSettingsRequest, CallSettings)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = CheckoutSettingsServiceClient.Create();
            // Initialize request argument(s)
            UpdateCheckoutSettingsRequest request = new UpdateCheckoutSettingsRequest
            {
                CheckoutSettings = new CheckoutSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CheckoutSettings response = checkoutSettingsServiceClient.UpdateCheckoutSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCheckoutSettingsAsync</summary>
        public async Task UpdateCheckoutSettingsRequestObjectAsync()
        {
            // Snippet: UpdateCheckoutSettingsAsync(UpdateCheckoutSettingsRequest, CallSettings)
            // Additional: UpdateCheckoutSettingsAsync(UpdateCheckoutSettingsRequest, CancellationToken)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = await CheckoutSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCheckoutSettingsRequest request = new UpdateCheckoutSettingsRequest
            {
                CheckoutSettings = new CheckoutSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CheckoutSettings response = await checkoutSettingsServiceClient.UpdateCheckoutSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCheckoutSettings</summary>
        public void UpdateCheckoutSettings()
        {
            // Snippet: UpdateCheckoutSettings(CheckoutSettings, FieldMask, CallSettings)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = CheckoutSettingsServiceClient.Create();
            // Initialize request argument(s)
            CheckoutSettings checkoutSettings = new CheckoutSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CheckoutSettings response = checkoutSettingsServiceClient.UpdateCheckoutSettings(checkoutSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCheckoutSettingsAsync</summary>
        public async Task UpdateCheckoutSettingsAsync()
        {
            // Snippet: UpdateCheckoutSettingsAsync(CheckoutSettings, FieldMask, CallSettings)
            // Additional: UpdateCheckoutSettingsAsync(CheckoutSettings, FieldMask, CancellationToken)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = await CheckoutSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CheckoutSettings checkoutSettings = new CheckoutSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CheckoutSettings response = await checkoutSettingsServiceClient.UpdateCheckoutSettingsAsync(checkoutSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteCheckoutSettings</summary>
        public void DeleteCheckoutSettingsRequestObject()
        {
            // Snippet: DeleteCheckoutSettings(DeleteCheckoutSettingsRequest, CallSettings)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = CheckoutSettingsServiceClient.Create();
            // Initialize request argument(s)
            DeleteCheckoutSettingsRequest request = new DeleteCheckoutSettingsRequest
            {
                CheckoutSettingsName = CheckoutSettingsName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]"),
            };
            // Make the request
            checkoutSettingsServiceClient.DeleteCheckoutSettings(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCheckoutSettingsAsync</summary>
        public async Task DeleteCheckoutSettingsRequestObjectAsync()
        {
            // Snippet: DeleteCheckoutSettingsAsync(DeleteCheckoutSettingsRequest, CallSettings)
            // Additional: DeleteCheckoutSettingsAsync(DeleteCheckoutSettingsRequest, CancellationToken)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = await CheckoutSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCheckoutSettingsRequest request = new DeleteCheckoutSettingsRequest
            {
                CheckoutSettingsName = CheckoutSettingsName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]"),
            };
            // Make the request
            await checkoutSettingsServiceClient.DeleteCheckoutSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCheckoutSettings</summary>
        public void DeleteCheckoutSettings()
        {
            // Snippet: DeleteCheckoutSettings(string, CallSettings)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = CheckoutSettingsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/programs/[PROGRAM]/checkoutSettings";
            // Make the request
            checkoutSettingsServiceClient.DeleteCheckoutSettings(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCheckoutSettingsAsync</summary>
        public async Task DeleteCheckoutSettingsAsync()
        {
            // Snippet: DeleteCheckoutSettingsAsync(string, CallSettings)
            // Additional: DeleteCheckoutSettingsAsync(string, CancellationToken)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = await CheckoutSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/programs/[PROGRAM]/checkoutSettings";
            // Make the request
            await checkoutSettingsServiceClient.DeleteCheckoutSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCheckoutSettings</summary>
        public void DeleteCheckoutSettingsResourceNames()
        {
            // Snippet: DeleteCheckoutSettings(CheckoutSettingsName, CallSettings)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = CheckoutSettingsServiceClient.Create();
            // Initialize request argument(s)
            CheckoutSettingsName name = CheckoutSettingsName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]");
            // Make the request
            checkoutSettingsServiceClient.DeleteCheckoutSettings(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCheckoutSettingsAsync</summary>
        public async Task DeleteCheckoutSettingsResourceNamesAsync()
        {
            // Snippet: DeleteCheckoutSettingsAsync(CheckoutSettingsName, CallSettings)
            // Additional: DeleteCheckoutSettingsAsync(CheckoutSettingsName, CancellationToken)
            // Create client
            CheckoutSettingsServiceClient checkoutSettingsServiceClient = await CheckoutSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CheckoutSettingsName name = CheckoutSettingsName.FromAccountProgram("[ACCOUNT]", "[PROGRAM]");
            // Make the request
            await checkoutSettingsServiceClient.DeleteCheckoutSettingsAsync(name);
            // End snippet
        }
    }
}
