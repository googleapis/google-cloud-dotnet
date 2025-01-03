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
    public sealed class AllGeneratedEmailPreferencesServiceClientSnippets
    {
        /// <summary>Snippet for GetEmailPreferences</summary>
        public void GetEmailPreferencesRequestObject()
        {
            // Snippet: GetEmailPreferences(GetEmailPreferencesRequest, CallSettings)
            // Create client
            EmailPreferencesServiceClient emailPreferencesServiceClient = EmailPreferencesServiceClient.Create();
            // Initialize request argument(s)
            GetEmailPreferencesRequest request = new GetEmailPreferencesRequest
            {
                EmailPreferencesName = EmailPreferencesName.FromAccountEmail("[ACCOUNT]", "[EMAIL]"),
            };
            // Make the request
            EmailPreferences response = emailPreferencesServiceClient.GetEmailPreferences(request);
            // End snippet
        }

        /// <summary>Snippet for GetEmailPreferencesAsync</summary>
        public async Task GetEmailPreferencesRequestObjectAsync()
        {
            // Snippet: GetEmailPreferencesAsync(GetEmailPreferencesRequest, CallSettings)
            // Additional: GetEmailPreferencesAsync(GetEmailPreferencesRequest, CancellationToken)
            // Create client
            EmailPreferencesServiceClient emailPreferencesServiceClient = await EmailPreferencesServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEmailPreferencesRequest request = new GetEmailPreferencesRequest
            {
                EmailPreferencesName = EmailPreferencesName.FromAccountEmail("[ACCOUNT]", "[EMAIL]"),
            };
            // Make the request
            EmailPreferences response = await emailPreferencesServiceClient.GetEmailPreferencesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEmailPreferences</summary>
        public void GetEmailPreferences()
        {
            // Snippet: GetEmailPreferences(string, CallSettings)
            // Create client
            EmailPreferencesServiceClient emailPreferencesServiceClient = EmailPreferencesServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/users/[EMAIL]/emailPreferences";
            // Make the request
            EmailPreferences response = emailPreferencesServiceClient.GetEmailPreferences(name);
            // End snippet
        }

        /// <summary>Snippet for GetEmailPreferencesAsync</summary>
        public async Task GetEmailPreferencesAsync()
        {
            // Snippet: GetEmailPreferencesAsync(string, CallSettings)
            // Additional: GetEmailPreferencesAsync(string, CancellationToken)
            // Create client
            EmailPreferencesServiceClient emailPreferencesServiceClient = await EmailPreferencesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/users/[EMAIL]/emailPreferences";
            // Make the request
            EmailPreferences response = await emailPreferencesServiceClient.GetEmailPreferencesAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEmailPreferences</summary>
        public void GetEmailPreferencesResourceNames()
        {
            // Snippet: GetEmailPreferences(EmailPreferencesName, CallSettings)
            // Create client
            EmailPreferencesServiceClient emailPreferencesServiceClient = EmailPreferencesServiceClient.Create();
            // Initialize request argument(s)
            EmailPreferencesName name = EmailPreferencesName.FromAccountEmail("[ACCOUNT]", "[EMAIL]");
            // Make the request
            EmailPreferences response = emailPreferencesServiceClient.GetEmailPreferences(name);
            // End snippet
        }

        /// <summary>Snippet for GetEmailPreferencesAsync</summary>
        public async Task GetEmailPreferencesResourceNamesAsync()
        {
            // Snippet: GetEmailPreferencesAsync(EmailPreferencesName, CallSettings)
            // Additional: GetEmailPreferencesAsync(EmailPreferencesName, CancellationToken)
            // Create client
            EmailPreferencesServiceClient emailPreferencesServiceClient = await EmailPreferencesServiceClient.CreateAsync();
            // Initialize request argument(s)
            EmailPreferencesName name = EmailPreferencesName.FromAccountEmail("[ACCOUNT]", "[EMAIL]");
            // Make the request
            EmailPreferences response = await emailPreferencesServiceClient.GetEmailPreferencesAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateEmailPreferences</summary>
        public void UpdateEmailPreferencesRequestObject()
        {
            // Snippet: UpdateEmailPreferences(UpdateEmailPreferencesRequest, CallSettings)
            // Create client
            EmailPreferencesServiceClient emailPreferencesServiceClient = EmailPreferencesServiceClient.Create();
            // Initialize request argument(s)
            UpdateEmailPreferencesRequest request = new UpdateEmailPreferencesRequest
            {
                EmailPreferences = new EmailPreferences(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EmailPreferences response = emailPreferencesServiceClient.UpdateEmailPreferences(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEmailPreferencesAsync</summary>
        public async Task UpdateEmailPreferencesRequestObjectAsync()
        {
            // Snippet: UpdateEmailPreferencesAsync(UpdateEmailPreferencesRequest, CallSettings)
            // Additional: UpdateEmailPreferencesAsync(UpdateEmailPreferencesRequest, CancellationToken)
            // Create client
            EmailPreferencesServiceClient emailPreferencesServiceClient = await EmailPreferencesServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEmailPreferencesRequest request = new UpdateEmailPreferencesRequest
            {
                EmailPreferences = new EmailPreferences(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EmailPreferences response = await emailPreferencesServiceClient.UpdateEmailPreferencesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEmailPreferences</summary>
        public void UpdateEmailPreferences()
        {
            // Snippet: UpdateEmailPreferences(EmailPreferences, FieldMask, CallSettings)
            // Create client
            EmailPreferencesServiceClient emailPreferencesServiceClient = EmailPreferencesServiceClient.Create();
            // Initialize request argument(s)
            EmailPreferences emailPreferences = new EmailPreferences();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EmailPreferences response = emailPreferencesServiceClient.UpdateEmailPreferences(emailPreferences, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEmailPreferencesAsync</summary>
        public async Task UpdateEmailPreferencesAsync()
        {
            // Snippet: UpdateEmailPreferencesAsync(EmailPreferences, FieldMask, CallSettings)
            // Additional: UpdateEmailPreferencesAsync(EmailPreferences, FieldMask, CancellationToken)
            // Create client
            EmailPreferencesServiceClient emailPreferencesServiceClient = await EmailPreferencesServiceClient.CreateAsync();
            // Initialize request argument(s)
            EmailPreferences emailPreferences = new EmailPreferences();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EmailPreferences response = await emailPreferencesServiceClient.UpdateEmailPreferencesAsync(emailPreferences, updateMask);
            // End snippet
        }
    }
}
