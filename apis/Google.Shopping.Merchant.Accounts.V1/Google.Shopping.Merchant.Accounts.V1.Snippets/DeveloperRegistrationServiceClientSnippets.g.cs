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
    using Google.Shopping.Merchant.Accounts.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDeveloperRegistrationServiceClientSnippets
    {
        /// <summary>Snippet for RegisterGcp</summary>
        public void RegisterGcpRequestObject()
        {
            // Snippet: RegisterGcp(RegisterGcpRequest, CallSettings)
            // Create client
            DeveloperRegistrationServiceClient developerRegistrationServiceClient = DeveloperRegistrationServiceClient.Create();
            // Initialize request argument(s)
            RegisterGcpRequest request = new RegisterGcpRequest
            {
                DeveloperRegistrationName = DeveloperRegistrationName.FromAccount("[ACCOUNT]"),
                DeveloperEmail = "",
            };
            // Make the request
            DeveloperRegistration response = developerRegistrationServiceClient.RegisterGcp(request);
            // End snippet
        }

        /// <summary>Snippet for RegisterGcpAsync</summary>
        public async Task RegisterGcpRequestObjectAsync()
        {
            // Snippet: RegisterGcpAsync(RegisterGcpRequest, CallSettings)
            // Additional: RegisterGcpAsync(RegisterGcpRequest, CancellationToken)
            // Create client
            DeveloperRegistrationServiceClient developerRegistrationServiceClient = await DeveloperRegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            RegisterGcpRequest request = new RegisterGcpRequest
            {
                DeveloperRegistrationName = DeveloperRegistrationName.FromAccount("[ACCOUNT]"),
                DeveloperEmail = "",
            };
            // Make the request
            DeveloperRegistration response = await developerRegistrationServiceClient.RegisterGcpAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeveloperRegistration</summary>
        public void GetDeveloperRegistrationRequestObject()
        {
            // Snippet: GetDeveloperRegistration(GetDeveloperRegistrationRequest, CallSettings)
            // Create client
            DeveloperRegistrationServiceClient developerRegistrationServiceClient = DeveloperRegistrationServiceClient.Create();
            // Initialize request argument(s)
            GetDeveloperRegistrationRequest request = new GetDeveloperRegistrationRequest
            {
                DeveloperRegistrationName = DeveloperRegistrationName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            DeveloperRegistration response = developerRegistrationServiceClient.GetDeveloperRegistration(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeveloperRegistrationAsync</summary>
        public async Task GetDeveloperRegistrationRequestObjectAsync()
        {
            // Snippet: GetDeveloperRegistrationAsync(GetDeveloperRegistrationRequest, CallSettings)
            // Additional: GetDeveloperRegistrationAsync(GetDeveloperRegistrationRequest, CancellationToken)
            // Create client
            DeveloperRegistrationServiceClient developerRegistrationServiceClient = await DeveloperRegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDeveloperRegistrationRequest request = new GetDeveloperRegistrationRequest
            {
                DeveloperRegistrationName = DeveloperRegistrationName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            DeveloperRegistration response = await developerRegistrationServiceClient.GetDeveloperRegistrationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeveloperRegistration</summary>
        public void GetDeveloperRegistration()
        {
            // Snippet: GetDeveloperRegistration(string, CallSettings)
            // Create client
            DeveloperRegistrationServiceClient developerRegistrationServiceClient = DeveloperRegistrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/developerRegistration";
            // Make the request
            DeveloperRegistration response = developerRegistrationServiceClient.GetDeveloperRegistration(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeveloperRegistrationAsync</summary>
        public async Task GetDeveloperRegistrationAsync()
        {
            // Snippet: GetDeveloperRegistrationAsync(string, CallSettings)
            // Additional: GetDeveloperRegistrationAsync(string, CancellationToken)
            // Create client
            DeveloperRegistrationServiceClient developerRegistrationServiceClient = await DeveloperRegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/developerRegistration";
            // Make the request
            DeveloperRegistration response = await developerRegistrationServiceClient.GetDeveloperRegistrationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeveloperRegistration</summary>
        public void GetDeveloperRegistrationResourceNames()
        {
            // Snippet: GetDeveloperRegistration(DeveloperRegistrationName, CallSettings)
            // Create client
            DeveloperRegistrationServiceClient developerRegistrationServiceClient = DeveloperRegistrationServiceClient.Create();
            // Initialize request argument(s)
            DeveloperRegistrationName name = DeveloperRegistrationName.FromAccount("[ACCOUNT]");
            // Make the request
            DeveloperRegistration response = developerRegistrationServiceClient.GetDeveloperRegistration(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeveloperRegistrationAsync</summary>
        public async Task GetDeveloperRegistrationResourceNamesAsync()
        {
            // Snippet: GetDeveloperRegistrationAsync(DeveloperRegistrationName, CallSettings)
            // Additional: GetDeveloperRegistrationAsync(DeveloperRegistrationName, CancellationToken)
            // Create client
            DeveloperRegistrationServiceClient developerRegistrationServiceClient = await DeveloperRegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeveloperRegistrationName name = DeveloperRegistrationName.FromAccount("[ACCOUNT]");
            // Make the request
            DeveloperRegistration response = await developerRegistrationServiceClient.GetDeveloperRegistrationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UnregisterGcp</summary>
        public void UnregisterGcpRequestObject()
        {
            // Snippet: UnregisterGcp(UnregisterGcpRequest, CallSettings)
            // Create client
            DeveloperRegistrationServiceClient developerRegistrationServiceClient = DeveloperRegistrationServiceClient.Create();
            // Initialize request argument(s)
            UnregisterGcpRequest request = new UnregisterGcpRequest
            {
                DeveloperRegistrationName = DeveloperRegistrationName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            developerRegistrationServiceClient.UnregisterGcp(request);
            // End snippet
        }

        /// <summary>Snippet for UnregisterGcpAsync</summary>
        public async Task UnregisterGcpRequestObjectAsync()
        {
            // Snippet: UnregisterGcpAsync(UnregisterGcpRequest, CallSettings)
            // Additional: UnregisterGcpAsync(UnregisterGcpRequest, CancellationToken)
            // Create client
            DeveloperRegistrationServiceClient developerRegistrationServiceClient = await DeveloperRegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UnregisterGcpRequest request = new UnregisterGcpRequest
            {
                DeveloperRegistrationName = DeveloperRegistrationName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            await developerRegistrationServiceClient.UnregisterGcpAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccountForGcpRegistration</summary>
        public void GetAccountForGcpRegistrationRequestObject()
        {
            // Snippet: GetAccountForGcpRegistration(Empty, CallSettings)
            // Create client
            DeveloperRegistrationServiceClient developerRegistrationServiceClient = DeveloperRegistrationServiceClient.Create();
            // Initialize request argument(s)
            Empty request = new Empty { };
            // Make the request
            GetAccountForGcpRegistrationResponse response = developerRegistrationServiceClient.GetAccountForGcpRegistration(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccountForGcpRegistrationAsync</summary>
        public async Task GetAccountForGcpRegistrationRequestObjectAsync()
        {
            // Snippet: GetAccountForGcpRegistrationAsync(Empty, CallSettings)
            // Additional: GetAccountForGcpRegistrationAsync(Empty, CancellationToken)
            // Create client
            DeveloperRegistrationServiceClient developerRegistrationServiceClient = await DeveloperRegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            Empty request = new Empty { };
            // Make the request
            GetAccountForGcpRegistrationResponse response = await developerRegistrationServiceClient.GetAccountForGcpRegistrationAsync(request);
            // End snippet
        }
    }
}
