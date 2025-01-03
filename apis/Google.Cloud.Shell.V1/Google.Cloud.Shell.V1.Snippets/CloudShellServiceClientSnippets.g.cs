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
    using Google.Cloud.Shell.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCloudShellServiceClientSnippets
    {
        /// <summary>Snippet for GetEnvironment</summary>
        public void GetEnvironmentRequestObject()
        {
            // Snippet: GetEnvironment(GetEnvironmentRequest, CallSettings)
            // Create client
            CloudShellServiceClient cloudShellServiceClient = CloudShellServiceClient.Create();
            // Initialize request argument(s)
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromUserEnvironment("[USER]", "[ENVIRONMENT]"),
            };
            // Make the request
            Environment response = cloudShellServiceClient.GetEnvironment(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironmentAsync</summary>
        public async Task GetEnvironmentRequestObjectAsync()
        {
            // Snippet: GetEnvironmentAsync(GetEnvironmentRequest, CallSettings)
            // Additional: GetEnvironmentAsync(GetEnvironmentRequest, CancellationToken)
            // Create client
            CloudShellServiceClient cloudShellServiceClient = await CloudShellServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromUserEnvironment("[USER]", "[ENVIRONMENT]"),
            };
            // Make the request
            Environment response = await cloudShellServiceClient.GetEnvironmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironment</summary>
        public void GetEnvironment()
        {
            // Snippet: GetEnvironment(string, CallSettings)
            // Create client
            CloudShellServiceClient cloudShellServiceClient = CloudShellServiceClient.Create();
            // Initialize request argument(s)
            string name = "users/[USER]/environments/[ENVIRONMENT]";
            // Make the request
            Environment response = cloudShellServiceClient.GetEnvironment(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironmentAsync</summary>
        public async Task GetEnvironmentAsync()
        {
            // Snippet: GetEnvironmentAsync(string, CallSettings)
            // Additional: GetEnvironmentAsync(string, CancellationToken)
            // Create client
            CloudShellServiceClient cloudShellServiceClient = await CloudShellServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "users/[USER]/environments/[ENVIRONMENT]";
            // Make the request
            Environment response = await cloudShellServiceClient.GetEnvironmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironment</summary>
        public void GetEnvironmentResourceNames()
        {
            // Snippet: GetEnvironment(EnvironmentName, CallSettings)
            // Create client
            CloudShellServiceClient cloudShellServiceClient = CloudShellServiceClient.Create();
            // Initialize request argument(s)
            EnvironmentName name = EnvironmentName.FromUserEnvironment("[USER]", "[ENVIRONMENT]");
            // Make the request
            Environment response = cloudShellServiceClient.GetEnvironment(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironmentAsync</summary>
        public async Task GetEnvironmentResourceNamesAsync()
        {
            // Snippet: GetEnvironmentAsync(EnvironmentName, CallSettings)
            // Additional: GetEnvironmentAsync(EnvironmentName, CancellationToken)
            // Create client
            CloudShellServiceClient cloudShellServiceClient = await CloudShellServiceClient.CreateAsync();
            // Initialize request argument(s)
            EnvironmentName name = EnvironmentName.FromUserEnvironment("[USER]", "[ENVIRONMENT]");
            // Make the request
            Environment response = await cloudShellServiceClient.GetEnvironmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for StartEnvironment</summary>
        public void StartEnvironmentRequestObject()
        {
            // Snippet: StartEnvironment(StartEnvironmentRequest, CallSettings)
            // Create client
            CloudShellServiceClient cloudShellServiceClient = CloudShellServiceClient.Create();
            // Initialize request argument(s)
            StartEnvironmentRequest request = new StartEnvironmentRequest
            {
                Name = "",
                AccessToken = "",
                PublicKeys = { "", },
            };
            // Make the request
            Operation<StartEnvironmentResponse, StartEnvironmentMetadata> response = cloudShellServiceClient.StartEnvironment(request);

            // Poll until the returned long-running operation is complete
            Operation<StartEnvironmentResponse, StartEnvironmentMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StartEnvironmentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartEnvironmentResponse, StartEnvironmentMetadata> retrievedResponse = cloudShellServiceClient.PollOnceStartEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartEnvironmentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartEnvironmentAsync</summary>
        public async Task StartEnvironmentRequestObjectAsync()
        {
            // Snippet: StartEnvironmentAsync(StartEnvironmentRequest, CallSettings)
            // Additional: StartEnvironmentAsync(StartEnvironmentRequest, CancellationToken)
            // Create client
            CloudShellServiceClient cloudShellServiceClient = await CloudShellServiceClient.CreateAsync();
            // Initialize request argument(s)
            StartEnvironmentRequest request = new StartEnvironmentRequest
            {
                Name = "",
                AccessToken = "",
                PublicKeys = { "", },
            };
            // Make the request
            Operation<StartEnvironmentResponse, StartEnvironmentMetadata> response = await cloudShellServiceClient.StartEnvironmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<StartEnvironmentResponse, StartEnvironmentMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StartEnvironmentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartEnvironmentResponse, StartEnvironmentMetadata> retrievedResponse = await cloudShellServiceClient.PollOnceStartEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartEnvironmentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AuthorizeEnvironment</summary>
        public void AuthorizeEnvironmentRequestObject()
        {
            // Snippet: AuthorizeEnvironment(AuthorizeEnvironmentRequest, CallSettings)
            // Create client
            CloudShellServiceClient cloudShellServiceClient = CloudShellServiceClient.Create();
            // Initialize request argument(s)
            AuthorizeEnvironmentRequest request = new AuthorizeEnvironmentRequest
            {
                Name = "",
                AccessToken = "",
                ExpireTime = new Timestamp(),
                IdToken = "",
            };
            // Make the request
            Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata> response = cloudShellServiceClient.AuthorizeEnvironment(request);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuthorizeEnvironmentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata> retrievedResponse = cloudShellServiceClient.PollOnceAuthorizeEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizeEnvironmentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AuthorizeEnvironmentAsync</summary>
        public async Task AuthorizeEnvironmentRequestObjectAsync()
        {
            // Snippet: AuthorizeEnvironmentAsync(AuthorizeEnvironmentRequest, CallSettings)
            // Additional: AuthorizeEnvironmentAsync(AuthorizeEnvironmentRequest, CancellationToken)
            // Create client
            CloudShellServiceClient cloudShellServiceClient = await CloudShellServiceClient.CreateAsync();
            // Initialize request argument(s)
            AuthorizeEnvironmentRequest request = new AuthorizeEnvironmentRequest
            {
                Name = "",
                AccessToken = "",
                ExpireTime = new Timestamp(),
                IdToken = "",
            };
            // Make the request
            Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata> response = await cloudShellServiceClient.AuthorizeEnvironmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuthorizeEnvironmentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata> retrievedResponse = await cloudShellServiceClient.PollOnceAuthorizeEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizeEnvironmentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddPublicKey</summary>
        public void AddPublicKeyRequestObject()
        {
            // Snippet: AddPublicKey(AddPublicKeyRequest, CallSettings)
            // Create client
            CloudShellServiceClient cloudShellServiceClient = CloudShellServiceClient.Create();
            // Initialize request argument(s)
            AddPublicKeyRequest request = new AddPublicKeyRequest
            {
                Environment = "",
                Key = "",
            };
            // Make the request
            Operation<AddPublicKeyResponse, AddPublicKeyMetadata> response = cloudShellServiceClient.AddPublicKey(request);

            // Poll until the returned long-running operation is complete
            Operation<AddPublicKeyResponse, AddPublicKeyMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddPublicKeyResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddPublicKeyResponse, AddPublicKeyMetadata> retrievedResponse = cloudShellServiceClient.PollOnceAddPublicKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddPublicKeyResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddPublicKeyAsync</summary>
        public async Task AddPublicKeyRequestObjectAsync()
        {
            // Snippet: AddPublicKeyAsync(AddPublicKeyRequest, CallSettings)
            // Additional: AddPublicKeyAsync(AddPublicKeyRequest, CancellationToken)
            // Create client
            CloudShellServiceClient cloudShellServiceClient = await CloudShellServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddPublicKeyRequest request = new AddPublicKeyRequest
            {
                Environment = "",
                Key = "",
            };
            // Make the request
            Operation<AddPublicKeyResponse, AddPublicKeyMetadata> response = await cloudShellServiceClient.AddPublicKeyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AddPublicKeyResponse, AddPublicKeyMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddPublicKeyResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddPublicKeyResponse, AddPublicKeyMetadata> retrievedResponse = await cloudShellServiceClient.PollOnceAddPublicKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddPublicKeyResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemovePublicKey</summary>
        public void RemovePublicKeyRequestObject()
        {
            // Snippet: RemovePublicKey(RemovePublicKeyRequest, CallSettings)
            // Create client
            CloudShellServiceClient cloudShellServiceClient = CloudShellServiceClient.Create();
            // Initialize request argument(s)
            RemovePublicKeyRequest request = new RemovePublicKeyRequest
            {
                Environment = "",
                Key = "",
            };
            // Make the request
            Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata> response = cloudShellServiceClient.RemovePublicKey(request);

            // Poll until the returned long-running operation is complete
            Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RemovePublicKeyResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata> retrievedResponse = cloudShellServiceClient.PollOnceRemovePublicKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemovePublicKeyResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemovePublicKeyAsync</summary>
        public async Task RemovePublicKeyRequestObjectAsync()
        {
            // Snippet: RemovePublicKeyAsync(RemovePublicKeyRequest, CallSettings)
            // Additional: RemovePublicKeyAsync(RemovePublicKeyRequest, CancellationToken)
            // Create client
            CloudShellServiceClient cloudShellServiceClient = await CloudShellServiceClient.CreateAsync();
            // Initialize request argument(s)
            RemovePublicKeyRequest request = new RemovePublicKeyRequest
            {
                Environment = "",
                Key = "",
            };
            // Make the request
            Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata> response = await cloudShellServiceClient.RemovePublicKeyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RemovePublicKeyResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata> retrievedResponse = await cloudShellServiceClient.PollOnceRemovePublicKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemovePublicKeyResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
