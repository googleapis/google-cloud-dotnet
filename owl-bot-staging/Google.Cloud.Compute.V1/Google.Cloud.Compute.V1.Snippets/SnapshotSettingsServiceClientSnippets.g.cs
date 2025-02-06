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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Cloud.Compute.V1;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSnapshotSettingsServiceClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetSnapshotSettingRequest, CallSettings)
            // Create client
            SnapshotSettingsServiceClient snapshotSettingsServiceClient = SnapshotSettingsServiceClient.Create();
            // Initialize request argument(s)
            GetSnapshotSettingRequest request = new GetSnapshotSettingRequest { Project = "", };
            // Make the request
            SnapshotSettings response = snapshotSettingsServiceClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetSnapshotSettingRequest, CallSettings)
            // Additional: GetAsync(GetSnapshotSettingRequest, CancellationToken)
            // Create client
            SnapshotSettingsServiceClient snapshotSettingsServiceClient = await SnapshotSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSnapshotSettingRequest request = new GetSnapshotSettingRequest { Project = "", };
            // Make the request
            SnapshotSettings response = await snapshotSettingsServiceClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, CallSettings)
            // Create client
            SnapshotSettingsServiceClient snapshotSettingsServiceClient = SnapshotSettingsServiceClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SnapshotSettings response = snapshotSettingsServiceClient.Get(project);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, CallSettings)
            // Additional: GetAsync(string, CancellationToken)
            // Create client
            SnapshotSettingsServiceClient snapshotSettingsServiceClient = await SnapshotSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SnapshotSettings response = await snapshotSettingsServiceClient.GetAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchSnapshotSettingRequest, CallSettings)
            // Create client
            SnapshotSettingsServiceClient snapshotSettingsServiceClient = SnapshotSettingsServiceClient.Create();
            // Initialize request argument(s)
            PatchSnapshotSettingRequest request = new PatchSnapshotSettingRequest
            {
                RequestId = "",
                Project = "",
                SnapshotSettingsResource = new SnapshotSettings(),
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = snapshotSettingsServiceClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = snapshotSettingsServiceClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchSnapshotSettingRequest, CallSettings)
            // Additional: PatchAsync(PatchSnapshotSettingRequest, CancellationToken)
            // Create client
            SnapshotSettingsServiceClient snapshotSettingsServiceClient = await SnapshotSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            PatchSnapshotSettingRequest request = new PatchSnapshotSettingRequest
            {
                RequestId = "",
                Project = "",
                SnapshotSettingsResource = new SnapshotSettings(),
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await snapshotSettingsServiceClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await snapshotSettingsServiceClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, SnapshotSettings, CallSettings)
            // Create client
            SnapshotSettingsServiceClient snapshotSettingsServiceClient = SnapshotSettingsServiceClient.Create();
            // Initialize request argument(s)
            string project = "";
            SnapshotSettings snapshotSettingsResource = new SnapshotSettings();
            // Make the request
            lro::Operation<Operation, Operation> response = snapshotSettingsServiceClient.Patch(project, snapshotSettingsResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = snapshotSettingsServiceClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, SnapshotSettings, CallSettings)
            // Additional: PatchAsync(string, SnapshotSettings, CancellationToken)
            // Create client
            SnapshotSettingsServiceClient snapshotSettingsServiceClient = await SnapshotSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            SnapshotSettings snapshotSettingsResource = new SnapshotSettings();
            // Make the request
            lro::Operation<Operation, Operation> response = await snapshotSettingsServiceClient.PatchAsync(project, snapshotSettingsResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await snapshotSettingsServiceClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
