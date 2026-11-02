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
    using Google.Api.Gax;
    using Google.Cloud.DiscoveryEngine.V1;
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCollectionServiceClientSnippets
    {
        /// <summary>Snippet for DeleteCollection</summary>
        public void DeleteCollectionRequestObject()
        {
            // Snippet: DeleteCollection(DeleteCollectionRequest, CallSettings)
            // Create client
            CollectionServiceClient collectionServiceClient = CollectionServiceClient.Create();
            // Initialize request argument(s)
            DeleteCollectionRequest request = new DeleteCollectionRequest
            {
                CollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
            };
            // Make the request
            Operation<Empty, DeleteCollectionMetadata> response = collectionServiceClient.DeleteCollection(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteCollectionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteCollectionMetadata> retrievedResponse = collectionServiceClient.PollOnceDeleteCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollectionAsync</summary>
        public async Task DeleteCollectionRequestObjectAsync()
        {
            // Snippet: DeleteCollectionAsync(DeleteCollectionRequest, CallSettings)
            // Additional: DeleteCollectionAsync(DeleteCollectionRequest, CancellationToken)
            // Create client
            CollectionServiceClient collectionServiceClient = await CollectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCollectionRequest request = new DeleteCollectionRequest
            {
                CollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
            };
            // Make the request
            Operation<Empty, DeleteCollectionMetadata> response = await collectionServiceClient.DeleteCollectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteCollectionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteCollectionMetadata> retrievedResponse = await collectionServiceClient.PollOnceDeleteCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollection</summary>
        public void DeleteCollection()
        {
            // Snippet: DeleteCollection(string, CallSettings)
            // Create client
            CollectionServiceClient collectionServiceClient = CollectionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            // Make the request
            Operation<Empty, DeleteCollectionMetadata> response = collectionServiceClient.DeleteCollection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteCollectionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteCollectionMetadata> retrievedResponse = collectionServiceClient.PollOnceDeleteCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollectionAsync</summary>
        public async Task DeleteCollectionAsync()
        {
            // Snippet: DeleteCollectionAsync(string, CallSettings)
            // Additional: DeleteCollectionAsync(string, CancellationToken)
            // Create client
            CollectionServiceClient collectionServiceClient = await CollectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            // Make the request
            Operation<Empty, DeleteCollectionMetadata> response = await collectionServiceClient.DeleteCollectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteCollectionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteCollectionMetadata> retrievedResponse = await collectionServiceClient.PollOnceDeleteCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollection</summary>
        public void DeleteCollectionResourceNames()
        {
            // Snippet: DeleteCollection(CollectionName, CallSettings)
            // Create client
            CollectionServiceClient collectionServiceClient = CollectionServiceClient.Create();
            // Initialize request argument(s)
            CollectionName name = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            // Make the request
            Operation<Empty, DeleteCollectionMetadata> response = collectionServiceClient.DeleteCollection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteCollectionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteCollectionMetadata> retrievedResponse = collectionServiceClient.PollOnceDeleteCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollectionAsync</summary>
        public async Task DeleteCollectionResourceNamesAsync()
        {
            // Snippet: DeleteCollectionAsync(CollectionName, CallSettings)
            // Additional: DeleteCollectionAsync(CollectionName, CancellationToken)
            // Create client
            CollectionServiceClient collectionServiceClient = await CollectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CollectionName name = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            // Make the request
            Operation<Empty, DeleteCollectionMetadata> response = await collectionServiceClient.DeleteCollectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteCollectionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteCollectionMetadata> retrievedResponse = await collectionServiceClient.PollOnceDeleteCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            CollectionServiceClient collectionServiceClient = CollectionServiceClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = collectionServiceClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            CollectionServiceClient collectionServiceClient = await CollectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await collectionServiceClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            CollectionServiceClient collectionServiceClient = CollectionServiceClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = collectionServiceClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            CollectionServiceClient collectionServiceClient = await CollectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await collectionServiceClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            CollectionServiceClient collectionServiceClient = CollectionServiceClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = collectionServiceClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            CollectionServiceClient collectionServiceClient = await CollectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await collectionServiceClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            CollectionServiceClient collectionServiceClient = CollectionServiceClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = collectionServiceClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            CollectionServiceClient collectionServiceClient = await CollectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await collectionServiceClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            CollectionServiceClient collectionServiceClient = CollectionServiceClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = collectionServiceClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            CollectionServiceClient collectionServiceClient = await CollectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await collectionServiceClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            CollectionServiceClient collectionServiceClient = CollectionServiceClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = collectionServiceClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            CollectionServiceClient collectionServiceClient = await CollectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await collectionServiceClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }
    }
}
