// Copyright 2019 Google LLC
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

namespace Google.Cloud.Redis.V1Beta1.Snippets
{
    using Google.LongRunning;
    using System.Threading.Tasks;
    using Google.Protobuf.WellKnownTypes;

    public class CloudRedisClientSnippets
    {
        /// <summary>Snippet for FailoverInstanceAsync</summary>
        public async Task FailoverInstanceAsync()
        {
            // Snippet: FailoverInstanceAsync(string,FailoverInstanceRequest.Types.DataProtectionMode,CallSettings)
            // Additional: FailoverInstanceAsync(string,FailoverInstanceRequest.Types.DataProtectionMode,CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]").ToString();
            FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode = FailoverInstanceRequest.Types.DataProtectionMode.Unspecified;
            // Make the request
            Operation<Instance, Any> response =
                await cloudRedisClient.FailoverInstanceAsync(formattedName, dataProtectionMode);

            // Poll until the returned long-running operation is complete
            Operation<Instance, Any> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, Any> retrievedResponse =
                await cloudRedisClient.PollOnceFailoverInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverInstance</summary>
        public void FailoverInstance()
        {
            // Snippet: FailoverInstance(string,FailoverInstanceRequest.Types.DataProtectionMode,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            string formattedName = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]").ToString();
            FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode = FailoverInstanceRequest.Types.DataProtectionMode.Unspecified;
            // Make the request
            Operation<Instance, Any> response =
                cloudRedisClient.FailoverInstance(formattedName, dataProtectionMode);

            // Poll until the returned long-running operation is complete
            Operation<Instance, Any> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, Any> retrievedResponse =
                cloudRedisClient.PollOnceFailoverInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
