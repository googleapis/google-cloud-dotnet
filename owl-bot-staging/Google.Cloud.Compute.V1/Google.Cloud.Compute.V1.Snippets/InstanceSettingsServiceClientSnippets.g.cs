// Copyright 2024 Google LLC
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
    public sealed class AllGeneratedInstanceSettingsServiceClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetInstanceSettingRequest, CallSettings)
            // Create client
            InstanceSettingsServiceClient instanceSettingsServiceClient = InstanceSettingsServiceClient.Create();
            // Initialize request argument(s)
            GetInstanceSettingRequest request = new GetInstanceSettingRequest
            {
                Zone = "",
                Project = "",
            };
            // Make the request
            InstanceSettings response = instanceSettingsServiceClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetInstanceSettingRequest, CallSettings)
            // Additional: GetAsync(GetInstanceSettingRequest, CancellationToken)
            // Create client
            InstanceSettingsServiceClient instanceSettingsServiceClient = await InstanceSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceSettingRequest request = new GetInstanceSettingRequest
            {
                Zone = "",
                Project = "",
            };
            // Make the request
            InstanceSettings response = await instanceSettingsServiceClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            InstanceSettingsServiceClient instanceSettingsServiceClient = InstanceSettingsServiceClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            InstanceSettings response = instanceSettingsServiceClient.Get(project, zone);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            InstanceSettingsServiceClient instanceSettingsServiceClient = await InstanceSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            InstanceSettings response = await instanceSettingsServiceClient.GetAsync(project, zone);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchInstanceSettingRequest, CallSettings)
            // Create client
            InstanceSettingsServiceClient instanceSettingsServiceClient = InstanceSettingsServiceClient.Create();
            // Initialize request argument(s)
            PatchInstanceSettingRequest request = new PatchInstanceSettingRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceSettingsResource = new InstanceSettings(),
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceSettingsServiceClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceSettingsServiceClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchInstanceSettingRequest, CallSettings)
            // Additional: PatchAsync(PatchInstanceSettingRequest, CancellationToken)
            // Create client
            InstanceSettingsServiceClient instanceSettingsServiceClient = await InstanceSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            PatchInstanceSettingRequest request = new PatchInstanceSettingRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceSettingsResource = new InstanceSettings(),
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceSettingsServiceClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceSettingsServiceClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, InstanceSettings, CallSettings)
            // Create client
            InstanceSettingsServiceClient instanceSettingsServiceClient = InstanceSettingsServiceClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            InstanceSettings instanceSettingsResource = new InstanceSettings();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceSettingsServiceClient.Patch(project, zone, instanceSettingsResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceSettingsServiceClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, InstanceSettings, CallSettings)
            // Additional: PatchAsync(string, string, InstanceSettings, CancellationToken)
            // Create client
            InstanceSettingsServiceClient instanceSettingsServiceClient = await InstanceSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            InstanceSettings instanceSettingsResource = new InstanceSettings();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceSettingsServiceClient.PatchAsync(project, zone, instanceSettingsResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceSettingsServiceClient.PollOncePatchAsync(operationName);
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
