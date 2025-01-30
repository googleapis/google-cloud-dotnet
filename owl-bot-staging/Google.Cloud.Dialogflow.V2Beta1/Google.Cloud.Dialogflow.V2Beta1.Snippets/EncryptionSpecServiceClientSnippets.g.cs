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
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEncryptionSpecServiceClientSnippets
    {
        /// <summary>Snippet for GetEncryptionSpec</summary>
        public void GetEncryptionSpecRequestObject()
        {
            // Snippet: GetEncryptionSpec(GetEncryptionSpecRequest, CallSettings)
            // Create client
            EncryptionSpecServiceClient encryptionSpecServiceClient = EncryptionSpecServiceClient.Create();
            // Initialize request argument(s)
            GetEncryptionSpecRequest request = new GetEncryptionSpecRequest
            {
                EncryptionSpecName = EncryptionSpecName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            EncryptionSpec response = encryptionSpecServiceClient.GetEncryptionSpec(request);
            // End snippet
        }

        /// <summary>Snippet for GetEncryptionSpecAsync</summary>
        public async Task GetEncryptionSpecRequestObjectAsync()
        {
            // Snippet: GetEncryptionSpecAsync(GetEncryptionSpecRequest, CallSettings)
            // Additional: GetEncryptionSpecAsync(GetEncryptionSpecRequest, CancellationToken)
            // Create client
            EncryptionSpecServiceClient encryptionSpecServiceClient = await EncryptionSpecServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEncryptionSpecRequest request = new GetEncryptionSpecRequest
            {
                EncryptionSpecName = EncryptionSpecName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            EncryptionSpec response = await encryptionSpecServiceClient.GetEncryptionSpecAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEncryptionSpec</summary>
        public void GetEncryptionSpec()
        {
            // Snippet: GetEncryptionSpec(string, CallSettings)
            // Create client
            EncryptionSpecServiceClient encryptionSpecServiceClient = EncryptionSpecServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/encryptionSpec";
            // Make the request
            EncryptionSpec response = encryptionSpecServiceClient.GetEncryptionSpec(name);
            // End snippet
        }

        /// <summary>Snippet for GetEncryptionSpecAsync</summary>
        public async Task GetEncryptionSpecAsync()
        {
            // Snippet: GetEncryptionSpecAsync(string, CallSettings)
            // Additional: GetEncryptionSpecAsync(string, CancellationToken)
            // Create client
            EncryptionSpecServiceClient encryptionSpecServiceClient = await EncryptionSpecServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/encryptionSpec";
            // Make the request
            EncryptionSpec response = await encryptionSpecServiceClient.GetEncryptionSpecAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEncryptionSpec</summary>
        public void GetEncryptionSpecResourceNames()
        {
            // Snippet: GetEncryptionSpec(EncryptionSpecName, CallSettings)
            // Create client
            EncryptionSpecServiceClient encryptionSpecServiceClient = EncryptionSpecServiceClient.Create();
            // Initialize request argument(s)
            EncryptionSpecName name = EncryptionSpecName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            EncryptionSpec response = encryptionSpecServiceClient.GetEncryptionSpec(name);
            // End snippet
        }

        /// <summary>Snippet for GetEncryptionSpecAsync</summary>
        public async Task GetEncryptionSpecResourceNamesAsync()
        {
            // Snippet: GetEncryptionSpecAsync(EncryptionSpecName, CallSettings)
            // Additional: GetEncryptionSpecAsync(EncryptionSpecName, CancellationToken)
            // Create client
            EncryptionSpecServiceClient encryptionSpecServiceClient = await EncryptionSpecServiceClient.CreateAsync();
            // Initialize request argument(s)
            EncryptionSpecName name = EncryptionSpecName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            EncryptionSpec response = await encryptionSpecServiceClient.GetEncryptionSpecAsync(name);
            // End snippet
        }

        /// <summary>Snippet for InitializeEncryptionSpec</summary>
        public void InitializeEncryptionSpecRequestObject()
        {
            // Snippet: InitializeEncryptionSpec(InitializeEncryptionSpecRequest, CallSettings)
            // Create client
            EncryptionSpecServiceClient encryptionSpecServiceClient = EncryptionSpecServiceClient.Create();
            // Initialize request argument(s)
            InitializeEncryptionSpecRequest request = new InitializeEncryptionSpecRequest
            {
                EncryptionSpec = new EncryptionSpec(),
            };
            // Make the request
            Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> response = encryptionSpecServiceClient.InitializeEncryptionSpec(request);

            // Poll until the returned long-running operation is complete
            Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InitializeEncryptionSpecResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> retrievedResponse = encryptionSpecServiceClient.PollOnceInitializeEncryptionSpec(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InitializeEncryptionSpecResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InitializeEncryptionSpecAsync</summary>
        public async Task InitializeEncryptionSpecRequestObjectAsync()
        {
            // Snippet: InitializeEncryptionSpecAsync(InitializeEncryptionSpecRequest, CallSettings)
            // Additional: InitializeEncryptionSpecAsync(InitializeEncryptionSpecRequest, CancellationToken)
            // Create client
            EncryptionSpecServiceClient encryptionSpecServiceClient = await EncryptionSpecServiceClient.CreateAsync();
            // Initialize request argument(s)
            InitializeEncryptionSpecRequest request = new InitializeEncryptionSpecRequest
            {
                EncryptionSpec = new EncryptionSpec(),
            };
            // Make the request
            Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> response = await encryptionSpecServiceClient.InitializeEncryptionSpecAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InitializeEncryptionSpecResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> retrievedResponse = await encryptionSpecServiceClient.PollOnceInitializeEncryptionSpecAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InitializeEncryptionSpecResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InitializeEncryptionSpec</summary>
        public void InitializeEncryptionSpec()
        {
            // Snippet: InitializeEncryptionSpec(EncryptionSpec, CallSettings)
            // Create client
            EncryptionSpecServiceClient encryptionSpecServiceClient = EncryptionSpecServiceClient.Create();
            // Initialize request argument(s)
            EncryptionSpec encryptionSpec = new EncryptionSpec();
            // Make the request
            Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> response = encryptionSpecServiceClient.InitializeEncryptionSpec(encryptionSpec);

            // Poll until the returned long-running operation is complete
            Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InitializeEncryptionSpecResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> retrievedResponse = encryptionSpecServiceClient.PollOnceInitializeEncryptionSpec(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InitializeEncryptionSpecResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InitializeEncryptionSpecAsync</summary>
        public async Task InitializeEncryptionSpecAsync()
        {
            // Snippet: InitializeEncryptionSpecAsync(EncryptionSpec, CallSettings)
            // Additional: InitializeEncryptionSpecAsync(EncryptionSpec, CancellationToken)
            // Create client
            EncryptionSpecServiceClient encryptionSpecServiceClient = await EncryptionSpecServiceClient.CreateAsync();
            // Initialize request argument(s)
            EncryptionSpec encryptionSpec = new EncryptionSpec();
            // Make the request
            Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> response = await encryptionSpecServiceClient.InitializeEncryptionSpecAsync(encryptionSpec);

            // Poll until the returned long-running operation is complete
            Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InitializeEncryptionSpecResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> retrievedResponse = await encryptionSpecServiceClient.PollOnceInitializeEncryptionSpecAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InitializeEncryptionSpecResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
