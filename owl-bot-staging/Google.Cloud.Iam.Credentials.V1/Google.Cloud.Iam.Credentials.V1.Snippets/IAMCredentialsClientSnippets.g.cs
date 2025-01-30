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
    using Google.Cloud.Iam.Credentials.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedIAMCredentialsClientSnippets
    {
        /// <summary>Snippet for GenerateAccessToken</summary>
        public void GenerateAccessTokenRequestObject()
        {
            // Snippet: GenerateAccessToken(GenerateAccessTokenRequest, CallSettings)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = IAMCredentialsClient.Create();
            // Initialize request argument(s)
            GenerateAccessTokenRequest request = new GenerateAccessTokenRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates = { "", },
                Scope = { "", },
                Lifetime = new Duration(),
            };
            // Make the request
            GenerateAccessTokenResponse response = iAMCredentialsClient.GenerateAccessToken(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAccessTokenAsync</summary>
        public async Task GenerateAccessTokenRequestObjectAsync()
        {
            // Snippet: GenerateAccessTokenAsync(GenerateAccessTokenRequest, CallSettings)
            // Additional: GenerateAccessTokenAsync(GenerateAccessTokenRequest, CancellationToken)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = await IAMCredentialsClient.CreateAsync();
            // Initialize request argument(s)
            GenerateAccessTokenRequest request = new GenerateAccessTokenRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates = { "", },
                Scope = { "", },
                Lifetime = new Duration(),
            };
            // Make the request
            GenerateAccessTokenResponse response = await iAMCredentialsClient.GenerateAccessTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAccessToken</summary>
        public void GenerateAccessToken()
        {
            // Snippet: GenerateAccessToken(string, IEnumerable<string>, IEnumerable<string>, Duration, CallSettings)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = IAMCredentialsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            IEnumerable<string> delegates = new string[] { "", };
            IEnumerable<string> scope = new string[] { "", };
            Duration lifetime = new Duration();
            // Make the request
            GenerateAccessTokenResponse response = iAMCredentialsClient.GenerateAccessToken(name, delegates, scope, lifetime);
            // End snippet
        }

        /// <summary>Snippet for GenerateAccessTokenAsync</summary>
        public async Task GenerateAccessTokenAsync()
        {
            // Snippet: GenerateAccessTokenAsync(string, IEnumerable<string>, IEnumerable<string>, Duration, CallSettings)
            // Additional: GenerateAccessTokenAsync(string, IEnumerable<string>, IEnumerable<string>, Duration, CancellationToken)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = await IAMCredentialsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            IEnumerable<string> delegates = new string[] { "", };
            IEnumerable<string> scope = new string[] { "", };
            Duration lifetime = new Duration();
            // Make the request
            GenerateAccessTokenResponse response = await iAMCredentialsClient.GenerateAccessTokenAsync(name, delegates, scope, lifetime);
            // End snippet
        }

        /// <summary>Snippet for GenerateAccessToken</summary>
        public void GenerateAccessTokenResourceNames()
        {
            // Snippet: GenerateAccessToken(ServiceAccountName, IEnumerable<string>, IEnumerable<string>, Duration, CallSettings)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = IAMCredentialsClient.Create();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            IEnumerable<string> delegates = new string[] { "", };
            IEnumerable<string> scope = new string[] { "", };
            Duration lifetime = new Duration();
            // Make the request
            GenerateAccessTokenResponse response = iAMCredentialsClient.GenerateAccessToken(name, delegates, scope, lifetime);
            // End snippet
        }

        /// <summary>Snippet for GenerateAccessTokenAsync</summary>
        public async Task GenerateAccessTokenResourceNamesAsync()
        {
            // Snippet: GenerateAccessTokenAsync(ServiceAccountName, IEnumerable<string>, IEnumerable<string>, Duration, CallSettings)
            // Additional: GenerateAccessTokenAsync(ServiceAccountName, IEnumerable<string>, IEnumerable<string>, Duration, CancellationToken)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = await IAMCredentialsClient.CreateAsync();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            IEnumerable<string> delegates = new string[] { "", };
            IEnumerable<string> scope = new string[] { "", };
            Duration lifetime = new Duration();
            // Make the request
            GenerateAccessTokenResponse response = await iAMCredentialsClient.GenerateAccessTokenAsync(name, delegates, scope, lifetime);
            // End snippet
        }

        /// <summary>Snippet for GenerateIdToken</summary>
        public void GenerateIdTokenRequestObject()
        {
            // Snippet: GenerateIdToken(GenerateIdTokenRequest, CallSettings)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = IAMCredentialsClient.Create();
            // Initialize request argument(s)
            GenerateIdTokenRequest request = new GenerateIdTokenRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates = { "", },
                Audience = "",
                IncludeEmail = false,
            };
            // Make the request
            GenerateIdTokenResponse response = iAMCredentialsClient.GenerateIdToken(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateIdTokenAsync</summary>
        public async Task GenerateIdTokenRequestObjectAsync()
        {
            // Snippet: GenerateIdTokenAsync(GenerateIdTokenRequest, CallSettings)
            // Additional: GenerateIdTokenAsync(GenerateIdTokenRequest, CancellationToken)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = await IAMCredentialsClient.CreateAsync();
            // Initialize request argument(s)
            GenerateIdTokenRequest request = new GenerateIdTokenRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates = { "", },
                Audience = "",
                IncludeEmail = false,
            };
            // Make the request
            GenerateIdTokenResponse response = await iAMCredentialsClient.GenerateIdTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateIdToken</summary>
        public void GenerateIdToken()
        {
            // Snippet: GenerateIdToken(string, IEnumerable<string>, string, bool, CallSettings)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = IAMCredentialsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            IEnumerable<string> delegates = new string[] { "", };
            string audience = "";
            bool includeEmail = false;
            // Make the request
            GenerateIdTokenResponse response = iAMCredentialsClient.GenerateIdToken(name, delegates, audience, includeEmail);
            // End snippet
        }

        /// <summary>Snippet for GenerateIdTokenAsync</summary>
        public async Task GenerateIdTokenAsync()
        {
            // Snippet: GenerateIdTokenAsync(string, IEnumerable<string>, string, bool, CallSettings)
            // Additional: GenerateIdTokenAsync(string, IEnumerable<string>, string, bool, CancellationToken)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = await IAMCredentialsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            IEnumerable<string> delegates = new string[] { "", };
            string audience = "";
            bool includeEmail = false;
            // Make the request
            GenerateIdTokenResponse response = await iAMCredentialsClient.GenerateIdTokenAsync(name, delegates, audience, includeEmail);
            // End snippet
        }

        /// <summary>Snippet for GenerateIdToken</summary>
        public void GenerateIdTokenResourceNames()
        {
            // Snippet: GenerateIdToken(ServiceAccountName, IEnumerable<string>, string, bool, CallSettings)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = IAMCredentialsClient.Create();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            IEnumerable<string> delegates = new string[] { "", };
            string audience = "";
            bool includeEmail = false;
            // Make the request
            GenerateIdTokenResponse response = iAMCredentialsClient.GenerateIdToken(name, delegates, audience, includeEmail);
            // End snippet
        }

        /// <summary>Snippet for GenerateIdTokenAsync</summary>
        public async Task GenerateIdTokenResourceNamesAsync()
        {
            // Snippet: GenerateIdTokenAsync(ServiceAccountName, IEnumerable<string>, string, bool, CallSettings)
            // Additional: GenerateIdTokenAsync(ServiceAccountName, IEnumerable<string>, string, bool, CancellationToken)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = await IAMCredentialsClient.CreateAsync();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            IEnumerable<string> delegates = new string[] { "", };
            string audience = "";
            bool includeEmail = false;
            // Make the request
            GenerateIdTokenResponse response = await iAMCredentialsClient.GenerateIdTokenAsync(name, delegates, audience, includeEmail);
            // End snippet
        }

        /// <summary>Snippet for SignBlob</summary>
        public void SignBlobRequestObject()
        {
            // Snippet: SignBlob(SignBlobRequest, CallSettings)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = IAMCredentialsClient.Create();
            // Initialize request argument(s)
            SignBlobRequest request = new SignBlobRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates = { "", },
                Payload = ByteString.Empty,
            };
            // Make the request
            SignBlobResponse response = iAMCredentialsClient.SignBlob(request);
            // End snippet
        }

        /// <summary>Snippet for SignBlobAsync</summary>
        public async Task SignBlobRequestObjectAsync()
        {
            // Snippet: SignBlobAsync(SignBlobRequest, CallSettings)
            // Additional: SignBlobAsync(SignBlobRequest, CancellationToken)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = await IAMCredentialsClient.CreateAsync();
            // Initialize request argument(s)
            SignBlobRequest request = new SignBlobRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates = { "", },
                Payload = ByteString.Empty,
            };
            // Make the request
            SignBlobResponse response = await iAMCredentialsClient.SignBlobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SignBlob</summary>
        public void SignBlob()
        {
            // Snippet: SignBlob(string, IEnumerable<string>, ByteString, CallSettings)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = IAMCredentialsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            IEnumerable<string> delegates = new string[] { "", };
            ByteString payload = ByteString.Empty;
            // Make the request
            SignBlobResponse response = iAMCredentialsClient.SignBlob(name, delegates, payload);
            // End snippet
        }

        /// <summary>Snippet for SignBlobAsync</summary>
        public async Task SignBlobAsync()
        {
            // Snippet: SignBlobAsync(string, IEnumerable<string>, ByteString, CallSettings)
            // Additional: SignBlobAsync(string, IEnumerable<string>, ByteString, CancellationToken)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = await IAMCredentialsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            IEnumerable<string> delegates = new string[] { "", };
            ByteString payload = ByteString.Empty;
            // Make the request
            SignBlobResponse response = await iAMCredentialsClient.SignBlobAsync(name, delegates, payload);
            // End snippet
        }

        /// <summary>Snippet for SignBlob</summary>
        public void SignBlobResourceNames()
        {
            // Snippet: SignBlob(ServiceAccountName, IEnumerable<string>, ByteString, CallSettings)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = IAMCredentialsClient.Create();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            IEnumerable<string> delegates = new string[] { "", };
            ByteString payload = ByteString.Empty;
            // Make the request
            SignBlobResponse response = iAMCredentialsClient.SignBlob(name, delegates, payload);
            // End snippet
        }

        /// <summary>Snippet for SignBlobAsync</summary>
        public async Task SignBlobResourceNamesAsync()
        {
            // Snippet: SignBlobAsync(ServiceAccountName, IEnumerable<string>, ByteString, CallSettings)
            // Additional: SignBlobAsync(ServiceAccountName, IEnumerable<string>, ByteString, CancellationToken)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = await IAMCredentialsClient.CreateAsync();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            IEnumerable<string> delegates = new string[] { "", };
            ByteString payload = ByteString.Empty;
            // Make the request
            SignBlobResponse response = await iAMCredentialsClient.SignBlobAsync(name, delegates, payload);
            // End snippet
        }

        /// <summary>Snippet for SignJwt</summary>
        public void SignJwtRequestObject()
        {
            // Snippet: SignJwt(SignJwtRequest, CallSettings)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = IAMCredentialsClient.Create();
            // Initialize request argument(s)
            SignJwtRequest request = new SignJwtRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates = { "", },
                Payload = "",
            };
            // Make the request
            SignJwtResponse response = iAMCredentialsClient.SignJwt(request);
            // End snippet
        }

        /// <summary>Snippet for SignJwtAsync</summary>
        public async Task SignJwtRequestObjectAsync()
        {
            // Snippet: SignJwtAsync(SignJwtRequest, CallSettings)
            // Additional: SignJwtAsync(SignJwtRequest, CancellationToken)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = await IAMCredentialsClient.CreateAsync();
            // Initialize request argument(s)
            SignJwtRequest request = new SignJwtRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates = { "", },
                Payload = "",
            };
            // Make the request
            SignJwtResponse response = await iAMCredentialsClient.SignJwtAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SignJwt</summary>
        public void SignJwt()
        {
            // Snippet: SignJwt(string, IEnumerable<string>, string, CallSettings)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = IAMCredentialsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            IEnumerable<string> delegates = new string[] { "", };
            string payload = "";
            // Make the request
            SignJwtResponse response = iAMCredentialsClient.SignJwt(name, delegates, payload);
            // End snippet
        }

        /// <summary>Snippet for SignJwtAsync</summary>
        public async Task SignJwtAsync()
        {
            // Snippet: SignJwtAsync(string, IEnumerable<string>, string, CallSettings)
            // Additional: SignJwtAsync(string, IEnumerable<string>, string, CancellationToken)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = await IAMCredentialsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            IEnumerable<string> delegates = new string[] { "", };
            string payload = "";
            // Make the request
            SignJwtResponse response = await iAMCredentialsClient.SignJwtAsync(name, delegates, payload);
            // End snippet
        }

        /// <summary>Snippet for SignJwt</summary>
        public void SignJwtResourceNames()
        {
            // Snippet: SignJwt(ServiceAccountName, IEnumerable<string>, string, CallSettings)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = IAMCredentialsClient.Create();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            IEnumerable<string> delegates = new string[] { "", };
            string payload = "";
            // Make the request
            SignJwtResponse response = iAMCredentialsClient.SignJwt(name, delegates, payload);
            // End snippet
        }

        /// <summary>Snippet for SignJwtAsync</summary>
        public async Task SignJwtResourceNamesAsync()
        {
            // Snippet: SignJwtAsync(ServiceAccountName, IEnumerable<string>, string, CallSettings)
            // Additional: SignJwtAsync(ServiceAccountName, IEnumerable<string>, string, CancellationToken)
            // Create client
            IAMCredentialsClient iAMCredentialsClient = await IAMCredentialsClient.CreateAsync();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            IEnumerable<string> delegates = new string[] { "", };
            string payload = "";
            // Make the request
            SignJwtResponse response = await iAMCredentialsClient.SignJwtAsync(name, delegates, payload);
            // End snippet
        }
    }
}
